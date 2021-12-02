using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using DatingService.Domain.Auth;
using DatingService.Service.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using Telegram.Bot;
using Telegram.Bot.Exceptions;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.InlineQueryResults;
using Telegram.Bot.Types.InputFiles;
using Telegram.Bot.Types.ReplyMarkups;

namespace DatingService.TelegramBot.Services
{
    public class HandleUpdateService
    {
        private readonly ITelegramBotClient _botClient;
        private readonly ILogger<HandleUpdateService> _logger;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IRequestService _requestService;

        public HandleUpdateService(
            ITelegramBotClient botClient,
            ILogger<HandleUpdateService> logger,
            UserManager<ApplicationUser> userManager,
            IRequestService requestService)
        {
            _requestService = requestService;
            _userManager = userManager;
            _botClient = botClient;
            _logger = logger;
        }

        public async Task EchoAsync(Update update)
        {
            var handler = update.Type switch
            {
                UpdateType.Message => BotOnMessageReceived(update.Message),
                UpdateType.EditedMessage => BotOnMessageReceived(update.EditedMessage),
                UpdateType.CallbackQuery => BotOnCallbackQueryReceived(update.CallbackQuery),
                UpdateType.InlineQuery => BotOnInlineQueryReceived(update.InlineQuery),
                UpdateType.ChosenInlineResult => BotOnChosenInlineResultReceived(update.ChosenInlineResult),
                _ => UnknownUpdateHandlerAsync(update)
            };

            try
            {
                await handler;
            }
            catch (Exception exception)
            {
                await HandleErrorAsync(exception);
            }
        }

        private async Task BotOnMessageReceived(Message message)
        {
            _logger.LogInformation($"Receive message type: {message.Type}");
            if (message.Type != MessageType.Text)
                return;

            var action = message.Text.Split(' ').First() switch
            {
                "/GetChatId" => SendChatId(_botClient, message),
                "/GetInboxRequest" => SendIncomingRequest(_botClient, message),
                "/GetSentRequest" => SendOutgoingRequest(_botClient, message),
                "/request" => RequestContactAndLocation(_botClient, message),
                _ => Usage(_botClient, message)
            };
            var sentMessage = await action;
            _logger.LogInformation($"The message was sent with id: {sentMessage.MessageId}");


            static async Task<Message> SendChatId(ITelegramBotClient bot, Message message)
            {
                await bot.SendChatActionAsync(message.Chat.Id, ChatAction.Typing);

                await Task.Delay(500);

                return await bot.SendTextMessageAsync(chatId: message.Chat.Id,
                                                      text: message.Chat.Id.ToString());
            }

            static async Task<Message> RequestContactAndLocation(ITelegramBotClient bot, Message message)
            {
                var RequestReplyKeyboard = new ReplyKeyboardMarkup(new[]
                {
                    KeyboardButton.WithRequestLocation("Location"),
                    KeyboardButton.WithRequestContact("Contact"),
                });

                return await bot.SendTextMessageAsync(chatId: message.Chat.Id,
                                                      text: "Who or Where are you?",
                                                      replyMarkup: RequestReplyKeyboard);
            }

            static async Task<Message> Usage(ITelegramBotClient bot, Message message)
            {
                const string usage = "Usage:\n" +
                                     "/GetChatId   - Get bot chat id\n" +
                                     "/GetInboxRequest - Get inbox request\n" +
                                     "/GetSentRequest   - Get send request\n";

                return await bot.SendTextMessageAsync(chatId: message.Chat.Id,
                                                      text: usage,
                                                      replyMarkup: new ReplyKeyboardRemove());
            }
        }

        private async Task<Message> SendIncomingRequest(ITelegramBotClient bot, Message message)
        {
            var text = "";
            var user = _userManager.Users.Where(u => u.TelegramChatId == message.Chat.Id).FirstOrDefault();
            if (user != null)
            {
                var requsets = _requestService.GetAllIncomingByUser(user);
                foreach (var item in requsets)
                {
                    text += $"{item.Sender.FirstName}: {item.DateCreated}" + Environment.NewLine;
                }
                if (requsets.Count() == 0)
                {
                    text = "No Request";
                }
            }
            else
            {
                text = "ChatId not installed on your user. Use /GetChatId";
            }

            return await bot.SendTextMessageAsync(chatId: message.Chat.Id,
                                                  text: text);
        }

        private async Task<Message> SendOutgoingRequest(ITelegramBotClient bot, Message message)
        {
            var text = "";
            var user = _userManager.Users.Where(u => u.TelegramChatId == message.Chat.Id).FirstOrDefault();
            if (user != null)
            {
                var requsets = _requestService.GetAllOutgoingByUser(user);
                foreach (var item in requsets)
                {
                    text += $"{item.Receiver.FirstName}: {item.DateCreated}" + Environment.NewLine;
                }
                if (requsets.Count() == 0)
                {
                    text = "No Request";
                }
            }
            else
            {
                text = "ChatId not installed on your user. Use /GetChatId";
            }

            return await bot.SendTextMessageAsync(chatId: message.Chat.Id,
                                                  text: text);
        }

        private async Task BotOnCallbackQueryReceived(CallbackQuery callbackQuery)
        {
            await _botClient.AnswerCallbackQueryAsync(
                callbackQueryId: callbackQuery.Id,
                text: $"Received {callbackQuery.Data}");

            await _botClient.SendTextMessageAsync(
                chatId: callbackQuery.Message.Chat.Id,
                text: $"Received {callbackQuery.Data}");
        }

        private async Task BotOnInlineQueryReceived(InlineQuery inlineQuery)
        {
            _logger.LogInformation($"Received inline query from: {inlineQuery.From.Id}");

            InlineQueryResultBase[] results = {
                new InlineQueryResultArticle(
                    id: "3",
                    title: "TgBots",
                    inputMessageContent: new InputTextMessageContent(
                        "hello"
                    )
                )
            };

            await _botClient.AnswerInlineQueryAsync(inlineQueryId: inlineQuery.Id,
                                                    results: results,
                                                    isPersonal: true,
                                                    cacheTime: 0);
        }

        private Task BotOnChosenInlineResultReceived(ChosenInlineResult chosenInlineResult)
        {
            _logger.LogInformation($"Received inline result: {chosenInlineResult.ResultId}");
            return Task.CompletedTask;
        }

        private Task UnknownUpdateHandlerAsync(Update update)
        {
            _logger.LogInformation($"Unknown update type: {update.Type}");
            return Task.CompletedTask;
        }

        public Task HandleErrorAsync(Exception exception)
        {
            var ErrorMessage = exception switch
            {
                ApiRequestException apiRequestException => $"Telegram API Error:\n[{apiRequestException.ErrorCode}]\n{apiRequestException.Message}",
                _ => exception.ToString()
            };

            _logger.LogInformation(ErrorMessage);
            return Task.CompletedTask;
        }
    }
}

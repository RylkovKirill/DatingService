using DatingService.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using DatingService.Infrastructure.ViewModels;
using Braintree;
using Microsoft.AspNetCore.Identity;
using DatingService.Domain.Auth;
using DatingService.Domain.Entities;

namespace DatingService.Controllers
{
    public class OrderController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IBraintreeService _braintreeService;

        private readonly IOrderService _orderService;

        public OrderController(
            IBraintreeService braintreeService,
            UserManager<ApplicationUser> userManager,
            IOrderService orderService)
        {
            _userManager = userManager;
            _braintreeService = braintreeService;
            _orderService = orderService;
        }

        public IActionResult SetPostsCount()
        {
            var gateway = _braintreeService.GetGateway();
            var clientToken = gateway.ClientToken.Generate();
            ViewBag.ClientToken = clientToken;
            var model = new OrderViewModel()
            {
                Title = "Increase posts Count",
                Description = "It only costs $2 to increase the posts count by 10",
                Price = 5m
            };
            return View(model);
        }

        public IActionResult SetAnyLocation()
        {
            var gateway = _braintreeService.GetGateway();
            var clientToken = gateway.ClientToken.Generate();
            ViewBag.ClientToken = clientToken;
            var model = new OrderViewModel()
            {
                Title = "Set any location",
                Description = "The ability to set any location costs only $1",
                Price = 1m
            };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> SetAnyLocationAsync(OrderViewModel model)
        {
            var user = await _userManager.GetUserAsync(HttpContext.User);
            if (user == null)
            {
                return NotFound();
            }

            var gateway = _braintreeService.GetGateway();
            var request = new TransactionRequest
            {
                Amount = model.Price,
                PaymentMethodNonce = model.Nonce,
                Options = new TransactionOptionsRequest
                {
                    SubmitForSettlement = true
                }
            };

            Result<Transaction> result = gateway.Transaction.Sale(request);

            if (result.IsSuccess())
            {
                user.AnyLocation = true;
                await _userManager.UpdateAsync(user);

                var order = new Order
                {
                    Id = Guid.NewGuid(),
                    Price = model.Price,
                    UserId = user.Id
                };

                _orderService.Add(order);
                return Redirect("/Identity/Account/Manage/Location");
            }

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> SetPostsCountAsync(OrderViewModel model)
        {
            var user = await _userManager.GetUserAsync(HttpContext.User);
            if (user == null)
            {
                return NotFound();
            }

            var gateway = _braintreeService.GetGateway();
            var request = new TransactionRequest
            {
                Amount = model.Price,
                PaymentMethodNonce = model.Nonce,
                Options = new TransactionOptionsRequest
                {
                    SubmitForSettlement = true
                }
            };

            Result<Transaction> result = gateway.Transaction.Sale(request);

            if (result.IsSuccess())
            {
                user.PostCount += 10;
                await _userManager.UpdateAsync(user);

                var order = new Order
                {
                    Id = Guid.NewGuid(),
                    Price = model.Price,
                    UserId = user.Id
                };

                _orderService.Add(order);

                return RedirectToAction("Create", "Post");
            }

            return View(model);
        }

    }
}

CREATE TABLE [dbo].[ApplicationUserChat] (
    [ChatsId] UNIQUEIDENTIFIER NOT NULL,
    [UsersId] UNIQUEIDENTIFIER NOT NULL,
    CONSTRAINT [PK_ApplicationUserChat] PRIMARY KEY CLUSTERED ([ChatsId] ASC, [UsersId] ASC),
    CONSTRAINT [FK_ApplicationUserChat_AspNetUsers_UsersId] FOREIGN KEY ([UsersId]) REFERENCES [dbo].[AspNetUsers] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_ApplicationUserChat_Chats_ChatsId] FOREIGN KEY ([ChatsId]) REFERENCES [dbo].[Chats] ([Id]) ON DELETE CASCADE
);


GO
CREATE NONCLUSTERED INDEX [IX_ApplicationUserChat_UsersId]
    ON [dbo].[ApplicationUserChat]([UsersId] ASC);


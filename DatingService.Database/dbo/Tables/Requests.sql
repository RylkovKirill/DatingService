CREATE TABLE [dbo].[Requests] (
    [Id]            UNIQUEIDENTIFIER NOT NULL,
    [RequestStatus] INT              NOT NULL,
    [SenderId]      UNIQUEIDENTIFIER NOT NULL,
    [ReceiverId]    UNIQUEIDENTIFIER NOT NULL,
    [DateCreated]   DATETIME2 (7)    NOT NULL,
    [DateUpdated]   DATETIME2 (7)    NOT NULL,
    CONSTRAINT [PK_Requests] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Requests_AspNetUsers_ReceiverId] FOREIGN KEY ([ReceiverId]) REFERENCES [dbo].[AspNetUsers] ([Id]),
    CONSTRAINT [FK_Requests_AspNetUsers_SenderId] FOREIGN KEY ([SenderId]) REFERENCES [dbo].[AspNetUsers] ([Id])
);


GO
CREATE NONCLUSTERED INDEX [IX_Requests_ReceiverId]
    ON [dbo].[Requests]([ReceiverId] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_Requests_SenderId]
    ON [dbo].[Requests]([SenderId] ASC);


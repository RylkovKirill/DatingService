CREATE TABLE [dbo].[Comments] (
    [Id]          UNIQUEIDENTIFIER NOT NULL,
    [Content]     NVARCHAR (1024)  NOT NULL,
    [PostId]      UNIQUEIDENTIFIER NOT NULL,
    [UserId]      UNIQUEIDENTIFIER NOT NULL,
    [DateCreated] DATETIME2 (7)    NOT NULL,
    [DateUpdated] DATETIME2 (7)    NOT NULL,
    CONSTRAINT [PK_Comments] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Comments_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [dbo].[AspNetUsers] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_Comments_Posts_PostId] FOREIGN KEY ([PostId]) REFERENCES [dbo].[Posts] ([Id]) ON DELETE CASCADE
);


GO
CREATE NONCLUSTERED INDEX [IX_Comments_PostId]
    ON [dbo].[Comments]([PostId] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_Comments_UserId]
    ON [dbo].[Comments]([UserId] ASC);


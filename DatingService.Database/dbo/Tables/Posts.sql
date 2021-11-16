CREATE TABLE [dbo].[Posts] (
    [Id]                UNIQUEIDENTIFIER NOT NULL,
    [Title]             NVARCHAR (256)   NOT NULL,
    [Content]           NVARCHAR (2048)  NOT NULL,
    [IsPublished]       BIT              NOT NULL,
    [ImageId]           UNIQUEIDENTIFIER NULL,
    [UserId]            UNIQUEIDENTIFIER NULL,
    [ApplicationUserId] UNIQUEIDENTIFIER NULL,
    [DateCreated]       DATETIME2 (7)    NOT NULL,
    [DateUpdated]       DATETIME2 (7)    NOT NULL,
    CONSTRAINT [PK_Posts] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Posts_AspNetUsers_ApplicationUserId] FOREIGN KEY ([ApplicationUserId]) REFERENCES [dbo].[AspNetUsers] ([Id]),
    CONSTRAINT [FK_Posts_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [dbo].[AspNetUsers] ([Id]),
    CONSTRAINT [FK_Posts_Images_ImageId] FOREIGN KEY ([ImageId]) REFERENCES [dbo].[Images] ([Id]) ON DELETE CASCADE
);


GO
CREATE NONCLUSTERED INDEX [IX_Posts_ApplicationUserId]
    ON [dbo].[Posts]([ApplicationUserId] ASC);


GO
CREATE UNIQUE NONCLUSTERED INDEX [IX_Posts_ImageId]
    ON [dbo].[Posts]([ImageId] ASC) WHERE ([ImageId] IS NOT NULL);


GO
CREATE NONCLUSTERED INDEX [IX_Posts_UserId]
    ON [dbo].[Posts]([UserId] ASC);


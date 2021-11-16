CREATE TABLE [dbo].[Avatars] (
    [Id]          UNIQUEIDENTIFIER NOT NULL,
    [UserId]      UNIQUEIDENTIFIER NOT NULL,
    [DateCreated] DATETIME2 (7)    NOT NULL,
    [DateUpdated] DATETIME2 (7)    NOT NULL,
    [Name]        NVARCHAR (64)    NOT NULL,
    [Path]        NVARCHAR (256)   NOT NULL,
    CONSTRAINT [PK_Avatars] PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
CREATE UNIQUE NONCLUSTERED INDEX [IX_Avatars_Path]
    ON [dbo].[Avatars]([Path] ASC);


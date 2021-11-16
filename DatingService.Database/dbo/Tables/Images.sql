CREATE TABLE [dbo].[Images] (
    [Id]          UNIQUEIDENTIFIER NOT NULL,
    [PostId]      UNIQUEIDENTIFIER NOT NULL,
    [DateCreated] DATETIME2 (7)    NOT NULL,
    [DateUpdated] DATETIME2 (7)    NOT NULL,
    [Name]        NVARCHAR (64)    NOT NULL,
    [Path]        NVARCHAR (256)   NOT NULL,
    CONSTRAINT [PK_Images] PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
CREATE UNIQUE NONCLUSTERED INDEX [IX_Images_Path]
    ON [dbo].[Images]([Path] ASC);


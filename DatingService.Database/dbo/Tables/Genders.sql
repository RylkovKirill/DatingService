CREATE TABLE [dbo].[Genders] (
    [Id]          UNIQUEIDENTIFIER NOT NULL,
    [Name]        NVARCHAR (64)    NOT NULL,
    [DateCreated] DATETIME2 (7)    NOT NULL,
    [DateUpdated] DATETIME2 (7)    NOT NULL,
    CONSTRAINT [PK_Genders] PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
CREATE UNIQUE NONCLUSTERED INDEX [IX_Genders_Name]
    ON [dbo].[Genders]([Name] ASC);


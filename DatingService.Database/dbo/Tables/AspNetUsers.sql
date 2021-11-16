CREATE TABLE [dbo].[AspNetUsers] (
    [Id]                   UNIQUEIDENTIFIER   NOT NULL,
    [FirstName]            NVARCHAR (64)      NOT NULL,
    [LastName]             NVARCHAR (64)      NOT NULL,
    [DateOfBirth]          DATETIME2 (7)      NOT NULL,
    [Latitude]             FLOAT (53)         NULL,
    [Longitude]            FLOAT (53)         NULL,
    [AvatarId]             UNIQUEIDENTIFIER   NULL,
    [GenderId]             UNIQUEIDENTIFIER   NULL,
    [UserName]             NVARCHAR (256)     NULL,
    [NormalizedUserName]   NVARCHAR (256)     NULL,
    [Email]                NVARCHAR (256)     NULL,
    [NormalizedEmail]      NVARCHAR (256)     NULL,
    [EmailConfirmed]       BIT                NOT NULL,
    [PasswordHash]         NVARCHAR (MAX)     NULL,
    [SecurityStamp]        NVARCHAR (MAX)     NULL,
    [ConcurrencyStamp]     NVARCHAR (MAX)     NULL,
    [PhoneNumber]          NVARCHAR (MAX)     NULL,
    [PhoneNumberConfirmed] BIT                NOT NULL,
    [TwoFactorEnabled]     BIT                NOT NULL,
    [LockoutEnd]           DATETIMEOFFSET (7) NULL,
    [LockoutEnabled]       BIT                NOT NULL,
    [AccessFailedCount]    INT                NOT NULL,
    CONSTRAINT [PK_AspNetUsers] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_AspNetUsers_Avatars_AvatarId] FOREIGN KEY ([AvatarId]) REFERENCES [dbo].[Avatars] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_AspNetUsers_Genders_GenderId] FOREIGN KEY ([GenderId]) REFERENCES [dbo].[Genders] ([Id])
);


GO
CREATE NONCLUSTERED INDEX [EmailIndex]
    ON [dbo].[AspNetUsers]([NormalizedEmail] ASC);


GO
CREATE UNIQUE NONCLUSTERED INDEX [IX_AspNetUsers_AvatarId]
    ON [dbo].[AspNetUsers]([AvatarId] ASC) WHERE ([AvatarId] IS NOT NULL);


GO
CREATE NONCLUSTERED INDEX [IX_AspNetUsers_GenderId]
    ON [dbo].[AspNetUsers]([GenderId] ASC);


GO
CREATE UNIQUE NONCLUSTERED INDEX [UserNameIndex]
    ON [dbo].[AspNetUsers]([NormalizedUserName] ASC) WHERE ([NormalizedUserName] IS NOT NULL);


CREATE TABLE [dbo].[Resource]
(
	[Id] INT IDENTITY (1, 1) NOT NULL, 
    [UniqueId] NVARCHAR(6) NOT NULL, 
    [Name] NVARCHAR(200) NOT NULL, 
    [Description] NVARCHAR(500) NULL, 
    [UserId] INT NOT NULL,
	CONSTRAINT [PK_Resource] PRIMARY KEY ([Id] ASC),
	CONSTRAINT [FK_Resource_User] FOREIGN KEY ([UserId]) REFERENCES [dbo].[User] ([Id])
)

CREATE TABLE [dbo].[Conversation]
(
	[Id] INT IDENTITY (1, 1) NOT NULL, 
    [ResourceId] INT NOT NULL, 
    [FinderUserId] INT NOT NULL,
	CONSTRAINT [PK_Conversation] PRIMARY KEY ([Id] ASC),
	CONSTRAINT [FK_Conversation_Resource] FOREIGN KEY ([ResourceId]) REFERENCES [dbo].[Resource] ([Id]),
	CONSTRAINT [FK_Conversation_User] FOREIGN KEY ([FinderUserId]) REFERENCES [dbo].[User] ([Id])
)

CREATE TABLE [dbo].[Message]
(
	[Id] INT IDENTITY (1, 1) NOT NULL, 
    [MessageText] NVARCHAR(500) NOT NULL, 
    [ConversationId] INT NOT NULL, 
    [TimeStamp] DATETIME2 NOT NULL, 
    [IsMessageFromFinder] BIT NOT NULL,
	CONSTRAINT [PK_Message] PRIMARY KEY ([Id] ASC),
	CONSTRAINT [FK_Message_Conversation] FOREIGN KEY ([ConversationId]) REFERENCES [dbo].[Conversation] ([Id])
)

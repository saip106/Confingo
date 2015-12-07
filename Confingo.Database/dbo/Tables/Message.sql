CREATE TABLE [dbo].[Message]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [MessageText] NVARCHAR(500) NOT NULL, 
    [ConsversationId] INT NOT NULL, 
    [TimeStamp] DATETIME2 NOT NULL, 
    [IsMessageFromFinder] BIT NOT NULL
)

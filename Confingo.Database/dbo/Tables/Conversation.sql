CREATE TABLE [dbo].[Conversation]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [ResourceId] INT NOT NULL, 
    [FounderName] NVARCHAR(200) NOT NULL
)

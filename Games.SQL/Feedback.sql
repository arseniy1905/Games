CREATE TABLE [dbo].[Feedback]
(
	[Id] INT NOT NULL IDENTITY(1,1) PRIMARY KEY, 
    [Text] TEXT NOT NULL, 
    [User] NVARCHAR(50) NULL, 
    [StatusId] INT NOT NULL, 
    [EnterDate] DATETIME NOT NULL
)

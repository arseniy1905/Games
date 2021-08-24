CREATE TABLE [dbo].[Prize]
(
	[Id] INT NOT NULL IDENTITY(1,1) PRIMARY KEY, 
    [DescriptionLine1] NVARCHAR(50) NULL, 
    [DescriptionLine2] NVARCHAR(250) NULL, 
    [ImagePath] NVARCHAR(250) NULL, 
    [Price] DECIMAL NULL, 
    [Stars] INT NULL, 
    [StatusId] INT NOT NULL, 
    [Year] INT NULL, 
    [Quarter] INT NULL
)

CREATE TABLE [dbo].[Purchases]
(
	[Id] INT NOT NULL PRIMARY KEY,
	[Notes] NVARCHAR(100) NOT NULL,
    [CreatedAt] DATETIME NOT NULL, 
    [CreatedBy] NVARCHAR(50) NOT NULL, 
    [ModifiedAt] DATETIME NOT NULL, 
    [ModifiedBy] NCHAR(10) NOT NULL,
)

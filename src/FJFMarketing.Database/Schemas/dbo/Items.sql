CREATE TABLE [dbo].[Items]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY,
	[SectionId] INT NOT NULL,
	[CategoryId] INT NOT NULL,
	[Name] NVARCHAR(50) NOT NULL, 
    [UnitId] INT NOT NULL, 
    [Fare] DECIMAL(18, 2) NOT NULL, 
    [UnitPrice] DECIMAL(18, 2) NOT NULL, 
    [SRP] DECIMAL(18, 2) NOT NULL, 
    [Notes] NVARCHAR(MAX) NOT NULL, 
    [IsActive] BIT NOT NULL, 
    [CreatedAt] DATETIME NOT NULL, 
    [CreatedBy] NVARCHAR(50) NOT NULL, 
    [ModifiedAt] DATETIME NOT NULL, 
    [ModifiedBy] NCHAR(10) NOT NULL,
)

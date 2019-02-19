CREATE TABLE [dbo].[Payables]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [PurchasedDate] DATETIME NOT NULL, 
    [PayTerms] TINYINT NOT NULL, 
    [NotificationDays] TINYINT NOT NULL,
	[Amount] DECIMAL(18,2) NOT NULL,
	[Notes] NVARCHAR(100) NOT NULL, 
    [CreatedAt] DATETIME NOT NULL, 
    [CreatedBy] NVARCHAR(50) NOT NULL, 
    [ModifiedAt] DATETIME NOT NULL, 
    [ModifiedBy] NCHAR(10) NOT NULL,
)

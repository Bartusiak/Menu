CREATE TABLE [dbo].[OrderDetails]
(
	[IdOrder] INT NOT NULL PRIMARY KEY IDENTITY, 
    [IdFood] INT NOT NULL, 
    [Amount] INT NOT NULL, 
    [PriceFood] INT NOT NULL
)

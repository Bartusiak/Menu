CREATE TABLE [dbo].[Order]
(
	[IdOrder] INT NOT NULL PRIMARY KEY, 
    [IdClient] INT NOT NULL, 
    [Date] DATE NOT NULL, 
    [PriceTotal] BIGINT NOT NULL, 
    [Comments] NTEXT NULL, 
    
)

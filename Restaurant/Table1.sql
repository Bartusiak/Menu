CREATE TABLE [dbo].[Food]
(
	[IdFood] INT NOT NULL PRIMARY KEY, 
    [FoodName] VARCHAR(50) NOT NULL, 
    [Price] INT NOT NULL
)

GO

INSERT Food (IdFood,FoodName,Price) VALUES (0,"Margheritta",22)
GO
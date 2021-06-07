CREATE TABLE [dbo].[Category]
(
	[CategoryId] INT NOT NULL IDENTITY,
	[Name] NVARCHAR(25) NOT NULL,
	CONSTRAINT [PK_Category] PRIMARY KEY ([CategoryId]),
	CONSTRAINT [UK_Category_Name] UNIQUE ([Name])
)

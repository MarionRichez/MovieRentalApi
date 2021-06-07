CREATE TABLE [dbo].[Language]
(
	[LanguageId] INT NOT NULL IDENTITY,
	[Name] NCHAR(20) NOT NULL,
	CONSTRAINT [PK_Language] PRIMARY KEY ([LanguageId]),
	CONSTRAINT [UK_Language_Name] UNIQUE ([Name])
)

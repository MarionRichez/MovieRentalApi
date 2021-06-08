CREATE PROCEDURE [dbo].[GetLanguages]
AS
BEGIN
	SELECT L.LanguageId, L.[Name] FROM [Language] L
END

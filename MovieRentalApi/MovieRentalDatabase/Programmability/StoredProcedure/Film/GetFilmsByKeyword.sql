CREATE PROCEDURE [dbo].[GetFilmsByKeyword]
	@keyword NVARCHAR(255)
AS
BEGIN
	SELECT F.FilmId, Title, [Description], ReleaseYear, LanguageName AS [Language], RentalDuration, RentalPrice, [Length], ReplacementCost, Rating 
	FROM V_Film F
	JOIN FilmCategory FC ON F.FilmId = FC.FilmId
	JOIN Category C ON C.CategoryId = FC.CategoryId
	WHERE Title LIKE '%'+@keyword+'%'
	OR [Description] LIKE '%'+@keyword+'%'
	OR C.[Name] = @keyword
END
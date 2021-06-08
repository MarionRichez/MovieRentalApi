CREATE PROCEDURE [dbo].[GetFilmById]
	@filmId INT
AS
BEGIN
	SELECT FilmId, Title, [Description], ReleaseYear, LanguageName AS [Language], RentalDuration, RentalPrice, [Length], ReplacementCost, Rating
	FROM V_Film
	WHERE FilmId = @filmId
END

CREATE PROCEDURE [dbo].[GetFilms]
AS
BEGIN
	SELECT FilmId, Title, [Description], ReleaseYear, LanguageName AS [Language], RentalDuration, RentalPrice, [Length], ReplacementCost, Rating 
	FROM V_Film
END

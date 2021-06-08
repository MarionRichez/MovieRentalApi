CREATE PROCEDURE [dbo].[GetFilmByTitle]
	@title NVARCHAR(255)
AS
BEGIN
	SELECT FilmId, Title, [Description], ReleaseYear, LanguageName AS [Language], RentalDuration, RentalPrice, [Length], ReplacementCost, Rating 
	FROM V_Film
	WHERE Title = @title
END

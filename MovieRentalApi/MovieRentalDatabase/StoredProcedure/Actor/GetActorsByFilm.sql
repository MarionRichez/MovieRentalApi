CREATE PROCEDURE [dbo].[GetActorsByFilm]
	@filmId INT
AS
BEGIN
	SELECT A.ActorId, A.LastName, A.FirstName FROM Actor A
	JOIN FilmActor FA ON A.ActorId = FA.ActorId
	WHERE FilmId = @filmId
END

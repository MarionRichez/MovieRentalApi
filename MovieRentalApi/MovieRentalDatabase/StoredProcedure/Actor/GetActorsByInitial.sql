CREATE PROCEDURE [dbo].[GetActorsByInitial]
	@initial CHAR
AS
BEGIN
	SELECT A.ActorId, A.LastName, A.FirstName FROM Actor A
	WHERE LEFT(A.LastName, 1) = @initial
END

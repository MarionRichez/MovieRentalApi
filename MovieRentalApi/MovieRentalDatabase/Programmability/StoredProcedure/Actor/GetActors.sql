CREATE PROCEDURE [dbo].[GetActors]
AS
BEGIN
	SELECT A.ActorId, A.LastName, A.FirstName 
	FROM Actor A
END

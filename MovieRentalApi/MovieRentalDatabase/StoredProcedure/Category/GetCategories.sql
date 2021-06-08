CREATE PROCEDURE [dbo].[GetCategories]
AS
BEGIN
	SELECT C.CategoryId, C.[Name] FROM Category C
END

CREATE VIEW [dbo].[V_Film]
AS 
SELECT F.FilmId, F.Title, F.[Description], F.ReleaseYear, F.LanguageId, L.[Name] AS LanguageName, F.RentalDuration, F.RentalPrice, F.[Length], F.ReplacementCost, F.RatingId, R.Rating
FROM Film F
JOIN Rating R ON F.RatingId = R.RatingId
JOIN Language L ON F.LanguageId = L.LanguageId

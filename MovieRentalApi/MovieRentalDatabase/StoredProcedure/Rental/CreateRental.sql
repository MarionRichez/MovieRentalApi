CREATE PROCEDURE [dbo].[CreateRental]
	@customerId INT,
	@filmIds FilmIds READONLY
AS
BEGIN
	INSERT INTO Rental(CustomerId) VALUES (@customerId)

	DECLARE @rentalId INT = SCOPE_IDENTITY()

	INSERT INTO RentalDetail (RentalId, FilmId, RentalPrice)
	SELECT @rentalId, FI.FilmId, F.RentalPrice
	FROM @filmIds FI
	JOIN Film F on FI.FilmId = F.FilmId

	SELECT @rentalId;
END

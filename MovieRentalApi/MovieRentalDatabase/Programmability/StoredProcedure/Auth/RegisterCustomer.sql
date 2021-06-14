CREATE PROCEDURE [dbo].[RegisterCustomer]
	@lastName NVARCHAR(75),
	@firstName NVARCHAR(75),
	@email NVARCHAR(320),
	@password VARCHAR(20)
AS
BEGIN
	INSERT INTO Customer (LastName, FirstName, Email, [Password])
	VALUES (@lastName, @firstName, @email, HASHBYTES('SHA2_512', dbo.GetPreHash() + @password + dbo.GetPostHash()))
END

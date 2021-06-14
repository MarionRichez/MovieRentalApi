CREATE PROCEDURE [dbo].[CheckCustomer]
	@email NVARCHAR(320),
	@password VARCHAR(20)
AS
BEGIN
	SELECT C.CustomerId, C.LastName, C.FirstName, C.Email FROM Customer C
	WHERE C.Email = @email AND C.[Password] = HASHBYTES('SHA2_512', dbo.GetPreHash() + @password + dbo.GetPostHash())
END

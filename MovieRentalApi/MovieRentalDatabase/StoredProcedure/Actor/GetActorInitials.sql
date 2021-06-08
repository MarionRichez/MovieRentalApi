﻿CREATE PROCEDURE [dbo].[GetActorInitials]
AS
BEGIN
	SELECT DISTINCT UPPER(LEFT(A.LastName, 1)) AS Initial 
	FROM Actor A
END

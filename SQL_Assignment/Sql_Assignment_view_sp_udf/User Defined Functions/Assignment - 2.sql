--UDF Assignment - 2

CREATE FUNCTION fn_GetStudentAge
(
@DateOfBirth DATE
)
RETURNS INT
AS
BEGIN

DECLARE @Age INT

SET @Age = DATEDIFF(YEAR, @DateOfBirth, GETDATE())

RETURN @Age

END;
GO

SELECT 
StudentID,
StudentFirstName + ' ' + LastName AS StudentName,
DateOfBirth,
dbo.fn_GetStudentAge(DateOfBirth) AS Age
FROM Students;
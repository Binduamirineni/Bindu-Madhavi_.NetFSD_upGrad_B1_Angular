--UDF Assignment - 3

CREATE FUNCTION fn_GetTotalMarks
(
@StudentID INT
)
RETURNS INT
AS
BEGIN

DECLARE @TotalMarks INT

SELECT @TotalMarks = SUM(MarksObtained)
FROM Marks
WHERE StudentID = @StudentID

RETURN @TotalMarks

END;
GO

SELECT 
StudentID,
dbo.fn_GetTotalMarks(StudentID) AS TotalMarks
FROM Marks
GROUP BY StudentID;
--Cursor Assignment - 2

CREATE PROCEDURE sp_CalculateStudentTotalMarks
AS
BEGIN

DECLARE @StudentID INT
DECLARE @StudentName VARCHAR(100)
DECLARE @TotalMarks INT

DECLARE student_cursor CURSOR FOR
SELECT StudentID, StudentFirstName + ' ' + LastName
FROM Students

OPEN student_cursor

FETCH NEXT FROM student_cursor
INTO @StudentID, @StudentName

WHILE @@FETCH_STATUS = 0
BEGIN

SELECT @TotalMarks = ISNULL(SUM(MarksObtained),0)
FROM Marks
WHERE StudentID = @StudentID

PRINT 'StudentName: ' + @StudentName +
      '  TotalMarks: ' + CAST(@TotalMarks AS VARCHAR)

FETCH NEXT FROM student_cursor
INTO @StudentID, @StudentName

END

CLOSE student_cursor
DEALLOCATE student_cursor

END;
GO

EXEC sp_CalculateStudentTotalMarks;
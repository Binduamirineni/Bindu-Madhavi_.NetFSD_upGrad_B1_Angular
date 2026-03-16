--Cursor Assignment - 1

CREATE PROCEDURE sp_DisplayStudentsCursor
AS
BEGIN

DECLARE @StudentID INT
DECLARE @StudentName VARCHAR(100)

DECLARE student_cursor CURSOR FOR
SELECT StudentID, StudentFirstName + ' ' + LastName
FROM Students

OPEN student_cursor

FETCH NEXT FROM student_cursor
INTO @StudentID, @StudentName

WHILE @@FETCH_STATUS = 0
BEGIN

PRINT 'StudentID: ' + CAST(@StudentID AS VARCHAR) + 
      '  StudentName: ' + @StudentName

FETCH NEXT FROM student_cursor
INTO @StudentID, @StudentName

END

CLOSE student_cursor
DEALLOCATE student_cursor

END;
GO

EXEC sp_DisplayStudentsCursor;
--EH Assignment - 2
IF OBJECT_ID('sp_InsertMarks','P') IS NOT NULL
DROP PROCEDURE sp_InsertMarks;
GO

CREATE PROCEDURE sp_InsertMarks
@MarkID INT,
@StudentID INT,
@ExamID INT,
@MarksObtained INT
AS
BEGIN

IF @MarksObtained < 0 OR @MarksObtained > 100
BEGIN
RAISERROR('Invalid Marks',16,1);
RETURN;
END

INSERT INTO Marks
(MarkID, StudentID, ExamID, MarksObtained)

VALUES
(@MarkID, @StudentID, @ExamID, @MarksObtained);

PRINT 'Marks inserted successfully';

END;
GO

EXEC sp_InsertMarks
31,1,1,85;

EXEC sp_InsertMarks
2,1,1,120;
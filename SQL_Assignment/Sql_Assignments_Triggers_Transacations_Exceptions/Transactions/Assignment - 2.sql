--Transactions Assignment - 2

CREATE PROCEDURE sp_RecordExamMarks
@MarkID INT,
@StudentID INT,
@ExamID INT,
@MarksObtained INT
AS
BEGIN

BEGIN TRY

BEGIN TRANSACTION

-- Insert marks
INSERT INTO Marks
(MarkID, StudentID, ExamID, MarksObtained)

VALUES
(@MarkID, @StudentID, @ExamID, @MarksObtained)

-- Update exam record
UPDATE Exams
SET ExamDate = GETDATE()
WHERE ExamID = @ExamID

COMMIT TRANSACTION

PRINT 'Marks recorded successfully'

END TRY

BEGIN CATCH

ROLLBACK TRANSACTION

PRINT 'Transaction failed: ' + ERROR_MESSAGE()

END CATCH

END;
GO

EXEC sp_RecordExamMarks
40, 3, 2, 85;

EXEC sp_RecordExamMarks
3, 3, 2, 90;
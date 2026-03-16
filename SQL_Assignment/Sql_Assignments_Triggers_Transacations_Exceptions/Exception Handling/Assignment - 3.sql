--EH Assignment - 3

CREATE PROCEDURE sp_DeleteStudent
@StudentID INT
AS
BEGIN

BEGIN TRY

DELETE FROM Students
WHERE StudentID = @StudentID;

PRINT 'Student deleted successfully';

END TRY

BEGIN CATCH

PRINT ERROR_MESSAGE();

END CATCH

END;
GO

EXEC sp_DeleteStudent 1;

EXEC sp_DeleteStudent 25;

--Transactions Assignment - 1

CREATE PROCEDURE sp_EnrollStudentTransaction
@EnrollmentID INT,
@StudentID INT,
@CourseID INT
AS
BEGIN

BEGIN TRY

BEGIN TRANSACTION

INSERT INTO Enrollments
(EnrollmentID, StudentID, CourseID, EnrollmentDate)

VALUES
(@EnrollmentID, @StudentID, @CourseID, GETDATE())

COMMIT TRANSACTION

PRINT 'Student enrolled successfully'

END TRY

BEGIN CATCH

ROLLBACK TRANSACTION

PRINT 'Enrollment failed: ' + ERROR_MESSAGE()

END CATCH

END;
GO

EXEC sp_EnrollStudentTransaction
31, 5, 3;

EXEC sp_EnrollStudentTransaction
1, 5, 3;
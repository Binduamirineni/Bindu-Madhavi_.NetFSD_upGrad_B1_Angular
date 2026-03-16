--Transactions Assignment - 3

CREATE PROCEDURE sp_TransferStudentDepartment
@StudentID INT,
@NewDepartmentID INT
AS
BEGIN
BEGIN TRY

BEGIN TRANSACTION

-- Check if department exists
IF NOT EXISTS (SELECT 1 FROM Departments WHERE DepartmentID = @NewDepartmentID)
BEGIN
RAISERROR('Department does not exist',16,1)
ROLLBACK TRANSACTION
RETURN
END

-- Update student department
UPDATE Students
SET DepartmentID = @NewDepartmentID
WHERE StudentID = @StudentID

COMMIT TRANSACTION

PRINT 'Student department transferred successfully'

END TRY

BEGIN CATCH

ROLLBACK TRANSACTION

PRINT 'Transfer failed: ' + ERROR_MESSAGE()

END CATCH

END;
GO

EXEC sp_TransferStudentDepartment
5,3;

EXEC sp_TransferStudentDepartment
5,99;
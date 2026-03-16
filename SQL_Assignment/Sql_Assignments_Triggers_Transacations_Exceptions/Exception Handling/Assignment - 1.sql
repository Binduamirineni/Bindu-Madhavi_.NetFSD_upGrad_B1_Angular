--EH Assignment - 1

CREATE PROCEDURE sp_AddStudent
@StudentID INT,
@FirstName VARCHAR(50),
@LastName VARCHAR(50),
@DepartmentID INT,
@Gender CHAR(1),
@AdmissionDate DATE
AS
BEGIN

BEGIN TRY

INSERT INTO Students
(StudentID, StudentFirstName, LastName, DepartmentID, Gender, AdmissionDate)

VALUES
(@StudentID, @FirstName, @LastName, @DepartmentID, @Gender, @AdmissionDate);

PRINT 'Student inserted successfully';

END TRY

BEGIN CATCH

PRINT 'Error: ' + ERROR_MESSAGE();

END CATCH

END;
GO

EXEC sp_AddStudent
103,'Ravi','Sharma',2,'M','2024-06-01';

EXEC sp_AddStudent
102,'Anita','Patel',99,'F','2024-06-01';
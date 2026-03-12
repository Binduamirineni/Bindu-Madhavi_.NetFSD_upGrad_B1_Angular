--SP Assignment - 1
DROP PROCEDURE IF EXISTS sp_InsertStudent;
GO

CREATE PROCEDURE sp_InsertStudent
@StudentID INT,
@FirstName VARCHAR(50),
@LastName VARCHAR(50),
@Gender CHAR(1),
@DepartmentID INT,
@AdmissionDate DATE
AS
BEGIN
INSERT INTO Students
(StudentID,StudentFirstName,LastName,Gender,DepartmentID,AdmissionDate)

VALUES
(@StudentID,@FirstName,@LastName,@Gender,@DepartmentID,@AdmissionDate);
END;
GO

EXEC sp_InsertStudent 25,'Rahul','Kumar','M',1,'2024-06-01';
--SP Assignment - 2

CREATE PROCEDURE sp_GetStudentsByDepartment
@DepartmentID INT
AS
BEGIN
SELECT 
StudentID,
StudentFirstName+' '+LastName AS StudentName,
AdmissionDate
FROM Students
WHERE DepartmentID=@DepartmentID;
END;

EXEC sp_GetStudentsByDepartment 2;
EXEC sp_GetStudentsByDepartment 3;
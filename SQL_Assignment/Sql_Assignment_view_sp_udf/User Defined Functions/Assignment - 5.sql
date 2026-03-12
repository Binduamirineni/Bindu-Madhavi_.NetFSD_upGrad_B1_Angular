--UDF Assignment - 5

CREATE FUNCTION fn_GetDepartmentStudents
(
@DepartmentID INT
)
RETURNS TABLE
AS
RETURN
(
SELECT 
StudentID,
StudentFirstName + ' ' + LastName AS StudentName,
AdmissionDate
FROM Students
WHERE DepartmentID = @DepartmentID
);
GO

SELECT *
FROM dbo.fn_GetDepartmentStudents(2);
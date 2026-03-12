--View Assignment - 1
DROP VIEW vw_StudentDepartment;
GO

CREATE VIEW vw_StudentDepartment AS
SELECT 
S.StudentID,
S.StudentFirstName + ' ' + S.LastName AS StudentName,
D.DepartmentName,
S.AdmissionDate
FROM Students S
JOIN Departments D
ON S.DepartmentID = D.DepartmentID;
GO

SELECT * FROM vw_StudentDepartment;

SELECT *
FROM vw_StudentDepartment
WHERE DepartmentName='Computer Science';

DROP VIEW vw_StudentDepartment;
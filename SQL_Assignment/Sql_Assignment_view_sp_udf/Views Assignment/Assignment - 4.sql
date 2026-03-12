--View Assignment - 4

CREATE VIEW vw_DepartmentStudentCount AS
SELECT 
D.DepartmentName,
COUNT(S.StudentID) AS TotalStudents
FROM Departments D
LEFT JOIN Students S
ON D.DepartmentID = S.DepartmentID
GROUP BY D.DepartmentName;
GO

SELECT *
FROM vw_DepartmentStudentCount
WHERE TotalStudents > 10;

SELECT *
FROM vw_DepartmentStudentCount
ORDER BY TotalStudents DESC;
--View Assignment - 2

CREATE VIEW vw_StudentCourses AS
SELECT 
S.StudentFirstName + ' ' + S.LastName AS StudentName,
C.CourseName,
E.EnrollmentDate
FROM Students S
JOIN Enrollments E ON S.StudentID = E.StudentID
JOIN Courses C ON E.CourseID = C.CourseID;
GO

SELECT *
FROM vw_StudentCourses
WHERE StudentName IN
(
SELECT StudentFirstName + ' ' + LastName
FROM Students
WHERE StudentID = 5
);

SELECT StudentName, COUNT(*) AS TotalCourses
FROM vw_StudentCourses
GROUP BY StudentName;

SELECT *
FROM vw_StudentCourses
WHERE EnrollmentDate > '2024-12-31';
--UDF Assignment - 4

CREATE FUNCTION fn_GetStudentCourses
(
@StudentID INT
)
RETURNS TABLE
AS
RETURN
(
SELECT 
C.CourseName,
E.EnrollmentDate
FROM Enrollments E
JOIN Courses C
ON E.CourseID = C.CourseID
WHERE E.StudentID = @StudentID
);
GO

SELECT * 
FROM dbo.fn_GetStudentCourses(5);
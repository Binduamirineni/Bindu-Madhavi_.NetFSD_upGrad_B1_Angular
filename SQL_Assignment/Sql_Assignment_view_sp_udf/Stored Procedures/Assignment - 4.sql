--SP Assignment - 4

CREATE PROCEDURE sp_GetStudentMarks
@StudentID INT
AS
BEGIN
SELECT 
S.StudentFirstName+' '+S.LastName AS StudentName,
C.CourseName,
E.ExamType,
M.MarksObtained
FROM Students S
JOIN Marks M ON S.StudentID=M.StudentID
JOIN Exams E ON M.ExamID=E.ExamID
JOIN Courses C ON E.CourseID=C.CourseID
WHERE S.StudentID=@StudentID;
END;

EXEC sp_GetStudentMarks 5;
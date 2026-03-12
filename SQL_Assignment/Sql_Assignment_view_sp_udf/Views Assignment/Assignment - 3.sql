--View Assignment - 3

CREATE VIEW vw_ExamResults AS
SELECT 
S.StudentFirstName + ' ' + S.LastName AS StudentName,
C.CourseName,
E.ExamType,
M.MarksObtained
FROM Students S
JOIN Marks M ON S.StudentID = M.StudentID
JOIN Exams E ON M.ExamID = E.ExamID
JOIN Courses C ON E.CourseID = C.CourseID;
GO

SELECT *
FROM vw_ExamResults
WHERE MarksObtained > 80;

SELECT ExamType, MAX(MarksObtained) AS TopScore
FROM vw_ExamResults
GROUP BY ExamType;

SELECT *
FROM vw_ExamResults
WHERE MarksObtained < 40;
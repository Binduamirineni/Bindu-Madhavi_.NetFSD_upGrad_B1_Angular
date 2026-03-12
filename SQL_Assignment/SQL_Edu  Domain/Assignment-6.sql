--Assignment - 6

SELECT DepartmentID, COUNT(*) AS TotalStudents
FROM Students
GROUP BY DepartmentID;

SELECT ExamID, AVG(MarksObtained) AS AverageMarks
FROM Marks
GROUP BY ExamID;

SELECT CourseID, COUNT(StudentID) AS TotalStudents
FROM Enrollments
GROUP BY CourseID;

SELECT ExamID, MAX(MarksObtained) AS MaxMarks
FROM Marks
GROUP BY ExamID;

SELECT CourseID, MIN(MarksObtained)
FROM Marks M
JOIN Exams E ON M.ExamID = E.ExamID
GROUP BY CourseID;

SELECT DepartmentID, COUNT(*) AS TotalStudents
FROM Students
GROUP BY DepartmentID
HAVING COUNT(*) > 5;

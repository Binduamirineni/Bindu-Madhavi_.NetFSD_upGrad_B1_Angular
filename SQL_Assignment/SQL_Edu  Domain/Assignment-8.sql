--Assignment - 8

SELECT * FROM Marks
WHERE MarksObtained >
(SELECT AVG(MarksObtained) FROM Marks);

SELECT * FROM Courses
WHERE Credits =
(SELECT MAX(Credits) FROM Courses);

SELECT StudentID
FROM Enrollments
GROUP BY StudentID
HAVING COUNT(CourseID) > 2;

SELECT * FROM Teachers
WHERE DepartmentID =
(SELECT DepartmentID FROM Teachers WHERE TeacherName='John');
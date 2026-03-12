--Assignment - 7

SELECT S.StudentFirstName, S.LastName, D.DepartmentName
FROM Students S
JOIN Departments D
ON S.DepartmentID = D.DepartmentID;

SELECT C.CourseName, T.TeacherName
FROM Courses C
JOIN Teachers T
ON C.TeacherID = T.TeacherID;

SELECT S.StudentFirstName, C.CourseName
FROM Students S
JOIN Enrollments E ON S.StudentID = E.StudentID
JOIN Courses C ON E.CourseID = C.CourseID;

SELECT S.StudentFirstName, E.ExamType, M.MarksObtained
FROM Students S
JOIN Marks M ON S.StudentID = M.StudentID
JOIN Exams E ON M.ExamID = E.ExamID;

SELECT C.CourseName, T.TeacherName
FROM Courses C
LEFT JOIN Teachers T
ON C.TeacherID = T.TeacherID;

SELECT TeacherName
FROM Teachers
WHERE TeacherID NOT IN
(SELECT TeacherID FROM Courses);
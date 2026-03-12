--Assignment - 5

SELECT * FROM Students
WHERE DepartmentID =
(SELECT DepartmentID FROM Departments WHERE DepartmentName='Computer Science');

SELECT * FROM Teachers
WHERE HireDate > '2022-12-31';

SELECT * FROM Students
WHERE StudentFirstName LIKE 'A%';

SELECT * FROM Courses
WHERE Credits > 3;

SELECT * FROM Students
WHERE DateOfBirth BETWEEN '2005-01-01' AND '2008-12-31';

SELECT * FROM Students
WHERE DepartmentID <>
(SELECT DepartmentID FROM Departments WHERE DepartmentName='Mechanical');

SELECT * FROM Teachers
WHERE Salary BETWEEN 40000 AND 70000;

SELECT * FROM Courses
WHERE TeacherID <> 3;
--Assignment - 10

CREATE INDEX idx_lastname
ON Students(LastName);

CREATE INDEX idx_teacher_email
ON Teachers(Email);

CREATE INDEX idx_student_course
ON Enrollments(StudentID, CourseID);

CREATE UNIQUE INDEX idx_dept_name
ON Departments(DepartmentName);

DROP INDEX idx_lastname
ON Students;
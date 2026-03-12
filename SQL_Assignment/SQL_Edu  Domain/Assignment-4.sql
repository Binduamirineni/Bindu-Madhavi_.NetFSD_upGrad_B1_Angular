--Assignment - 4
--Departments
INSERT INTO Departments VALUES (1,'Computer Science','Block A');
INSERT INTO Departments VALUES (2,'Mechanical','Block B');
INSERT INTO Departments VALUES (3,'Electronics','Block C');
INSERT INTO Departments VALUES (4,'Civil','Block D');
INSERT INTO Departments VALUES (5,'IT','Block E');

--Teachers
INSERT INTO Teachers VALUES (1,'John','john@school.com',1,'2023-01-10',50000);
INSERT INTO Teachers VALUES (2,'Ravi','ravi@school.com',2,'2021-03-12',45000);
INSERT INTO Teachers VALUES (3,'Priya','priya@school.com',3,'2022-06-15',60000);
INSERT INTO Teachers VALUES (4,'Amit','amit@school.com',1,'2024-02-20',55000);
INSERT INTO Teachers VALUES (5,'Sneha','sneha@school.com',5,'2023-04-10',48000);
INSERT INTO Teachers VALUES (6,'Kiran','kiran@school.com',4,'2020-01-11',52000);
INSERT INTO Teachers VALUES (7,'David','david@school.com',1,'2023-07-01',47000);
INSERT INTO Teachers VALUES (8,'Anita','anita@school.com',2,'2022-09-09',43000);
INSERT INTO Teachers VALUES (9,'Rahul','rahul@school.com',3,'2024-01-15',62000);
INSERT INTO Teachers VALUES (10,'Meena','meena@school.com',5,'2021-11-11',46000);

--Students
INSERT INTO Students VALUES (1,'Amit','Sharma','2006-05-10','M',1,'2023-06-01');
INSERT INTO Students VALUES (2,'Anita','Reddy','2007-03-15','F',1,'2023-06-01');
INSERT INTO Students VALUES (3,'Rahul','Verma','2005-11-21','M',2,'2022-06-01');
INSERT INTO Students VALUES (4,'Sneha','Patel','2006-07-08','F',3,'2023-06-01');
INSERT INTO Students VALUES (5,'Arjun','Singh','2007-01-17','M',1,'2023-06-01');
INSERT INTO Students VALUES (6,'Kavya','Nair','2006-04-09','F',5,'2023-06-01');
INSERT INTO Students VALUES (7,'Rohit','Kumar','2005-12-12','M',2,'2022-06-01');
INSERT INTO Students VALUES (8,'Pooja','Gupta','2007-09-25','F',3,'2023-06-01');
INSERT INTO Students VALUES (9,'Vikram','Rao','2006-08-14','M',4,'2023-06-01');
INSERT INTO Students VALUES (10,'Asha','Das','2005-02-28','F',5,'2022-06-01');
INSERT INTO Students VALUES (11,'Ajay','Khan','2007-05-16','M',1,'2023-06-01');
INSERT INTO Students VALUES (12,'Neha','Mishra','2006-03-11','F',2,'2023-06-01');
INSERT INTO Students VALUES (13,'Kunal','Jain','2005-10-30','M',3,'2022-06-01');
INSERT INTO Students VALUES (14,'Priya','Yadav','2006-06-19','F',4,'2023-06-01');
INSERT INTO Students VALUES (15,'Sahil','Shah','2007-07-23','M',5,'2023-06-01');
INSERT INTO Students VALUES (16,'Arti','Kapoor','2006-01-05','F',1,'2023-06-01');
INSERT INTO Students VALUES (17,'Varun','Chopra','2005-08-18','M',2,'2022-06-01');
INSERT INTO Students VALUES (18,'Nisha','Saxena','2006-09-09','F',3,'2023-06-01');
INSERT INTO Students VALUES (19,'Deepak','Agarwal','2007-11-02','M',4,'2023-06-01');
INSERT INTO Students VALUES (20,'Anil','Pandey','2005-04-14','M',5,'2022-06-01');

--Courses
INSERT INTO Courses VALUES (1,'Database Systems',4,1,1);
INSERT INTO Courses VALUES (2,'Operating Systems',4,1,4);
INSERT INTO Courses VALUES (3,'Thermodynamics',3,2,2);
INSERT INTO Courses VALUES (4,'Digital Electronics',4,3,3);
INSERT INTO Courses VALUES (5,'Structural Engineering',3,4,6);
INSERT INTO Courses VALUES (6,'Web Development',3,5,5);
INSERT INTO Courses VALUES (7,'Data Structures',4,1,7);
INSERT INTO Courses VALUES (8,'Machine Design',3,2,8);
INSERT INTO Courses VALUES (9,'Microprocessors',4,3,9);
INSERT INTO Courses VALUES (10,'Cloud Computing',5,5,10);

--Enrollments
INSERT INTO Enrollments VALUES (1,1,1,GETDATE());
INSERT INTO Enrollments VALUES (2,2,1,GETDATE());
INSERT INTO Enrollments VALUES (3,3,2,GETDATE());
INSERT INTO Enrollments VALUES (4,4,3,GETDATE());
INSERT INTO Enrollments VALUES (5,5,1,GETDATE());
INSERT INTO Enrollments VALUES (6,6,6,GETDATE());
INSERT INTO Enrollments VALUES (7,7,2,GETDATE());
INSERT INTO Enrollments VALUES (8,8,4,GETDATE());
INSERT INTO Enrollments VALUES (9,9,5,GETDATE());
INSERT INTO Enrollments VALUES (10,10,6,GETDATE());
INSERT INTO Enrollments VALUES (11,11,7,GETDATE());
INSERT INTO Enrollments VALUES (12,12,8,GETDATE());
INSERT INTO Enrollments VALUES (13,13,9,GETDATE());
INSERT INTO Enrollments VALUES (14,14,10,GETDATE());
INSERT INTO Enrollments VALUES (15,15,6,GETDATE());
INSERT INTO Enrollments VALUES (16,16,7,GETDATE());
INSERT INTO Enrollments VALUES (17,17,8,GETDATE());
INSERT INTO Enrollments VALUES (18,18,9,GETDATE());
INSERT INTO Enrollments VALUES (19,19,5,GETDATE());
INSERT INTO Enrollments VALUES (20,20,10,GETDATE());
INSERT INTO Enrollments VALUES (21,1,2,GETDATE());
INSERT INTO Enrollments VALUES (22,2,3,GETDATE());
INSERT INTO Enrollments VALUES (23,3,4,GETDATE());
INSERT INTO Enrollments VALUES (24,4,5,GETDATE());
INSERT INTO Enrollments VALUES (25,5,6,GETDATE());
INSERT INTO Enrollments VALUES (26,6,7,GETDATE());
INSERT INTO Enrollments VALUES (27,7,8,GETDATE());
INSERT INTO Enrollments VALUES (28,8,9,GETDATE());
INSERT INTO Enrollments VALUES (29,9,10,GETDATE());
INSERT INTO Enrollments VALUES (30,10,1,GETDATE());

--Exams
INSERT INTO Exams VALUES (1,1,'2024-03-10','Midterm');
INSERT INTO Exams VALUES (2,2,'2024-03-12','Midterm');
INSERT INTO Exams VALUES (3,3,'2024-03-15','Midterm');
INSERT INTO Exams VALUES (4,4,'2024-03-18','Final');
INSERT INTO Exams VALUES (5,5,'2024-03-20','Final');

--Marks
INSERT INTO Marks VALUES (1,1,1,85);
INSERT INTO Marks VALUES (2,2,1,78);
INSERT INTO Marks VALUES (3,3,2,90);
INSERT INTO Marks VALUES (4,4,3,70);
INSERT INTO Marks VALUES (5,5,1,88);
INSERT INTO Marks VALUES (6,6,5,76);
INSERT INTO Marks VALUES (7,7,2,65);
INSERT INTO Marks VALUES (8,8,4,92);
INSERT INTO Marks VALUES (9,9,5,80);
INSERT INTO Marks VALUES (10,10,3,74);
INSERT INTO Marks VALUES (11,11,1,81);
INSERT INTO Marks VALUES (12,12,2,79);
INSERT INTO Marks VALUES (13,13,3,83);
INSERT INTO Marks VALUES (14,14,4,68);
INSERT INTO Marks VALUES (15,15,5,91);
INSERT INTO Marks VALUES (16,16,1,77);
INSERT INTO Marks VALUES (17,17,2,69);
INSERT INTO Marks VALUES (18,18,3,84);
INSERT INTO Marks VALUES (19,19,4,72);
INSERT INTO Marks VALUES (20,20,5,86);
INSERT INTO Marks VALUES (21,1,2,75);
INSERT INTO Marks VALUES (22,2,3,82);
INSERT INTO Marks VALUES (23,3,4,88);
INSERT INTO Marks VALUES (24,4,5,79);
INSERT INTO Marks VALUES (25,5,1,90);
INSERT INTO Marks VALUES (26,6,2,73);
INSERT INTO Marks VALUES (27,7,3,67);
INSERT INTO Marks VALUES (28,8,4,93);
INSERT INTO Marks VALUES (29,9,5,81);
INSERT INTO Marks VALUES (30,10,1,76);
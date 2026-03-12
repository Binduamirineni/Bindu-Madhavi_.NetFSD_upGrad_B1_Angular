--Assignment - 1

CREATE DATABASE SchoolManagementDB;

USE SchoolManagementDB;

CREATE TABLE Departments
(
    DepartmentID INT PRIMARY KEY,
    DepartmentName VARCHAR(100) UNIQUE,
    Location VARCHAR(100)
);

CREATE TABLE Teachers
(
    TeacherID INT PRIMARY KEY,
    TeacherName VARCHAR(100),
    Email VARCHAR(100) UNIQUE,
    DepartmentID INT,
    HireDate DATE,
    Salary DECIMAL(10,2),

    FOREIGN KEY (DepartmentID)
    REFERENCES Departments(DepartmentID),

    CHECK (Salary > 20000)
);

CREATE TABLE Students
(
    StudentID INT PRIMARY KEY,
    FirstName VARCHAR(50),
    LastName VARCHAR(50),
    DateOfBirth DATE,
    Gender CHAR(1),
    DepartmentID INT,
    AdmissionDate DATE,

    FOREIGN KEY (DepartmentID)
    REFERENCES Departments(DepartmentID),

    CHECK (Gender IN ('M','F'))
);

CREATE TABLE Courses
(
    CourseID INT PRIMARY KEY,
    CourseName VARCHAR(100),
    Credits INT,
    DepartmentID INT,
    TeacherID INT,

    FOREIGN KEY (DepartmentID)
    REFERENCES Departments(DepartmentID),

    FOREIGN KEY (TeacherID)
    REFERENCES Teachers(TeacherID),

    CHECK (Credits BETWEEN 1 AND 5)
);

CREATE TABLE Enrollments
(
    EnrollmentID INT PRIMARY KEY,
    StudentID INT,
    CourseID INT,
    EnrollmentDate DATE DEFAULT GETDATE(),

    FOREIGN KEY (StudentID)
    REFERENCES Students(StudentID),

    FOREIGN KEY (CourseID)
    REFERENCES Courses(CourseID)
);

CREATE TABLE Exams
(
    ExamID INT PRIMARY KEY,
    CourseID INT,
    ExamDate DATE,
    ExamType VARCHAR(50),

    FOREIGN KEY (CourseID)
    REFERENCES Courses(CourseID)
);

CREATE TABLE Marks
(
    MarkID INT PRIMARY KEY,
    StudentID INT,
    ExamID INT,
    MarksObtained INT,

    FOREIGN KEY (StudentID)
    REFERENCES Students(StudentID),

    FOREIGN KEY (ExamID)
    REFERENCES Exams(ExamID),

    CHECK (MarksObtained BETWEEN 0 AND 100)
);
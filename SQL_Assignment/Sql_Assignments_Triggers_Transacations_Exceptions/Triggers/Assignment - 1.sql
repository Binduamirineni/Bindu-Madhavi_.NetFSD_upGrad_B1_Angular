--Trigger Assignment - 1

CREATE TABLE StudentAudit
(
AuditID INT IDENTITY(1,1) PRIMARY KEY,
StudentID INT,
ActionType VARCHAR(20),
ActionDate DATETIME
);
GO

GO
CREATE TRIGGER trg_StudentInsertAudit
ON Students
AFTER INSERT
AS
BEGIN

INSERT INTO StudentAudit (StudentID, ActionType, ActionDate)
SELECT StudentID,'INSERT',GETDATE()
FROM inserted;

END;
GO

INSERT INTO Students
(StudentID,StudentFirstName,LastName,DateOfBirth,Gender,DepartmentID,AdmissionDate)
VALUES
(101,'Rahul','Kumar','2004-05-10','M',1,'2024-06-01');

SELECT * FROM StudentAudit;
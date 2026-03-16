--Trigger Assignment - 3

CREATE TABLE MarksAudit
(
AuditID INT IDENTITY(1,1) PRIMARY KEY,
StudentID INT,
ExamID INT,
OldMarks INT,
NewMarks INT,
UpdatedDate DATETIME
);
GO

GO
CREATE TRIGGER trg_UpdateMarksAudit
ON Marks
AFTER UPDATE
AS
BEGIN

INSERT INTO MarksAudit(StudentID,ExamID,OldMarks,NewMarks,UpdatedDate)

SELECT
d.StudentID,
d.ExamID,
d.MarksObtained,
i.MarksObtained,
GETDATE()

FROM deleted d
JOIN inserted i
ON d.MarkID=i.MarkID;

END;
GO

UPDATE Marks
SET MarksObtained = 90
WHERE MarkID = 1;

SELECT * FROM MarksAudit;
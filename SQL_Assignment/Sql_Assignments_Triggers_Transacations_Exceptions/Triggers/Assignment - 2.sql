--Trigger Assignment - 2

GO
CREATE TRIGGER trg_PreventStudentDelete
ON Students
INSTEAD OF DELETE
AS
BEGIN

IF EXISTS
(
SELECT 1
FROM Enrollments E
JOIN deleted D
ON E.StudentID=D.StudentID
)

BEGIN
RAISERROR('Student has course enrollments and cannot be deleted',16,1);
ROLLBACK TRANSACTION;
RETURN;
END

DELETE FROM Students
WHERE StudentID IN (SELECT StudentID FROM deleted);

END;
GO

DELETE FROM Students
WHERE StudentID = 1;

delete from Students where StudentID=150 

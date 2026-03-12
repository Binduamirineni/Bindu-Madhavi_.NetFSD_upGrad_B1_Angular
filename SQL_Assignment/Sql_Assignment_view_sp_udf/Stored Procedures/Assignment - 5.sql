--SP Assignment - 5

CREATE PROCEDURE sp_UpdateMarks
@MarkID INT,
@NewMarks INT
AS
BEGIN

-- Update the marks
UPDATE Marks
SET MarksObtained = @NewMarks
WHERE MarkID = @MarkID;

-- Display the updated result
SELECT *
FROM Marks
WHERE MarkID = @MarkID;

END;
GO

EXEC sp_UpdateMarks 3, 85;
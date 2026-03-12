--SP Assignment - 6

CREATE PROCEDURE sp_DeleteEnrollment
@EnrollmentID INT
AS
BEGIN

-- Delete the enrollment record
DELETE FROM Enrollments
WHERE EnrollmentID = @EnrollmentID;

-- Verify deletion
SELECT * 
FROM Enrollments
WHERE EnrollmentID = @EnrollmentID;

END;
GO

EXEC sp_DeleteEnrollment 10;

SELECT * FROM Enrollments;
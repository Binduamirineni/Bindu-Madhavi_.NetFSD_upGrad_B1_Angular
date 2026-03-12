--Assignment - 3

ALTER TABLE Students
ADD PhoneNumber VARCHAR(15);

ALTER TABLE Teachers
ALTER COLUMN Salary DECIMAL(12,2);

ALTER TABLE Teachers
ADD CONSTRAINT Salary_Check
CHECK (Salary > 20000);

ALTER TABLE Students
DROP COLUMN PhoneNumber;

EXEC sp_rename 'Students.FirstName', 'StudentFirstName', 'COLUMN';
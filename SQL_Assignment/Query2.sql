-- FIRST_NAME using alias WORKER_NAME
SELECT FIRST_NAME AS WORKER_NAME FROM Worker;

--FIRST_NAME in upper case
SELECT UPPER(FIRST_NAME) FROM Worker;

--unique DEPARTMENT values
SELECT DISTINCT DEPARTMENT FROM Worker;

--first 3 characters of FIRST_NAME
SELECT SUBSTRING(FIRST_NAME,1,3) FROM Worker;

--position of ‘a’ in FIRST_NAME = 'Amitabh'
SELECT CHARINDEX('a','Amitabh')
-- from table
SELECT CHARINDEX('a', FIRST_NAME)
FROM Worker
WHERE FIRST_NAME='Amitabh';

--Remove right side spaces from FIRST_NAME
SELECT RTRIM(FIRST_NAME) FROM Worker;

--Remove left side spaces from DEPARTMENT
SELECT LTRIM(DEPARTMENT) FROM Worker;

--Unique DEPARTMENT and its length
SELECT DISTINCT DEPARTMENT, LEN(DEPARTMENT) AS Dept_Length FROM Worker;

--Replace ‘a’ with ‘A’ in FIRST_NAME
SELECT REPLACE(FIRST_NAME,'a','A') FROM Worker;

--Combine FIRST_NAME + LAST_NAME as COMPLETE_NAME
SELECT FIRST_NAME +' '+ LAST_NAME AS COMPLETE_NAME FROM Worker;

--Order by FIRST_NAME Ascending
SELECT * FROM Worker ORDER BY FIRST_NAME ASC;

--Order by FIRST_NAME Asc & DEPARTMENT Desc
SELECT * FROM Worker ORDER BY FIRST_NAME ASC, DEPARTMENT DESC;

--Workers with FIRST_NAME “Vipul” and “Satish”
SELECT * FROM Worker WHERE FIRST_NAME IN ('Vipul','Satish');

--Excluding “Vipul” and “Satish”
SELECT * FROM Worker WHERE FIRST_NAME NOT IN ('Vipul','Satish');

--Workers from Admin department
SELECT * FROM Worker WHERE DEPARTMENT = 'Admin';

--FIRST_NAME contains ‘a’
SELECT * FROM Worker WHERE FIRST_NAME LIKE '%a%';

--FIRST_NAME ends with ‘a’
SELECT * FROM Worker WHERE FIRST_NAME LIKE '%a';

--FIRST_NAME ends with ‘h’ and has 6 letters
SELECT * FROM Worker WHERE FIRST_NAME LIKE '_____h';

--SALARY between 100000 and 500000
SELECT * FROM Worker WHERE SALARY BETWEEN 100000 AND 500000;

--Joined in Feb 2014
SELECT * FROM Worker WHERE MONTH(JOINING_DATE)=2 AND YEAR(JOINING_DATE)=2014;

--Salary between 50000 and 100000
SELECT * FROM Worker WHERE SALARY BETWEEN 50000 AND 100000;

--Number of workers per department (Descending)
SELECT DEPARTMENT, COUNT(*) AS TOTAL_Workers FROM Worker
GROUP BY DEPARTMENT
ORDER BY TOTAL_Workers DESC; 

--Workers who are Managers
SELECT * FROM Worker WHERE WORKER_ID IN(
	SELECT WORKER_REF_ID 
	FROM Title
	WHERE WORKER_TITLE = 'Manager'
);

--current date and time
SELECT GETDATE();

--top 10 records
SELECT TOP 10 * FROM Worker;

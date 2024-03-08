--task day 6--
--1. Create a scalar function that takes date and returns Month name of that 
--date.
CREATE FUNCTION MonthName(@date DATE)
RETURNS VARCHAR(20)
AS
BEGIN
    DECLARE @mname VARCHAR(20)
    SET @mname = FORMAT(@date, 'MMMM')
    RETURN @mname
END
--calling
SELECT dbo.MonthName('2024-07-08')


--2. Create a multi-statements table-valued function that takes 2 integers 
--and returns the values between them.
--Name with Student full name.

user 
a. If first name and Last name are null then display 'First name & 
last name are null'
b. If First name is null then display 'first name is null'
c. If Last name is null then display 'last name is null'
d. Else display 'First name & last name are not null'*/
-- first solution
CREATE FUNCTION getmsg(@St_Id INT)
RETURNS VARCHAR(100)
AS
BEGIN
    DECLARE @msg VARCHAR(100)

    SELECT @msg = 
        CASE
            WHEN St_Fname IS NULL AND St_Lname IS NULL THEN 'First name & last name are null'
            WHEN St_Fname IS NULL THEN 'First name is null'
            WHEN St_Lname IS NULL THEN 'Last name is null'
            ELSE 'First name & last name are not null'
        END
    FROM Student
    WHERE St_Id = @St_Id

    RETURN @msg
END
RETURNS VARCHAR(100)
AS
BEGIN
    DECLARE @msg VARCHAR(100)

    DECLARE @St_Fname VARCHAR(50)
    DECLARE @St_Lname VARCHAR(50)

    SELECT @St_Fname = St_Fname, @St_Lname = St_Lname
    FROM Student
    WHERE St_Id = @St_Id

    IF @St_Fname IS NULL AND @St_Lname IS NULL
        SET @msg = 'First name & last name are null'
    ELSE IF @St_Fname IS NULL
        SET @msg = 'First name is null'
    ELSE IF @St_Lname IS NULL
        SET @msg = 'Last name is null'
    ELSE
        SET @msg = 'First name & last name are not null'

    RETURN @msg
END
--and displays department name, Manager Name and hiring date
If string='first name' returns student first name
If string='last name' returns student last name 
If string='full name' returns Full Name from student table 
Note: Use �ISNULL� function*/
returns @t table
			(
			 sname varchar(60)
			)
as
	begin
		if @format='first'
			insert into @t
            select isnull(st_fname, '') FROM Student;
		else if @format='last'
			insert into @t
			select isnull(st_Lname, '') from Student
		else if @format='fullname'
			insert into @t
			select isnull(concat(st_fname,' ',st_lname), '') from Student
		return 
	end

--calling
select * from dbo.getstuds('first')

--7. Write a query that returns the Student No and Student first name 
--without the last char

SELECT
    St_ID,
    SUBSTRING(St_Fname, 1, LEN(St_Fname) - 1) AS TrimmedFirstName
FROM
    Student;

From Stud_Course sc inner JOIN Student S
ON S.St_Id = sc. St_Id inner JOIN Department D
ON S.Dept_Id = d. Dept_Id
WHERE D.Dept_Name�=�'SD';






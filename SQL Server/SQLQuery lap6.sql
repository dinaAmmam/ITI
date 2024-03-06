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
--and returns the values between them.create function getrange(@num1 int , @num2 int)returns @t table           (		     val int           )as        begin	         declare @counter int = @num1			 while @counter <= @num2			 begin			    insert into @t (val)				values (@counter)				set @counter = @counter + 1			 end		return	   end--callingSELECT * FROM dbo.getrange(3, 8)--3. Create inline function that takes Student No and returns Department 
--Name with Student full name.use ITIcreate function getstd(@St_Id int)returns tableas    return	     (		   select Dept_Name as department_name , concat(St_Fname, ' ', St_Lname) AS fullName		   from Student s , Department d		   where St_Id = @St_Id and s.Dept_Id = d.Dept_Id		 )--callingselect * from getstd(2)
/*4. Create a scalar function that takes Student ID and returns a message to 
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
END--secondCREATE FUNCTION getmsgg(@St_Id INT)
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
END--callingSELECT dbo.getmsgg(1)select dbo.getmsg(11)--5 Create inline function that takes integer which represents manager ID 
--and displays department name, Manager Name and hiring datecreate function getdept(@Dept_Manager int)returns tableas    return	     (		   select Dept_Name as department_name , Ins_Name as manger_name , Manager_hiredate as manger_hiredate		   from Instructor i , Department d		   where Dept_Manager=@Dept_Manager and i.Dept_Id = d.Dept_Id		 )--callingselect * from getdept(2)/*6. Create multi-statements table-valued function that takes a string
If string='first name' returns student first name
If string='last name' returns student last name 
If string='full name' returns Full Name from student table 
Note: Use “ISNULL” function*/create function getstuds(@format varchar(30))
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
--8. Write query to delete all grades for the students Located in SD DepartmentDELETE sc
From Stud_Course sc inner JOIN Student S
ON S.St_Id = sc. St_Id inner JOIN Department D
ON S.Dept_Id = d. Dept_Id
WHERE D.Dept_Name = 'SD';







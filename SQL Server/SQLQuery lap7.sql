use ITI
--lap7
--1. Create a view that displays student full name, course name if the 
--student has a grade more than 50. 
alter view Vstud
as
	select concat(St_Fname, ' ', St_Lname) AS fullName , Crs_Name
	from student s, Stud_Course sc , Course c
	where s.St_Id = sc.St_Id and sc.Crs_Id = c.Crs_Id and Grade > 50

select * from Vstud

--2. Create an Encrypted view that displays manager names and the topics 
--they teach. 
alter View Vmng(instructor_name , course_name)
as
	select Ins_Name , Crs_Name
	from Instructor i , Ins_Course ic , Course c
	where i.Ins_Id = ic.Ins_Id and ic.Crs_Id = c.Crs_Id

Select * from Vmng

--another solution
create View Vmng2(instructor_name , course_name)with encryption
as
	select Ins_Name , Crs_Name
	from Instructor i , Ins_Course ic , Course c
	where i.Ins_Id = ic.Ins_Id and ic.Crs_Id = c.Crs_Id

Select * from Vmng2

--3. Create a view that will display Instructor Name, Department Name for 
--the �SD� or �Java� Department 
alter view vindn 
as 
     select Ins_Name , Dept_Name
	 from Instructor i, Department d
	 where i.Dept_Id = d.Dept_Id and  Dept_Name in ('SD', 'jave')

select * from vindn

/*4. Create a view �V1� that displays student data for student who lives in 
Alex or Cairo. 
Note: Prevent the users to run the following query 
Update V1 set st_address=�tanta�
Where st_address=�alex�;*/
as
	select *
	from Student
	where St_Address in ('cairo' , 'alex')
	with check option

select * from Vi1
--not allowed
Update Vi1 set st_address='tanta'

--employees work on it. �Use Company DB�
a. Company Schema 
i. Department table (Programmatically)
ii. Project table (by wizard)
b. Human Resource Schema
i. Employee table (Programmatically)*/
ALTER SCHEMA Company TRANSFER dbo.Departments;
--ALTER SCHEMA Company TRANSFER dbo.Project;

create schema HumanResource
Alter SCHEMA HumanResource TRANSFER dbo.Employee;
--data in table Department. What will happen? - Use ITI DB
on Department(manager_Hiredate)
--happen? - Use ITI DB
on student(st_age)
--10% if Salary <3000 and increases it by 20% if Salary >=3000. Use 
--company DB
DECLARE @EmpId INT, @CurrentSalary int, @NewSalary int;

DECLARE EmployeeCursor CURSOR FOR
SELECT SSN, Salary
FROM Employee;

OPEN EmployeeCursor;

FETCH NEXT FROM EmployeeCursor INTO @EmpId, @CurrentSalary;

WHILE @@FETCH_STATUS = 0
BEGIN
    IF @CurrentSalary < 3000
        SET @NewSalary = @CurrentSalary * 1.10; -- Increase by 10%
    ELSE
        SET @NewSalary = @CurrentSalary * 1.20; -- Increase by 20%

    -- Update the Employee table
    UPDATE Employee
    SET Salary = @NewSalary
    WHERE SSN = @EmpId;

    FETCH NEXT FROM EmployeeCursor INTO @EmpId, @CurrentSalary;
END

CLOSE EmployeeCursor;
DEALLOCATE EmployeeCursor;
for select distinct Dept_Name , Dept_Manager
	from Department d
for read only
open C2
Fetch C2 into @deptName,@DeptManger
while @@FETCH_STATUS=0
 begin
  select @deptName,@DeptManger
  Fetch C2 into @deptName,@DeptManger
 end
close C2
Deallocate C2
--Cursor . Use ITI DB
for select  ins_name
 from Instructor
 where Ins_Name is not null
for read only
declare @name varchar(20),@all_names varchar(300)=''
open c3
fetch c3 into @name
while @@FETCH_STATUS=0
 begin
  set @all_names=concat(@all_names,',',@name)
  fetch c3 into @name   --Next Row
 end
select @all_names
close c3
deallocate C3
--this DB
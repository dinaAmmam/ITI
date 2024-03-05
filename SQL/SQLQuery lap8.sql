--day8
--1. Create a stored procedure to show the number of students per 
--department.[use ITI DB]use ITIcreate proc getnumstas      select COUNT(St_Id) , Dept_Name	 from Student s , Department d	 where s.Dept_Id = d.Dept_Id	 group by Dept_Name--calling getnumst /*2. Create a stored procedure that will check for the # of employees in the 
project p1 if they are more than 3 print message to the user “'The number 
of employees in the project p1 is 3 or more'” if they are less display a 
message to the user “'The following employees work for the project p1'” in 
addition to the first name and last name of each one. [Company DB] */use Company_SD

alter PROCEDURE GetstBypnum @pnum INT
AS
BEGIN
    IF (
            (SELECT COUNT(e.SSN)
             FROM Project p, employee e, Works_for w
             WHERE p.Pnumber = @pnum AND e.SSN = w.ESSn AND p.Pnumber = w.Pno) >= 3
    )
        SELECT 'The number of employees in p' + CAST(@pnum AS VARCHAR(10)) + ' is 3 or more' AS Message;
    ELSE
        BEGIN
            SELECT 'The following employees work for the project ' + CAST(@pnum AS VARCHAR(10)) AS Message;
            SELECT CONCAT(e.Fname, ' ', e.Lname) AS EmployeeName
            FROM Project p, employee e, Works_for w
            WHERE p.Pnumber = @pnum AND e.SSN = w.ESSn AND p.Pnumber = w.Pno;
        END
END;
GetstBypnum  200

/*3. Create a stored procedure that will be used in case there is an old 
employee has left the project and a new one become instead of him. The 
procedure should take 3 parameters (old Emp. number, new Emp. number 
and the project number) and it will be used to update works_on table. 
[Company DB]*/
alter proc updateemp @oldemp int , @newemp int , @pnum int
as
  begin
    IF (
    EXISTS (
        SELECT 1
        FROM employee e
        JOIN works_for w ON e.SSN = w.ESSn
        JOIN project p ON p.Pnumber = w.Pno
        WHERE e.SSN = @oldemp AND p.Pnumber = @pnum
    )
)
 
    UPDATE Works_for   
    SET ESSn = @newemp
	where ESSn = @oldemp
   end

   updateemp 223344 , 342001 , 10
    
--4
/*This table will be used to audit the update trials on the Budget column 
(Project table, Company DB)
Example:
If a user updated the budget column then the project number, user name 
that made that update, the date of the modification and the value of the 
old and the new budget will be inserted into the Audit table
Note: This process will take place only if the user updated the budget 
column*/

/*5. Create a trigger to prevent anyone from inserting a new record in the 
Department table [ITI DB]
“Print a message for user to tell him that he can’t insert a new record in 
that table”*/
use ITI
alter trigger t1
on Department
instead of insert
as
		select 'you cannot insert new record in that table'

INSERT INTO Department (Dept_Id , Dept_Name ,Dept_Desc, Dept_Location, Dept_Manager , Manager_hiredate) 
values(80,'nc','buss' , 'cairo' , null , null)

/*6. Create a trigger that prevents the insertion Process for Employee table in 
March [Company DB].*/
use Company_SD
create trigger t2
on Employee
after Insert
as
   begin
	if format(getdate(),'mmmm')='march'
	select 'Insert operation not allowed in March'
	rollback;
   end

/*7. Create a trigger on student table after insert to add Row in Student Audit
table (Server User Name , Date, Note) where note will be “[username] 
Insert New Row with Key=[Key Value] in table [table name]”*/
use iti
Create Table Student_Audit
(
_user nvarchar(20),
_date date,
_note nVARCHAR(50)
)

alter trigger t3
on student
after insert 
as
		begin
			DECLARE @Key nVARCHAR(50);
            SELECT @Key = St_Fname from inserted;
			declare @Note nVARCHAR(50)
			SET @Note = @Key;
			insert into Student_Audit
			values(suser_name(),getdate(),@Key)
		end	

insert into Student 
values (340,'dinaa' , 'mohamed' , ' mahalla' , null , null , null)
/*8. Create a trigger on student table instead of delete to add Row in Student
Audit table (Server User Name, Date, Note) where note will be“ try to 
delete Row with Key=[Key Value]”







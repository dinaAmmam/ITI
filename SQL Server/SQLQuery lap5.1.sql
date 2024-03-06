use ITI
--lap 5
/*1*/
select COUNT(St_Id)
from Student
where St_Age is not null
/*2*/
select distinct Ins_Name
from Instructor
/*3*/
select St_Id as studentID  , CONCAT(ISNULL(s.St_Fname, ''), ' ' , ISNULL(s.St_Lname, ''))as fullName ,
d.Dept_Name as departmentName
from Student s , Department d
where d.Dept_Id = s.Dept_Id
/*4*/
SELECT
    I.Ins_Name AS instructorName,
    D.Dept_Name AS departmentName
FROM
    Instructor I
LEFT JOIN
    Department D ON I.Dept_Id = D.Dept_Id;
/*5*/
select CONCAT(s.St_Fname , ' ',s.St_Lname) as fullName , Crs_Name
from Student s , Stud_Course sc , Course c
where s.St_Id = sc.St_Id and sc.Crs_Id = c.Crs_Id
/*6*/
select T.Top_Name,
count(C.crs_id) as [Number of Courses]
from Topic as T
join Course as C
on T.Top_Id = C.Top_Id
group by T.Top_Name
/*7*/
select max(salary) As [Max Salary] , min(salary) as [Min Salary]
from Instructor
where Salary is not null
/*8*/
select Ins_Name
from Instructor
where Salary < (select avg(salary) from Instructor)
/*9*/
Select Dept_Name

from
(Select Dept_Name,ROW_NUMBER() over (Order by I.salary) as RowNum
from Instructor as I
join Department as D
on I.Dept_Id = D.Dept_Id) As Ranking_Sub_Query

where RowNum=1
/*10*/
select Top(2) Salary,ROW_NUMBER() over(Order by Salary desc) as RowNum
from Instructor
/*11*/
select Ins_Name , coalesce(convert(varchar(10),Salary),'Bonus')
from Instructor
/*12*/
select avg(salary)
from Instructor
/*13*/
select S.St_Fname , Sup.*
from Student as S 
join Student as Sup
on S.St_super = Sup.St_Id
/*14*/
select Dept_name,Salary
from
(select Dept_name,Salary ,ROW_NUMBER() over (partition by D.dept_id order by I.salary desc) as RowNum
from Instructor As I
join Department As D
on I.Dept_Id = D.Dept_id
Where Salary is Not Null)
as [Ranking Query]
where RowNum in (1,2)
/*15*/
select *
from (
    select *, ROW_NUMBER() over (Partition by Dept_Id order by NEWID()) as RowNum
    from Student
) as Ranking_Subquery
where RowNum = 1;
use Company_SD
--lap3
/*1*/
select Dnum , Dname , Fname ,MGRSSN
from Employee e , Departments d
where e.SSN = d.MGRSSN
/*2*/
select Dname , Pname
from Project p , Departments d
where d.Dnum = p.Dnum
/*3*/
SELECT d.*
FROM Dependent d
LEFT JOIN Employee e ON d.ESSN = e.SSN;
/*4*/
select Pnumber , Pname , Plocation
from Project
where city in('alex','cairo')
/*5*/
select *
from Project
where Pname like 'a%'
/*6*/
SELECT *
FROM Employee e
LEFT JOIN Departments d ON e.Dno = d.Dnum
WHERE d.Dnum = 30 AND e.Salary between 1000 AND 2000
/*7*/
select concat(Fname, ' ', Lname)  AS FullName
from Employee e
inner join works_for w
on e.SSN = w.ESSn
	inner join
	Project p
	on w.Pno = p.Pnumber
where e.Dno = 10 and w.Hours >= 10 and p.Pname='AL Rabwah'
-------------------
Select concat(e.Fname, ' ', e.Lname) AS FullName
from Employee e inner join works_for w
	on e.SSN = w.ESSn  
	inner join
	Project p
	on w.Pno = p.Pnumber
	where e.Dno = 10 and w.Hours >= 10 and p.Pname='AL Rabwah'
/*8*/
select concat(e1.Fname, ' ', e1.Lname) AS employees
from Employee e1 inner join Employee e2
on e1.Superssn = e2.SSN
where concat(e2.Fname, ' ', e2.Lname) = 'Kamel Mohamed'
/*9*/
select e.Fname, p.Pname
from Employee e inner join Works_for w
on e.SSN = w.ESSn
inner join Project p
on w.Pno = p.Pnumber
order by p.Pname

Select e.Fname,p.Pname
from Employee e, Works_for w, Project p
where e.SSN = w.ESSn   and w.Pno = p.Pnumber
order by p.Pname

/*10*/
select pnumber,dname, e.fname
from Project p inner join Departments d
on d.Dnum=p.Dnum
inner join Employee e
on ssn=MGRSSN and City='cairo'
/*11*/
select e.* 
from Employee e , Departments d
where e.SSN=d.MGRSSN
/*12*/
select e.* , d.*
from Employee e left outer join Dependent d
on SSN = ESSN
/*13*/
insert into Employee (Dno,ssn,Superssn,Salary)
values(30,12660,112233,3000)
--14
insert into employee(dno,ssn)
values(30,102660)
--15
update Employee
set Salary += (salary*0.2)
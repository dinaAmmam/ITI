use Company_SD
--lap 4 
/*1*/
select d.Dependent_name , d.Sex
from Dependent d , Employee e
where e.SSN = d.ESSN and 
d.Sex = 'f' and e.Sex = 'f'
union
select d.Dependent_name , d.Sex
from Dependent d , Employee e
where e.SSN = d.ESSN and 
d.Sex = 'm' and e.Sex = 'm'
/*2*/
select p.Pname , SUM(w.Hours)
from Employee e , Project p , Works_for w
where e.SSN = w.ESSn and w.Pno = p.Pnumber
group by p.Pname
/*3*/
select d.*
from Departments d , Employee e
where Dnum = Dno and e.SSN=(select min(SSN) from Employee)
/*4*/
select d.Dname ,max(e.Salary),min(e.Salary),avg(isnull (e.Salary ,0))
from Departments d , Employee e
where Dnum=Dno
group by d.Dname
/*5*/
select CONCAT(e.Fname, ' ' , e.Lname) as fullName
from Employee e , Departments d
where e.SSN = d.MGRSSN and SSN not in ( select ESSN from Dependent)
/*6*/
SELECT D.Dnum, D.Dname, COUNT(E.SSN) AS EmployeeNum
FROM Departments d , Employee e
where D.Dnum = E.Dno
GROUP BY D.Dnum, D.Dname
HAVING AVG(E.Salary) < (SELECT AVG(Salary) FROM Employee)
/*7*/
select CONCAT(e.Fname, ' ' , e.Lname) as fullName , p.Pname
from Employee e ,Project p, Works_for w
where e.SSN = w.ESSn and w.Pno = p.Pnumber
order by e.Dno , e.Lname ,e.Fname
/*8*/ ----------------------------------
SELECT Salary
FROM employee e
WHERE salary IS NOT NULL AND 2 >= 
(SELECT COUNT( salary)
 FROM employee e2
 WHERE e2.salary >= e.salary
)
order by Salary desc
---------------------------------------
/*9*/
select DISTINCT CONCAT(e.Fname, ' ' , e.Lname) as employeeName 
from Employee e , Dependent d
where E.Fname + ' ' + E.Lname LIKE ('%' + D.Dependent_name + '%') and e.SSN = d.ESSN
/*10*/
select e.SSN , CONCAT(e.Fname, ' ' , e.Lname) as employeeName
from Employee e 
where exists(  SELECT 1 FROM Dependent d WHERE d.ESSN = e.SSN)
/*11*/
insert into Departments (Dname, Dnum , MGRSSN , [MGRStart Date])
values ('Dept IT',100,112233,'1/11/2006')
/*12*/
--a
update Departments
set MGRSSN= 968574
where Dnum=100
--b
-- on update cascade
update Departments
SET MGRSSN = 102672
WHERE Dnum = 20
--c ----------------
UPDATE Employee
SET Superssn = 102672
WHERE SSN = 102660
----------------------
/*13*/
UPDATE Dependent
SET ESSN=102672
WHERE ESSN = 223344
UPDATE works_for
SET ESSN=102672
WHERE ESSN = 223344
UPDATE Departments
SET MGRSSN = 102672
WHERE Dnum = 10
UPDATE employee
SET SUPERSSN = 102672
WHERE SUPERSSN = 223344
DELETE FROM employee
WHERE SSN = 223344
/*14*/
UPDATE Employee
SET Salary = Salary * 1.30
WHERE SSN IN (
 SELECT W.ESSn
 FROM Works_for AS W
 JOIN Project AS P
ON W.Pno = P.Pnumber
 WHERE P.Pname = 'Al Rabwah'
)




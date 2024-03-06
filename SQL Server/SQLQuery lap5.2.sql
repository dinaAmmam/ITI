Use AdventureWorks2012
/*1*/
select salesOrderID,ShipDate 
from Sales.SalesOrderHeader
where OrderDate between '7/28/2002' and '7/29/2014'
/*2*/
select ProductID,Name
from Production.Product
where StandardCost <110
/*3*/
select ProductID,Name
from Production.Product
where Weight is null
/*4*/
select ProductID,Name
from Production.Product
where color in ('silver','black','red')
/*5*/
select *
from Production.Product
where Name like ('B%')
/*6*/
Update  Production.ProductDescription 
set Description = 'Chromoly steel_High of defects'
WHERE ProductDescriptionID = 3
select Description
from Production.ProductDescription
where Description like '%[_]%'
/*7*/
select sum(TotalDue)
from Sales.SalesOrderHeader
where OrderDate between '7/1/2001' and '7/31/2014'
group by OrderDate
/*8*/
select distinct HireDate
from HumanResources.Employee
/*9*/
select avg (DISTINCT ListPrice)
from Production.Product
/*10*/
select 'The'+ Name+'is only!'+ Convert(varchar(50),ListPrice) as Offers
from Production.Product
where ListPrice between 100 and 120
order by ListPrice
/*12*/
select format(getdate(),'d-M-yyyy')
union
select format(getdate(),'ddd-MMM-yyyy')
union
select format(getdate(),'dddd-MMMM-yyyy')

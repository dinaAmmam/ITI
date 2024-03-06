--task2
use Company_SD

create table instructor
(
id int primary key identity(1,1),
salery int default 3000,
overtime int,
bd date,
age as (year(getdate())-year(bd)),
first varchar(10),
last varchar(10),
hiredate date default getdate(),
address varchar(50),
netsalery as (salery+overtime) persisted,
constraint c11 unique(overtime),
constraint c22 check (address in ('cairo','alex')),
constraint c33 check(salery between 1000 and 5000),
)
create table course
(
cid int primary key identity(1,1),
duration int,
cname varchar(20),
constraint c1 unique(duration),
)
create table lap
(
lid int,
lcid int,
location varchar(20),
capacity int,
constraint c55 primary key(lid,lcid),
constraint c66 check (capacity<20),
constraint c77 foreign key(lcid) references course(cid)
on delete cascade on update cascade,
)
create table teach
(
ccid int,
iid int,
constraint c80 primary key(ccid,iid),
constraint c90 foreign key(iid) references course(cid)
on delete cascade on update cascade ,
constraint c100 foreign key(ccid) references instructor(id)
on delete cascade on update cascade ,
)
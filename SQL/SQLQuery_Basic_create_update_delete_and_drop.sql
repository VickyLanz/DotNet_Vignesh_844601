create database EmployeeDB;
use EmployeeDB;
create table Employee
(empid int not null primary key,
emname varchar(50) not null,
ssn bigint not null,
salary float not null,
deptid int not null);
insert into Employee values(1,'suresh',0001,12000,1);
insert into Employee values(2,'vicky',0002,22000,2);
insert into Employee values(3,'ricky',0003,32000,3);
insert into Employee values(5,'rocky',0004,42000,7,'02-05-1998');
alter table Employee 
add depid int;

select * from Employee;
delete Employee;
drop table Employee;
create table department
(deptid int not null primary key,
deptname varchar(50) not null);
insert into department values(1,'Admin');
insert into department values(2,'marketing');
insert into department values(3,'technical');
insert into department values(4,'stores');
select * from department;


drop table department;

update Employee set ssn=5 where empid=5;

select * from Employee where salary between 1900 and 25000;

select * from Employee where deptid <= 4;

select empid,ssn,deptid from Employee where emname='THIRU';
select * from department where deptid=3;
alter table department
add descriptio varchar(100);
alter table department column 'deptid' to 'depid';
update department set descriptio='this is admin area' where deptid=1;
update department set descriptio='this is marketing area' where deptid=2;
update department set descriptio='this is technical area' where deptid=3;
update department set descriptio='this is stores area' where deptid=4;
Alter table Employee
add constraint fk_depid foreign key(depid) references department(deptid);
alter table Employee
drop column depid;
delete table constraint;
alter table Employee drop constraint fk_depid;
alter table Employee
Add dob date;
update Employee set salary=22000 where empid=5;
update Employee set dob='10/12/1997' where empid =1;
update Employee set dob='12/11/1995' where empid =2;
update Employee set dob='10/05/1992' where empid =3;
update Employee set dob='12/31/1996' where empid =4;
update Employee set emname='vignesh' where empid=1;
select sum(salary) [sum salary] from Employee;
select count(empid) [Total no of employees] from Employee;
select depid, sum(salary) [total salary] from Employee group by(depid)having sum(salary)>25000 order by depid;
select top(5) * from Employee order by salary;

select e.empid,e.emname,e.ssn,e.salary,d.deptid,d.deptname from Employee as e inner join department as d on e.depid =d.deptid;
select getdate() as 'current date';
select emname,datediff(yyyy,dob,getdate()) as 'age' from Employee;
select day(getdate()) as 'day';
select month(getdate()) as month;
select year(getdate()) as year;
select emname,len(emname) as length from Employee;
select upper(emname) as upper_case, lower(emname) as lower_case from Employee;
select emname,substring(emname,1,3) as partname from Employee;
select substring('fire truck is on the way',1,13);
select emname,reverse(emname) as name_reverse from Employee;
select replace('good morning','morning','evening')as replaced_word;
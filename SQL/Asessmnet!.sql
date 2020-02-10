create database EmployeeDB;

create table Employee
(EmpId int ,
EmpName varchar(50),
DeptID int,
DeptName Varchar(50));


insert into Employee values(101,'John Snow',008,'Admin');
insert into Employee values(102,'Arya stark',002,'Marketing');
insert into Employee values(103,'Hodor',005,'Sales');
insert into Employee values(104,'kings landings',007,'Production');


Select * from Employee;

sp_rename "Employee.EmpID","EmployeeID","column";

select * from Employee;
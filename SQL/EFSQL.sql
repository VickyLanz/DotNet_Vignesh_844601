create database EmployeeEFDB;


--creating employee table
create table Employee
(EmpID int primary key,
Name varchar(30) not null,
SSN bigint not null,
Salary float not null,
DepID int not null);

--creating Departmnet table
create table Department
(DepID int primary key,
Name varchar(30) not null);


--Adding Primary key and Foreign Key Constraint
Alter table Employee 
Add constraint FK_DepID foreign key (DepID) references Department (DepID);

insert into Employee values(04,'Vicky',1234,21900.34,1);


--Inserting values into the Department table

insert into Department values(1,'Admin');
insert into Department values(2,'Marketing');
insert into Department values(3,'Sales');

select * from Employee;
select * from Department;


update Department
set Name='Production' where Name='Marketing';
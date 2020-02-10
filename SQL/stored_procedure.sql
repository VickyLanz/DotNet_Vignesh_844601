Select * from Customers;
create procedure GetCustomersByCountry
(@country varchar(50))
as
select CustomerID,ContactName,CompanyName,Address,Country from Customers where Country=@country;


Execute GetCustomersByCountry 'USA';


create procedure GetProductByCategoryName
(@categoryID int)
as
Select p.ProductID,p.ProductName,p.UnitPrice,p.QuantityPerUnit,c.CategoryID,c.CategoryName from Products p inner join Categories c on p.CategoryID=c.CategoryID and c.CategoryID=@categoryID;

Execute GetProductByCategoryName  5;

create procedure GetProductsByCategoryName
(@categoryID int)
as
Select p.ProductID,p.ProductName,p.UnitPrice,p.QuantityPerUnit,c.CategoryID,c.CategoryName from Products p inner join Categories c on p.CategoryID=c.CategoryID ;

execute GetProductsByCategoryName 4;


--Declaring an local variable

declare @country as varchar(12);
set @country='UK';

Select * from Customers where Country=@country;

--Creating stored Procedures that returns a value

Alter procedure GetTotalOrdersByDates
(@date1 date,@date2 date ,@countOrder int output)
as
Select @countOrder=Count(OrderID) from Orders where OrderDate between @date1 and @date2;
go


declare @count as int;
--set @count=830;
Execute GetTotalOrdersByDates '01/01/1990','12/31/1998',@count output;

print 'Total number of Orders placed  :'+Cast(@count as varchar(29));


--creatin functions

alter function Multiply(@n1 int,@n2 int )
returns bigint
as
begin
   declare @prod as bigint;
   set @prod=@n1*@n2;
   return @prod;
end;

select dbo.Multiply(50,80) as Product;


--table value function

create function GetCustomer(@country varchar(30)) returns table
as
return select * from Customers Where Country=@country;
go


select * from dbo.GetCustomer('Germany')

--table value function with INNER JOIN 

alter function GetAllProductsByCategoryName
(@categoryID int)returns table
as
return Select p.ProductID,p.ProductName,p.UnitPrice,p.QuantityPerUnit,c.CategoryID,c.CategoryName from Products p inner join Categories c on p.CategoryID=c.CategoryID and @categoryID=c.CategoryID;

select * from dbo.GetAllProductsByCategoryName(5)


--sub query 

select ProductID,ProductName,UnitPrice,QuantityPerUnit,CategoryID from Products 
where UnitPrice>(Select avg(UnitPrice) from Products) order by UnitPrice

Select Distinct Country from Customers
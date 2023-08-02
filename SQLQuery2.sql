Select ContactName,CompanyName,City from Customers

select * from Customers where City='Berlin'

select * from Products where CategoryID=1 or CategoryID=2

select * from Products where  CategoryID=2 and UnitPrice<=10

select *from Products order by ProductName

select * from Products order by SupplierID,CategoryID

select * from Products order by UnitPrice --- asc düşükten yükseğe ---desc yüksekten düşüğe

select * from Products where CategoryID=1 order by UnitPrice asc

select count(*) from Products where CategoryID=2

select CategoryID,   count(*) from Products group by CategoryID

select CategoryID  , count(*) from  Products where UnitPrice>20
group by CategoryID having count(*)<10

select *
from Products inner join Categories
on Products.CategoryID=Categories.CategoryID


select Products.ProductID,Categories.CategoryName,Products.UnitPrice,Products.ProductName
from Products inner join Categories
on Products.CategoryID=Categories.CategoryID

--DTO Data  Transformation object

select Products.ProductID,Categories.CategoryName,Products.UnitPrice,Products.ProductName
from Products inner join Categories
on Products.CategoryID=Categories.CategoryID
where Products.UnitPrice>10

select * from Products p inner join [Order Details] od
on p.ProductID = od.ProductID

select * from Products p left join [Order Details] od ----left solda olup sağda olmayanları da  getir
on p.ProductID = od.ProductID


select *from  Customers c inner join  Orders o 
on  c.CustomerID=o.CustomerID

select *from  Customers c left join  Orders o 
on  c.CustomerID=o.CustomerID

select *from  Customers c left join  Orders o 
on  c.CustomerID=o.CustomerID
where o.CustomerID is null

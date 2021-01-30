-- ANSII standardı
--Büyük küçük harf duyarsız her türlü yazılabilir
--Select sorgu demek kısa çizgiler yorumsatırı için
Select ContactName Adi,CompanyName SirketAdi,City Sehir from Customers

Select * from Customers where City = 'London'

select * from Products where CategoryID = 1 or CategoryID = 3

select * from Products where CategoryID = 1 and UnitPrice >=10

select * from Products order by UnitPrice asc --asc -> ascending (artan) desc -> descending (azalan (düşen)) sırala 

select COUNT(*) Adet from Products where CategoryID = 2

select CategoryID, COUNT(*) from Products where UnitPrice >20 group by CategoryID having COUNT(*) <10 -- her bir grubun sayısını hesaplıyor

-- inner join sadece eşleşen kayıtlarda(tablolarda) kullanılır 
select Products.ProductID,Products.ProductName,Products.UnitPrice, Categories.CategoryName
from Products inner join Categories-- birleştir, bir araya getirir
on Products.CategoryID = Categories.CategoryID-- bu şartlar sağlandığında 
where Products.UnitPrice>10 -- fiyatı 10 dan büyük olanlar için bunları yap 

--left join (yazıma göre) solda olup sağda olmayanları da getir demek
select * from Products p left join [Order Details] od
on p.ProductID = od.ProductID 

select * from Customers c left join Orders o
on c.CustomerID = o.CustomerID
where o.CustomerID is null -- sağda olmayanları gösterdik 

select * from Products p inner join [Order Details] od
on p.ProductID = od.ProductID 
inner join Orders o -- bir birleştirme daha yaptık 
on o.OrderID = od.OrderID
 


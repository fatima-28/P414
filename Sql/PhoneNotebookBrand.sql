
--Database Yaradin 
--Brands Adinda Table Yaradin 2 dene colum Id ve Name
--Notebooks Adinda Table Yaradin Id,Name, Price Columlari Olsun.
--Phones Adinda Table Yaradin Id, Name, Price Columlari Olsun. 
--Notebook ve Brand Arasinda Mentiqe Uygun Relation Qurun.
--Phones ve Brand Arasinda Mentiqe Uygun Relation Qurun.
--Notebooks Adini, Brandin Adini BrandName kimi ve Qiymetini Cixardan Query.
--Brand Adinin Terkibinde s Olan Butun Notebooklari Cixardan Query.
--Qiymeti 1000 ve 3000 arasi ve ya 5000 den yuksek Notebooklari Cixardan query yazin
--Her Branda Aid Nece dene Notebook Varsa Brandin Adini Ve Yaninda Sayini Cixardan query yazin
--Phone ve Notebook da Id, Name, Price, ve BrandId Olan Butun Datalari Cixardan query yazin.
--Phone ve Notebook da Id, Name, Price, ve Brandin Adini BrandName kimi Olan Butun Datalarin Icinden Price 1000-den Boyuk Olan Datalari Cixardan  query yazin.  
-- Phones Tabelenden Data Cixardacaqsiniz 
-- Brandin Adi (BrandName kimi), Hemin Brandda Olan Telefonlarin Pricenin Cemi (TotalPrice Kimi) ve Hemin Branda Nece dene Telefon Varsa Sayini (ProductCount Kimi) Olan Datalari Cixardan Query



create database BrandsDb
use BrandsDb

create table Brands(
Id int primary key identity,
[Name] nvarchar(60) not null
);

create table Notebooks(
Id int primary key identity,
[Name] nvarchar(60) not null,
[Price] float ,
BrandsId int foreign key references Brands(Id)
);
create table Phones(
Id int primary key identity,
[Name] nvarchar(60) not null,
[Price] float ,
BrandsId int foreign key references Brands(Id)
);
insert into Notebooks([Name],[Price],[BrandsId])
values ('Linuxnew A70',5700,2)
insert into Phones([Name],[Price],[BrandsId])
values ('Iphone  14',700,1)
insert into Brands([Name])
values ('Apple'),('Samsung')

--Notebooks Adini, Brandin Adini BrandName kimi ve Qiymetini Cixardan Query.

Select Notebooks.[Name] as Notebook ,Notebooks.Price ,Brands.[Name] as BrandName from Notebooks
join Brands on 
Notebooks.BrandsId=Brands.Id

--Brand Adinin Terkibinde s Olan Butun Notebooklari Cixardan Query.
Select Notebooks.[Name] as Notebook ,Notebooks.Price ,Brands.[Name] as BrandName from Notebooks
join Brands on 
Notebooks.BrandsId=Brands.Id
where Brands.Name like '%s%'

--Qiymeti 1000 ve 3000 arasi ve ya 5000 den yuksek Notebooklari Cixardan query yazin

Select *  from Notebooks
where Notebooks.Price Between 1000 and 3000 or Notebooks.Price>5000

--Her Branda Aid Nece dene Notebook Varsa Brandin Adini Ve Yaninda Sayini Cixardan query yazin
Select Brands.[Name] as BrandName,Count(Notebooks.Id) as 'Count' from Notebooks
join Brands on 
Notebooks.BrandsId=Brands.Id
group by Brands.[Name]

--Phone ve Notebook da Id, Name, Price, ve BrandId Olan Butun Datalari Cixardan query yazin.
Select Notebooks.Id as ProductId ,Notebooks.[Name] as ProductName ,Notebooks.Price  ,Brands.[Name] as BrandName from Notebooks
join Brands on 
Notebooks.BrandsId=Brands.Id
UNION ALL
Select Phones.Id as ProductId ,Phones.[Name] as ProductName ,Phones.Price  ,Brands.[Name] as BrandName from Phones
join Brands on 
Phones.BrandsId=Brands.Id


--Phone ve Notebook da Id, Name, Price, ve Brandin Adini BrandName kimi Olan Butun Datalarin Icinden Price 1000-den Boyuk Olan Datalari Cixardan  query yazin.  

Select Notebooks.Id as ProductId ,Notebooks.[Name] as ProductName ,Notebooks.Price  ,Brands.[Name] as BrandName from Notebooks
join Brands on 
Notebooks.BrandsId=Brands.Id
where Notebooks.Price>1000
UNION ALL
Select Phones.Id as ProductId ,Phones.[Name] as ProductName ,Phones.Price  ,Brands.[Name] as BrandName from Phones
join Brands on 
Phones.BrandsId=Brands.Id
where Phones.Price>1000
-- Phones Tabelenden Data Cixardacaqsiniz ,Brandin Adi (BrandName kimi), Hemin Brandda Olan Telefonlarin Pricenin Cemi (TotalPrice Kimi) ve Hemin Branda Nece dene Telefon Varsa Sayini (ProductCount Kimi) Olan Datalari Cixardan Query

Select Brands.[Name] as BrandName,SUM(Phones.Price) as TotalPrice,Count(Phones.Id) as ProductCount from Phones
join Brands on 
Phones.BrandsId=Brands.Id
GROUP BY Brands.[Name]








create database Project
use project

--Position,employee,filial,product tableleri
--position id,name
--emp id,name,userCode,Saalary,age
--filial id,region
--product id,name,selldate,sellprice,purchasePrice
--Uygun tableler arasinda duzgun relationlar qurun ve tasklari hell edin
  --iscilerin sayi
  --iscileri yasa gore sirala
  --iscileri maasa gore sirala(ters sira ile)
  --satis tarixine gore sirala
  --son 2 ay erzinde satilan mehsullari gosterin



create table Position(
[id] int primary key identity,
[name] nvarchar(50),
[FilialId] int foreign key references Filial([Id])
)

insert into Position([Name],[FilialId])
values('developer',3),
('desinger',1),
('data-analyst',1),
('sql-developer',3)
create table Employee(
[id] int primary key identity,
[name] nvarchar(50),
[userCode] nvarchar(50),
[Adress] nvarchar(50),
[Salary] float,
[Age] int,
[PositionId] int foreign key references Position([Id])

)
insert into Employee([Name],[userCode],[Adress],[Salary],[Age],[PositionId])
values('Musa','A1','Elmler',2500,19,1),
('Nana','A2','28 may',1700,25,3),
('Gultac','A6','Nesimi',700,19,2),
('Murad','A08','Elmler',500,19,2)


create table Filial(
[id] int primary key identity,
[Region] nvarchar(50)

)
insert into Filial([Region])
values('Elmler'),
('Azadliq')


create table Product(
[id] int primary key identity,
[name] nvarchar(100),
[purchasePrice] float not null,
[sellPrice] float not null,
[sellDate] date
)
insert into Product([name],[purchasePrice],[sellPrice],[sellDate])
values('Macbook13 Pro',100,800,'09-03-2023'),
('Phone16',1200,800,'12-03-2023'),
('Phone3',1200,1500,'12-04-2022'),
('Phone',1200,1500,'12-03-2022'),
('Laptop',1200,1500,'12-10-2022'),
('Iphone',4500,5500,'11-10-2020'),
('Samsung',200,500,'09-10-2021'),
('Android',160,1500,'12-10-2002')
create table ProductFilial(
[id] int primary key identity,
[PoroductId] int foreign key references Product([Id]),
FilialId int foreign key references Filial([Id])
)
insert into ProductFilial([PoroductId],FilialId)
values(1,2),
(2,3),
(1,3),
(3,2)

select * from employee
select * from filial
select * from position
select * from ProductFilial
select * from Product




--iscilerin sayi,
select Count(*) as 'Count' from Employee
--iscileri yasa gore sirala,
select*  from Employee order by Age desc
--iscileri maasa gore sirala,
select*  from Employee order by Salary asc
--satis tarixine gore sirala,
select*  from Product order by [Selldate] desc
--son 2 ay erzinde satilan mehsullari gosterin
SELECT *FROM Product
WHERE Selldate >= DATEADD(M, -2, GETDATE())


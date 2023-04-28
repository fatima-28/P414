

--Academy databazası yaradın
--Groups(İd,Name) ve Students(İd,Name,Surname,Groupİd) table-ları yaradın(one-to-many), təkrar qrup adı əlavə etmək olmasin.
--Students table-na Grade (int) kalonunu əlavə etmək ve icerisini her bir student ucun doldurmaq(sonradan add edin,tableni silib tezesini yaratmayin!)
--Groups table-na ve Student tablesine datalar elave etmek
--P414 qrupuna aid olan tələbələrin siyahisini gosterin
--Her qrupda neçə tələbə olduğunu göstərən listi çıxarmaq
--View yaratmaq - student adını, qrupun adını-qrup kimi , stdent soyadını, tələbənin balını göstərməlidir
--Procedure yazin,bu procedure, göndərilən baldan yüksək bal alan studentlərin siyahısını göstərməlidir
--Funksiya yazin ,bu funksiya göndərilən qrup adina uyğun neçə tələbə olduğunu göstərməlidi 
Create database Academy
use Academy


create table Grup(
Id int primary key identity,
[Name] nvarchar(50) unique)



create table Students(
Id int primary key identity,
[Name] nvarchar(50) ,
Surname nvarchar(50),
GroupId int foreign key references Grup(Id)
)

insert into Grup([Name])
values('Bp201'),
('P414'),('P155')

insert into Students([Name],Surname,GroupId)
values ('Leman','Hasimova',1),
('Vusal','Zeynalov',1),
('Fatima ','Bayramova',2),
('Nicat','Novruzzade',2),
('Nana','Aslanzade',2),
('Musa','Afandiyev',3)

--Students table-na Grade (int) kalonunu əlavə etmək ve icerisini her bir student ucun doldurmaq(sonradan add edin,tableni silib tezesini yaratmayin!)

ALTER TABLE Students
ADD Grade int;

UPDATE Students
SET Grade = 99
WHERE Students.Id=7;


--P414 qrupuna aid olan tələbələrin siyahisini gosterin
select * from Students
join Grup on
Students.GroupId=Grup.Id
where Grup.Name='P414'

--Her qrupda neçə tələbə olduğunu göstərən listi çıxarmaq
select Grup.[Name] as Grup ,Count(Students.Id) as 'count' from Students
join Grup on
Students.GroupId=Grup.Id
group by Grup.[Name]

--View yaratmaq - student adını, qrupun adını-qrup kimi , stdent soyadını, tələbənin balını göstərməlidir
create view vw_StudentInfos as
Select Students.Name as name,Students.Surname as surname,Grup.Name as Grup,Students.Grade from Students
inner join Grup
on Students.GroupId=Grup.Id


select * from vw_StudentInfos

--Procedure yazin,bu procedure, göndərilən baldan yüksək bal alan studentlərin siyahısını göstərməlidir



CREATE PROCEDURE GetStudentList
@Grade int 
AS
BEGIN
   select * from Students
   where Students.Grade>@Grade
END

exec GetStudentList @Grade=80
--Funksiya yazin ,bu funksiya göndərilən qrup adina uyğun neçə tələbə olduğunu göstərməlidi 
 
CREATE FUNCTION GetStuCount( @groupName nvarchar(50))
RETURNS int AS  
BEGIN  
RETURN 
(Select Count(Students.Id) as Say from Students
join
Grup on Students.GroupId=Grup.Id 
where  Grup.[Name]=@groupName
group By Grup.[Name])
END   

SELECT [dbo].GetStuCount('P414') as 'Count'
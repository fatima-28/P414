-- Liberary database-i qurursunuz
--Books (Id, Name, PageCount)
--Books-un Name columu minimum 2 simvol maksimum 100 simvol deyer ala bileceyi serti olsun.
--Books-un PageCount columu minimum 10 deyerini ala bileceyi serti olsun.
--Authors (Id, Name, Surname)
--Books ve Authors table-larinizin mentiqi uygun realtionunu qurun.
--Id, Name, PageCount ve AuthorFullName columnlarinin valuelarini qaytaran bir view yaradin

--Gonderilmis axtaris valuesine gore hemin axtaris deyeri name ve ya authorun FullNamelerinde olan Book-lari Id, 
--Name, PageCount, AuthorFullName columnlari seklinde gostern procedure yazin

--Authors tableinin insert, update  ucun  procedure yaradin

--Authors-lari id, FullName,BooksCount ,maxpageCount seklinde qaytaran view yaradin.Id-author 
--id-si, FullName - Name ve Surname birlesmesi, BooksCount - Hemin authorun elaqeli oldugu kitablarin sayi,
--MaxPageCount - hemin authorun elaqeli oldugu kitablarin icerisindeki max pagecount deyeri
	

create database LibraryDb2
use LibraryDb2

create table Books(
[Id] int primary key identity(1,1),
[Name] nvarchar(100) check(len([Name]) between 2 and 100),
[PageCount] int check([PageCount]>10)
);

insert into Books([Name],[PageCount])
values('The Sicilian',416),
      ('The Godfather',433),
      ('1984',328),
      ('Homage to Catalonia',328)


create table Authors(
[Id] int primary key identity(1,1),
[Name] nvarchar(50),
[Surname] nvarchar (50)

);

insert into Authors([Name],[Surname])
values('Mario','Puzo'),
       ('George','Orwell')




create table BookAuthors(
[Id] int primary key identity(1,1),
[AuthorId] int foreign key references Authors([Id]),
[BookId] int foreign key references Books([Id])
);

insert into BookAuthors([BookId],[AuthorId])
values(1,2),
       (2,2),
	   (3,1)


--Id, Name, PageCount ve AuthorFullName columnlarinin valuelarini qaytaran bir view yaradin
CREATE VIEW vw_autBook AS
SELECT Books.[Id],Books.[Name],Books.[PageCount],concat(Authors.[Name],[Surname]) as 'Fullname'
FROM Books
 JOIN 
BookAuthors ON 
Books.[Id]=BookAuthors.[BookId]
 JOIN 
Authors ON 
BookAuthors.[AuthorId]=Authors.[Id]
 

 --Gonderilmis axtaris valuesine gore hemin axtaris deyeri name ve ya authorun FullNamelerinde olan Book-lari Id, 
--Name, PageCount, AuthorFullName columnlari seklinde gostern procedure yazin
 CREATE PROCEDURE GetAuthorsAndBooks
   @value nvarchar(50)              
     AS  
   BEGIN  
     SELECT Books.[Id],Books.[Name],Books.[PageCount],concat(Authors.[Name],[Surname]) as 'Fullname'
    FROM Books
    JOIN 
    BookAuthors ON 
    Books.[Id]=BookAuthors.[BookId]
    JOIN 
    Authors ON 
    BookAuthors.[AuthorId]=Authors.[Id]
    where Books.[Name]=@value or concat(Authors.[Name],[Surname])=@value
    END  
    EXEC GetAuthorsAndBooks 'NicatOrwell';  

  
  --Authors tableinin insert  ucun  procedure yaradin
   CREATE PROCEDURE AddAuthor
                @AutName nvarchar(50),  
				  @AutSurname nvarchar(50)
              
         AS  
          BEGIN  
        insert into Authors([Name],[Surname]) 
	    values(@AutName,@AutSurname)
       END  



      EXEC AddAuthor 'Leman','Hesimova'; 



   --Authors tableinin update  ucun  procedure yaradin
   CREATE PROCEDURE AddColumnToAuthor3
     @AutName nvarchar(50), 
	 @Email nvarchar(50),
	 @AutId int
              
     AS  
     BEGIN  
   
 UPDATE Authors
SET [Name] = @AutName,
[Email]=@Email
where [Id]=@AutId

   END  

    EXEC AddColumnToAuthor3 'Fatima','fatima@mail.ru',4; 
   

	--Authors-lari id, FullName,BooksCount ,maxpageCount seklinde qaytaran view yaradin.Id-author 
	--id-si, FullName - Name ve Surname birlesmesi, BooksCount - Hemin authorun elaqeli oldugu kitablarin sayi,
	--MaxPageCount - hemin authorun elaqeli oldugu kitablarin icerisindeki max pagecount deyeri
	
	create view vw_authorsBooksInformations 
	AS
    SELECT  Authors.[Id],concat(Authors.[Name],[Surname]) as 'Full Name',
	COUNT(Books.[Id]) AS 'Books Count',MAX(Books.[PageCount]) AS 'Max Page Count'
   FROM Authors 
   JOIN 
   BookAuthors  ON Authors.[Id] = BookAuthors.[AuthorId]
   JOIN
   Books  on BookAuthors.[BookId]=Books.[Id]
   GROUP BY concat(Authors.[Name],[Surname]) ,Authors.[Id]


	select * from Books
	select * from Authors
	select * from BookAuthors
	select * from vw_autBook
	select * from vw_authorsBooksInformations




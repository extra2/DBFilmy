-- CREATE TABLE CLIENT
create table Client (ID_client int not null primary key identity(1,1), city varchar(100), street varchar(100), post_number varchar(6), house_number int, flat_number int, Name varchar(100), Surname varchar(100), PESEL varchar(100))
-- CREATE TABLE MOVIE
create table Movie(ID_Movie int not null primary key identity(1,1), Title varchar(100), Director varchar(100), Relase_Date datetime, Category varchar(100), Year_Limitation int, Penalty int)
-- CREATE TABLE MOVIE_INSTANCE
create table Movie_Instance ( ID_Movie_Instance int not null primary key identity(1,1), FK_ID_Movie int, constraint FK_ID_Movie Foreign key (FK_ID_Movie) references Movie(ID_Movie), Is_Rented bit)
-- CREATE TABLE TRANSACTIONS
create table Transactions (ID_Transactions int not null primary key identity(1,1), FK_ID_Movie_Instance int, FK_ID_Clients int, constraint FK_ID_Movie_Instance foreign key (FK_ID_Movie_Instance) references Movie_instance(ID_Movie_Instance), constraint FK_ID_Clients foreign key (FK_ID_Clients) references Client(ID_Client), rental_date datetime)
-- FUNCTION: SELECT TOP 5 RENTED MOVIES
CREATE FUNCTION Top5RentedMovies()
RETURNS TABLE  
AS  
RETURN  
    SELECT distinct Top(5) dbo.Movie.Title, dbo.Movie.ID_Movie, count(dbo.Transactions.FK_ID_Movie_Instance)
FROM            dbo.Movie_Instance INNER JOIN
                         dbo.Movie ON dbo.Movie_Instance.FK_ID_Movie = dbo.Movie.ID_Movie INNER JOIN
                         dbo.Transactions ON dbo.Movie_Instance.ID_Movie_Instance = dbo.Transactions.FK_ID_Movie_Instance 
WHERE dbo.Transactions.FK_ID_Movie_Instance
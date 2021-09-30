create database MovieRating
use MovieRating

--Creating table movie
create table Movie(mID int primary key,
					title varchar(100),
					YearRelease int check(YearRelease>1900),
					director varchar(100))


--Creating table Reviewer
create table reviewer(rID int primary key,
						name varchar(100) not null)

--Creating table Rating
create table Rating(rID int references reviewer(rID),
					mID int references Movie(mID),
					stars int check(stars in (1,2,3,4,5)) not null,
					ratingDate date check(ratingDate>='2000-01-01'))


--Inserting data in table Movie
insert into Movie values(1,'First Movie',1901,'First Director')
insert into Movie values(2,'Second Movie',2000,'Second Director')
insert into Movie values(3,'Third Movie',2005,'Third Director')
insert into Movie values(4,'Fourth Movie',2006,'Fourth Director')
insert into Movie values(5,'Fifth Movie',2010,'Fifth Director')

--Constraints check for table Movie
insert into Movie values(1,'First Movie',1901,'First Director')
insert into Movie values(6,'First Movie',1801,'First Director')

--Insert into table Reviewer
insert into reviewer values(1,'First Reviewer')
insert into reviewer values(2,'Second Reviewer')

--Constraint check for table reviewer
insert into reviewer values(1,'First Reviewer')
insert into reviewer (rID) values(1)

--Insert into table Rating
insert into Rating values(1,1,4,'2001-04-01')
insert into Rating values(2,3,3,'2002-05-08')
insert into Rating values(1,4,2,'2003-06-07')

--Constraint check for table Rating
insert into Rating values(1,1,6,'2001-04-01')
insert into Rating values(1,1,4,'1998-04-01')
insert into Rating (rID,mID,ratingDate) values(1,1,'2001-04-01')

select * from Rating
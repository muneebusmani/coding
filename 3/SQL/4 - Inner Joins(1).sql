
create database joins;
use joins;
create table employeetb1(
    [emp id] int identity(1,1) unique not null,
    [name] varchar(255) not null,
    [email] varchar(255) not null,
    [designation] varchar(255) not null
);

drop table employeetb1;
SELECT * FROM [employeetb1];

CREATE PROCEDURE insertemptb1 @name varchar(255),@email varchar(255),@designation varchar(255)
AS
begin
INSERT INTO employeetb1 (name,email,designation) values(@name,@email,@designation)
END

insertemptb1 "faizan",'faizan@gmail.com','faculty';

insertemptb1 "ali",'ali@gmail.com','it';

insertemptb1 "yasir",'yasir@gmail.com','manager';

insertemptb1 "ali",'ali@gmail.com','faculty';

insertemptb1 "usman",'usman@gmail.com','computer operator';

insertemptb1 "waqar",'waqar@gmail.com','computer operator';

insertemptb1 "wasay",'wasay@gmail.com','computer operator';

insertemptb1 "atif",'atif@gmail.com'  ,'computer operator';

insertemptb1 "imran",'imran@gmail.com','faculty';








CREATE TABLE department(
    [dept id] int  unique not null,
    [dept name] varchar(255) not null,
    [dept salary] int not null,
    [emp id] int unique not null
)
drop procedure insertdept1

CREATE PROCEDURE insertdept1  @id int,@name varchar(255),@salary int,@empid int
AS
begin
INSERT INTO [department] values (@id,@name,@salary,@empid)
END

insertdept1 111,'adminstration',50000,1;
insertdept1 112,'it',25000,2;
insertdept1 113,'academic',75000,3;
insertdept1 114,'hr',85000,4;
insertdept1 115,'quality assurance',35000,5;
insertdept1 116,'hr',85000,6;
insertdept1 117,'it',85000,7;
insertdept1 118,'adminstration',50000,8;
insertdept1 119,'hr',50000,9;

select * FROM  [employeetb1] as [employee]
inner join [department] as [dept]
on [employee].[emp id]= [dept].[emp id]
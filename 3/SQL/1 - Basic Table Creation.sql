/* Database Creation */
create database management;

/*  Using Database To perform query */
use management;

/* Creating Table inside it */
create table employees(
    EmployeeId int primary key,
    EmployeeName varchar(255) not null,
    EmployeeRole varchar(255) not null,
    EmployeeDepartment varchar(255) not null
);

/* Inserting Data */
insert into employees values
(1,'Owais ur Rehman',   'Junior  Full stack Developer'  ,'Development'),
(2,'Ahmed Khan',        'Senior  Full stack Developer'  ,'Development'),
(3,'Jawwad',            'Android Developer'             ,'Development'),
(4,'Mubeen Ansari',     'IOS Developer'                 ,'Development'),
(5,'Sami ullah',        'Devops Engineer'               ,'Development Operations');


/* Displaying data */
select * from employees;

/* Emptying The Table */
TRUNCATE  TABLE employees;
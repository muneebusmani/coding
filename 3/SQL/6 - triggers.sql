--sample trigger to detect the insertion of rows
CREATE TRIGGER inserted 
on employees after INSERT
as 
begin
select * from employees
end

--trigger for deletion backup
CREATE TRIGGER deletion 
on employees 
after DELETE
as
BEGIN
INSERT INTO [employeesBackup] select * from deleted
end


--trigger for prevention of row insertion
create trigger insertPrevention
on employees
INSTEAD OF INSERT
AS BEGIN
PRINT 'Not eligible for inserting queries'
END

--employee backup table for deleting rows
create table employeesBackup(
    EmployeeId int primary key,
    EmployeeName varchar(255) not null,
    EmployeeRole varchar(255) not null,
    EmployeeDepartment varchar(255) not null
)
rmEmployee 6;
regEmployee 'Lmao','Junior Full stack Developer','Development';

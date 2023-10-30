--Procedures Are just functions like any programming
use management;


-- Stored Procedure Creation Starts

    /* Display Data start */

        -- See Employee By Id and Name starts

            CREATE PROCEDURE seeEmployee
            @id int,
            @name varchar(255)
            as
            begin
                select * from employees where EmployeeId=@id and EmployeeName=@name; 
            end;

        -- See Employee By Id and Name Ends


        -- See Employee By Id Starts

            CREATE PROCEDURE seeEmployeeById
            @id int
            as
            begin
                select * from employees where EmployeeId=@id; 
            end;

        -- See Employee By Id Ends

        -- See Employee As Admin Starts

            CREATE PROCEDURE seeEmployeeAsAdmin
            as
            begin
                select * from employees; 
            end;

        -- See Employee As Admin Starts

     /* Display Data Ends */


    /* Delete Data start */

        -- By Id(default) 
        CREATE PROCEDURE rmEmployee
        @id int
        as
        begin
            DELETE from employees where EmployeeId=@id; 
        end;

        -- By Depart(i.e when you want to eliminate the people of this depart from company)
        CREATE PROCEDURE rmEmployeeByDepart
        @depart varchar(255)
        as
        begin
            DELETE from employees where EmployeeDepartment=@depart; 
        end;


        -- By role(i.e when you want to eliminate the people of this role from company)
        CREATE PROCEDURE rmEmployeeByRole
        @role varchar(255)
        as
        begin
            DELETE from employees where EmployeeRole=@role; 
        end;



    /* Delete Data end */




    /* Insert Data  Start */

        CREATE PROCEDURE regEmployee
        @name varchar(255),
        @role varchar(255),
        @depart varchar(255)
        as
        begin
            insert into employees (EmployeeName,EmployeeRole,EmployeeDepartment) values (@name,@role,@depart);
        end;

    /* Insert Data  End */




    /* Update Data Start */

        -- Update Name start
            CREATE PROCEDURE updateEmployeeName 
            @id int,
            @name varchar(255)
            as 
            begin
                update employees set EmployeeName=@name where EmployeeId=@id
            end;
        -- Update Name end



        -- Update role start
            CREATE PROCEDURE updateEmployeeRole 
            @id int,
            @role varchar(255)
            as 
            begin
                update employees set EmployeeRole=@role where EmployeeId=@id
            end;
        -- Update role end




        -- Update depart start
            CREATE PROCEDURE updateEmployeeDepartment 
            @id int,
            @depart varchar(255)
            as 
            begin
                update employees set EmployeeDepartment =@depart where EmployeeId=@id
            end;
        -- Update depart end

    /* Update Data End */



    
    /* View User Defined Stored Procedures*/
    CREATE PROCEDURE availableSp
    as
    begin
    SELECT name FROM sys.objects WHERE type = 'P' ORDER BY name;
    end


-- Stored Procedure Creation Ends
drop Procedure rmEmployeeByRole;


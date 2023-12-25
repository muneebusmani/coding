--Tesing All stored Procedures
use management;

/* View Available Stored Procedures */
availableSp;


/* Register Employees starts */

exec regEmployee 'Owais ur Rehman','Junior  Full stack Developer'  ,'Development';
exec regEmployee 'Ahmed Khan',        'Senior  Full stack Developer'  ,'Development';
exec regEmployee 'Jawwad',            'Android Developer'             ,'Development';
exec regEmployee 'Mubeen Ansari',     'IOS Developer'                 ,'Development';
exec regEmployee 'Sami ullah',        'Devops Engineer'               ,'Development Operations';


/* Register Employees ends */


/* View all Employees Details Starts */

    --See Employee Credentials by Employee Id and Name
    seeEmployee 1,'muneeb';


    --See Employee Credentials by Employee Id
    seeEmployeeById 2;

    --See Employee Credentials as Admin
    seeEmployeeAsAdmin;

/* View all Employees Details Ends */


/* Employee Remove starts  */

    --default
    rmEmployee 11;

    --by depart
    rmEmployeeByDepart 'Development';

    rmEmployeeByDepart 'Development operations';


    --by Role
    rmEmployeeByRole 'IOS Developer';

    rmEmployeeByRole 'Junior  Full stack Developer';


/* Employee Remove Ends */


/* Update Employee Credentials Starts */

    --This Stored Procedure only works by id

        -- Update Name
            updateEmployeeName 13 , 'Lakshmi' --put id and updated name

        -- Update Role
            updateEmployeeRole 13 , 'Devops' --put id and updated role
            updateEmployeeRole 13 , 'Version Control' --put id and updated role

        -- Updated Depart
            updateEmployeeDepartment 13,'Devops Department'

/* Update Employee Credentials Ends */



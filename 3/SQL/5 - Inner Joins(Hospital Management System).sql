--bharway practice krlio iski, dekhne se ni smjh ana





CREATE database [The Indus Hospital];

-- Doing this is necessary to work inside our desired database, because this isnt phpmyadmin, we have to manually select the database we wanna work on
use [The Indus Hospital];

/*syntax for identity constraint:
 identity(starting_value,increment_counter)
 
 
 square brakets([ ]) in ms sql server works the same as backticks(``) mysql
 used when you want to use spaces inside procedure/database/table/column names

procedure/database/table/column and other things like these are known as database objects
thats why we encounter error(unknown database object [your procedure/database/table/column] on line 2 etc)

 */


-- room table Creation
CREATE TABLE [room](
    [room id] int identity(300,1)  primary key,
    [room type] varchar(255) NOT NULL
)

-- doctor table Creation
CREATE TABLE [doctor](
    id int identity(1,1)  primary key,
    name varchar(255) not null,
    email varchar(255),
    contact varchar(255) not null,
    speciality varchar(255) not null
)

-- patients table with foreign key of corresponding doctor's id and room id which references to corresponding room id in room table and doctor id in doctor table 
CREATE TABLE [patients](
    id int identity(1,1) primary key,
    name varchar(255)  not null,
    number varchar(255) not null,
    disease varchar(255) not null,
    [room id] int,
    [doctor id] int,
    FOREIGN KEY([room id]) REFERENCES room([room id]),
    FOREIGN KEY([doctor id]) REFERENCES doctor(id)
)


-- Data Insertion
INSERT INTO doctor (name,email,contact,speciality) values
('hasnain'          ,'hasnain@gmail.com'        ,'03123456789','cardiologist'),
('rahim'            ,'rahim@gmail.com'          ,'03123456789','dentist'),
('shoaib'           ,'shoaib@gmail.com'         ,'03123456789','surgeon'),
('Achun Pathan'     ,'pathan@gmail.com'         ,'03123456789','radiologist'),
('Anus baloch'      ,'baloch@gmail.com'         ,'03123456789','urologist'),
('Sohail Jawwad'    ,'sohail@gmail.com'         ,'03123456789','cardiologist'),
('Ahmed Shehzad'    ,'ahmed@gmail.com'          ,'03123456789','neuro surgeon');


-- Data Insertion
insert into room ([room type]) values ('private ward'),
('private ward'),
('private ward'),
('private ward'),
('private ward'),
('private ward'),
('private ward'),
('private ward'),
('private ward'),
('private ward'),
('public ward'),
('public ward'),
('public ward'),
('public ward'),
('public ward'),
('public ward'),
('public ward'),
('public ward'),
('public ward'),
('public ward'),
('public ward'),
('public ward'),
('public ward'),
('public ward'),
('public ward'),
('public ward'),
('public ward'),
('public ward'),
('public ward');

-- Patients registration
insert into patients (name,number,disease,[room id],[doctor id]) values
('Shahmeer Khan'        ,03123456789,'heart attack' ,301,1),
('Ibad Alam'            ,03123456789,'tooth decay'  ,302,2),
('Seema Jamshed'        ,03123456789,'delievery'    ,303,3),
('Rohaan Shahid'        ,03123456789,'xray'         ,304,4);



-- Displaying Patients details while joining them with room and doctors table where conditions match
SELECT * FROM patients 
inner join room     on  [patients].[room id]    = [room].[room id]
inner join doctor   on  [patients].[doctor id]  = [doctor].[id]


/*
This above join query will First fetch the patients table, then it will do an innner join i.e joining two tables with common data evaluation,
it will basically compare values which we define after on keyword and based on that comparison it will fetch the rows with this,
then it will place and inner join with room table and compare the foreign and primary keys and then fetch joined tables output
*/








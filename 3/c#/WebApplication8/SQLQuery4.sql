use crud_db
create table crud_tb(
[ID] int PRIMARY KEY,
[First Name] nvarchar(255) NOT NULL,
[Last  Name] nvarchar(255) NOT NULL,
Gender nvarchar(255) NOT NULL
);
INSERT INTO crud_tb VALUES
(1,'Muneeb','Usmani','Male'),
(2,'Shoaib','Amaan','Male'),
(3,'Muhammad','Ali','Male'),
(4,'Shiza','Khan','Female');
select * from crud_tb;
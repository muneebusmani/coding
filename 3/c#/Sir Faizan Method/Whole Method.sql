create database Sir_Faizan_Method;
use Sir_Faizan_Method;

CREATE TABLE Sir_Faizan_Method_Table(
[Id] INT IDENTITY(1,1) PRIMARY KEY,
[Name] NVARCHAR(max),
[Age] NVARCHAR(max),
[Height] NVARCHAR(max)
);

INSERT INTO Sir_Faizan_Method_Table([Name],[Age],[Height]) 
VALUES 
('Muneeb','17','6 11'),
('Shoaib','16','5 8'),
('Shiza','16','5 2'),
('Shahbaz','19','5 6'),
('Ali','17','5 4');

select * from Sir_Faizan_Method_Table;

# SELECT students.name AS student ,groups.name AS [group] FROM students JOIN groups ON group_id = groups.id;
Полное решение:

Запрос №1:

CREATE DATABASE GroupsStudents;

Запрос №2:

CREATE TABLE groups(

id INT NOT NULL PRIMARY KEY IDENTITY,

[name] VARCHAR(20) NOT NULL

);

INSERT INTO groups 

VALUES 

('Программирование'),

 ('Экономика'),
 
 ('Логистика');
 
CREATE TABLE students(

id INT NOT NULL PRIMARY KEY IDENTITY,

[name] VARCHAR(20) NOT NULL,

group_id INT

);

INSERT INTO students 

VALUES 

('Владимир',3),

 ('Татьяна', 1),
 
 ('Александр', 2);
 
 SELECT students.name AS student ,groups.name AS [group] FROM students JOIN groups ON group_id = groups.id;

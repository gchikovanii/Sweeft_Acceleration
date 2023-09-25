﻿create table Teacher 
(
	Teacher_Id int Identity PRIMARY KEY,
	FirstName varchar(50),
	LastName varchar(50),
	Gender varchar(50),
	Subjects varchar(50)
)

create table Pupil 
(
	Pupil_Id int Identity PRIMARY KEY,
	FirstName varchar(50),
	LastName varchar(50),
	Gender varchar(50),
	Grade int
)

create table Teacher_Pupil
(
	Teacher_Id int,
	Pupil_Id int,
	CONSTRAINT teacher_pupil_pk PRIMARY KEY (Teacher_Id, Pupil_Id),
	CONSTRAINT FK_Teacher FOREIGN KEY (Teacher_Id) References Teacher (Teacher_ID),
	CONSTRAINT FK_Pupil FOREIGN KEY (Pupil_Id) References Pupil (Pupil_ID)
)


Select Distinct(t.Teacher_Id), t.FirstName,t.LastName, t.Subjects,t.Gender from Teacher t
join Teacher_Pupil tp on t.Teacher_Id = tp.Teacher_Id 
join Pupil as p on p.Pupil_Id = tp.Pupil_Id
where p.FirstName = N'გიორგი'
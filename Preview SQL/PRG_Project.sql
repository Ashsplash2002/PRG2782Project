USE master
GO


CREATE DATABASE [PRG2782Project]
GO


USE [PRG2782Project]
GO

USE PRG2782Project
GO

-- This creates the modules table

CREATE TABLE modules (
  modCode bigint NOT NULL IDENTITY(1, 1),
  modName varchar(50) NOT NULL,
  modDesc varchar(100) NOT NULL,
  link varchar(50) NOT NULL
)
GO


-- This creates the student table

CREATE TABLE students (
  stdNum bigint NOT NULL IDENTITY(1, 1),
  stdName varchar(50) NOT NULL,
  stdSurname varchar(50) NOT NULL,
  stdImage varbinary(100) NOT NULL,
  dateObirth date NOT NULL,
  gender varchar(50) NOT NULL,
  phoneNum varchar(50) NOT NULL,
  address varchar(50) NOT NULL,
  moduleCode bigint NOT NULL
)
GO

-- This adds indexing for modules

ALTER TABLE modules
  ADD PRIMARY KEY (modCode)
GO


-- This adds indexing for students

ALTER TABLE students
  ADD PRIMARY KEY (stdNum)
GO







-- This is for the relationship between modules and student tables

ALTER TABLE students
  ADD CONSTRAINT students_ibfk_1 FOREIGN KEY (moduleCode) REFERENCES modules (modCode)
GO


-- Adds dummy data for modules table

INSERT INTO modules(modName, modDesc, link)
VALUES ('IT','This module will be about general IT information','https://this.isFake.com')
GO


-- Adds dummy data for students table

INSERT INTO students(stdName, stdSurname, stdImage, dateObirth, gender, phoneNum, address, moduleCode) 
VALUES ('Bob','Builder',CAST('test' AS VARBINARY(MAX)),'2022-10-17','M','0811321234','1 Snake Drive','1')
GO

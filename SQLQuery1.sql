USE master
GO


CREATE DATABASE [PRG2782Project]
GO


USE [PRG2782Project]
GO

-- This creates the modules table

CREATE TABLE modules (
  modCode varchar(7) NOT NULL,
  modName varchar(50) NOT NULL,
  modDesc varchar(100) NOT NULL,
  link varchar(50) NOT NULL
)
GO


-- This creates the student table

CREATE TABLE students (
  stdNum bigint NOT NULL,
  stdName varchar(50) NOT NULL,
  stdSurname varchar(50) NOT NULL,
  stdImage varchar(100) NOT NULL,
  gender varchar(50) NOT NULL,
  phoneNum varchar(50) NOT NULL,
  address varchar(50) NOT NULL,
  moduleCode varchar(7) NOT NULL,
  dateObirth date NOT NULL
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

INSERT INTO modules(modCode, modName, modDesc, link)
VALUES ('TEST272','IT','This module will be about general IT information','https://this.isFake.com')
GO


-- Adds dummy data for students table

INSERT INTO students(stdNum, stdName, stdSurname, stdImage, gender, phoneNum, address, moduleCode, dateObirth) 
VALUES ('123456','Bob','Builder','test.png','M','0811321234','1 Snake Drive','TEST272','2022-10-17')
GO
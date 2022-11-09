
-- This creates the modules table

CREATE TABLE modules (
  modCode bigint(50) NOT NULL,
  modName bigint(50) NOT NULL,
  modDesc varchar(100) NOT NULL,
  link varchar(50) NOT NULL
)


-- This creates the student table

CREATE TABLE students (
  stdNum bigint(50) NOT NULL,
  stdName varchar(50) NOT NULL,
  stdSurname varchar(50) NOT NULL,
  stdImage varbinary(100) NOT NULL,
  dateObirth date NOT NULL,
  gender varchar(50) NOT NULL,
  phoneNum varchar(50) NOT NULL,
  address varchar(50) NOT NULL,
  moduleCode bigint(50) NOT NULL
)



-- This adds indexing for modules

ALTER TABLE modules
  ADD PRIMARY KEY (modCode),
  ADD KEY link (link),
  ADD KEY modDesc (modDesc),
  ADD KEY modName (modName),
  ADD KEY id (modCode)



-- This adds indexing for students

ALTER TABLE students
  ADD PRIMARY KEY (stdNum),
  ADD KEY id (stdNum),
  ADD KEY stdName (stdName),
  ADD KEY stdSurname (stdSurname),
  ADD KEY stdImage (stdImage),
  ADD KEY dateObirth (dateObirth),
  ADD KEY gender (gender),
  ADD KEY phoneNum (phoneNum),
  ADD KEY address (address),
  ADD KEY moduleCode (moduleCode)



-- This adds auto increment for the primary key in modules table

ALTER TABLE modules
  MODIFY modCode bigint(50) NOT NULL AUTO_INCREMENT



-- This adds auto increment for the primary key in students table

ALTER TABLE students
  MODIFY stdNum bigint(50) NOT NULL AUTO_INCREMENT



-- This is for the relationship between modules and student tables

ALTER TABLE students
  ADD CONSTRAINT students_ibfk_1 FOREIGN KEY (moduleCode) REFERENCES modules (modCode)




-- Adds dummy data for modules table


INSERT INTO modules(modName, modDesc, link)
VALUES ('IT','This module will be about general IT information','https://this.isFake.com')



-- Adds dummy data for students table

INSERT INTO students(stdName, stdSurname, stdImage, dateObirth, gender, phoneNum, address, moduleCode) 
VALUES ('Bob','Builder','0x7DEGFAD89FDA13FJBGWPE35E','2022-10-17','M','0811321234','1 Snake Drive','1')


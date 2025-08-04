------created a database for the two tables called test--------
Create database test 
go 
use test
go
CREATE TABLE Departments (
   Code INTEGER PRIMARY KEY NOT NULL,
   Name varchar(50) NOT NULL ,
   Budget REAL NOT NULL 
 );

 Go

 CREATE TABLE Employees (
   SSN INTEGER PRIMARY KEY NOT NULL,
   Name varchar(50) NOT NULL ,
   LastName varchar(50) NOT NULL ,
   Department INTEGER NOT NULL , 
   CONSTRAINT fk_Departments_Code FOREIGN KEY(Department) 
   REFERENCES Departments(Code)
 );

Go

INSERT INTO Departments(Code,Name,Budget) VALUES(14,'IT',65000);
INSERT INTO Departments(Code,Name,Budget) VALUES(37,'Accounting',15000);
INSERT INTO Departments(Code,Name,Budget) VALUES(59,'Human Resources',240000);
INSERT INTO Departments(Code,Name,Budget) VALUES(77,'Research',55000);

INSERT INTO Employees(SSN,Name,LastName,Department) VALUES('123234877','Michael','Rogers',14);
INSERT INTO Employees(SSN,Name,LastName,Department) VALUES('152934485','Anand','Manikutty',14);
INSERT INTO Employees(SSN,Name,LastName,Department) VALUES('222364883','Carol','Smith',37);
INSERT INTO Employees(SSN,Name,LastName,Department) VALUES('326587417','Joe','Stevens',37);
INSERT INTO Employees(SSN,Name,LastName,Department) VALUES('332154719','Mary-Anne','Foster',14);
INSERT INTO Employees(SSN,Name,LastName,Department) VALUES('332569843','George','ODonnell',77);
INSERT INTO Employees(SSN,Name,LastName,Department) VALUES('546523478','John','Doe',59);
INSERT INTO Employees(SSN,Name,LastName,Department) VALUES('631231482','David','Smith',77);
INSERT INTO Employees(SSN,Name,LastName,Department) VALUES('654873219','Zacary','Efron',59);
INSERT INTO Employees(SSN,Name,LastName,Department) VALUES('745685214','Eric','Goldsmith',59);
INSERT INTO Employees(SSN,Name,LastName,Department) VALUES('845657245','Elizabeth','Doe',14);
INSERT INTO Employees(SSN,Name,LastName,Department) VALUES('845657246','Kumar','Swamy',14);

Go
--1-Select the last name of all employees.
SELECT LastName From Employees


-----------------------------------------------------------------------------------------------------------------------------------
--2-Select the last name of all employees, without duplicates.
SELECT DISTINCT LastName From Employees



-----------------------------------------------------------------------------------------------------------------------------------
--3-Select all the data of employees whose last name is "Smith".
SELECT * FROM Employees where LastName='Smith'

-----------------------------------------------------------------------------------------------------------------------------------
--4-Select all the data of employees whose last name is "Smith" or "Doe".
SELECT * FROM Employees where LastName='Smith' or LastName='Doe'


--or

SELECT * FROM Employees WHERE LastName IN ('Smith', 'Doe');
-----------------------------------------------------------------------------------------------------------------------------------
--5-Select all the data of employees that work in department 14.
SELECT * FROM Employees where Department = 14



-----------------------------------------------------------------------------------------------------------------------------------
--6-Select all the data of employees that work in department 37 or department 77.
SELECT * FROM Employees where Department IN (37,77)



-----------------------------------------------------------------------------------------------------------------------------------
--7-Select all the data of employees whose last name begins with an "S".
SELECT * FROM Employees WHERE LastName LIKE 'S%';


-----------------------------------------------------------------------------------------------------------------------------------
--8-Select the sum of all the departments' budgets.
SELECT SUM(Budget) AS TotalBudget FROM Departments

-----------------------------------------------------------------------------------------------------------------------------------
--9-Select the number of employees in each department (you only need to show the department code and the number of employees).
SELECT Department , COUNT(*) As NumEmployees
From Employees
Group by Department


--and Name 
SELECT d.Code, d.Name, COUNT(e.SSN) AS NumEmployees
FROM Departments d
JOIN Employees e ON d.Code = e.Department
GROUP BY d.Code, d.Name;

-----------------------------------------------------------------------------------------------------------------------------------
--10-Select all the data of employees, including each employee's department's data.
Select *
From Employees AS e 
Join Departments As d ON  d.Code = e.Department
-----------------------------------------------------------------------------------------------------------------------------------
--11-Select the name and last name of each employee, along with the name and budget of the employee's department.

SELECT e.Name, e.LastName, d.Name AS DeptName, d.Budget
FROM Employees e
JOIN Departments d ON e.Department = d.Code;

-----------------------------------------------------------------------------------------------------------------------------------
--12-Select the name and last name of employees working for departments with a budget greater than $60,000.

SELECT e.Name, e.LastName, d.Name AS DeptName, d.Budget
FROM Employees e
JOIN Departments d ON e.Department = d.Code
where d.Budget > 60000

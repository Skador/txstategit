/* These Answers to Part II are crafted by Cody Kern, Tammy Trevathan, and Michelle Leipnik
*/

Use Assignment4CIS3382;

--1)
IF OBJECT_ID('dbo.Employee', 'U') IS NOT NULL
DROP TABLE Employee;
GO

CREATE TABLE Employee
(EmployeeID INT NOT NULL PRIMARY KEY,
EmpFName VARCHAR(35) NOT NULL,
EmpLName VARCHAR(35) NOT NULL,
EmpMInitial CHAR NULL,
EmpStAddress1 VARCHAR(50) NOT NULL,
EmpStAddress2 VARCHAR(50) NULL,
EmpCity VARCHAR(50) NOT NULL,
EmpState VARCHAR(2) NULL,
EmpZipCode VARCHAR(20) NULL,
EmpCountry VARCHAR(50) NOT NULL DEFAULT 'United States',
EmpPhoneNumber VARCHAR(20) NOT NULL,
EmpSalary MONEY NOT NULL);
GO

INSERT INTO Employee VALUES(1001, 'Alice', 'Dolittle', 'P', '1960 Somewhere St.', 'APT 626', 'Austin', 'TX', '78704', DEFAULT, '512-555-5559', 150000),
  (1002, 'P', 'Shermin', NULL, 'Whalaby Way', NULL, 'Sydney', NULL, NULL, 'Australia', '+61-555-555-5555', 134000)

SELECT * FROM Employee;
GO
--2)

ALTER TABLE MaintenanceProcedures WITH NOCHECK
 ADD SupervisorID INT NOT NULL DEFAULT 0 CONSTRAINT FK_SupervisorEmployeeID FOREIGN KEY REFERENCES Employee(EmployeeID);
UPDATE MaintenanceProcedures SET SupervisorID = 1001 WHERE MaintID = 2;
UPDATE MaintenanceProcedures SET SupervisorID = 1002 WHERE MaintID = 1;

SELECT * FROM MaintenanceProcedures; 
GO

-- 3)
UPDATE Employee SET EmpSalary = EmpSalary * 1.10

SELECT * FROM Employee;
GO

-- 4)
CREATE NONCLUSTERED INDEX IX_Reservations_NonClustered_FlightID ON Reservations(FlightID);
CREATE NONCLUSTERED INDEX IX_Reservations_NonClustered_CustID ON Reservations(CustID);

-- 5)
SELECT Customers.CustID, Customers.CustFName, Customers.CustLName, Reservations.FlightDateTime
FROM Customers INNER JOIN Reservations ON Customers.CustID = Reservations.CustID 
INNER JOIN Flights ON Reservations.FlightID = Flights.FlightID
ORDER BY Customers.CustID, Reservations.FlightDateTime;
GO
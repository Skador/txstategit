/* These tables are crafted by Cody Kern, Tammy Trevathan, and Michelle Leipnik
Model used is the Assignment 4 model.
*/

Use Assignment4CIS3382;

--Dropping tables to allow testing

IF OBJECT_ID('dbo.MaintenenceProcedures', 'U') IS NOT NULL
DROP TABLE MaintenenceProcedures;

IF OBJECT_ID('dbo.Reservations', 'U') IS NOT NULL
DROP TABLE Reservations;

IF OBJECT_ID('dbo.Maintenance', 'U') IS NOT NULL
DROP TABLE Maintenance;

IF OBJECT_ID('dbo.Flights', 'U') IS NOT NULL
DROP TABLE Flights;

IF OBJECT_ID('dbo.Customers', 'U') IS NOT NULL
DROP TABLE Customers;

IF OBJECT_ID('dbo.Planes', 'U') IS NOT NULL
DROP TABLE Planes;

IF OBJECT_ID('dbo.Procedures', 'U') IS NOT NULL
DROP TABLE Procedures;

GO

-- Creating Tables for Assignment 4

-- Create Procedures Table
CREATE TABLE Procedures(
ProcedureID INT NOT NULL PRIMARY KEY IDENTITY(1,1),
Description VARCHAR(50) NOT NULL,
EstimatedTime VARCHAR(50) NOT NULL);

-- Create Planes Table
CREATE TABLE Planes(
PlaneID INT NOT NULL PRIMARY KEY,
ModelNumber VARCHAR(20) NOT NULL,
TotalCapacity VARCHAR(200) NOT NULL,
MaintenanceDateTime DATETIME NOT NULL, -- Modifying for DATETIME
-- MaintenanceTime TIME NOT NULL
);

-- Create Customers Table
CREATE TABLE Customers(
CustID INT NOT NULL PRIMARY KEY IDENTITY(1,1),
CustFName VARCHAR(50) NOT NULL,
CustLName VARCHAR(50) NOT NULL,
CustMInitial VARCHAR(50) NULL, -- Needs to be changed on Data doc
CustDOB DATE NOT NULL,
CustHPhone VARCHAR(50) NULL,
CustWPhone VARCHAR(50) NULL,
CustCPhone VARCHAR(50) NULL,
CustEmail VARCHAR(50) NOT NULL); -- Create Unique index

-- Create Flights Table
CREATE TABLE Flights(
FlightID INT NOT NULL PRIMARY KEY, -- Remove Identity
PlaneID INT NOT NULL REFERENCES Planes(PlaneID) ON UPDATE CASCADE,
OriginCity VARCHAR(50) NOT NULL,
OriginState VARCHAR(2) NULL, -- Needs to be updated IF INTERNATIONAL And updating to 2 char state
OriginCountry VARCHAR(50) DEFAULT 'United States' NOT NULL, -- Needs to be changed Setting Default to "United States"
DestinationCity VARCHAR(50) NOT NULL,
DestinationState VARCHAR(2) NULL, -- Needs to be updated IF INTERNATIONAL And updating to 2 char state
DestinationCountry VARCHAR(50) DEFAULT 'United States' NOT NULL, --Needs updated name and rules
DepartureDateTime DATETIME NOT NULL,
--DepartureTime TIME NOT NULL,
ArrivalDateTime DATETIME NOT NULL, -- Needs updated name (Spellcheck)
--ArrivalTime TIME NOT NULL, -- Same as above
StandardFare SMALLMONEY NOT NULL); -- Needs updates on the Data Dictionary

-- Create Maintenance Table
CREATE TABLE Maintenance(
MaintID INT NOT NULL PRIMARY KEY IDENTITY(1,1), --Needs update on name
PlaneID INT NOT NULL REFERENCES Planes(PlaneID) ON UPDATE CASCADE,
LastMaintDateTime DATETIME NOT NULL, --ShortHand Name Updated
--LastMaintTime TIME NULL,
ReturnMaintDateTime DATETIME NOT NULL,
/*ReturnMaintTime TIME NULL*/);

-- Create Reservations Table
CREATE TABLE Reservations(
ResID INT NOT NULL IDENTITY(1,1),
FlightID INT NOT NULL,
CustID INT NOT NULL,
FlightDateTime DATETIME NOT NULL,
--FlightTime TIME NOT NULL,
ResDateTime DATETIME NOT NULL,
--ResTime TIME NOT NULL,
ActualFare SMALLMONEY NOT NULL,
PaymentAmt SMALLMONEY DEFAULT 0 NOT NULL,
PaymentDateTime DATETIME NULL,
--PaymentTime TIME Null,
CONSTRAINT PK_Reservations PRIMARY KEY(ResID),
CONSTRAINT FK_FlightID FOREIGN KEY(FlightID) REFERENCES Flights(FlightID) ON UPDATE CASCADE,
CONSTRAINT FK_CustID FOREIGN KEY(CustID) REFERENCES Customers(CustID) ON UPDATE CASCADE,
CONSTRAINT CK_PaymentAmt CHECK(PaymentAmt >= 0));

-- Create MaintenenceProcedures Table
CREATE TABLE MaintenenceProcedures(
MaintID INT NOT NULL PRIMARY KEY REFERENCES Maintenance(MaintID), -- Remove Identity 
ProcedureID INT NOT NULL REFERENCES Procedures(ProcedureID) ON UPDATE CASCADE,
ActualTime VARCHAR(50) NOT NULL);
GO

-- Create Indexes

CREATE INDEX IX_Flights_PlaneID ON Flights(PlaneID);
CREATE INDEX IX_Maintenance_PlaneID ON Maintenance(PlaneID);
CREATE INDEX IX_Reservations_FlightID ON Reservations(FlightID);
CREATE INDEX IX_Reservations_CustID ON Reservations(CustID);
CREATE UNIQUE INDEX IX_Customer_CustEmail ON Customers(CustEmail);
GO

-- Insert Data

INSERT INTO Procedures VALUES('Repairing of Landing Gear Tires', '5 Working Days'), ('Replacing elastic shock absorber cords', '10 Working Days')
SELECT * FROM Procedures;

INSERT INTO Planes VALUES(123, 'PL112233', 'H350', '12/13/2014 10:30am');
INSERT INTO Planes VALUES(456, 'PL445566', 'H465', '04/25/2014 2:30pm');
SELECT * FROM Planes;

INSERT INTO Customers VALUES('John', 'Smith', 'J', '5/4/1979', '214-666-1212', NULL, '214-666-1212', 'JohnSmith@yahoo.com');
INSERT INTO Customers VALUES('Kim', 'Jones', 'C', '8/15/1989', '512-555-6565', '907-320-1818', '512-555-6565', 'KimCJ@gmail.com');
SELECT * FROM Customers;

INSERT INTO Flights VALUES(654123, 123, 'Dallas', 'TX', 'United States', 'Miami', 'FL', 'United States', '6/15/2014 9:00am', '6/15/2014 12:00pm', 236)
INSERT INTO Flights VALUES(321456, 456, 'Portland', 'OR', 'United States', 'Denver', 'CO', 'United States', '8/01/2015 7:00am', '8/01/2015 4:00pm', 358)
SELECT * FROM Flights;

INSERT INTO Maintenance VALUES(456, '12/1/2014 2:15pm', '12/13/2014 10:30am'), (123, '04/01/2015 4:00pm', '04/25/2015 12:15pm')
SELECT * FROM Maintenance;

INSERT INTO Reservations VALUES(321456, 1, '6/15/2014 9:00am', '6/15/2014 8:00am', 236, DEFAULT, NULL),
    (654123, 2, '8/01/2015 7:00am', '8/01/2015 6:00am', 358, 358, '7/15/2015 11:30am');
SELECT * FROM Reservations;

INSERT INTO MaintenenceProcedures VALUES(1, 2, '9 Working Days'), (2, 1, '6 Working Days');
SELECT * FROM MaintenenceProcedures;
Go
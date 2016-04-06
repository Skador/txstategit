-- Server to connect too - cissql.matrix.txstate.edu\CIS3382SPRNG2016

/* These tables are created by Cody Kern.
Model used is the Accounts Payable model.
*/

-- Use statement to specify a Database

USE AccountPayableCIS3382;

-- Drop Tables before testing create
IF OBJECT_ID('dbo.InvoiceLineItems', 'U') IS NOT NULL -- Line verifies that the Table exists before running the "DROP TABLE <Table>"
DROP TABLE InvoiceLineItems;
IF OBJECT_ID('dbo.Invoices', 'U') IS NOT NULL
DROP TABLE Invoices;
IF OBJECT_ID('dbo.Vendors', 'U') IS NOT NULL
DROP TABLE Vendors;
IF OBJECT_ID('dbo.Terms', 'U') IS NOT NULL
DROP TABLE Terms;
IF OBJECT_ID('dbo.GLAccounts', 'U') IS NOT NULL
DROP TABLE GLAccounts;
IF OBJECT_ID('dbo.Employee', 'U') IS NOT NULL
DROP TABLE Employee;

GO

-- Create Terms Table

CREATE TABLE Terms
(TermsID INT NOT NULL PRIMARY KEY,
TermsDescription VARCHAR(50) NOT NULL,
TermsDueDays SMALLINT NOT NULL);

-- Create GLAccounts Table

CREATE TABLE GLAccounts
(AccountNo INT NOT NULL PRIMARY KEY,
AccountDescription VARCHAR(50) NOT NULL);

-- Create Vendors Table
CREATE TABLE Vendors
(VendorID INT NOT NULL PRIMARY KEY IDENTITY(1,1),
VendorName VARCHAR(50) NOT NULL,
VendorAddress1 VARCHAR(50) NULL,
VendorAddress2 VARCHAR(50) NULL,
VendorCity VARCHAR(50) NOT NULL,
VendorState CHAR(2) NOT NULL,
VendorZipCode VARCHAR(20) NOT NULL,
VendorPhone VARCHAR(50) NULL,
VendorContactLName VARCHAR(50) NULL,
VendorContactFName VARCHAR(50) NULL,
DefaultTermsID INT NOT NULL /* Short Name */ REFERENCES Terms(TermsID) ON UPDATE CASCADE,
DefaultAccountNo INT NOT NULL REFERENCES GLAccounts(AccountNo));

-- Create Invoices Table
CREATE TABLE Invoices
(InvoiceID INT NOT NULL PRIMARY KEY IDENTITY(1,1),
VendorID INT NOT NULL CONSTRAINT FK_VendorID FOREIGN KEY REFERENCES Vendors(VendorID) ON UPDATE CASCADE,
InvoiceNumber VARCHAR(50) NOT NULL,
InvoiceDate SMALLDATETIME NOT NULL,
InvoiceTotal MONEY NOT NULL,
PaymentTotal MONEY NOT NULL DEFAULT 0 CHECK(PaymentTotal >= 0),
CreditTotal MONEY NOT NULL DEFAULT 0,
TermsID INT NOT NULL CONSTRAINT FK_TermsID FOREIGN KEY REFERENCES Terms(TermsID),
InvoiceDueDate SMALLDATETIME NOT NULL,
PaymentDate SMALLDATETIME NULL);

-- Create InvoiceLineItems Table
CREATE TABLE InvoiceLineItems
(InvoiceID INT NOT NULL,
InvoiceSequence SMALLINT NOT NULL,
AccountNo INT NOT NULL,
InvoiceLineItemAmount MONEY NOT NULL,
InvoiceLineItemDescription VARCHAR(100) NOT NULL,
CONSTRAINT PK_InvoiceLineItems PRIMARY KEY(InvoiceID, InvoiceSequence),
CONSTRAINT FK_InvoiceID FOREIGN KEY(InvoiceID) REFERENCES Invoices(InvoiceID),
CONSTRAINT FK_AccountNo FOREIGN KEY(AccountNo) REFERENCES GLAccounts(AccountNo),
CONSTRAINT CK_InvoiceLineItemAmount CHECK(InvoiceLineItemAmount >= 0));

GO
-- Create Indexes

CREATE INDEX IX_Vendors_DefaultTermsID On Vendors(DefaultTermsID);
CREATE INDEX IX_Vendors_DefaultAccountNo On Vendors(DefaultAccountNo);
CREATE INDEX IX_Invoices_VendorID On Invoices(VendorID);
CREATE INDEX IX_Invoices_TermsID On Invoices(TermsID);
CREATE INDEX IX_InvoiceLineItems_InvoiceID On InvoiceLineItems(InvoiceID);
CREATE INDEX IX_InvoiceLineItems_AccountNo On InvoiceLineItems(AccountNo ASC);
CREATE NONCLUSTERED INDEX IX_Invoices_InvoiceDate ON Invoices(InvoiceDate DESC, InvoiceTotal DESC);
CREATE UNIQUE INDEX IX_Vendors_VendorName ON Vendors(VendorName);

-- Load Data Into Tabels
-- Load Terms Table
INSERT INTO Terms VALUES(1, 'Net due 10 days', 10);
INSERT INTO Terms VALUES(2, 'Net due 20 days', 20);

SELECT * FROM Terms;

-- Load GLAccounts Table
INSERT INTO GLAccounts(AccountDescription, AccountNo) VALUES('Accounts Payable', 200), ('Freight', 553);

SELECT * FROM GLAccounts;

-- Load Vendors Table
INSERT INTO Vendors VALUES('United Parcel Service', 'P.O. Box 50582', NULL, 'Reno', 'NV', '88905', '(800) 555-0855', 'Beauregard', 'Violet', 2, 553);
INSERT INTO Vendors VALUES('Federal Express Corporation', 'P.O. Box 38101', 'Dept A', 'Memphis', 'TN', '38101', '(800) 555-4091', 'Bucket', 'Charlie', 2, 553);

SELECT * FROM Vendors;

--Load Invoices Table
INSERT INTO Invoices VALUES(2, '26325324', '2015-03-10', 40.20, 40.20, 0.00, 2, '2015-03-30', '2015-03-14'), 
   (1, '989319-457', '2015-03-30', 3813.33, 0, 0.00, 2, '2015-04-20', NULL);

SELECT * FROM Invoices;

--Load InvoiceLineItems Table

INSERT INTO InvoiceLineItems VALUES(1, 1, 553, 40.20, 'Freight');
INSERT INTO InvoiceLineItems VALUES(2, 1, 553, 3813.33, 'Freight');

SELECT * FROM InvoiceLineItems;

UPDATE Invoices SET PaymentTotal = 3813.33, PaymentDate = GETDATE() WHERE InvoiceID = 2;

CREATE TABLE Employee
(EmployeeID INT NOT NULL PRIMARY KEY,
EmployeeFName VARCHAR(35) NOT NULL,
EmployeeLName VARCHAR(35) NOT NULL,
EmployeeMInitial CHAR NULL,
EmployeeSalary MONEY NOT NULL);

INSERT INTO Employee VALUES(1, 'Cody', 'Kern', 'M', 75000), (2, 'Stephen', 'Stacy', NULL, 134000)

SELECT * FROM Employee;

UPDATE Employee SET EmployeeSalary = EmployeeSalary * 1.13

SELECT * FROM Employee;
CREATE DATABASE CodingChallenge;

use CodingChallenge
go

CREATE TABLE Products(
					ID INT PRIMARY KEY IDENTITY, 
					[Name] nvarchar(50) NOT NULL,
					Price float NOT NULL 
);

CREATE TABLE Customers(
					ID INT PRIMARY KEY IDENTITY, 
					[FirstName] nvarchar(20) NOT NULL,
					[LastName] nvarchar(20) NOT NULL,
					[CardNumber] nvarchar(20) NOT NULL
);

CREATE TABLE Orders(
					ID INT Primary Key IDENTITY,
					ProductID INT,
					CustomerID INT,
					FOREIGN KEY (ProductID) references Products(ID),
					FOREIGN KEY (CustomerID) references Customers(ID)
);

INSERT INTO Products([Name],Price)
VALUES ('Keyboard',15.00), 
		('Mouse', 5.00),
		('MousePad',2.00);
		
INSERT INTO Customers(FirstName,LastName,CardNumber)
VALUES ('Pedro','Rivera','1234 5678 9876 5432'),
		('Gabriel','Sarango','5555 5555 5555 5555'),
		('Mike', 'Buono','1234 1234 1234 1234');

INSERT INTO Orders(ProductID,CustomerID)
VALUES (1,1),
		(2,1),
		(1,2),
		(2,2);
INSERT INTO Products([Name],Price)
VALUES ('iPhone',200.00);

INSERT INTO Customers([FirstName],LastName,CardNumber)
VALUES ('Tina','Smith','9999 9999 9999 9999');

INSERT INTO Orders(ProductID,CustomerID)
VALUES (4,4);

select * From Orders where CustomerID = 4;



UPDATE Products
SET Price = 250.00
WHERE [Name] = 'iPhone';
						 
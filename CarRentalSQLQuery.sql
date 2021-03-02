CREATE TABLE Brands(
	BrandId int PRIMARY KEY IDENTITY(1,1),
	BrandName nvarchar(25),
)

CREATE TABLE Colors(
	ColorId int PRIMARY KEY IDENTITY(1,1),
	ColorName nvarchar(25),
)

CREATE TABLE Cars(
	CarId int PRIMARY KEY IDENTITY(1,1),
	BrandId int,
	ColorId int,
	CarName nvarchar(25),
	ModelYear nvarchar(25),
	DailyPrice decimal,
	Descriptions nvarchar(25),
	FOREIGN KEY (ColorId) REFERENCES Colors(ColorId),
	FOREIGN KEY (BrandId) REFERENCES Brands(BrandId)
)

CREATE TABLE Users(
    Id           INT          IDENTITY (1, 1) NOT NULL,
    FirstName    VARCHAR (50) NOT NULL,
    LastName     VARCHAR (50) NOT NULL,
    Email        VARCHAR (50) NOT NULL,
    PasswordHash BINARY (500) NOT NULL,
    PasswordSalt BINARY (500) NOT NULL,
    Status       BIT          NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
)

CREATE TABLE Customers(
	Id int PRIMARY KEY IDENTITY(1,1),
	UserId int,
	CompanyName nvarchar(50),
	FOREIGN KEY (UserId) REFERENCES Users(Id)
)

CREATE TABLE Rentals(
	Id int PRIMARY KEY IDENTITY(1,1),
	CarId int,
	CustomerId int,
	RentDate datetime,
	ReturnDate datetime,
	FOREIGN KEY (CarId) REFERENCES Cars(CarId),
	FOREIGN KEY (CustomerId) REFERENCES Customers(Id)
)

CREATE TABLE CarImages (
    Id int,
    CarId int,
    ImagePath varchar(255),
    Date DateTime
);

CREATE TABLE UserOperationClaims (
    Id               INT IDENTITY (1, 1) NOT NULL,
    UserId           INT NOT NULL,
    OperationClaimId INT NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

CREATE TABLE OperationClaims (
    Id   INT           IDENTITY (1, 1) NOT NULL,
    Name VARCHAR (250) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

ALTER TABLE CarImages
ALTER COLUMN Id int NOT NULL;

ALTER TABLE CarImages
ADD PRIMARY KEY (Id);
ALTER TABLE CarImages
ADD FOREIGN KEY (CarId) REFERENCES Cars(Id);

INSERT INTO Brands(BrandName)
VALUES
	('Mercedes'),
	('BMW'),
	('Renault');

INSERT INTO Colors(ColorName)
VALUES
	('Beyaz'),
	('Siyah'),
	('Mavi');

INSERT INTO Cars(BrandId,ColorId,CarName,ModelYear,DailyPrice,Descriptions)
VALUES
	('1','2','Mercedes Benz','2012','100','Manuel Benzin'),
	('1','3','Mercedes Benz','2015','150','Otomatik Dizel'),
	('2','1','BMW M5','2017','200','Otomatik Hybrid'),
	('3','3','Renault Clio','2014','125','Manuel Dizel');

INSERT INTO Users(FirstName, LastName, Email, Password)
VALUES
	('Engin','DEMİROĞ','engindemirog@gmail.com','1234');

INSERT INTO Customers(UserId, CompanyName)
VALUES
	('1','SOLIDTEAM');

INSERT INTO Rentals(CarId, CustomerId, RentDate, ReturnDate)
VALUES
	('1','1','2021-02-10','2021-02-13');

SELECT * FROM Cars
SELECT * FROM Brands
SELECT * FROM Colors
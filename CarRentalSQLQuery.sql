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

SELECT * FROM Cars
SELECT * FROM Brands
SELECT * FROM Colors
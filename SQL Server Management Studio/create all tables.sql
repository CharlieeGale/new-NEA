CREATE TABLE makes(
MakeID int PRIMARY KEY IDENTITY,
makeName varchar(255),
)

CREATE TABLE models(
ModelID int PRIMARY KEY IDENTITY ,
modelName varchar(255),
MakeID int FOREIGN KEY REFERENCES makes(MakeID),
)

CREATE TABLE cars(
CarID int PRIMARY KEY IDENTITY,
ModelID int FOREIGN KEY REFERENCES models(ModelID),
MakeID int FOREIGN KEY REFERENCES makes(MakeID),
regYear int,
fuelType varchar (6),
driveTrain varchar (3),
transmission varchar (9),
engineSize decimal (3,2),
fullName varchar(255)
CanID int,
)



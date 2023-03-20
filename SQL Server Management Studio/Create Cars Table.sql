CREATE TABLE cars(
CarID int PRIMARY KEY,
ModelID int,
FOREIGN KEY(ModelID) REFERENCES models(ModelID),
MakeID int ,
FOREIGN KEY (MakeID) REFERENCES makes(MakeID),
regYear int,
fuelType varchar (6),
driveTrain varchar (3),
transmission varchar (9),
engineSize decimal (3,2),
CanID int
)

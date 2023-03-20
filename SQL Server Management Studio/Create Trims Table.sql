CREATE TABLE trims(
TrimID int PRIMARY KEY,
trimName varchar,
ModelID int FOREIGN KEY REFERENCES ModelID(models)
)
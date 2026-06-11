DROP TABLE IF EXISTS FurnitureType;

CREATE TABLE FurnitureType (
  fType char(4) PRIMARY KEY,
  typeName varchar(30) NOT NULL
);

INSERT INTO FurnitureType (fType, typeName) VALUES
    ('FT01', 'Table'),
    ('FT02', 'Chair'),
    ('FT03', 'Sofa'),
    ('FT04', 'Shelf'),
    ('FT05', 'Wardrobe'),
    ('FT06', 'Bed');
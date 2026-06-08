DROP TABLE IF EXISTS Material;

CREATE TABLE Material (
  materialCode char(5) PRIMARY KEY,
  mName varchar(30) NOT NULL,
  mQuantity int(10) NOT NULL DEFAULT 0,
  munit varchar(18) NOT NULL
);

INSERT INTO Material VALUES
    ('M0001', 'Oak Wood Plank', 500, 'pcs'),
    ('M0002', 'Steel Tube', 200, 'meter'),
    ('M0003', 'Fabric Cloth', 100, 'meter'),
    ('M0004', 'High Density Foam', 50, 'block');
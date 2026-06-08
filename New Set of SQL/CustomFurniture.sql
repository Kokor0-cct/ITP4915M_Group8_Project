DROP TABLE IF EXISTS CustomFurniture;

CREATE TABLE CustomFurniture (
  cfID char(8) NOT NULL PRIMARY KEY,
  cUserID char(8) NOT NULL,
  cfName varchar(50) NOT NULL,
  fType char(4) NOT NULL,
  cfprice decimal(8,2) NOT NULL,
  cfDesc text NOT NULL,
  CONSTRAINT CF_fk_cUserID FOREIGN KEY (cUserID) REFERENCES Customers(cUserID),
  CONSTRAINT CF_fk_fType FOREIGN KEY (fType) REFERENCES FurnitureType(fType)
);

INSERT INTO CustomFurniture VALUES
    ('CF000001', 'C0000001', 'Steel Dining Chair', 'FT02', 550.00, 'Classic style dining chair made of solid Steel.'),
    ('CF000002', 'C0000002', 'Fabric Dining Table', 'FT01', 3500.00, '8-seater dining table, perfect for families.');

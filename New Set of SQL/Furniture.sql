DROP TABLE IF EXISTS Furniture;

CREATE TABLE Furniture (
  fID char(9) PRIMARY KEY,
  fName varchar(50) NOT NULL,
  fQuantity int(10) NOT NULL DEFAULT 0,
  fType char(4) NOT NULL,
  fprice decimal(8,2) NOT NULL,
  fDesc text NOT NULL,
  CONSTRAINT fk_fType FOREIGN KEY (fType) REFERENCES FurnitureType(fType)
);

INSERT INTO Furniture VALUES
    ('F00000001', 'Oak Dining Chair', 200, 'FT02', 450.00, 'Classic style dining chair made of solid oak.'),
    ('F00000002', 'Large Dining Table', 120, 'FT01', 2500.00, '6-seater dining table, perfect for families.'),
    ('F00000003', '3-Seater Fabric Sofa', 350, 'FT03', 3800.00, 'Comfortable grey fabric sofa with foam filling.'),
    ('F00000004', 'Wooden Wardrobe', 330, 'FT05', 1800.00, 'Double door wardrobe with hanging space.'),
    ('F00000005', 'Industrial Bookshelf', 50, 'FT04', 1200.00, 'Modern style bookshelf with steel frame.'),
    ('F00000006', 'Queen Size Bed Frame', 230, 'FT06', 2200.00, 'Sturdy bed frame for queen size mattress.');

DROP TABLE IF EXISTS ShippingOption;

CREATE TABLE ShippingOption (
  soId char(4) PRIMARY KEY,
  soName varchar(20) NOT NULL,
  Charge decimal(5,2) NOT NULL
);

INSERT INTO ShippingOption VALUES
('SO01', 'Ordinary Transport', 50.00),
('SO02', 'Express Shipping', 100.00);
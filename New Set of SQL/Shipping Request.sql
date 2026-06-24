CREATE TABLE ShippingRequest (
  SRID CHAR(10) PRIMARY KEY,
  IID VARCHAR(10) NOT NULL UNIQUE,
  createDate date NOT NULL DEFAULT CURRENT_TIMESTAMP,
  deliveryDate date Not NULL,
  collectAddress text NOT NULL,
  deliveryAddress  text NOT NULL,
  statusType char(4) NOT NULL DEFAULT 'ST05'
);

INSERT INTO ShippingRequest (SRID, IID, deliveryDate, collectAddress, deliveryAddress) VALUES
('SR00000001', 'O0000001', '2026-08-28', 'Caddress', 'Daddress'),
('SR00000002', 'CF000001', '2026-07-16','Caddress', 'Daddress'),
('SR00000003', 'MR00000001', '2026-12-3', 'Caddress', 'Daddress');
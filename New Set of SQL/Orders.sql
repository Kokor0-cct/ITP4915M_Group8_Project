DROP TABLE IF EXISTS ORDERS;

CREATE TABLE Orders (
  orderID char(8) NOT NULL,
  fID char(9) NOT NULL,
  Quantity int(10) NOT NULL,
  cUserID char(8) NOT NULL,
  oAmount decimal(10,2) NOT NULL,
  odeliverydate date DEFAULT NULL,
  odeliveryaddress text DEFAULT NULL,
  shippingType char(4) NOT NULL,
  statusType char(4) NOT NULL,
  CONSTRAINT fk_fid FOREIGN KEY (fID) REFERENCES Furniture(fID),
  CONSTRAINT fk_cid FOREIGN KEY (cUserID) REFERENCES Customers(cUserID),
  CONSTRAINT fk_shippingType FOREIGN KEY (shippingType) REFERENCES ShippingOption(soID),
  CONSTRAINT fk_statusType FOREIGN KEY (statusType) REFERENCES Status(statusCode),
  PRIMARY KEY (orderID, fID)
);

INSERT INTO Orders VALUES
    ('O0000001', 'F00000001', 1, 'C0000001', 450.00, '2026-04-10', 'Flat A, 133/F, Sunshine Building, Mong Kok, Kowloon', 'SO02', 'ST01'),
    ('O0000002', 'F00000002', 1, 'C0000001', 2500.00, '2026-04-12', NULL, 'SO01', 'ST05');
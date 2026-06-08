DROP TABLE IF EXISTS Customers;

CREATE TABLE Customers (
  cUserID char(8) PRIMARY KEY,
  cName varchar(30) NOT NULL,
  cPhone varchar(20) NOT NULL,
  cPassword varchar(20) NOT NULL,
  cAddress varchar(255) NOT NULL,
  company varchar(255) DEFAULT NULL,
  cBudget int(11) DEFAULT 0
);

INSERT INTO Customers (cUserID, cName, cPhone, cPassword, cAddress, company) VALUES
    ('C0000001', 'taiman', '23456789', 'cust123', 'Flat A, 12/F, Sunshine Building, Mong Kok, Kowloon', 'ABC Trading Ltd.'),
    ('C0000002', 'siuming', '98765432', 'cust456', 'Room 8, 3/F, Harbour View Court, Tsuen Wan, New Territories', NULL);

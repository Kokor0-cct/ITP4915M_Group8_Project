DROP TABLE IF EXISTS Staff;

CREATE TABLE Staff (
  sUserID char(8) PRIMARY KEY,
  sName varchar(30) NOT NULL,
  sPassword varchar(20) NOT NULL,
  deptCode char(3) NOT NULL,
  sPhone varchar(20) NOT NULL,
  CONSTRAINT fk_dept FOREIGN KEY (deptCode) REFERENCES Department(deptCode)
);

INSERT INTO Staff (sUserID, sName, sPassword, deptCode, sPhone) VALUES
  ('S0000001', 'Admin01', 'Admin001', 'D01', '12345678'),
  ('S0000002', 'Sales01', 'Sales001', 'D02', '22345678'),
  ('S0000003', 'Production01', 'Production001', 'D03', '33345678'),
  ('S0000004', 'Inventory01', 'Inventory001', 'D04', '44445678'),
  ('S0000005', 'Logistic01', 'Logistic001', 'D05', '55555678'),
  ('S0000006', 'Design01', 'Design001', 'D06', '66666678');
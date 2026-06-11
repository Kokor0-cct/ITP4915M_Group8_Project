DROP TABLE IF EXISTS Department;

CREATE TABLE Department (
  deptCode char(3) PRIMARY KEY,
  deptName varchar(30) NOT NULL
);

INSERT INTO Department VALUES
    ('D01', 'Admin'),
    ('D02', 'Sales'),
    ('D03', 'Production'),
    ('D04', 'Inventory'),
    ('D05', 'Logistic'),
    ('D06', 'Design');
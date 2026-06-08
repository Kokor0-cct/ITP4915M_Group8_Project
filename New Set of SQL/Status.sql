DROP TABLE IF EXISTS Status;

CREATE TABLE Status (
  statusCode char(4) PRIMARY KEY,
  statusDesc varchar(30) NOT NULL
);

INSERT INTO Status VALUES
    ('ST01', 'Pending'),
    ('ST02', 'In Production'),
    ('ST03', 'In Transit'),
    ('ST04', 'Delivered'),
    ('ST05', 'Failed'),
    ('ST06', 'Cancel');
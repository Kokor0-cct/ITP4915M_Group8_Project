DROP TABLE IF EXISTS FurnitureMaterials;

CREATE TABLE FurnitureMaterials (
  fID char(9) NOT NULL,
  materialCode char(5) NOT NULL,
  pmqty int(11) NOT NULL,
  CONSTRAINT FM_fk_fid FOREIGN KEY (fID) REFERENCES Furniture(fID),
  CONSTRAINT FM_fk_materialCode FOREIGN KEY (materialCode) REFERENCES Material(materialCode),
  PRIMARY KEY (fID, materialCode)
);

INSERT INTO FurnitureMaterials VALUES
    ('F00000001', 'M0001', 2),
    ('F00000002', 'M0001', 10),
    ('F00000003', 'M0001', 5),
    ('F00000003', 'M0003', 10),
    ('F00000003', 'M0004', 3),
    ('F00000004', 'M0001', 15),
    ('F00000005', 'M0001', 4),
    ('F00000005', 'M0002', 6),
    ('F00000006', 'M0001', 12);
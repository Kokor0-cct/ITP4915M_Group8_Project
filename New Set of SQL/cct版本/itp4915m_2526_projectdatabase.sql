SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;


CREATE TABLE `customers` (
  `cUserID` char(8) NOT NULL,
  `cName` varchar(30) NOT NULL,
  `cPhone` varchar(20) NOT NULL,
  `cPassword` varchar(20) NOT NULL,
  `cAddress` varchar(255) NOT NULL,
  `company` varchar(255) DEFAULT NULL,
  `cBudget` int(11) DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

INSERT INTO `customers` (`cUserID`, `cName`, `cPhone`, `cPassword`, `cAddress`, `company`, `cBudget`) VALUES
('C0000001', 'taiman', '23456789', 'cust123', 'Flat A, 12/F, Sunshine Building, Mong Kok, Kowloon', 'ABC Trading Ltd.', 0),
('C0000002', 'siuming', '98765432', 'cust456', 'Room 8, 3/F, Harbour View Court, Tsuen Wan, New Territories', NULL, 0);

CREATE TABLE `customfurniture` (
  `cfID` char(8) NOT NULL,
  `cUserID` char(8) NOT NULL,
  `cfrID` char(8) NOT NULL,
  `cfName` varchar(50) NOT NULL,
  `fType` char(4) NOT NULL,
  `cfprice` decimal(8,2) NOT NULL,
  `cfDesc` text NOT NULL,
  `cfState` enum('Design pending','Pending approval','Design completed') NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

INSERT INTO `customfurniture` (`cfID`, `cUserID`, `cfrID`, `cfName`, `fType`, `cfprice`, `cfDesc`, `cfState`) VALUES
('CF000001', 'C0000001', 'CFR00001', 'Fabric Dining Table', 'FT02', 3500.00, '8-seater dining table, perfect for families.', 'Design pending'),
('CF000002', 'C0000002', 'CFR00002', 'YOU KNOW WHO???', 'FT01', 2500.00, 'YOU KNWO WHO?????', 'Design completed'),
('CF000003', 'C0000001', 'CFR00003', 'test3', 'FT03', 20.00, 'test3', 'Design completed');

CREATE TABLE `customfurniturerequest` (
  `cfrID` char(8) NOT NULL,
  `cUserID` char(8) NOT NULL,
  `fType` char(4) NOT NULL,
  `cfrBudget` int(11) NOT NULL,
  `cfrDESC` text NOT NULL,
  `cfrCreateDate` date NOT NULL,
  `Completed` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

INSERT INTO `customfurniturerequest` (`cfrID`, `cUserID`, `fType`, `cfrBudget`, `cfrDESC`, `cfrCreateDate`, `Completed`) VALUES
('CFR00001', 'C0000001', 'FT02', 4500, 'you kown who ?', '2025-01-01', 1),
('CFR00002', 'C0000001', 'FT01', 2500, 'you kown who ?2.0', '2025-01-02', 1),
('CFR00003', 'C0000001', 'FT03', 1500, 'you kown who ?3.0', '2025-01-02', 1);

CREATE TABLE `customorders` (
  `corderID` char(8) NOT NULL,
  `cfID` char(8) NOT NULL,
  `Quantity` int(10) NOT NULL,
  `cUserID` char(8) NOT NULL,
  `coAmount` decimal(10,2) NOT NULL,
  `codeliverydate` date NOT NULL,
  `coCreateDate` date NOT NULL,
  `codeliveryaddress` text NOT NULL,
  `shippingType` char(4) NOT NULL,
  `statusType` char(4) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

INSERT INTO `customorders` (`corderID`, `cfID`, `Quantity`, `cUserID`, `coAmount`, `codeliverydate`, `coCreateDate`, `codeliveryaddress`, `shippingType`, `statusType`) VALUES
('CO000001', 'CF000001', 1, 'C0000001', 2500.00, '2026-04-12', '2026-04-10', 'Flat B, 133/F, Sunshine Building, Mong Kok, Kowloon', 'SO01', 'ST05'),
('CO000002', 'CF000003', 2, 'C0000001', 190.00, '2027-02-20', '2026-06-18', 'Flat A, 12/F, Sunshine Building, Mong Kok, Kowloon', 'SO02', 'ST02');

CREATE TABLE `department` (
  `deptCode` char(3) NOT NULL,
  `deptName` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

INSERT INTO `department` (`deptCode`, `deptName`) VALUES
('D01', 'Admin'),
('D02', 'Sales'),
('D03', 'Production'),
('D04', 'Inventory'),
('D05', 'Logistic'),
('D06', 'Design');

CREATE TABLE `furniture` (
  `fID` char(9) NOT NULL,
  `fName` varchar(50) NOT NULL,
  `fQuantity` int(10) NOT NULL DEFAULT 0,
  `fType` char(4) NOT NULL,
  `fprice` decimal(8,2) NOT NULL,
  `fDesc` text NOT NULL,
  `fImgPath` varchar(200) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

INSERT INTO `furniture` (`fID`, `fName`, `fQuantity`, `fType`, `fprice`, `fDesc`, `fImgPath`) VALUES
('F00000001', 'Oak Dining Chair', 108, 'FT02', 450.00, 'Classic style dining chair made of solid oak.', '../../../IMG/Oak_Dining_Chair.png'),
('F00000002', 'Large Dining Table', 350, 'FT01', 2500.00, '6-seater dining table, perfect for families.', '../../../IMG/Large Dining Table.png'),
('F00000003', '3-Seater Fabric Sofa', 350, 'FT03', 3800.00, 'Comfortable grey fabric sofa with foam filling.', '../../../IMG/3-Seater Fabric Sofa.png'),
('F00000004', 'Wooden Wardrobe', 330, 'FT05', 1800.00, 'Double door wardrobe with hanging space.', '../../../IMG/Wooden Wardrobe.png'),
('F00000005', 'Industrial Bookshelf', 50, 'FT04', 1200.00, 'Modern style bookshelf with steel frame.', '../../../IMG/Industrial Bookshelf.png'),
('F00000006', 'Queen Size Bed Frame', 230, 'FT06', 2200.00, 'Sturdy bed frame for queen size mattress.', '../../../IMG/Queen Size Bed Frame.png');

CREATE TABLE `furniturematerials` (
  `fID` char(9) NOT NULL,
  `materialCode` char(5) NOT NULL,
  `pmqty` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

INSERT INTO `furniturematerials` (`fID`, `materialCode`, `pmqty`) VALUES
('F00000001', 'M0001', 2),
('F00000002', 'M0001', 10),
('F00000003', 'M0001', 5),
('F00000003', 'M0003', 10),
('F00000003', 'M0004', 3),
('F00000004', 'M0001', 15),
('F00000005', 'M0001', 4),
('F00000005', 'M0002', 6),
('F00000006', 'M0001', 12);

CREATE TABLE `furnituretype` (
  `fType` char(4) NOT NULL,
  `typeName` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

INSERT INTO `furnituretype` (`fType`, `typeName`) VALUES
('FT01', 'Table'),
('FT02', 'Chair'),
('FT03', 'Sofa'),
('FT04', 'Shelf'),
('FT05', 'Wardrobe'),
('FT06', 'Bed');

CREATE TABLE `material` (
  `materialCode` char(5) NOT NULL,
  `mName` varchar(30) NOT NULL,
  `mQuantity` int(10) NOT NULL DEFAULT 0,
  `munit` varchar(18) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

INSERT INTO `material` (`materialCode`, `mName`, `mQuantity`, `munit`) VALUES
('M0001', 'Oak Wood Plank', 500, 'pcs'),
('M0002', 'Steel Tube', 200, 'meter'),
('M0003', 'Fabric Cloth', 100, 'meter'),
('M0004', 'High Density Foam', 50, 'block');

CREATE TABLE `materialrequest` (
  `mrID` char(10) NOT NULL,
  `materialCode` char(5) NOT NULL,
  `mrQuantity` int(20) NOT NULL,
  `UrgencyLevel` enum('Low','Medium','High') NOT NULL,
  `createDate` date NOT NULL,
  `sUserID` char(8) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

INSERT INTO `materialrequest` (`mrID`, `materialCode`, `mrQuantity`, `UrgencyLevel`, `createDate`, `sUserID`) VALUES
('MR00000001', 'M0001', 5, 'Medium', '2012-12-12', 'S0000001'),
('MR00000002', 'M0001', 2, 'Low', '2026-06-16', 'S0000001'),
('MR00000002', 'M0003', 1, 'Low', '2026-06-16', 'S0000001');

CREATE TABLE `orders` (
  `orderID` char(8) NOT NULL,
  `fID` char(9) NOT NULL,
  `Quantity` int(10) NOT NULL,
  `cUserID` char(8) NOT NULL,
  `oAmount` decimal(10,2) NOT NULL,
  `odeliverydate` date NOT NULL,
  `oCreateDate` date NOT NULL,
  `odeliveryaddress` text NOT NULL,
  `shippingType` char(4) NOT NULL,
  `statusType` char(4) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

INSERT INTO `orders` (`orderID`, `fID`, `Quantity`, `cUserID`, `oAmount`, `odeliverydate`, `oCreateDate`, `odeliveryaddress`, `shippingType`, `statusType`) VALUES
('O0000001', 'F00000001', 1, 'C0000001', 450.00, '2026-04-10', '2026-04-09', 'Flat A, 133/F, Sunshine Building, Mong Kok, Kowloon', 'SO02', 'ST01'),
('O0000002', 'F00000002', 1, 'C0000001', 2500.00, '2026-04-12', '2026-04-10', 'Flat B, 133/F, Sunshine Building, Mong Kok, Kowloon', 'SO01', 'ST05'),
('O0000003', 'F00000001', 12, 'C0000001', 5550.00, '2026-06-18', '2026-06-18', 'Flat A, 12/F, Sunshine Building, Mong Kok, Kowloon', 'SO02', 'ST01');

CREATE TABLE `shippingoption` (
  `soId` char(4) NOT NULL,
  `soName` varchar(20) NOT NULL,
  `Charge` decimal(5,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

INSERT INTO `shippingoption` (`soId`, `soName`, `Charge`) VALUES
('SO01', 'Ordinary Transport', 50.00),
('SO02', 'Express Shipping', 100.00);

CREATE TABLE `staff` (
  `sUserID` char(8) NOT NULL,
  `sName` varchar(30) NOT NULL,
  `sPassword` varchar(20) NOT NULL,
  `deptCode` char(3) NOT NULL,
  `sPhone` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

INSERT INTO `staff` (`sUserID`, `sName`, `sPassword`, `deptCode`, `sPhone`) VALUES
('S0000001', 'Admin01', 'Admin001', 'D01', '12345678'),
('S0000002', 'Sales01', 'Sales001', 'D02', '22345678'),
('S0000003', 'Production01', 'Production001', 'D03', '33345678'),
('S0000004', 'Inventory01', 'Inventory001', 'D04', '44445678'),
('S0000005', 'Logistic01', 'Logistic001', 'D05', '55555678'),
('S0000006', 'Design01', 'Design001', 'D06', '66666678');

CREATE TABLE `status` (
  `statusCode` char(4) NOT NULL,
  `statusDesc` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

INSERT INTO `status` (`statusCode`, `statusDesc`) VALUES
('ST01', 'Pending'),
('ST02', 'In Production'),
('ST03', 'In Transit'),
('ST04', 'Delivered'),
('ST05', 'Failed'),
('ST06', 'Cancel');


ALTER TABLE `customers`
  ADD PRIMARY KEY (`cUserID`);

ALTER TABLE `customfurniture`
  ADD PRIMARY KEY (`cfID`),
  ADD KEY `CF_fk_cUserID` (`cUserID`),
  ADD KEY `CF_fk_fType` (`fType`);

ALTER TABLE `customfurniturerequest`
  ADD PRIMARY KEY (`cfrID`);

ALTER TABLE `customorders`
  ADD PRIMARY KEY (`corderID`),
  ADD KEY `fk_cfid` (`cfID`),
  ADD KEY `fk_cUserID` (`cUserID`),
  ADD KEY `fk_ShippingID` (`shippingType`),
  ADD KEY `fk_Status` (`statusType`);

ALTER TABLE `department`
  ADD PRIMARY KEY (`deptCode`);

ALTER TABLE `furniture`
  ADD PRIMARY KEY (`fID`),
  ADD KEY `fk_fType` (`fType`);

ALTER TABLE `furniturematerials`
  ADD PRIMARY KEY (`fID`,`materialCode`),
  ADD KEY `FM_fk_materialCode` (`materialCode`);

ALTER TABLE `furnituretype`
  ADD PRIMARY KEY (`fType`);

ALTER TABLE `material`
  ADD PRIMARY KEY (`materialCode`);

ALTER TABLE `materialrequest`
  ADD PRIMARY KEY (`mrID`,`materialCode`),
  ADD KEY `fk_staffID` (`sUserID`);

ALTER TABLE `orders`
  ADD PRIMARY KEY (`orderID`,`fID`),
  ADD KEY `fk_fid` (`fID`),
  ADD KEY `fk_cid` (`cUserID`),
  ADD KEY `fk_shippingType` (`shippingType`),
  ADD KEY `fk_statusType` (`statusType`);

ALTER TABLE `shippingoption`
  ADD PRIMARY KEY (`soId`);

ALTER TABLE `staff`
  ADD PRIMARY KEY (`sUserID`),
  ADD KEY `fk_dept` (`deptCode`);

ALTER TABLE `status`
  ADD PRIMARY KEY (`statusCode`);


ALTER TABLE `customfurniture`
  ADD CONSTRAINT `CF_fk_cUserID` FOREIGN KEY (`cUserID`) REFERENCES `customers` (`cUserID`),
  ADD CONSTRAINT `CF_fk_fType` FOREIGN KEY (`fType`) REFERENCES `furnituretype` (`fType`);

ALTER TABLE `customorders`
  ADD CONSTRAINT `fk_ShippingID` FOREIGN KEY (`shippingType`) REFERENCES `shippingoption` (`soId`),
  ADD CONSTRAINT `fk_Status` FOREIGN KEY (`statusType`) REFERENCES `status` (`statusCode`),
  ADD CONSTRAINT `fk_cUserID` FOREIGN KEY (`cUserID`) REFERENCES `customers` (`cUserID`),
  ADD CONSTRAINT `fk_cfid` FOREIGN KEY (`cfID`) REFERENCES `customfurniture` (`cfID`);

ALTER TABLE `furniture`
  ADD CONSTRAINT `fk_fType` FOREIGN KEY (`fType`) REFERENCES `furnituretype` (`fType`);

ALTER TABLE `furniturematerials`
  ADD CONSTRAINT `FM_fk_fid` FOREIGN KEY (`fID`) REFERENCES `furniture` (`fID`),
  ADD CONSTRAINT `FM_fk_materialCode` FOREIGN KEY (`materialCode`) REFERENCES `material` (`materialCode`);

ALTER TABLE `orders`
  ADD CONSTRAINT `fk_cid` FOREIGN KEY (`cUserID`) REFERENCES `customers` (`cUserID`),
  ADD CONSTRAINT `fk_fid` FOREIGN KEY (`fID`) REFERENCES `furniture` (`fID`),
  ADD CONSTRAINT `fk_shippingType` FOREIGN KEY (`shippingType`) REFERENCES `shippingoption` (`soId`),
  ADD CONSTRAINT `fk_statusType` FOREIGN KEY (`statusType`) REFERENCES `status` (`statusCode`);

ALTER TABLE `staff`
  ADD CONSTRAINT `fk_dept` FOREIGN KEY (`deptCode`) REFERENCES `department` (`deptCode`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

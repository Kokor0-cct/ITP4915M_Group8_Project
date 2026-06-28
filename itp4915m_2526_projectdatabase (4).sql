-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- 主机： 127.0.0.1
-- 生成日期： 2026-06-28 14:21:08
-- 服务器版本： 10.4.32-MariaDB
-- PHP 版本： 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- 数据库： `itp4915m_2526_projectdatabase`
--

-- --------------------------------------------------------

--
-- 表的结构 `customers`
--

CREATE TABLE `customers` (
  `cUserID` char(8) NOT NULL,
  `cName` varchar(30) NOT NULL,
  `cPhone` varchar(20) NOT NULL,
  `cPassword` varchar(20) NOT NULL,
  `cAddress` varchar(255) NOT NULL,
  `company` varchar(255) DEFAULT NULL,
  `cBudget` int(11) DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- 转存表中的数据 `customers`
--

INSERT INTO `customers` (`cUserID`, `cName`, `cPhone`, `cPassword`, `cAddress`, `company`, `cBudget`) VALUES
('C0000001', 'taiman', '23456789', 'cust123', 'Flat A, 12/F, Sunshine Building, Mong Kok, Kowloon', 'ABC Trading Ltd.', 31301),
('C0000002', 'siuming', '98765432', 'cust456', 'Room 8, 3/F, Harbour View Court, Tsuen Wan, New Territories', NULL, 0);

-- --------------------------------------------------------

--
-- 表的结构 `customfurniture`
--

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

--
-- 转存表中的数据 `customfurniture`
--

INSERT INTO `customfurniture` (`cfID`, `cUserID`, `cfrID`, `cfName`, `fType`, `cfprice`, `cfDesc`, `cfState`) VALUES
('CF000001', 'C0000001', 'CFR00001', 'Fabric Dining Table', 'FT02', 3500.00, '8-seater dining table, perfect for families.', 'Design pending'),
('CF000002', 'C0000002', 'CFR00002', 'YOU KNOW WHO???', 'FT01', 2500.00, 'YOU KNWO WHO?????', 'Design completed'),
('CF000003', 'C0000001', 'CFR00003', 'test3', 'FT03', 20.00, 'test3', 'Design completed'),
('CF000004', 'C0000001', 'CFR00004', 'asd', 'FT04', 123.00, '123', 'Pending approval');

-- --------------------------------------------------------

--
-- 表的结构 `customfurniturerequest`
--

CREATE TABLE `customfurniturerequest` (
  `cfrID` char(8) NOT NULL,
  `cUserID` char(8) NOT NULL,
  `fType` char(4) NOT NULL,
  `cfrBudget` int(11) NOT NULL,
  `cfrDESC` text NOT NULL,
  `cfrCreateDate` date NOT NULL,
  `Completed` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- 转存表中的数据 `customfurniturerequest`
--

INSERT INTO `customfurniturerequest` (`cfrID`, `cUserID`, `fType`, `cfrBudget`, `cfrDESC`, `cfrCreateDate`, `Completed`) VALUES
('CFR00001', 'C0000001', 'FT02', 4500, 'you kown who ?', '2025-01-01', 0),
('CFR00002', 'C0000001', 'FT01', 2500, 'you kown who ?2.0', '2025-01-02', 1),
('CFR00003', 'C0000001', 'FT03', 1500, 'you kown who ?3.0', '2025-01-02', 1),
('CFR00004', 'C0000001', 'FT04', 100, 'asdasdasdasd\nSize: L=100,W=100,H=100', '2026-06-28', 1);

-- --------------------------------------------------------

--
-- 表的结构 `customorders`
--

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
  `statusType` char(4) NOT NULL,
  `StaffNote` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- 转存表中的数据 `customorders`
--

INSERT INTO `customorders` (`corderID`, `cfID`, `Quantity`, `cUserID`, `coAmount`, `codeliverydate`, `coCreateDate`, `codeliveryaddress`, `shippingType`, `statusType`, `StaffNote`) VALUES
('CO000001', 'CF000003', 1, 'C0000001', 70.00, '2026-06-28', '2026-06-28', 'Flat A, 12/F, Sunshine Building, Mong Kok, Kowloon', 'SO01', 'ST09', NULL),
('CO000002', 'CF000003', 1, 'C0000001', 70.00, '2026-06-28', '2026-06-28', 'Flat A, 12/F, Sunshine Building, Mong Kok, Kowloon', 'SO01', 'ST01', NULL),
('CO000003', 'CF000003', 1, 'C0000001', 70.00, '2026-06-28', '2026-06-28', 'Flat A, 12/F, Sunshine Building, Mong Kok, Kowloon', 'SO01', 'ST12', NULL);

-- --------------------------------------------------------

--
-- 表的结构 `customrequestmaterials`
--

CREATE TABLE `customrequestmaterials` (
  `cfrID` char(8) NOT NULL,
  `mid` char(5) NOT NULL,
  `pmqty` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- 转存表中的数据 `customrequestmaterials`
--

INSERT INTO `customrequestmaterials` (`cfrID`, `mid`, `pmqty`) VALUES
('CF000004', 'M0002', 2),
('CF000004', 'M0003', 1);

-- --------------------------------------------------------

--
-- 表的结构 `department`
--

CREATE TABLE `department` (
  `deptCode` char(3) NOT NULL,
  `deptName` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- 转存表中的数据 `department`
--

INSERT INTO `department` (`deptCode`, `deptName`) VALUES
('D01', 'Admin'),
('D02', 'Sales'),
('D03', 'Production'),
('D04', 'Inventory'),
('D05', 'Logistic'),
('D06', 'Design');

-- --------------------------------------------------------

--
-- 表的结构 `furniture`
--

CREATE TABLE `furniture` (
  `fID` char(9) NOT NULL,
  `fName` varchar(50) NOT NULL,
  `fQuantity` int(10) NOT NULL DEFAULT 0,
  `fType` char(4) NOT NULL,
  `fprice` decimal(8,2) NOT NULL,
  `fDesc` text NOT NULL,
  `fImgPath` varchar(200) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- 转存表中的数据 `furniture`
--

INSERT INTO `furniture` (`fID`, `fName`, `fQuantity`, `fType`, `fprice`, `fDesc`, `fImgPath`) VALUES
('F00000001', 'Oak Dining Chair', 120, 'FT02', 450.00, 'Classic style dining chair made of solid oak.', '../../../IMG/Oak_Dining_Chair.png'),
('F00000002', 'Large Dining Table', 350, 'FT01', 2500.00, '6-seater dining table, perfect for families.', '../../../IMG/Large Dining Table.png'),
('F00000003', '3-Seater Fabric Sofa', 350, 'FT03', 3800.00, 'Comfortable grey fabric sofa with foam filling.', '../../../IMG/3-Seater Fabric Sofa.png'),
('F00000004', 'Wooden Wardrobe', 330, 'FT05', 1800.00, 'Double door wardrobe with hanging space.', '../../../IMG/Wooden Wardrobe.png'),
('F00000005', 'Industrial Bookshelf', 38, 'FT04', 1200.00, 'Modern style bookshelf with steel frame.', '../../../IMG/Industrial Bookshelf.png'),
('F00000006', 'Queen Size Bed Frame', 229, 'FT06', 2200.00, 'Sturdy bed frame for queen size mattress.', '../../../IMG/Queen Size Bed Frame.png');

-- --------------------------------------------------------

--
-- 表的结构 `furniturematerials`
--

CREATE TABLE `furniturematerials` (
  `fID` char(9) NOT NULL,
  `materialCode` char(5) NOT NULL,
  `pmqty` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- 转存表中的数据 `furniturematerials`
--

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

-- --------------------------------------------------------

--
-- 表的结构 `furnituretype`
--

CREATE TABLE `furnituretype` (
  `fType` char(4) NOT NULL,
  `typeName` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- 转存表中的数据 `furnituretype`
--

INSERT INTO `furnituretype` (`fType`, `typeName`) VALUES
('FT01', 'Table'),
('FT02', 'Chair'),
('FT03', 'Sofa'),
('FT04', 'Shelf'),
('FT05', 'Wardrobe'),
('FT06', 'Bed');

-- --------------------------------------------------------

--
-- 表的结构 `material`
--

CREATE TABLE `material` (
  `materialCode` char(5) NOT NULL,
  `mName` varchar(30) NOT NULL,
  `mQuantity` int(10) NOT NULL DEFAULT 0,
  `PerUnitPrice` int(11) NOT NULL,
  `munit` varchar(18) NOT NULL,
  `supplier` varchar(200) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- 转存表中的数据 `material`
--

INSERT INTO `material` (`materialCode`, `mName`, `mQuantity`, `PerUnitPrice`, `munit`, `supplier`) VALUES
('M0001', 'Oak Wood Plank', 405, 20, 'pcs', 'Shenzhen Hengshun Hardware Materials Co., Ltd.'),
('M0002', 'Steel Tube', 204, 50, 'meter', 'Dongguan Shengda Plastic Raw Materials Co., Ltd.'),
('M0003', 'Fabric Cloth', 74, 10, 'meter', 'Dongguan Shengda Plastic Raw Materials Co., Ltd.'),
('M0004', 'High Density Foam', 50, 120, 'block', 'Foshan Lianxin Packaging Materials Co., Ltd.');

-- --------------------------------------------------------

--
-- 表的结构 `materialreport`
--

CREATE TABLE `materialreport` (
  `mReportID` int(11) NOT NULL,
  `mid` char(5) NOT NULL,
  `qty` int(20) NOT NULL,
  `createDate` datetime NOT NULL DEFAULT current_timestamp(),
  `StaffNote` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- 转存表中的数据 `materialreport`
--

INSERT INTO `materialreport` (`mReportID`, `mid`, `qty`, `createDate`, `StaffNote`) VALUES
(1, 'M0001', 5, '2026-06-28 16:50:08', NULL),
(2, 'M0003', 4, '2026-06-28 16:50:08', NULL),
(3, 'M0002', 5, '2026-06-28 16:54:42', NULL),
(4, 'M0003', 3, '2026-06-28 16:54:43', NULL),
(5, 'M0001', -50, '2026-06-28 20:20:37', NULL),
(6, 'M0003', -20, '2026-06-28 20:20:37', NULL);

-- --------------------------------------------------------

--
-- 表的结构 `materialrequest`
--

CREATE TABLE `materialrequest` (
  `mrID` char(10) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `createDate` date NOT NULL DEFAULT current_timestamp(),
  `sUserID` char(8) NOT NULL,
  `materialCode` char(5) NOT NULL,
  `mrQuantity` int(20) NOT NULL,
  `UrgencyLevel` enum('Low','Medium','High') NOT NULL,
  `RequiredDate` date NOT NULL,
  `mrdeliveryaddress` text NOT NULL,
  `statusType` char(4) DEFAULT 'ST01'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- 转存表中的数据 `materialrequest`
--

INSERT INTO `materialrequest` (`mrID`, `createDate`, `sUserID`, `materialCode`, `mrQuantity`, `UrgencyLevel`, `RequiredDate`, `mrdeliveryaddress`, `statusType`) VALUES
('MR00000001', '2026-06-28', 'S0000001', 'M0001', 50, 'Low', '2026-07-02', 'Production Site 1', 'ST02'),
('MR00000001', '2026-06-28', 'S0000001', 'M0003', 20, 'Low', '2026-07-02', 'Production Site 1', 'ST02'),
('MR00000002', '2026-06-28', 'S0000001', 'M0002', 1, 'Low', '2026-07-22', 'Production Site 1', 'ST01');

-- --------------------------------------------------------

--
-- 表的结构 `orders`
--

CREATE TABLE `orders` (
  `orderID` char(8) NOT NULL,
  `fID` char(9) NOT NULL,
  `Quantity` int(10) NOT NULL,
  `cUserID` char(8) NOT NULL,
  `oAmount` decimal(10,2) NOT NULL,
  `odeliverydate` date NOT NULL,
  `oCreateDate` date NOT NULL DEFAULT current_timestamp(),
  `odeliveryaddress` text NOT NULL,
  `shippingType` char(4) NOT NULL,
  `statusType` char(4) NOT NULL,
  `StaffNote` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- 转存表中的数据 `orders`
--

INSERT INTO `orders` (`orderID`, `fID`, `Quantity`, `cUserID`, `oAmount`, `odeliverydate`, `oCreateDate`, `odeliveryaddress`, `shippingType`, `statusType`, `StaffNote`) VALUES
('O0000001', 'F00000001', 1, 'C0000001', 450.00, '2026-04-10', '2026-04-09', 'Flat A, 133/F, Sunshine Building, Mong Kok, Kowloon', 'SO02', 'ST11', NULL),
('O0000002', 'F00000002', 1, 'C0000001', 2500.00, '2026-04-12', '2026-04-10', 'Flat B, 133/F, Sunshine Building, Mong Kok, Kowloon', 'SO01', 'ST11', NULL),
('O0000003', 'F00000001', 12, 'C0000001', 5550.00, '2026-06-18', '2026-06-18', 'Flat A, 12/F, Sunshine Building, Mong Kok, Kowloon', 'SO02', 'ST11', NULL),
('O0000004', 'F00000001', 2, 'C0000001', 950.00, '2026-07-03', '2026-06-27', 'Flat A, 12/F, Sunshine Building, Mong Kok, Kowloon', 'SO01', 'ST11', NULL),
('O0000004', 'F00000002', 2, 'C0000001', 5050.00, '2026-07-03', '2026-06-27', 'Flat A, 12/F, Sunshine Building, Mong Kok, Kowloon', 'SO01', 'ST11', NULL),
('O0000005', 'F00000005', 12, 'C0000001', 14450.00, '2026-07-03', '2026-06-27', 'Flat A, 12/F, Sunshine Building, Mong Kok, Kowloon', 'SO01', 'ST12', NULL),
('O0000005', 'F00000006', 1, 'C0000001', 2250.00, '2026-07-03', '2026-06-27', 'Flat A, 12/F, Sunshine Building, Mong Kok, Kowloon', 'SO01', 'ST12', NULL);

-- --------------------------------------------------------

--
-- 表的结构 `returnreplacerequest`
--

CREATE TABLE `returnreplacerequest` (
  `rid` char(11) NOT NULL,
  `oid` char(8) NOT NULL,
  `fid` char(9) NOT NULL,
  `rCreateDate` datetime NOT NULL,
  `cid` char(8) NOT NULL,
  `rType` enum('Refund','Replace') NOT NULL,
  `rDESC` text NOT NULL,
  `statusType` enum('Pending','Rejected','Accept') NOT NULL DEFAULT 'Pending'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- 转存表中的数据 `returnreplacerequest`
--

INSERT INTO `returnreplacerequest` (`rid`, `oid`, `fid`, `rCreateDate`, `cid`, `rType`, `rDESC`, `statusType`) VALUES
('RPR00000001', 'O0000004', 'F00000002', '2026-06-28 19:13:19', 'C0000001', 'Replace', '123123', 'Pending'),
('RPR00000002', 'O0000003', 'F00000001', '2026-06-28 19:15:26', 'C0000001', 'Replace', '123123', 'Pending'),
('RPR00000003', 'CO000005', 'CF000003', '2026-06-28 19:15:34', 'C0000001', 'Refund', '123123', 'Rejected'),
('RPR00000004', 'CO000006', 'CF000003', '2026-06-28 19:15:42', 'C0000001', 'Replace', '123123', 'Accept');

-- --------------------------------------------------------

--
-- 表的结构 `salesreport`
--

CREATE TABLE `salesreport` (
  `salesID` int(11) NOT NULL,
  `Amount` int(11) NOT NULL,
  `createDate` datetime NOT NULL,
  `StaffNote` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- 转存表中的数据 `salesreport`
--

INSERT INTO `salesreport` (`salesID`, `Amount`, `createDate`, `StaffNote`) VALUES
(1, 123, '2026-06-28 05:20:30', NULL),
(2, -87, '2026-06-28 05:20:39', NULL);

-- --------------------------------------------------------

--
-- 表的结构 `shippingoption`
--

CREATE TABLE `shippingoption` (
  `soId` char(4) NOT NULL,
  `soName` varchar(20) NOT NULL,
  `Charge` decimal(5,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- 转存表中的数据 `shippingoption`
--

INSERT INTO `shippingoption` (`soId`, `soName`, `Charge`) VALUES
('SO01', 'Ordinary Transport', 50.00),
('SO02', 'Express Shipping', 100.00);

-- --------------------------------------------------------

--
-- 表的结构 `shippingrequest`
--

CREATE TABLE `shippingrequest` (
  `SRID` char(10) NOT NULL,
  `IID` varchar(10) NOT NULL,
  `createDate` date NOT NULL DEFAULT current_timestamp(),
  `deliveryDate` date NOT NULL,
  `collectAddress` text NOT NULL,
  `deliveryAddress` text NOT NULL,
  `statusType` char(4) NOT NULL DEFAULT 'ST05'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- 转存表中的数据 `shippingrequest`
--

INSERT INTO `shippingrequest` (`SRID`, `IID`, `createDate`, `deliveryDate`, `collectAddress`, `deliveryAddress`, `statusType`) VALUES
('SR00000001', 'O0000001', '2026-06-27', '2026-08-28', 'Caddress', 'Daddress', 'ST05'),
('SR00000002', 'CF000001', '2026-06-27', '2026-07-16', 'Caddress', 'Daddress', 'ST05'),
('SR00000003', 'MR00000001', '2026-06-27', '2026-12-03', 'Caddress', 'Daddress', 'ST05'),
('SR00000004', 'CO000008', '2026-06-28', '2026-07-04', 'Warehouse 1', 'Flat A, 12/F, Sunshine Building, Mong Kok, Kowloon', 'ST05');

-- --------------------------------------------------------

--
-- 表的结构 `staff`
--

CREATE TABLE `staff` (
  `sUserID` char(8) NOT NULL,
  `sName` varchar(30) NOT NULL,
  `sPassword` varchar(20) NOT NULL,
  `deptCode` char(3) NOT NULL,
  `sPhone` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- 转存表中的数据 `staff`
--

INSERT INTO `staff` (`sUserID`, `sName`, `sPassword`, `deptCode`, `sPhone`) VALUES
('S0000001', 'Admin01', 'Admin001', 'D01', '12345678'),
('S0000002', 'Sales01', 'Sales001', 'D02', '22345678'),
('S0000003', 'Production01', 'Production001', 'D03', '33345678'),
('S0000004', 'Inventory01', 'Inventory001', 'D04', '44445678'),
('S0000005', 'Logistic01', 'Logistic001', 'D05', '55555678'),
('S0000006', 'Design01', 'Design001', 'D06', '66666678');

-- --------------------------------------------------------

--
-- 表的结构 `status`
--

CREATE TABLE `status` (
  `statusCode` char(4) NOT NULL,
  `statusDesc` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- 转存表中的数据 `status`
--

INSERT INTO `status` (`statusCode`, `statusDesc`) VALUES
('ST01', 'Pending'),
('ST02', 'Accepted'),
('ST03', 'In Production'),
('ST04', 'Produced'),
('ST05', 'Waiting for Delivery'),
('ST06', 'In Transit'),
('ST07', 'Delivered'),
('ST08', 'Failed'),
('ST09', 'Completed'),
('ST10', 'Cancelled'),
('ST11', 'Under review'),
('ST12', 'Refund'),
('ST13', 'Replace');

-- --------------------------------------------------------

--
-- 表的结构 `support_messages`
--

CREATE TABLE `support_messages` (
  `msg_id` int(11) NOT NULL,
  `cid` char(8) NOT NULL,
  `sid` char(8) DEFAULT NULL,
  `sender_type` enum('customer','staff') NOT NULL,
  `message` text NOT NULL,
  `created_at` datetime NOT NULL DEFAULT current_timestamp(),
  `isRead` int(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- 转存表中的数据 `support_messages`
--

INSERT INTO `support_messages` (`msg_id`, `cid`, `sid`, `sender_type`, `message`, `created_at`, `isRead`) VALUES
(7, 'C0000001', NULL, 'customer', 'hi', '2026-06-27 19:50:20', 0),
(8, 'C0000001', NULL, 'customer', 'Please edit your requirements.', '2026-06-27 20:06:43', 0),
(9, 'C0000001', 'S0000001', 'staff', 'hi', '2026-06-27 21:04:09', 0),
(10, 'C0000001', 'S0000001', 'staff', 'why', '2026-06-27 21:05:25', 0),
(11, 'C0000001', NULL, 'customer', '为什么了', '2026-06-27 21:18:12', 0),
(12, 'C0000001', 'S0000001', 'staff', 'hi', '2026-06-27 22:22:11', 0),
(13, 'C0000002', NULL, 'customer', 'ii love you', '2026-06-27 22:23:49', 0),
(14, 'C0000002', 'S0000002', 'staff', 'no!', '2026-06-27 22:24:12', 0);

--
-- 转储表的索引
--

--
-- 表的索引 `customers`
--
ALTER TABLE `customers`
  ADD PRIMARY KEY (`cUserID`);

--
-- 表的索引 `customfurniture`
--
ALTER TABLE `customfurniture`
  ADD PRIMARY KEY (`cfID`),
  ADD KEY `CF_fk_cUserID` (`cUserID`),
  ADD KEY `CF_fk_fType` (`fType`);

--
-- 表的索引 `customfurniturerequest`
--
ALTER TABLE `customfurniturerequest`
  ADD PRIMARY KEY (`cfrID`);

--
-- 表的索引 `customorders`
--
ALTER TABLE `customorders`
  ADD PRIMARY KEY (`corderID`),
  ADD KEY `fk_cfid` (`cfID`),
  ADD KEY `fk_cUserID` (`cUserID`),
  ADD KEY `fk_ShippingID` (`shippingType`),
  ADD KEY `fk_Status` (`statusType`);

--
-- 表的索引 `customrequestmaterials`
--
ALTER TABLE `customrequestmaterials`
  ADD PRIMARY KEY (`cfrID`,`mid`);

--
-- 表的索引 `department`
--
ALTER TABLE `department`
  ADD PRIMARY KEY (`deptCode`);

--
-- 表的索引 `furniture`
--
ALTER TABLE `furniture`
  ADD PRIMARY KEY (`fID`),
  ADD KEY `fk_fType` (`fType`);

--
-- 表的索引 `furniturematerials`
--
ALTER TABLE `furniturematerials`
  ADD PRIMARY KEY (`fID`,`materialCode`),
  ADD KEY `FM_fk_materialCode` (`materialCode`);

--
-- 表的索引 `furnituretype`
--
ALTER TABLE `furnituretype`
  ADD PRIMARY KEY (`fType`);

--
-- 表的索引 `material`
--
ALTER TABLE `material`
  ADD PRIMARY KEY (`materialCode`);

--
-- 表的索引 `materialreport`
--
ALTER TABLE `materialreport`
  ADD PRIMARY KEY (`mReportID`);

--
-- 表的索引 `materialrequest`
--
ALTER TABLE `materialrequest`
  ADD PRIMARY KEY (`mrID`,`materialCode`),
  ADD KEY `fk_staffID` (`sUserID`);

--
-- 表的索引 `orders`
--
ALTER TABLE `orders`
  ADD PRIMARY KEY (`orderID`,`fID`),
  ADD KEY `fk_fid` (`fID`),
  ADD KEY `fk_cid` (`cUserID`),
  ADD KEY `fk_shippingType` (`shippingType`),
  ADD KEY `fk_statusType` (`statusType`);

--
-- 表的索引 `returnreplacerequest`
--
ALTER TABLE `returnreplacerequest`
  ADD PRIMARY KEY (`rid`),
  ADD KEY `fk_rpr_cid` (`cid`);

--
-- 表的索引 `salesreport`
--
ALTER TABLE `salesreport`
  ADD PRIMARY KEY (`salesID`);

--
-- 表的索引 `shippingoption`
--
ALTER TABLE `shippingoption`
  ADD PRIMARY KEY (`soId`);

--
-- 表的索引 `shippingrequest`
--
ALTER TABLE `shippingrequest`
  ADD PRIMARY KEY (`SRID`),
  ADD UNIQUE KEY `IID` (`IID`);

--
-- 表的索引 `staff`
--
ALTER TABLE `staff`
  ADD PRIMARY KEY (`sUserID`),
  ADD KEY `fk_dept` (`deptCode`);

--
-- 表的索引 `status`
--
ALTER TABLE `status`
  ADD PRIMARY KEY (`statusCode`);

--
-- 表的索引 `support_messages`
--
ALTER TABLE `support_messages`
  ADD PRIMARY KEY (`msg_id`),
  ADD KEY `fk_sm_cid` (`cid`),
  ADD KEY `fk_sm_sid` (`sid`);

--
-- 在导出的表使用AUTO_INCREMENT
--

--
-- 使用表AUTO_INCREMENT `materialreport`
--
ALTER TABLE `materialreport`
  MODIFY `mReportID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- 使用表AUTO_INCREMENT `salesreport`
--
ALTER TABLE `salesreport`
  MODIFY `salesID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- 使用表AUTO_INCREMENT `support_messages`
--
ALTER TABLE `support_messages`
  MODIFY `msg_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=15;

--
-- 限制导出的表
--

--
-- 限制表 `customfurniture`
--
ALTER TABLE `customfurniture`
  ADD CONSTRAINT `CF_fk_cUserID` FOREIGN KEY (`cUserID`) REFERENCES `customers` (`cUserID`),
  ADD CONSTRAINT `CF_fk_fType` FOREIGN KEY (`fType`) REFERENCES `furnituretype` (`fType`);

--
-- 限制表 `furniture`
--
ALTER TABLE `furniture`
  ADD CONSTRAINT `fk_fType` FOREIGN KEY (`fType`) REFERENCES `furnituretype` (`fType`);

--
-- 限制表 `furniturematerials`
--
ALTER TABLE `furniturematerials`
  ADD CONSTRAINT `FM_fk_fid` FOREIGN KEY (`fID`) REFERENCES `furniture` (`fID`),
  ADD CONSTRAINT `FM_fk_materialCode` FOREIGN KEY (`materialCode`) REFERENCES `material` (`materialCode`);

--
-- 限制表 `returnreplacerequest`
--
ALTER TABLE `returnreplacerequest`
  ADD CONSTRAINT `fk_rpr_cid` FOREIGN KEY (`cid`) REFERENCES `customers` (`cUserID`);

--
-- 限制表 `staff`
--
ALTER TABLE `staff`
  ADD CONSTRAINT `fk_dept` FOREIGN KEY (`deptCode`) REFERENCES `department` (`deptCode`);

--
-- 限制表 `support_messages`
--
ALTER TABLE `support_messages`
  ADD CONSTRAINT `fk_sm_cid` FOREIGN KEY (`cid`) REFERENCES `customers` (`cUserID`),
  ADD CONSTRAINT `fk_sm_sid` FOREIGN KEY (`sid`) REFERENCES `staff` (`sUserID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

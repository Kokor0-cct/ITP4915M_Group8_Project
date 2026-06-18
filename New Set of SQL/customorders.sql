-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- 主机： 127.0.0.1
-- 生成日期： 2026-06-18 13:53:27
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
  `statusType` char(4) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- 转存表中的数据 `customorders`
--

INSERT INTO `customorders` (`corderID`, `cfID`, `Quantity`, `cUserID`, `coAmount`, `codeliverydate`, `coCreateDate`, `codeliveryaddress`, `shippingType`, `statusType`) VALUES
('CO000001', 'CF000001', 1, 'C0000001', 2500.00, '2026-04-12', '2026-04-10', 'Flat B, 133/F, Sunshine Building, Mong Kok, Kowloon', 'SO01', 'ST05'),
('CO000002', 'CF000003', 2, 'C0000001', 190.00, '2027-02-20', '2026-06-18', 'Flat A, 12/F, Sunshine Building, Mong Kok, Kowloon', 'SO02', 'ST02');

--
-- 转储表的索引
--

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
-- 限制导出的表
--

--
-- 限制表 `customorders`
--
ALTER TABLE `customorders`
  ADD CONSTRAINT `fk_ShippingID` FOREIGN KEY (`shippingType`) REFERENCES `shippingoption` (`soId`),
  ADD CONSTRAINT `fk_Status` FOREIGN KEY (`statusType`) REFERENCES `status` (`statusCode`),
  ADD CONSTRAINT `fk_cUserID` FOREIGN KEY (`cUserID`) REFERENCES `customers` (`cUserID`),
  ADD CONSTRAINT `fk_cfid` FOREIGN KEY (`cfID`) REFERENCES `customfurniture` (`cfID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

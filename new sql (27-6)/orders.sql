-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- 主机： 127.0.0.1
-- 生成日期： 2026-06-27 16:39:59
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
('O0000003', 'F00000001', 12, 'C0000001', 5550.00, '2026-06-18', '2026-06-18', 'Flat A, 12/F, Sunshine Building, Mong Kok, Kowloon', 'SO02', 'ST01', NULL),
('O0000004', 'F00000001', 2, 'C0000001', 950.00, '2026-07-03', '2026-06-27', 'Flat A, 12/F, Sunshine Building, Mong Kok, Kowloon', 'SO01', 'ST01', NULL),
('O0000004', 'F00000002', 2, 'C0000001', 5050.00, '2026-07-03', '2026-06-27', 'Flat A, 12/F, Sunshine Building, Mong Kok, Kowloon', 'SO01', 'ST01', NULL),
('O0000005', 'F00000005', 12, 'C0000001', 14450.00, '2026-07-03', '2026-06-27', 'Flat A, 12/F, Sunshine Building, Mong Kok, Kowloon', 'SO01', 'ST12', NULL),
('O0000005', 'F00000006', 1, 'C0000001', 2250.00, '2026-07-03', '2026-06-27', 'Flat A, 12/F, Sunshine Building, Mong Kok, Kowloon', 'SO01', 'ST12', NULL);

--
-- 转储表的索引
--

--
-- 表的索引 `orders`
--
ALTER TABLE `orders`
  ADD PRIMARY KEY (`orderID`,`fID`),
  ADD KEY `fk_fid` (`fID`),
  ADD KEY `fk_cid` (`cUserID`),
  ADD KEY `fk_shippingType` (`shippingType`),
  ADD KEY `fk_statusType` (`statusType`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

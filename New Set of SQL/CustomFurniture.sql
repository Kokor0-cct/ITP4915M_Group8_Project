-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- 主机： 127.0.0.1
-- 生成日期： 2026-06-18 13:53:10
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
('CF000003', 'C0000001', 'CFR00003', 'test3', 'FT03', 20.00, 'test3', 'Design completed');

--
-- 转储表的索引
--

--
-- 表的索引 `customfurniture`
--
ALTER TABLE `customfurniture`
  ADD PRIMARY KEY (`cfID`),
  ADD KEY `CF_fk_cUserID` (`cUserID`),
  ADD KEY `CF_fk_fType` (`fType`);

--
-- 限制导出的表
--

--
-- 限制表 `customfurniture`
--
ALTER TABLE `customfurniture`
  ADD CONSTRAINT `CF_fk_cUserID` FOREIGN KEY (`cUserID`) REFERENCES `customers` (`cUserID`),
  ADD CONSTRAINT `CF_fk_fType` FOREIGN KEY (`fType`) REFERENCES `furnituretype` (`fType`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- 主机： 127.0.0.1
-- 生成日期： 2026-06-27 16:38:59
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
('C0000001', 'taiman', '23456789', 'cust123', 'Flat A, 12/F, Sunshine Building, Mong Kok, Kowloon', 'ABC Trading Ltd.', 20100),
('C0000002', 'siuming', '98765432', 'cust456', 'Room 8, 3/F, Harbour View Court, Tsuen Wan, New Territories', NULL, 0);

--
-- 转储表的索引
--

--
-- 表的索引 `customers`
--
ALTER TABLE `customers`
  ADD PRIMARY KEY (`cUserID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

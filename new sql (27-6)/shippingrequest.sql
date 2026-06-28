-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- 主机： 127.0.0.1
-- 生成日期： 2026-06-27 16:40:21
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
('SR00000003', 'MR00000001', '2026-06-27', '2026-12-03', 'Caddress', 'Daddress', 'ST05');

--
-- 转储表的索引
--

--
-- 表的索引 `shippingrequest`
--
ALTER TABLE `shippingrequest`
  ADD PRIMARY KEY (`SRID`),
  ADD UNIQUE KEY `IID` (`IID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

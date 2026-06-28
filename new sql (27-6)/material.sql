-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- 主机： 127.0.0.1
-- 生成日期： 2026-06-27 16:39:45
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
-- 表的结构 `material`
--

CREATE TABLE `material` (
  `materialCode` char(5) NOT NULL,
  `mName` varchar(30) NOT NULL,
  `mQuantity` int(10) NOT NULL DEFAULT 0,
  `munit` varchar(18) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- 转存表中的数据 `material`
--

INSERT INTO `material` (`materialCode`, `mName`, `mQuantity`, `munit`) VALUES
('M0001', 'Oak Wood Plank', 500, 'pcs'),
('M0002', 'Steel Tube', 200, 'meter'),
('M0003', 'Fabric Cloth', 100, 'meter'),
('M0004', 'High Density Foam', 50, 'block');

--
-- 转储表的索引
--

--
-- 表的索引 `material`
--
ALTER TABLE `material`
  ADD PRIMARY KEY (`materialCode`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

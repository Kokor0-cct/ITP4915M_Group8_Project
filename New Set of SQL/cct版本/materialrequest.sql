-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- 主机： 127.0.0.1
-- 生成日期： 2026-06-18 13:53:57
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
-- 表的结构 `materialrequest`
--

CREATE TABLE `materialrequest` (
  `mrID` char(10) NOT NULL,
  `materialCode` char(5) NOT NULL,
  `mrQuantity` int(20) NOT NULL,
  `UrgencyLevel` enum('Low','Medium','High') NOT NULL,
  `createDate` date NOT NULL,
  `sUserID` char(8) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- 转存表中的数据 `materialrequest`
--

INSERT INTO `materialrequest` (`mrID`, `materialCode`, `mrQuantity`, `UrgencyLevel`, `createDate`, `sUserID`) VALUES
('MR00000001', 'M0001', 5, 'Medium', '2012-12-12', 'S0000001'),
('MR00000002', 'M0001', 2, 'Low', '2026-06-16', 'S0000001'),
('MR00000002', 'M0003', 1, 'Low', '2026-06-16', 'S0000001');

--
-- 转储表的索引
--

--
-- 表的索引 `materialrequest`
--
ALTER TABLE `materialrequest`
  ADD PRIMARY KEY (`mrID`,`materialCode`),
  ADD KEY `fk_staffID` (`sUserID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

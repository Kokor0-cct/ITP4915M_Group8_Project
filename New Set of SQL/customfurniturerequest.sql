-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- 主机： 127.0.0.1
-- 生成日期： 2026-06-18 13:53:23
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
('CFR00001', 'C0000001', 'FT02', 4500, 'you kown who ?', '2025-01-01', 1),
('CFR00002', 'C0000001', 'FT01', 2500, 'you kown who ?2.0', '2025-01-02', 1),
('CFR00003', 'C0000001', 'FT03', 1500, 'you kown who ?3.0', '2025-01-02', 1);

--
-- 转储表的索引
--

--
-- 表的索引 `customfurniturerequest`
--
ALTER TABLE `customfurniturerequest`
  ADD PRIMARY KEY (`cfrID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- 主机： 127.0.0.1
-- 生成日期： 2026-06-18 13:54:12
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

--
-- 转储表的索引
--

--
-- 表的索引 `staff`
--
ALTER TABLE `staff`
  ADD PRIMARY KEY (`sUserID`),
  ADD KEY `fk_dept` (`deptCode`);

--
-- 限制导出的表
--

--
-- 限制表 `staff`
--
ALTER TABLE `staff`
  ADD CONSTRAINT `fk_dept` FOREIGN KEY (`deptCode`) REFERENCES `department` (`deptCode`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

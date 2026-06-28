-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- 主机： 127.0.0.1
-- 生成日期： 2026-06-27 16:39:34
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

--
-- 转储表的索引
--

--
-- 表的索引 `furniturematerials`
--
ALTER TABLE `furniturematerials`
  ADD PRIMARY KEY (`fID`,`materialCode`),
  ADD KEY `FM_fk_materialCode` (`materialCode`);

--
-- 限制导出的表
--

--
-- 限制表 `furniturematerials`
--
ALTER TABLE `furniturematerials`
  ADD CONSTRAINT `FM_fk_fid` FOREIGN KEY (`fID`) REFERENCES `furniture` (`fID`),
  ADD CONSTRAINT `FM_fk_materialCode` FOREIGN KEY (`materialCode`) REFERENCES `material` (`materialCode`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

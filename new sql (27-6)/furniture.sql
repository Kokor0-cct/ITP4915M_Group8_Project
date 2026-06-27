-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- 主机： 127.0.0.1
-- 生成日期： 2026-06-27 16:39:29
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
-- 表的结构 `furniture`
--

CREATE TABLE `furniture` (
  `fID` char(9) NOT NULL,
  `fName` varchar(50) NOT NULL,
  `fQuantity` int(10) NOT NULL DEFAULT 0,
  `fType` char(4) NOT NULL,
  `fprice` decimal(8,2) NOT NULL,
  `fDesc` text NOT NULL,
  `fImgPath` varchar(200) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- 转存表中的数据 `furniture`
--

INSERT INTO `furniture` (`fID`, `fName`, `fQuantity`, `fType`, `fprice`, `fDesc`, `fImgPath`) VALUES
('F00000001', 'Oak Dining Chair', 106, 'FT02', 450.00, 'Classic style dining chair made of solid oak.', '../../../IMG/Oak_Dining_Chair.png'),
('F00000002', 'Large Dining Table', 348, 'FT01', 2500.00, '6-seater dining table, perfect for families.', '../../../IMG/Large Dining Table.png'),
('F00000003', '3-Seater Fabric Sofa', 350, 'FT03', 3800.00, 'Comfortable grey fabric sofa with foam filling.', '../../../IMG/3-Seater Fabric Sofa.png'),
('F00000004', 'Wooden Wardrobe', 330, 'FT05', 1800.00, 'Double door wardrobe with hanging space.', '../../../IMG/Wooden Wardrobe.png'),
('F00000005', 'Industrial Bookshelf', 38, 'FT04', 1200.00, 'Modern style bookshelf with steel frame.', '../../../IMG/Industrial Bookshelf.png'),
('F00000006', 'Queen Size Bed Frame', 229, 'FT06', 2200.00, 'Sturdy bed frame for queen size mattress.', '../../../IMG/Queen Size Bed Frame.png');

--
-- 转储表的索引
--

--
-- 表的索引 `furniture`
--
ALTER TABLE `furniture`
  ADD PRIMARY KEY (`fID`),
  ADD KEY `fk_fType` (`fType`);

--
-- 限制导出的表
--

--
-- 限制表 `furniture`
--
ALTER TABLE `furniture`
  ADD CONSTRAINT `fk_fType` FOREIGN KEY (`fType`) REFERENCES `furnituretype` (`fType`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

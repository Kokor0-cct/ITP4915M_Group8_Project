-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- 主机： 127.0.0.1
-- 生成日期： 2026-06-27 16:40:07
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
-- 表的结构 `returnreplacerequest`
--

CREATE TABLE `returnreplacerequest` (
  `rid` char(11) NOT NULL,
  `oid` char(8) NOT NULL,
  `fid` char(9) NOT NULL,
  `rCreateDate` datetime NOT NULL,
  `cid` char(8) NOT NULL,
  `rType` enum('Refund','Replace') NOT NULL,
  `rDESC` text NOT NULL,
  `statusType` enum('Pending','Rejected','Accept') NOT NULL DEFAULT 'Pending'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- 转储表的索引
--

--
-- 表的索引 `returnreplacerequest`
--
ALTER TABLE `returnreplacerequest`
  ADD PRIMARY KEY (`rid`),
  ADD KEY `fk_rpr_cid` (`cid`),
  ADD KEY `fk_rpr_oid` (`oid`),
  ADD KEY `fk_rpr_fid` (`fid`);

--
-- 限制导出的表
--

--
-- 限制表 `returnreplacerequest`
--
ALTER TABLE `returnreplacerequest`
  ADD CONSTRAINT `fk_rpr_cid` FOREIGN KEY (`cid`) REFERENCES `customers` (`cUserID`),
  ADD CONSTRAINT `fk_rpr_fid` FOREIGN KEY (`fid`) REFERENCES `furniture` (`fID`),
  ADD CONSTRAINT `fk_rpr_oid` FOREIGN KEY (`oid`) REFERENCES `orders` (`orderID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

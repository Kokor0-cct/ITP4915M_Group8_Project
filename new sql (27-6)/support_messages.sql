-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- 主机： 127.0.0.1
-- 生成日期： 2026-06-27 16:40:37
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
-- 表的结构 `support_messages`
--

CREATE TABLE `support_messages` (
  `msg_id` int(11) NOT NULL,
  `cid` char(8) NOT NULL,
  `sid` char(8) DEFAULT NULL,
  `sender_type` enum('customer','staff') NOT NULL,
  `message` text NOT NULL,
  `created_at` datetime NOT NULL DEFAULT current_timestamp(),
  `isRead` int(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- 转存表中的数据 `support_messages`
--

INSERT INTO `support_messages` (`msg_id`, `cid`, `sid`, `sender_type`, `message`, `created_at`, `isRead`) VALUES
(7, 'C0000001', NULL, 'customer', 'hi', '2026-06-27 19:50:20', 0),
(8, 'C0000001', NULL, 'customer', 'Please edit your requirements.', '2026-06-27 20:06:43', 0),
(9, 'C0000001', 'S0000001', 'staff', 'hi', '2026-06-27 21:04:09', 0),
(10, 'C0000001', 'S0000001', 'staff', 'why', '2026-06-27 21:05:25', 0),
(11, 'C0000001', NULL, 'customer', '为什么了', '2026-06-27 21:18:12', 0),
(12, 'C0000001', 'S0000001', 'staff', 'hi', '2026-06-27 22:22:11', 0),
(13, 'C0000002', NULL, 'customer', 'ii love you', '2026-06-27 22:23:49', 0),
(14, 'C0000002', 'S0000002', 'staff', 'no!', '2026-06-27 22:24:12', 0);

--
-- 转储表的索引
--

--
-- 表的索引 `support_messages`
--
ALTER TABLE `support_messages`
  ADD PRIMARY KEY (`msg_id`),
  ADD KEY `fk_sm_cid` (`cid`),
  ADD KEY `fk_sm_sid` (`sid`);

--
-- 在导出的表使用AUTO_INCREMENT
--

--
-- 使用表AUTO_INCREMENT `support_messages`
--
ALTER TABLE `support_messages`
  MODIFY `msg_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=15;

--
-- 限制导出的表
--

--
-- 限制表 `support_messages`
--
ALTER TABLE `support_messages`
  ADD CONSTRAINT `fk_sm_cid` FOREIGN KEY (`cid`) REFERENCES `customers` (`cUserID`),
  ADD CONSTRAINT `fk_sm_sid` FOREIGN KEY (`sid`) REFERENCES `staff` (`sUserID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

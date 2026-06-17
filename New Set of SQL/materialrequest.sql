SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;


DROP TABLE IF EXISTS `materialrequest`;
CREATE TABLE `materialrequest` (
  `mrID` char(10) NOT NULL,
  `materialCode` char(5) NOT NULL,
  `mrQuantity` int(20) NOT NULL,
  `UrgencyLevel` enum('Low','Medium','High') NOT NULL,
  `createDate` date NOT NULL,
  `sUserID` char(8) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

INSERT INTO `materialrequest` (`mrID`, `materialCode`, `mrQuantity`, `UrgencyLevel`, `createDate`, `sUserID`) VALUES
('MR00000001', 'M0001', 5, 'Medium', '2012-12-12', 'S0000001'),
('MR00000002', 'M0001', 2, 'Low', '2026-06-16', 'S0000001'),
('MR00000002', 'M0003', 1, 'Low', '2026-06-16', 'S0000001');


ALTER TABLE `materialrequest`
  ADD PRIMARY KEY (`mrID`,`materialCode`),
  ADD KEY `fk_mCode` (`materialCode`),
  ADD KEY `fk_staffID` (`sUserID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

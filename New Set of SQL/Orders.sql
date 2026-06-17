SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;


DROP TABLE IF EXISTS `orders`;
CREATE TABLE `orders` (
  `orderID` char(8) NOT NULL,
  `fID` char(9) NOT NULL,
  `Quantity` int(10) NOT NULL,
  `cUserID` char(8) NOT NULL,
  `oAmount` decimal(10,2) NOT NULL,
  `odeliverydate` date NOT NULL,
  `oCreateDate` date NOT NULL,
  `odeliveryaddress` text NOT NULL,
  `shippingType` char(4) NOT NULL,
  `statusType` char(4) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

INSERT INTO `orders` (`orderID`, `fID`, `Quantity`, `cUserID`, `oAmount`, `odeliverydate`, `oCreateDate`, `odeliveryaddress`, `shippingType`, `statusType`) VALUES
('O0000001', 'F00000001', 1, 'C0000001', 450.00, '2026-04-10', '2026-04-09', 'Flat A, 133/F, Sunshine Building, Mong Kok, Kowloon', 'SO02', 'ST01'),
('O0000002', 'F00000002', 1, 'C0000001', 2500.00, '2026-04-12', '2026-04-10', 'Flat B, 133/F, Sunshine Building, Mong Kok, Kowloon', 'SO01', 'ST05');


ALTER TABLE `orders`
  ADD PRIMARY KEY (`orderID`,`fID`),
  ADD KEY `fk_fid` (`fID`),
  ADD KEY `fk_cid` (`cUserID`),
  ADD KEY `fk_shippingType` (`shippingType`),
  ADD KEY `fk_statusType` (`statusType`);


ALTER TABLE `orders`
  ADD CONSTRAINT `fk_cid` FOREIGN KEY (`cUserID`) REFERENCES `customers` (`cUserID`),
  ADD CONSTRAINT `fk_fid` FOREIGN KEY (`fID`) REFERENCES `furniture` (`fID`),
  ADD CONSTRAINT `fk_shippingType` FOREIGN KEY (`shippingType`) REFERENCES `shippingoption` (`soId`),
  ADD CONSTRAINT `fk_statusType` FOREIGN KEY (`statusType`) REFERENCES `status` (`statusCode`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

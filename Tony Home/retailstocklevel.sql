-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jun 10, 2022 at 07:39 AM
-- Server version: 10.4.22-MariaDB
-- PHP Version: 8.1.2

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `betterlimited`
--

-- --------------------------------------------------------

--
-- Table structure for table `retailstocklevel`
--

CREATE TABLE `retailstocklevel` (
  `itemID` int(5) NOT NULL,
  `StoreID` int(5) NOT NULL,
  `Quantity` int(3) NOT NULL,
  `LowLevelQty` int(3) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `retailstocklevel`
--

INSERT INTO `retailstocklevel` (`itemID`, `StoreID`, `Quantity`, `LowLevelQty`) VALUES
(10001, 1, 20, 5),
(10002, 1, 3, 5),
(10003, 1, 12, 5),
(10004, 1, 24, 0),
(10005, 1, 0, 5),
(10006, 1, 27, 5);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `retailstocklevel`
--
ALTER TABLE `retailstocklevel`
  ADD PRIMARY KEY (`itemID`),
  ADD KEY `StoreID` (`StoreID`);

--
-- Constraints for dumped tables
--

--
-- Constraints for table `retailstocklevel`
--
ALTER TABLE `retailstocklevel`
  ADD CONSTRAINT `FK_itemIDrs` FOREIGN KEY (`itemID`) REFERENCES `item` (`ItemID`) ON DELETE CASCADE,
  ADD CONSTRAINT `retailstocklevel_ibfk_1` FOREIGN KEY (`StoreID`) REFERENCES `store` (`StoreID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

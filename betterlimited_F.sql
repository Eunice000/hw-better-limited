-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- 主機： 127.0.0.1
-- 產生時間： 2022-06-06 19:23:14
-- 伺服器版本： 10.4.24-MariaDB
-- PHP 版本： 7.4.29

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- 資料庫： `betterlimited`
--

-- --------------------------------------------------------

--
-- 資料表結構 `customer`
--

CREATE TABLE `customer` (
  `CustomerID` int(5) NOT NULL,
  `Name` varchar(20) NOT NULL,
  `Address` varchar(50) DEFAULT NULL,
  `Tel` int(8) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- 傾印資料表的資料 `customer`
--

INSERT INTO `customer` (`CustomerID`, `Name`, `Address`, `Tel`) VALUES
(10001, 'ABC', 'HK', 23984221),
(10002, 'Chan ', 'dasdasda@gmail.com', 32312123),
(10003, 'Chan', 'dasdasda@gmail.com', 6234232),
(10004, 'sdas', 'ytwghhfd@gmail.com', 32334123),
(10005, 'SDA', 'thgfhf@gmail.com', 32342123),
(10006, 'DAD', 'rthregh4ew@gmail.com', 3231223),
(10007, 'CADA', 'uikergt@gmail.com', 98888553),
(10008, 'SANASsdasgduj', 'kiewgu@gmail.com', 12378553),
(10009, 'GFS', 'kiegfhi@gmail.com', 12461233),
(10010, 'CVX', 'muiyuw@gmail.com', 97525356),
(10011, 'MID', '234612@gmail.com', 76431233),
(10012, 'Tony', 'dsjw22@gmail.com', 31289054);

-- --------------------------------------------------------

--
-- 資料表結構 `deliveryorder`
--

CREATE TABLE `deliveryorder` (
  `DeliveryID` int(5) NOT NULL,
  `SalesOrderID` int(5) NOT NULL,
  `DeliveryDate` date NOT NULL,
  `DeliveryTime` time NOT NULL,
  `DeliveryStatus` enum('pending','In-transit','delivered') NOT NULL DEFAULT 'pending'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- 傾印資料表的資料 `deliveryorder`
--

INSERT INTO `deliveryorder` (`DeliveryID`, `SalesOrderID`, `DeliveryDate`, `DeliveryTime`, `DeliveryStatus`) VALUES
(10001, 10001, '2022-06-04', '07:03:00', 'In-transit'),
(10004, 10001, '2022-06-14', '38:19:52', 'pending'),
(10005, 10001, '2022-06-15', '05:14:29', 'pending'),
(10006, 10001, '2022-06-29', '38:26:52', 'In-transit'),
(10007, 10001, '2022-06-29', '38:26:52', 'In-transit'),
(10008, 10001, '2022-06-29', '38:26:52', 'In-transit'),
(10009, 10001, '2022-06-29', '38:26:52', 'In-transit'),
(10010, 10001, '2022-06-29', '38:26:52', 'In-transit');

-- --------------------------------------------------------

--
-- 資料表結構 `deliveryorder_item`
--

CREATE TABLE `deliveryorder_item` (
  `DeliveryID` int(5) NOT NULL,
  `itemID` int(5) NOT NULL,
  `Qty` int(5) NOT NULL DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- 傾印資料表的資料 `deliveryorder_item`
--

INSERT INTO `deliveryorder_item` (`DeliveryID`, `itemID`, `Qty`) VALUES
(10005, 10004, 1),
(10006, 10006, 4),
(10010, 10003, 2);

-- --------------------------------------------------------

--
-- 資料表結構 `goodreturnnote`
--

CREATE TABLE `goodreturnnote` (
  `ReturnNoteID` int(5) NOT NULL,
  `SalesOrderID` int(5) NOT NULL,
  `SupplierID` int(5) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- 傾印資料表的資料 `goodreturnnote`
--

INSERT INTO `goodreturnnote` (`ReturnNoteID`, `SalesOrderID`, `SupplierID`) VALUES
(1, 10006, 10001),
(2, 10004, 10002),
(3, 10003, 10001);

-- --------------------------------------------------------

--
-- 資料表結構 `goodreturnnote_item`
--

CREATE TABLE `goodreturnnote_item` (
  `ReturnNoteID` int(5) NOT NULL,
  `ItemID` int(5) NOT NULL,
  `Qty` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- 傾印資料表的資料 `goodreturnnote_item`
--

INSERT INTO `goodreturnnote_item` (`ReturnNoteID`, `ItemID`, `Qty`) VALUES
(1, 10009, 231),
(3, 10009, 85),
(3, 10014, 13);

-- --------------------------------------------------------

--
-- 資料表結構 `goodsreceivednote`
--

CREATE TABLE `goodsreceivednote` (
  `ReceivedID` int(5) NOT NULL,
  `PurchaseOrderID` int(5) NOT NULL,
  `SupplierID` int(5) NOT NULL,
  `InboundDate` date NOT NULL,
  `InboundTime` time NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- 資料表結構 `installationorder`
--

CREATE TABLE `installationorder` (
  `InstallationID` int(5) NOT NULL,
  `SalesOrderID` int(5) NOT NULL,
  `InstallationDate` date NOT NULL,
  `InstallationTime` time NOT NULL,
  `InstallationStatus` enum('pending','installed') DEFAULT 'pending'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- 傾印資料表的資料 `installationorder`
--

INSERT INTO `installationorder` (`InstallationID`, `SalesOrderID`, `InstallationDate`, `InstallationTime`, `InstallationStatus`) VALUES
(10001, 10001, '2022-06-04', '08:35:00', 'pending'),
(10002, 10007, '2022-06-15', '00:15:01', 'installed'),
(10003, 10006, '2022-06-15', '00:15:01', 'installed'),
(10004, 10005, '2022-06-15', '00:15:01', 'installed'),
(10005, 10004, '2022-06-15', '00:15:01', 'installed'),
(10006, 10007, '2022-06-15', '00:15:01', 'installed'),
(10007, 10007, '2022-06-15', '00:15:01', 'installed');

-- --------------------------------------------------------

--
-- 資料表結構 `installationorder_item`
--

CREATE TABLE `installationorder_item` (
  `InstallationID` int(5) NOT NULL,
  `itemID` int(5) NOT NULL,
  `Qty` int(5) NOT NULL DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- 傾印資料表的資料 `installationorder_item`
--

INSERT INTO `installationorder_item` (`InstallationID`, `itemID`, `Qty`) VALUES
(10001, 10009, 1),
(10004, 10009, 13),
(10007, 10009, 13);

-- --------------------------------------------------------

--
-- 資料表結構 `inventorystocklevel`
--

CREATE TABLE `inventorystocklevel` (
  `itemID` int(5) NOT NULL,
  `itemName` varchar(10) NOT NULL,
  `Quantity` int(3) NOT NULL,
  `LowLevelQty` int(3) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- 傾印資料表的資料 `inventorystocklevel`
--

INSERT INTO `inventorystocklevel` (`itemID`, `itemName`, `Quantity`, `LowLevelQty`) VALUES
(10001, 'Iphone7', 20, 5),
(10002, 'Iphone8', 20, 5),
(10005, 'Iphone9', 7, 5),
(10008, 'Iphone12', 3, 5);

-- --------------------------------------------------------

--
-- 資料表結構 `item`
--

CREATE TABLE `item` (
  `ItemID` int(5) NOT NULL,
  `ItemCat` varchar(20) NOT NULL,
  `ItemName` varchar(20) NOT NULL,
  `ItemDesc` varchar(50) NOT NULL,
  `ItemImg` mediumblob DEFAULT NULL,
  `SalePrice` int(11) NOT NULL,
  `SupplierID` int(5) NOT NULL,
  `SupplierPrice` int(20) NOT NULL,
  `WarrantyMonth` int(11) NOT NULL,
  `AllowDelivery` enum('true','false') NOT NULL DEFAULT 'false'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- 傾印資料表的資料 `item`
--

INSERT INTO `item` (`ItemID`, `ItemCat`, `ItemName`, `ItemDesc`, `ItemImg`, `SalePrice`, `SupplierID`, `SupplierPrice`, `WarrantyMonth`, `AllowDelivery`) VALUES
(10001, 'phone', 'Iphone7', '128GB', '', 7000, 10001, 6000, 12, 'false'),
(10002, 'phone', 'Iphone8', '128GB', NULL, 23113, 10001, 2321, 12, 'false'),
(10003, 'phone', 'Iphone211', '128GB', NULL, 7000, 10001, 3231, 12, 'false'),
(10004, 'phone', 'Iphone8', '256GB', NULL, 7120, 10001, 31231, 12, 'false'),
(10005, 'phone', 'Iphone9', '128GB', NULL, 72310, 10001, 312, 12, 'false'),
(10006, 'phone', 'Iphone10', '256GB', NULL, 7123, 10001, 62310, 12, 'false'),
(10007, 'phone', 'Iphone11', '128GB', NULL, 7231, 10001, 6130, 12, 'false'),
(10008, 'phone', 'Iphone12', '256GB', NULL, 72123, 10001, 6120, 12, 'false'),
(10009, 'phone', 'Iphone135', '128GB', NULL, 3212, 10001, 63120, 12, 'false'),
(10010, 'phone', 'Iphone51', '128GB', NULL, 73120, 10001, 62310, 12, 'false'),
(10011, 'Car', 'aghJFKLS', 'adhKLFGA', NULL, 1235, 10001, 562234, 12, 'false'),
(10012, 'Car', 'aghJFKLS', 'adhKLFGA', NULL, 51341, 10001, 4212312, 24, 'false'),
(10013, 'Car', 'aghJFKLS', 'adhKLFGA', NULL, 1235, 10001, 532, 36, 'false'),
(10014, 'Car', 'aghJFKLS', 'adhKLFGA', NULL, 1235, 10001, 123, 48, 'false'),
(10015, 'Car', 'aghJFKLS', 'adhKLFGA', NULL, 1235, 10001, 3233, 52, 'false');

-- --------------------------------------------------------

--
-- 資料表結構 `purchaseorder`
--

CREATE TABLE `purchaseorder` (
  `PurchaseOrderID` int(5) NOT NULL,
  `SupplierID` int(5) NOT NULL,
  `Price` int(5) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- 傾印資料表的資料 `purchaseorder`
--

INSERT INTO `purchaseorder` (`PurchaseOrderID`, `SupplierID`, `Price`) VALUES
(1, 10001, 23472),
(2, 10001, 23472),
(3, 10002, 2161),
(4, 10001, 23472),
(5, 10002, 8732),
(6, 10001, 7821);

-- --------------------------------------------------------

--
-- 資料表結構 `purchaseorder_item`
--

CREATE TABLE `purchaseorder_item` (
  `PurchaseOrderID` int(5) NOT NULL,
  `ItemID` int(5) NOT NULL,
  `Qty` int(11) NOT NULL,
  `SupplierID` int(5) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- 傾印資料表的資料 `purchaseorder_item`
--

INSERT INTO `purchaseorder_item` (`PurchaseOrderID`, `ItemID`, `Qty`, `SupplierID`) VALUES
(3, 10001, 112, 1),
(4, 10002, 112, 1),
(5, 10008, 112, 1),
(6, 10007, 112, 1),
(6, 10009, 112, 1);

-- --------------------------------------------------------

--
-- 資料表結構 `reorderrequest`
--

CREATE TABLE `reorderrequest` (
  `ReorderRequestID` int(5) NOT NULL,
  `StaffID` int(5) NOT NULL,
  `RequestDate` date NOT NULL,
  `RequestTime` time NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- 傾印資料表的資料 `reorderrequest`
--

INSERT INTO `reorderrequest` (`ReorderRequestID`, `StaffID`, `RequestDate`, `RequestTime`) VALUES
(10002, 10003, '2022-06-05', '08:01:41'),
(10003, 10003, '2022-06-05', '08:05:16'),
(10004, 10003, '2022-06-05', '08:08:40'),
(10005, 10003, '2022-06-05', '08:12:39'),
(10006, 10003, '2022-06-05', '08:12:56'),
(10007, 10003, '2022-06-05', '08:33:11'),
(10008, 10003, '2022-06-05', '08:33:22'),
(10009, 10003, '2022-06-05', '08:35:44'),
(10010, 10003, '2022-06-05', '08:37:27'),
(10011, 10003, '2022-06-05', '08:45:32'),
(10012, 10003, '2022-06-05', '08:48:35'),
(10013, 10003, '2022-06-05', '08:51:57'),
(10014, 10003, '2022-06-05', '08:52:14'),
(10015, 10003, '2022-06-05', '08:53:18'),
(10016, 10003, '2022-06-05', '08:53:54'),
(10017, 10003, '2022-06-05', '08:54:24'),
(10018, 10003, '2022-06-05', '08:55:53'),
(10019, 10003, '2022-06-05', '08:56:42'),
(10020, 10003, '2022-06-05', '08:58:37'),
(10021, 10003, '2022-06-05', '08:59:15'),
(10022, 10003, '2022-06-05', '09:00:34'),
(10023, 10003, '2022-06-05', '09:00:39'),
(10024, 10003, '2022-06-05', '09:01:58'),
(10025, 10003, '2022-06-05', '09:02:41'),
(10026, 10003, '2022-06-05', '09:12:55'),
(10027, 10003, '2022-06-05', '09:13:47'),
(10028, 10003, '2022-06-05', '09:17:12'),
(10029, 10003, '2022-06-05', '09:18:23'),
(10030, 10003, '2022-06-05', '09:19:47'),
(10031, 10003, '2022-06-05', '09:20:36'),
(10032, 10003, '2022-06-05', '09:22:14'),
(10033, 10003, '2022-06-05', '09:24:29'),
(10034, 10003, '2022-06-05', '09:26:22'),
(10035, 10003, '2022-06-05', '09:26:52'),
(10036, 10003, '2022-06-05', '09:26:56');

-- --------------------------------------------------------

--
-- 資料表結構 `reorderrequest_item`
--

CREATE TABLE `reorderrequest_item` (
  `ItemID` int(5) NOT NULL,
  `ReorderRequestID` int(5) NOT NULL,
  `Qty` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- 傾印資料表的資料 `reorderrequest_item`
--

INSERT INTO `reorderrequest_item` (`ItemID`, `ReorderRequestID`, `Qty`) VALUES
(10002, 10002, 5),
(10005, 10003, 3),
(10005, 10004, 5),
(10002, 10005, 6),
(10002, 10006, 7),
(10001, 10007, 5),
(10002, 10008, 10),
(10008, 10009, 5),
(10002, 10010, 3),
(10002, 10011, 3),
(10001, 10012, 2),
(10002, 10013, 5),
(10005, 10014, 3),
(10002, 10015, 1),
(10001, 10016, 1),
(10001, 10017, 2),
(10001, 10018, 5),
(10001, 10019, 2),
(10002, 10020, 4),
(10002, 10021, 4),
(10002, 10022, 1),
(10002, 10023, 5),
(10002, 10024, 3),
(10001, 10025, 3),
(10002, 10026, 3),
(10002, 10027, 3),
(10005, 10028, 3),
(10005, 10029, 3),
(10001, 10030, 3),
(10001, 10031, 3),
(10001, 10032, 3),
(10001, 10033, 3),
(10001, 10034, 3),
(10002, 10035, 1),
(10002, 10036, 2);

-- --------------------------------------------------------

--
-- 資料表結構 `restockrequest`
--

CREATE TABLE `restockrequest` (
  `RestockRequestID` int(5) NOT NULL,
  `StaffID` int(5) NOT NULL,
  `RequestDate` date NOT NULL,
  `RequestTime` time NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- 傾印資料表的資料 `restockrequest`
--

INSERT INTO `restockrequest` (`RestockRequestID`, `StaffID`, `RequestDate`, `RequestTime`) VALUES
(10027, 10032, '2022-06-15', '02:45:59'),
(10028, 10002, '2022-06-04', '02:05:25'),
(10029, 10002, '2022-06-04', '02:05:47'),
(10030, 10002, '2022-06-04', '02:06:05'),
(10031, 10002, '2022-06-04', '02:59:18'),
(10032, 10002, '2022-06-04', '03:02:29'),
(10033, 10002, '2022-06-04', '03:10:53'),
(10034, 10002, '2022-06-04', '03:12:15'),
(10035, 10002, '2022-06-04', '03:12:38'),
(10036, 10002, '2022-06-04', '03:19:38'),
(10037, 10002, '2022-06-04', '03:19:43'),
(10038, 10002, '2022-06-04', '03:24:30');

-- --------------------------------------------------------

--
-- 資料表結構 `restockrequest_item`
--

CREATE TABLE `restockrequest_item` (
  `RestockRequestID` int(5) NOT NULL,
  `itemID` int(5) NOT NULL,
  `Quantity` int(3) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- 傾印資料表的資料 `restockrequest_item`
--

INSERT INTO `restockrequest_item` (`RestockRequestID`, `itemID`, `Quantity`) VALUES
(10029, 10001, 30),
(10030, 10002, 123),
(10032, 10002, 231),
(10034, 10001, 1),
(10034, 10002, 1),
(10034, 10003, 1),
(10035, 10001, 4),
(10035, 10002, 3),
(10035, 10003, 6),
(10036, 10001, 1),
(10036, 10002, 1),
(10036, 10003, 1),
(10037, 10001, 1),
(10037, 10002, 1),
(10037, 10003, 1),
(10038, 10003, 10);

-- --------------------------------------------------------

--
-- 資料表結構 `retailstocklevel`
--

CREATE TABLE `retailstocklevel` (
  `itemID` int(5) NOT NULL,
  `itemName` varchar(20) NOT NULL,
  `storeName` varchar(10) NOT NULL,
  `Quantity` int(3) NOT NULL,
  `LowLevelQty` int(3) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- 資料表結構 `salesorder`
--

CREATE TABLE `salesorder` (
  `SalesOrderID` int(5) NOT NULL,
  `StoreID` int(5) NOT NULL,
  `StaffID` int(5) NOT NULL,
  `PaymentStatus` enum('ordered','settled') DEFAULT NULL,
  `PaidAmt` int(20) NOT NULL,
  `Date` date NOT NULL,
  `Time` time NOT NULL,
  `ExpDate` date DEFAULT NULL,
  `CustomerID` int(5) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- 傾印資料表的資料 `salesorder`
--

INSERT INTO `salesorder` (`SalesOrderID`, `StoreID`, `StaffID`, `PaymentStatus`, `PaidAmt`, `Date`, `Time`, `ExpDate`, `CustomerID`) VALUES
(10001, 1, 10001, 'ordered', 100, '2022-06-04', '07:03:00', NULL, 10001),
(10002, 1, 10013, 'settled', 1645, '2022-06-15', '21:00:01', '2022-06-15', 10004),
(10003, 2, 10009, 'settled', 1645, '2022-08-15', '21:00:01', '2022-06-15', 10004),
(10004, 2, 10009, 'settled', 1645, '2022-09-15', '22:00:01', '2022-07-15', 10004),
(10005, 1, 10013, 'settled', 1645, '2022-01-15', '23:00:01', '2022-08-15', 10004),
(10006, 2, 10014, 'settled', 1645, '2022-02-15', '24:00:01', '2022-09-15', 10004),
(10007, 1, 10015, 'settled', 1645, '2022-03-15', '16:00:01', '2022-10-15', 10004);

-- --------------------------------------------------------

--
-- 資料表結構 `salesorder_item`
--

CREATE TABLE `salesorder_item` (
  `SalesOrderID` int(5) NOT NULL,
  `ItemID` int(5) NOT NULL,
  `SalePrice` int(11) NOT NULL,
  `Qty` int(11) NOT NULL,
  `WarrantyMouth` int(11) DEFAULT NULL,
  `SerialNo` varchar(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- 傾印資料表的資料 `salesorder_item`
--

INSERT INTO `salesorder_item` (`SalesOrderID`, `ItemID`, `SalePrice`, `Qty`, `WarrantyMouth`, `SerialNo`) VALUES
(10001, 10001, 3456, 126, 24, '232efsdfsqa'),
(10001, 10002, 3456, 126, 24, '232efsdfsqa'),
(10002, 10002, 86534, 64, 36, '23323dasqa'),
(10002, 10003, 86534, 64, 36, '23323dasqa'),
(10003, 10003, 345, 112, 48, '123123dfas'),
(10003, 10004, 345, 112, 48, '123123dfas'),
(10004, 10005, 7654, 963, 64, '2543qa'),
(10004, 10009, 23113, 12, 24, '223123312-23312'),
(10005, 10006, 987, 137, 128, 'tgrg2345'),
(10006, 10008, 2332, 112, 24, '23231fdfsqa');

-- --------------------------------------------------------

--
-- 資料表結構 `salesreceipt`
--

CREATE TABLE `salesreceipt` (
  `ReceiptID` int(5) NOT NULL,
  `SalesOrderID` int(5) NOT NULL,
  `CustomerID` int(5) NOT NULL,
  `Qty` int(11) NOT NULL,
  `Price` int(11) NOT NULL,
  `PaymentType` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- 資料表結構 `staff`
--

CREATE TABLE `staff` (
  `StaffID` int(5) NOT NULL,
  `StaffName` varchar(20) NOT NULL,
  `Gender` char(1) NOT NULL,
  `DateOfBirth` date NOT NULL,
  `Tel` int(8) NOT NULL,
  `Email` varchar(50) NOT NULL,
  `Position` varchar(20) NOT NULL,
  `Depart` varchar(20) NOT NULL,
  `Salary` int(10) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- 傾印資料表的資料 `staff`
--

INSERT INTO `staff` (`StaffID`, `StaffName`, `Gender`, `DateOfBirth`, `Tel`, `Email`, `Position`, `Depart`, `Salary`) VALUES
(10001, 'admin', 'M', '1980-04-06', 24368333, 'betterlimited10001@gmail.com', 'Admin', 'Admin', NULL),
(10002, 'Better Limited', 'M', '1984-07-02', 24368334, 'betterlimited999@betterlimited.com', 'Admin', 'Admin', NULL),
(10003, 'Ryan Biddle', 'M', '1972-06-04', 24368332, 'ryanbiddle@betterlimited.com', 'CEO', 'CEO', NULL),
(10004, 'Rocky Hahn', 'M', '1969-10-19', 24365628, 'rockyhahn@betterlimited.com', 'Sales Manager', 'Sales', 57520),
(10005, 'Pierre Holquin', 'M', '1976-02-16', 24368472, 'pierreholquin@betterlimited.com', 'Sales Manager', 'Sales', 55200),
(10006, 'Phyllis Kinnison', 'F', '1978-05-25', 24365428, 'phylliskinnison@betterlimited.com', 'Inventory Manager', 'Inventory', 49230),
(10007, 'Carolyn Colon', 'F', '1981-10-26', 24369962, 'carolyncolon@betterlimited.com', 'Inventory Manager', 'Inventory', 48270),
(10008, 'Robert Fulkerson', 'M', '1968-10-30', 24368235, 'robertfulkerson@betterlimited.com', 'Purchase Manager', 'Purchase', 53230),
(10009, 'Rebecca Allen', 'F', '1980-08-16', 24363547, 'rebeccaallen@betterlimited.com', 'Purchase Manager', 'Purchase', 51980),
(10010, 'Robert Robinson', 'M', '1972-09-14', 24362748, 'robertrobinson@betterlimited.com', 'Accounting Manager', 'Accounting', 47850),
(10011, 'Jesse Young', 'M', '1965-07-10', 24368272, 'jesseyoung@betterlimited.com', 'Accounting Manager', 'Accounting', 49860),
(10012, 'Carlos Read', 'M', '1975-05-06', 24367282, 'carlosread@betterlimited.com', 'Technical Support Of', 'Admin', 38520),
(10013, 'Carolyn White', 'F', '1977-04-28', 24369729, 'carolynwhite@betterlimited.com', 'Technical Support Of', 'Admin', 35950),
(10014, 'Ruth Brown', 'F', '1979-10-01', 24369210, 'ruthbrown@betterlimited.com', 'Sales Representative', 'Sales', 28450),
(10015, 'Jennifer Stock', 'F', '1985-08-02', 24362478, 'jenniferstock@betterlimited.com', 'Sales Representative', 'Sales', 26870),
(10016, 'Peter Sheets', 'M', '1989-04-19', 24369372, 'petersheets@betterlimited.com', 'Sales Representative', 'Sales', 25990),
(10017, 'Anne Raymond', 'F', '1992-09-29', 24362357, 'anneraymond@betterlimited.com', 'Inventory Clerk', 'Inventory', 22840),
(10018, 'Erin Bain', 'M', '1984-08-12', 24362829, 'erinbain@betterlimited.com', 'Inventory Clerk', 'Inventory', 26910),
(10019, 'Lane Suggs', 'M', '1997-11-04', 24366218, 'lanesuggs@betterlimited.com', 'Goods Inwards Clerk', 'Inventory', 19850),
(10020, 'John Mauro', 'M', '1987-02-23', 24365910, 'johnmauro@betterlimited.com', 'Goods Inwards Clerk', 'Inventory', 21590),
(10021, 'David Love', 'M', '1992-07-25', 24369829, 'davidlove@betterlimited.com', 'Delivery Workman', 'Inventory', 24850),
(10022, 'Robert Thompson', 'M', '1992-09-20', 24369981, 'robertthompson@betterlimited.com', 'Delivery Workman', 'Inventory', 26590),
(10023, 'Jane Campbell', 'F', '1990-05-28', 24368719, 'janecampbell@betterlimited.com', 'Purchase Officer', 'Purchase', 24720),
(10024, 'Ervin Dobson', 'M', '1985-05-20', 24369820, 'ervindobson@betterlimited.com', 'Accounting Clerk', 'Accounting', 27200),
(10025, 'Pierre Holquin', 'M', '1976-02-16', 24368472, 'pierreholquin@betterlimited.com', 'Sales Manager', 'Sales', 55200),
(10026, 'Phyllis Kinnison', 'F', '1978-05-25', 24365428, 'phylliskinnison@betterlimited.com', 'Inventory Manager', 'Inventory', 49230),
(10027, 'Carolyn Colon', 'F', '1981-10-26', 24369962, 'carolyncolon@betterlimited.com', 'Inventory Manager', 'Inventory', 48270),
(10028, 'Robert Fulkerson', 'M', '1968-10-30', 24368235, 'robertfulkerson@betterlimited.com', 'Purchase Manager', 'Purchase', 53230),
(10029, 'Rebecca Allen', 'F', '1980-08-16', 24363547, 'rebeccaallen@betterlimited.com', 'Purchase Manager', 'Purchase', 51980),
(10030, 'Robert Robinson', 'M', '1972-09-14', 24362748, 'robertrobinson@betterlimited.com', 'Accounting Manager', 'Accounting', 47850),
(10031, 'Jesse Young', 'M', '1965-07-10', 24368272, 'jesseyoung@betterlimited.com', 'Accounting Manager', 'Accounting', 49860),
(10032, 'Carlos Read', 'M', '1975-05-06', 24367282, 'carlosread@betterlimited.com', 'Technical Support Of', 'Admin', 38520),
(10033, 'Carolyn White', 'F', '1977-04-28', 24369729, 'carolynwhite@betterlimited.com', 'Technical Support Of', 'Admin', 35950),
(10034, 'Ruth Brown', 'F', '1979-10-01', 24369210, 'ruthbrown@betterlimited.com', 'Sales Representative', 'Sales', 28450),
(10035, 'Jennifer Stock', 'F', '1985-08-02', 24362478, 'jenniferstock', 'Sales Representative', 'Sales', 26870),
(10036, 'Peter Sheets', 'M', '1989-04-19', 24369372, 'petersheets@betterlimited.com', 'Sales Representative', 'Sales', 25990),
(10037, 'Anne Raymond', 'F', '1992-09-29', 24362357, 'anneraymond@betterlimited.com', 'Inventory Clerk', 'Inventory', 22840),
(10038, 'Erin Bain', 'M', '1984-08-12', 24362829, 'erinbain@betterlimited.com', 'Inventory Clerk', 'Inventory', 26910),
(10039, 'Lane Suggs', 'M', '1997-11-04', 24366218, 'lanesuggs@betterlimited.com', 'Goods Inwards Clerk', 'Inventory', 19850),
(10040, 'John Mauro', 'M', '1987-02-23', 24365910, 'johnmauro@betterlimited.com', 'Goods Inwards Clerk', 'Inventory', 21590),
(10041, 'David Love', 'M', '1992-07-25', 24369829, 'davidlove@betterlimited.com', 'Delivery Workman', 'Inventory', 24850),
(10042, 'Robert Thompson', 'M', '1992-09-20', 24369981, 'robertthompson@betterlimited.com', 'Delivery Workman', 'Inventory', 26590),
(10043, 'Jane Campbell', 'F', '1990-05-28', 24368719, 'janecampbell@betterlimited.com', 'Purchase Officer', 'Purchase', 24720),
(10044, 'Ervin Dobson', 'M', '1985-05-20', 24369820, 'ervindobson@betterlimited.com', 'Accounting Clerk', 'Accounting', 27200);

-- --------------------------------------------------------

--
-- 資料表結構 `store`
--

CREATE TABLE `store` (
  `StoreID` int(5) NOT NULL,
  `Address` varchar(50) NOT NULL,
  `Tel` int(8) NOT NULL,
  `StaffID` int(5) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- 傾印資料表的資料 `store`
--

INSERT INTO `store` (`StoreID`, `Address`, `Tel`, `StaffID`) VALUES
(1, 'store1@gmail.com', 12341234, 10037),
(2, 'store2@gmail.com', 32312123, 10021);

-- --------------------------------------------------------

--
-- 資料表結構 `supplier`
--

CREATE TABLE `supplier` (
  `SupplierID` int(5) NOT NULL,
  `SupplierName` varchar(20) NOT NULL,
  `Address` varchar(50) NOT NULL,
  `Tel` int(8) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- 傾印資料表的資料 `supplier`
--

INSERT INTO `supplier` (`SupplierID`, `SupplierName`, `Address`, `Tel`) VALUES
(10001, 'abc', 'addd', 12345678),
(10002, 'aa', 'sdff', 23456789);

-- --------------------------------------------------------

--
-- 資料表結構 `useraccount`
--

CREATE TABLE `useraccount` (
  `UserAccountID` int(5) NOT NULL,
  `StaffID` int(5) NOT NULL,
  `UserName` varchar(20) NOT NULL,
  `Password` varchar(20) NOT NULL,
  `Email` varchar(50) NOT NULL,
  `CreateDateTime` datetime NOT NULL,
  `LastLoginDateTime` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- 傾印資料表的資料 `useraccount`
--

INSERT INTO `useraccount` (`UserAccountID`, `StaffID`, `UserName`, `Password`, `Email`, `CreateDateTime`, `LastLoginDateTime`) VALUES
(10001, 10001, 'admin', 'Qwer1234!', 'betterlimited10001@gmail.com', '2022-05-24 20:04:05', '2022-06-07 00:39:01'),
(10008, 10001, 'admin2', 'Qwer1234!', 'betterlimited10001@gmail.com', '2022-05-27 04:59:15', NULL),
(10011, 10001, 'admin2', 'Qwer1234!', 'betterlimited10001@gmail.com', '2022-05-27 05:52:37', NULL),
(10012, 10001, 'admin3', 'Qwer1234!', 'betterlimited10001@gmail.com', '2022-05-27 05:55:06', NULL),
(10014, 10002, 'betterlimited', 'Qwer1234!', 'betterlimited999@betterlimited.com', '2022-05-28 05:03:40', '2022-05-28 05:04:10'),
(10015, 10002, 'betterlimmited2', 'Qwer1234!', 'betterlimited999@betterlimited.com', '2022-05-28 05:16:18', '2022-06-04 06:27:20');

--
-- 已傾印資料表的索引
--

--
-- 資料表索引 `customer`
--
ALTER TABLE `customer`
  ADD PRIMARY KEY (`CustomerID`);

--
-- 資料表索引 `deliveryorder`
--
ALTER TABLE `deliveryorder`
  ADD PRIMARY KEY (`DeliveryID`),
  ADD KEY `FKDeliveryNo330361` (`SalesOrderID`);

--
-- 資料表索引 `deliveryorder_item`
--
ALTER TABLE `deliveryorder_item`
  ADD PRIMARY KEY (`DeliveryID`,`itemID`),
  ADD KEY `deliveryorder_item_ibfk_2` (`itemID`);

--
-- 資料表索引 `goodreturnnote`
--
ALTER TABLE `goodreturnnote`
  ADD PRIMARY KEY (`ReturnNoteID`),
  ADD KEY `FKGoodReturn385517` (`SupplierID`),
  ADD KEY `FKGoodReturn63513` (`SalesOrderID`);

--
-- 資料表索引 `goodreturnnote_item`
--
ALTER TABLE `goodreturnnote_item`
  ADD PRIMARY KEY (`ReturnNoteID`,`ItemID`),
  ADD KEY `FKGoodReturn748003` (`ItemID`);

--
-- 資料表索引 `goodsreceivednote`
--
ALTER TABLE `goodsreceivednote`
  ADD PRIMARY KEY (`ReceivedID`,`PurchaseOrderID`),
  ADD KEY `FKGoodsRecei36177` (`PurchaseOrderID`),
  ADD KEY `FKGoodsRecei913086` (`SupplierID`);

--
-- 資料表索引 `installationorder`
--
ALTER TABLE `installationorder`
  ADD PRIMARY KEY (`InstallationID`),
  ADD KEY `FKInstallati300044` (`SalesOrderID`);

--
-- 資料表索引 `installationorder_item`
--
ALTER TABLE `installationorder_item`
  ADD PRIMARY KEY (`InstallationID`,`itemID`),
  ADD KEY `itemID` (`itemID`);

--
-- 資料表索引 `inventorystocklevel`
--
ALTER TABLE `inventorystocklevel`
  ADD PRIMARY KEY (`itemID`);

--
-- 資料表索引 `item`
--
ALTER TABLE `item`
  ADD PRIMARY KEY (`ItemID`),
  ADD KEY `FKItem506810` (`SupplierID`);

--
-- 資料表索引 `purchaseorder`
--
ALTER TABLE `purchaseorder`
  ADD PRIMARY KEY (`PurchaseOrderID`),
  ADD KEY `FKPurchaseOr510102` (`SupplierID`);

--
-- 資料表索引 `purchaseorder_item`
--
ALTER TABLE `purchaseorder_item`
  ADD PRIMARY KEY (`PurchaseOrderID`,`ItemID`),
  ADD KEY `FKPurchaseOr100230` (`ItemID`);

--
-- 資料表索引 `reorderrequest`
--
ALTER TABLE `reorderrequest`
  ADD PRIMARY KEY (`ReorderRequestID`),
  ADD KEY `FK_StaffID` (`StaffID`);

--
-- 資料表索引 `reorderrequest_item`
--
ALTER TABLE `reorderrequest_item`
  ADD PRIMARY KEY (`ReorderRequestID`);

--
-- 資料表索引 `restockrequest`
--
ALTER TABLE `restockrequest`
  ADD PRIMARY KEY (`RestockRequestID`),
  ADD KEY `StaffID` (`StaffID`);

--
-- 資料表索引 `restockrequest_item`
--
ALTER TABLE `restockrequest_item`
  ADD PRIMARY KEY (`RestockRequestID`,`itemID`),
  ADD KEY `itemID` (`itemID`);

--
-- 資料表索引 `retailstocklevel`
--
ALTER TABLE `retailstocklevel`
  ADD PRIMARY KEY (`itemID`);

--
-- 資料表索引 `salesorder`
--
ALTER TABLE `salesorder`
  ADD PRIMARY KEY (`SalesOrderID`),
  ADD KEY `FKSalesOrder557619` (`CustomerID`),
  ADD KEY `FKSalesOrder841473` (`StoreID`),
  ADD KEY `FKSalesOrder426975` (`StaffID`);

--
-- 資料表索引 `salesorder_item`
--
ALTER TABLE `salesorder_item`
  ADD PRIMARY KEY (`SalesOrderID`,`ItemID`),
  ADD KEY `FKSalesOrder929714` (`SalesOrderID`),
  ADD KEY `FKSalesOrder804327` (`ItemID`);

--
-- 資料表索引 `salesreceipt`
--
ALTER TABLE `salesreceipt`
  ADD PRIMARY KEY (`ReceiptID`),
  ADD KEY `FKSalesRecei652713` (`SalesOrderID`),
  ADD KEY `FKSalesRecei494615` (`CustomerID`);

--
-- 資料表索引 `staff`
--
ALTER TABLE `staff`
  ADD PRIMARY KEY (`StaffID`);

--
-- 資料表索引 `store`
--
ALTER TABLE `store`
  ADD PRIMARY KEY (`StoreID`),
  ADD KEY `FKStore384954` (`StaffID`);

--
-- 資料表索引 `supplier`
--
ALTER TABLE `supplier`
  ADD PRIMARY KEY (`SupplierID`);

--
-- 資料表索引 `useraccount`
--
ALTER TABLE `useraccount`
  ADD PRIMARY KEY (`UserAccountID`),
  ADD KEY `FKUserAccoun919948` (`StaffID`);

--
-- 在傾印的資料表使用自動遞增(AUTO_INCREMENT)
--

--
-- 使用資料表自動遞增(AUTO_INCREMENT) `customer`
--
ALTER TABLE `customer`
  MODIFY `CustomerID` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10013;

--
-- 使用資料表自動遞增(AUTO_INCREMENT) `deliveryorder`
--
ALTER TABLE `deliveryorder`
  MODIFY `DeliveryID` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10012;

--
-- 使用資料表自動遞增(AUTO_INCREMENT) `goodreturnnote`
--
ALTER TABLE `goodreturnnote`
  MODIFY `ReturnNoteID` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- 使用資料表自動遞增(AUTO_INCREMENT) `goodsreceivednote`
--
ALTER TABLE `goodsreceivednote`
  MODIFY `ReceivedID` int(5) NOT NULL AUTO_INCREMENT;

--
-- 使用資料表自動遞增(AUTO_INCREMENT) `installationorder`
--
ALTER TABLE `installationorder`
  MODIFY `InstallationID` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10008;

--
-- 使用資料表自動遞增(AUTO_INCREMENT) `item`
--
ALTER TABLE `item`
  MODIFY `ItemID` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10016;

--
-- 使用資料表自動遞增(AUTO_INCREMENT) `purchaseorder`
--
ALTER TABLE `purchaseorder`
  MODIFY `PurchaseOrderID` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- 使用資料表自動遞增(AUTO_INCREMENT) `reorderrequest`
--
ALTER TABLE `reorderrequest`
  MODIFY `ReorderRequestID` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10037;

--
-- 使用資料表自動遞增(AUTO_INCREMENT) `restockrequest`
--
ALTER TABLE `restockrequest`
  MODIFY `RestockRequestID` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10039;

--
-- 使用資料表自動遞增(AUTO_INCREMENT) `salesorder`
--
ALTER TABLE `salesorder`
  MODIFY `SalesOrderID` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10008;

--
-- 使用資料表自動遞增(AUTO_INCREMENT) `salesreceipt`
--
ALTER TABLE `salesreceipt`
  MODIFY `ReceiptID` int(5) NOT NULL AUTO_INCREMENT;

--
-- 使用資料表自動遞增(AUTO_INCREMENT) `staff`
--
ALTER TABLE `staff`
  MODIFY `StaffID` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10045;

--
-- 使用資料表自動遞增(AUTO_INCREMENT) `store`
--
ALTER TABLE `store`
  MODIFY `StoreID` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- 使用資料表自動遞增(AUTO_INCREMENT) `supplier`
--
ALTER TABLE `supplier`
  MODIFY `SupplierID` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10003;

--
-- 使用資料表自動遞增(AUTO_INCREMENT) `useraccount`
--
ALTER TABLE `useraccount`
  MODIFY `UserAccountID` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10020;

--
-- 已傾印資料表的限制式
--

--
-- 資料表的限制式 `deliveryorder`
--
ALTER TABLE `deliveryorder`
  ADD CONSTRAINT `FKDeliveryNo330361` FOREIGN KEY (`SalesOrderID`) REFERENCES `salesorder` (`SalesOrderID`) ON DELETE CASCADE;

--
-- 資料表的限制式 `deliveryorder_item`
--
ALTER TABLE `deliveryorder_item`
  ADD CONSTRAINT `deliveryorder_item_ibfk_1` FOREIGN KEY (`DeliveryID`) REFERENCES `deliveryorder` (`DeliveryID`) ON DELETE CASCADE,
  ADD CONSTRAINT `deliveryorder_item_ibfk_2` FOREIGN KEY (`itemID`) REFERENCES `salesorder_item` (`ItemID`) ON DELETE CASCADE;

--
-- 資料表的限制式 `goodreturnnote`
--
ALTER TABLE `goodreturnnote`
  ADD CONSTRAINT `FKGoodReturn385517` FOREIGN KEY (`SupplierID`) REFERENCES `supplier` (`SupplierID`) ON DELETE CASCADE,
  ADD CONSTRAINT `FKGoodReturn63513` FOREIGN KEY (`SalesOrderID`) REFERENCES `salesorder` (`SalesOrderID`) ON DELETE CASCADE;

--
-- 資料表的限制式 `goodreturnnote_item`
--
ALTER TABLE `goodreturnnote_item`
  ADD CONSTRAINT `FKGoodReturn395895` FOREIGN KEY (`ReturnNoteID`) REFERENCES `goodreturnnote` (`ReturnNoteID`) ON DELETE CASCADE,
  ADD CONSTRAINT `FKGoodReturn748003` FOREIGN KEY (`ItemID`) REFERENCES `item` (`ItemID`) ON DELETE CASCADE;

--
-- 資料表的限制式 `goodsreceivednote`
--
ALTER TABLE `goodsreceivednote`
  ADD CONSTRAINT `FKGoodsRecei36177` FOREIGN KEY (`PurchaseOrderID`) REFERENCES `purchaseorder` (`PurchaseOrderID`),
  ADD CONSTRAINT `FKGoodsRecei913086` FOREIGN KEY (`SupplierID`) REFERENCES `supplier` (`SupplierID`) ON DELETE CASCADE;

--
-- 資料表的限制式 `installationorder`
--
ALTER TABLE `installationorder`
  ADD CONSTRAINT `FKInstallati300044` FOREIGN KEY (`SalesOrderID`) REFERENCES `salesorder` (`SalesOrderID`);

--
-- 資料表的限制式 `installationorder_item`
--
ALTER TABLE `installationorder_item`
  ADD CONSTRAINT `installationorder_item_ibfk_1` FOREIGN KEY (`itemID`) REFERENCES `salesorder_item` (`ItemID`),
  ADD CONSTRAINT `installationorder_item_ibfk_2` FOREIGN KEY (`InstallationID`) REFERENCES `installationorder` (`InstallationID`);

--
-- 資料表的限制式 `inventorystocklevel`
--
ALTER TABLE `inventorystocklevel`
  ADD CONSTRAINT `FK_itemID` FOREIGN KEY (`itemID`) REFERENCES `item` (`ItemID`);

--
-- 資料表的限制式 `item`
--
ALTER TABLE `item`
  ADD CONSTRAINT `FKItem506810` FOREIGN KEY (`SupplierID`) REFERENCES `supplier` (`SupplierID`) ON DELETE CASCADE;

--
-- 資料表的限制式 `purchaseorder`
--
ALTER TABLE `purchaseorder`
  ADD CONSTRAINT `FKPurchaseOr510102` FOREIGN KEY (`SupplierID`) REFERENCES `supplier` (`SupplierID`);

--
-- 資料表的限制式 `purchaseorder_item`
--
ALTER TABLE `purchaseorder_item`
  ADD CONSTRAINT `FKPurchaseOr100230` FOREIGN KEY (`ItemID`) REFERENCES `item` (`ItemID`) ON DELETE CASCADE,
  ADD CONSTRAINT `FKPurchaseOr444232` FOREIGN KEY (`PurchaseOrderID`) REFERENCES `purchaseorder` (`PurchaseOrderID`) ON DELETE CASCADE;

--
-- 資料表的限制式 `reorderrequest`
--
ALTER TABLE `reorderrequest`
  ADD CONSTRAINT `FK_StaffID` FOREIGN KEY (`StaffID`) REFERENCES `staff` (`StaffID`) ON DELETE CASCADE;

--
-- 資料表的限制式 `reorderrequest_item`
--
ALTER TABLE `reorderrequest_item`
  ADD CONSTRAINT `FK_ReOrderRequestID` FOREIGN KEY (`ReorderRequestID`) REFERENCES `reorderrequest` (`ReorderRequestID`) ON DELETE CASCADE;

--
-- 資料表的限制式 `restockrequest`
--
ALTER TABLE `restockrequest`
  ADD CONSTRAINT `restockrequest_ibfk_1` FOREIGN KEY (`StaffID`) REFERENCES `staff` (`StaffID`) ON DELETE CASCADE;

--
-- 資料表的限制式 `restockrequest_item`
--
ALTER TABLE `restockrequest_item`
  ADD CONSTRAINT `restockrequest_item_ibfk_1` FOREIGN KEY (`itemID`) REFERENCES `item` (`ItemID`) ON DELETE CASCADE,
  ADD CONSTRAINT `restockrequest_item_ibfk_2` FOREIGN KEY (`RestockRequestID`) REFERENCES `restockrequest` (`RestockRequestID`) ON DELETE CASCADE;

--
-- 資料表的限制式 `retailstocklevel`
--
ALTER TABLE `retailstocklevel`
  ADD CONSTRAINT `FK_itemIDrs` FOREIGN KEY (`itemID`) REFERENCES `item` (`ItemID`) ON DELETE CASCADE;

--
-- 資料表的限制式 `salesorder`
--
ALTER TABLE `salesorder`
  ADD CONSTRAINT `FKSalesOrder426975` FOREIGN KEY (`StaffID`) REFERENCES `staff` (`StaffID`) ON DELETE CASCADE,
  ADD CONSTRAINT `FKSalesOrder557619` FOREIGN KEY (`CustomerID`) REFERENCES `customer` (`CustomerID`),
  ADD CONSTRAINT `FKSalesOrder841473` FOREIGN KEY (`StoreID`) REFERENCES `store` (`StoreID`);

--
-- 資料表的限制式 `salesorder_item`
--
ALTER TABLE `salesorder_item`
  ADD CONSTRAINT `FKSalesOrder804327` FOREIGN KEY (`ItemID`) REFERENCES `item` (`ItemID`) ON DELETE CASCADE,
  ADD CONSTRAINT `FKSalesOrder929714` FOREIGN KEY (`SalesOrderID`) REFERENCES `salesorder` (`SalesOrderID`) ON DELETE CASCADE;

--
-- 資料表的限制式 `salesreceipt`
--
ALTER TABLE `salesreceipt`
  ADD CONSTRAINT `FKSalesRecei494615` FOREIGN KEY (`CustomerID`) REFERENCES `customer` (`CustomerID`),
  ADD CONSTRAINT `FKSalesRecei652713` FOREIGN KEY (`SalesOrderID`) REFERENCES `salesorder` (`SalesOrderID`) ON DELETE CASCADE;

--
-- 資料表的限制式 `store`
--
ALTER TABLE `store`
  ADD CONSTRAINT `FKStore384954` FOREIGN KEY (`StaffID`) REFERENCES `staff` (`StaffID`) ON DELETE CASCADE;

--
-- 資料表的限制式 `useraccount`
--
ALTER TABLE `useraccount`
  ADD CONSTRAINT `FKUserAccoun919948` FOREIGN KEY (`StaffID`) REFERENCES `staff` (`StaffID`) ON DELETE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

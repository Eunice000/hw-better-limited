-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- 主機： 127.0.0.1
-- 產生時間： 2022-06-02 23:02:40
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
  `Address` varchar(50) NOT NULL,
  `Tel` int(8) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- 傾印資料表的資料 `customer`
--

INSERT INTO `customer` (`CustomerID`, `Name`, `Address`, `Tel`) VALUES
(1, 'paper', 'aAdasgyduask@gmail.com', 23132321);

-- --------------------------------------------------------

--
-- 資料表結構 `deliverynote`
--

CREATE TABLE `deliverynote` (
  `DeliveryID` int(5) NOT NULL,
  `SalesOrderID` int(5) NOT NULL,
  `CustomerID` int(5) NOT NULL,
  `DeliveryDate` date NOT NULL,
  `DeliveryTime` time NOT NULL,
  `DeliveryStatus` enum('pending','In-transit','delivered') NOT NULL DEFAULT 'pending'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- 傾印資料表的資料 `deliverynote`
--

INSERT INTO `deliverynote` (`DeliveryID`, `SalesOrderID`, `CustomerID`, `DeliveryDate`, `DeliveryTime`, `DeliveryStatus`) VALUES
(1, 6, 1, '2022-06-08', '14:26:52', 'pending'),
(3, 10, 1, '2022-06-14', '14:18:52', 'delivered'),
(4, 10, 1, '2022-06-14', '38:18:52', 'pending'),
(6, 10, 1, '2022-06-14', '00:00:01', 'pending'),
(7, 10, 1, '2022-06-14', '38:18:52', 'pending'),
(8, 9, 1, '2022-06-22', '38:19:52', 'pending'),
(9, 9, 1, '2022-06-22', '38:19:52', 'pending'),
(10, 9, 1, '2022-06-22', '38:19:52', 'pending'),
(11, 9, 1, '2022-06-22', '38:19:52', 'pending'),
(12, 9, 1, '2022-06-22', '38:19:52', 'pending'),
(13, 9, 1, '2022-06-22', '38:19:52', 'pending'),
(14, 9, 1, '2022-06-22', '38:19:52', 'pending');

-- --------------------------------------------------------

--
-- 資料表結構 `goodreturnnote`
--

CREATE TABLE `goodreturnnote` (
  `ReturnNoteID` int(5) NOT NULL,
  `SalesOrderID` int(5) NOT NULL,
  `SupplierID` int(5) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- 資料表結構 `goodreturnnote_item`
--

CREATE TABLE `goodreturnnote_item` (
  `ReturnNoteID` int(5) NOT NULL,
  `ItemID` int(5) NOT NULL,
  `Qty` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

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
  `CustomerID` int(5) NOT NULL,
  `InstallationDate` date NOT NULL,
  `InstallationTime` time NOT NULL,
  `installationStatus` enum('pending','installed') NOT NULL DEFAULT 'pending'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- 傾印資料表的資料 `installationorder`
--

INSERT INTO `installationorder` (`InstallationID`, `SalesOrderID`, `CustomerID`, `InstallationDate`, `InstallationTime`, `installationStatus`) VALUES
(3, 10, 1, '2022-06-16', '21:30:32', 'pending'),
(4, 10, 1, '2022-06-15', '21:30:32', 'pending'),
(5, 10, 1, '2022-06-15', '21:30:32', 'pending'),
(6, 8, 1, '2022-06-14', '16:29:55', '');

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
  `SupplierPirce` int(20) NOT NULL,
  `WarrantyMonth` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- 傾印資料表的資料 `item`
--

INSERT INTO `item` (`ItemID`, `ItemCat`, `ItemName`, `ItemDesc`, `ItemImg`, `SalePrice`, `SupplierID`, `SupplierPirce`, `WarrantyMonth`) VALUES
(1, 'phone', 'Iphone7', '128GB', '', 7000, 1, 6000, 12),
(2, 'phone', 'Iphone8', '128GB', NULL, 23113, 1, 2321, 12),
(3, 'phone', 'Iphone211', '128GB', NULL, 7000, 1, 3231, 12),
(4, 'phone', 'Iphone8', '256GB', NULL, 7120, 1, 31231, 12),
(5, 'phone', 'Iphone9', '128GB', NULL, 72310, 1, 312, 12),
(6, 'phone', 'Iphone10', '256GB', NULL, 7123, 1, 62310, 12),
(7, 'phone', 'Iphone11', '128GB', NULL, 7231, 1, 6130, 12),
(8, 'phone', 'Iphone12', '256GB', NULL, 72123, 1, 6120, 12),
(9, 'phone', 'Iphone135', '128GB', NULL, 3212, 1, 63120, 12),
(10, 'phone', 'Iphone51', '128GB', NULL, 73120, 1, 62310, 12);

-- --------------------------------------------------------

--
-- 資料表結構 `purchaseorder`
--

CREATE TABLE `purchaseorder` (
  `PurchaseOrderID` int(5) NOT NULL,
  `SupplierID` int(5) NOT NULL,
  `Price` int(5) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

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

-- --------------------------------------------------------

--
-- 資料表結構 `reorderrequest`
--

CREATE TABLE `reorderrequest` (
  `ReorderRequestID` int(5) NOT NULL,
  `StaffID` int(5) NOT NULL,
  `RequestDate` date NOT NULL,
  `RequestTime` time NOT NULL,
  `PurchaseOrderPurchaseOrderID` int(5) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- 資料表結構 `reorderrequest_item`
--

CREATE TABLE `reorderrequest_item` (
  `ItemID` int(5) NOT NULL,
  `ReorderRequestID` int(5) NOT NULL,
  `Qty` int(11) NOT NULL
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
  `ExpDate` date NOT NULL,
  `CustomerID` int(5) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- 傾印資料表的資料 `salesorder`
--

INSERT INTO `salesorder` (`SalesOrderID`, `StoreID`, `StaffID`, `PaymentStatus`, `PaidAmt`, `Date`, `Time`, `ExpDate`, `CustomerID`) VALUES
(6, 1, 10033, 'ordered', 16231, '2028-07-21', '11:11:11', '2029-08-31', 1),
(7, 1, 10027, 'settled', 1312, '2022-06-07', '21:18:12', '2022-06-15', 1),
(8, 2, 10007, 'settled', 42342, '2022-05-19', '21:32:23', '2022-05-27', 1),
(9, 1, 10033, '', 16231, '2028-07-21', '11:11:11', '2029-08-31', 1),
(10, 1, 10033, 'settled', 16231, '2028-07-21', '11:11:11', '2029-08-31', 1);

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
(6, 2, 7000, 112, 12, '223123312-23312'),
(10, 5, 2332, 12, 24, '2321231-3123asda');

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
(1, 'VTC', 'dwedeqw@gmail.com', 12353123);

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
(10001, 10001, 'admin', 'qwer1234', 'betterlimited10001@gmail.com', '2022-05-24 20:04:05', '2022-06-03 04:44:18'),
(10008, 10001, 'admin2', 'qwer1234', 'betterlimited10001@gmail.com', '2022-05-27 04:59:15', NULL),
(10011, 10001, 'admin2', 'qwer1234', 'betterlimited10001@gmail.com', '2022-05-27 05:52:37', NULL),
(10012, 10001, 'admin3', 'qwer1234', 'betterlimited10001@gmail.com', '2022-05-27 05:55:06', NULL),
(10014, 10002, 'betterlimited', 'qwer1234', 'betterlimited999@betterlimited.com', '2022-05-28 05:03:40', '2022-05-31 05:12:12'),
(10015, 10002, 'betterlimmited2', 'qwer1234', 'betterlimited999@betterlimited.com', '2022-05-28 05:16:18', NULL),
(10019, 10003, 'Ryan Biddle', 'qwer1234', 'ryanbiddle@betterlimited.com', '2022-05-31 05:26:41', '2022-05-31 05:33:41');

--
-- 已傾印資料表的索引
--

--
-- 資料表索引 `customer`
--
ALTER TABLE `customer`
  ADD PRIMARY KEY (`CustomerID`);

--
-- 資料表索引 `deliverynote`
--
ALTER TABLE `deliverynote`
  ADD PRIMARY KEY (`DeliveryID`),
  ADD KEY `FKDeliveryNo488459` (`CustomerID`),
  ADD KEY `FKDeliveryNo330361` (`SalesOrderID`);

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
  ADD KEY `FKInstallati300044` (`SalesOrderID`),
  ADD KEY `FKInstallati141946` (`CustomerID`);

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
  ADD KEY `FKReorderReq909591` (`StaffID`);

--
-- 資料表索引 `reorderrequest_item`
--
ALTER TABLE `reorderrequest_item`
  ADD PRIMARY KEY (`ItemID`,`ReorderRequestID`),
  ADD KEY `FKReorderReq254158` (`ReorderRequestID`);

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
  ADD PRIMARY KEY (`SalesOrderID`),
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
  MODIFY `CustomerID` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- 使用資料表自動遞增(AUTO_INCREMENT) `deliverynote`
--
ALTER TABLE `deliverynote`
  MODIFY `DeliveryID` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=15;

--
-- 使用資料表自動遞增(AUTO_INCREMENT) `goodreturnnote`
--
ALTER TABLE `goodreturnnote`
  MODIFY `ReturnNoteID` int(5) NOT NULL AUTO_INCREMENT;

--
-- 使用資料表自動遞增(AUTO_INCREMENT) `goodsreceivednote`
--
ALTER TABLE `goodsreceivednote`
  MODIFY `ReceivedID` int(5) NOT NULL AUTO_INCREMENT;

--
-- 使用資料表自動遞增(AUTO_INCREMENT) `installationorder`
--
ALTER TABLE `installationorder`
  MODIFY `InstallationID` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- 使用資料表自動遞增(AUTO_INCREMENT) `item`
--
ALTER TABLE `item`
  MODIFY `ItemID` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- 使用資料表自動遞增(AUTO_INCREMENT) `purchaseorder`
--
ALTER TABLE `purchaseorder`
  MODIFY `PurchaseOrderID` int(5) NOT NULL AUTO_INCREMENT;

--
-- 使用資料表自動遞增(AUTO_INCREMENT) `reorderrequest`
--
ALTER TABLE `reorderrequest`
  MODIFY `ReorderRequestID` int(5) NOT NULL AUTO_INCREMENT;

--
-- 使用資料表自動遞增(AUTO_INCREMENT) `salesorder`
--
ALTER TABLE `salesorder`
  MODIFY `SalesOrderID` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

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
  MODIFY `SupplierID` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- 使用資料表自動遞增(AUTO_INCREMENT) `useraccount`
--
ALTER TABLE `useraccount`
  MODIFY `UserAccountID` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10020;

--
-- 已傾印資料表的限制式
--

--
-- 資料表的限制式 `deliverynote`
--
ALTER TABLE `deliverynote`
  ADD CONSTRAINT `FKDeliveryNo330361` FOREIGN KEY (`SalesOrderID`) REFERENCES `salesorder` (`SalesOrderID`),
  ADD CONSTRAINT `FKDeliveryNo488459` FOREIGN KEY (`CustomerID`) REFERENCES `customer` (`CustomerID`);

--
-- 資料表的限制式 `goodreturnnote`
--
ALTER TABLE `goodreturnnote`
  ADD CONSTRAINT `FKGoodReturn385517` FOREIGN KEY (`SupplierID`) REFERENCES `supplier` (`SupplierID`),
  ADD CONSTRAINT `FKGoodReturn63513` FOREIGN KEY (`SalesOrderID`) REFERENCES `salesorder` (`SalesOrderID`);

--
-- 資料表的限制式 `goodreturnnote_item`
--
ALTER TABLE `goodreturnnote_item`
  ADD CONSTRAINT `FKGoodReturn395895` FOREIGN KEY (`ReturnNoteID`) REFERENCES `goodreturnnote` (`ReturnNoteID`),
  ADD CONSTRAINT `FKGoodReturn748003` FOREIGN KEY (`ItemID`) REFERENCES `item` (`ItemID`);

--
-- 資料表的限制式 `goodsreceivednote`
--
ALTER TABLE `goodsreceivednote`
  ADD CONSTRAINT `FKGoodsRecei36177` FOREIGN KEY (`PurchaseOrderID`) REFERENCES `purchaseorder` (`PurchaseOrderID`),
  ADD CONSTRAINT `FKGoodsRecei913086` FOREIGN KEY (`SupplierID`) REFERENCES `supplier` (`SupplierID`);

--
-- 資料表的限制式 `installationorder`
--
ALTER TABLE `installationorder`
  ADD CONSTRAINT `FKInstallati141946` FOREIGN KEY (`CustomerID`) REFERENCES `customer` (`CustomerID`),
  ADD CONSTRAINT `FKInstallati300044` FOREIGN KEY (`SalesOrderID`) REFERENCES `salesorder` (`SalesOrderID`);

--
-- 資料表的限制式 `item`
--
ALTER TABLE `item`
  ADD CONSTRAINT `FKItem506810` FOREIGN KEY (`SupplierID`) REFERENCES `supplier` (`SupplierID`);

--
-- 資料表的限制式 `purchaseorder`
--
ALTER TABLE `purchaseorder`
  ADD CONSTRAINT `FKPurchaseOr510102` FOREIGN KEY (`SupplierID`) REFERENCES `supplier` (`SupplierID`);

--
-- 資料表的限制式 `purchaseorder_item`
--
ALTER TABLE `purchaseorder_item`
  ADD CONSTRAINT `FKPurchaseOr100230` FOREIGN KEY (`ItemID`) REFERENCES `item` (`ItemID`),
  ADD CONSTRAINT `FKPurchaseOr444232` FOREIGN KEY (`PurchaseOrderID`) REFERENCES `purchaseorder` (`PurchaseOrderID`);

--
-- 資料表的限制式 `reorderrequest`
--
ALTER TABLE `reorderrequest`
  ADD CONSTRAINT `FKReorderReq909591` FOREIGN KEY (`StaffID`) REFERENCES `staff` (`StaffID`);

--
-- 資料表的限制式 `reorderrequest_item`
--
ALTER TABLE `reorderrequest_item`
  ADD CONSTRAINT `FKReorderReq254158` FOREIGN KEY (`ReorderRequestID`) REFERENCES `reorderrequest` (`ReorderRequestID`),
  ADD CONSTRAINT `FKReorderReq782151` FOREIGN KEY (`ItemID`) REFERENCES `item` (`ItemID`);

--
-- 資料表的限制式 `salesorder`
--
ALTER TABLE `salesorder`
  ADD CONSTRAINT `FKSalesOrder426975` FOREIGN KEY (`StaffID`) REFERENCES `staff` (`StaffID`),
  ADD CONSTRAINT `FKSalesOrder557619` FOREIGN KEY (`CustomerID`) REFERENCES `customer` (`CustomerID`),
  ADD CONSTRAINT `FKSalesOrder841473` FOREIGN KEY (`StoreID`) REFERENCES `store` (`StoreID`);

--
-- 資料表的限制式 `salesorder_item`
--
ALTER TABLE `salesorder_item`
  ADD CONSTRAINT `FKSalesOrder804327` FOREIGN KEY (`ItemID`) REFERENCES `item` (`ItemID`),
  ADD CONSTRAINT `FKSalesOrder929714` FOREIGN KEY (`SalesOrderID`) REFERENCES `salesorder` (`SalesOrderID`);

--
-- 資料表的限制式 `salesreceipt`
--
ALTER TABLE `salesreceipt`
  ADD CONSTRAINT `FKSalesRecei494615` FOREIGN KEY (`CustomerID`) REFERENCES `customer` (`CustomerID`),
  ADD CONSTRAINT `FKSalesRecei652713` FOREIGN KEY (`SalesOrderID`) REFERENCES `salesorder` (`SalesOrderID`);

--
-- 資料表的限制式 `store`
--
ALTER TABLE `store`
  ADD CONSTRAINT `FKStore384954` FOREIGN KEY (`StaffID`) REFERENCES `staff` (`StaffID`);

--
-- 資料表的限制式 `useraccount`
--
ALTER TABLE `useraccount`
  ADD CONSTRAINT `FKUserAccoun919948` FOREIGN KEY (`StaffID`) REFERENCES `staff` (`StaffID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

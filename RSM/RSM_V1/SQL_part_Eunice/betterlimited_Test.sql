-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jun 02, 2022 at 10:53 PM
-- Server version: 10.4.24-MariaDB
-- PHP Version: 7.4.29

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
-- Table structure for table `customer`
--

CREATE TABLE `customer` (
  `CustomerID` int(5) NOT NULL,
  `Name` varchar(20) NOT NULL,
  `Address` varchar(50) NOT NULL,
  `Tel` int(8) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `deliverynote`
--

CREATE TABLE `deliverynote` (
  `DeliveryID` int(5) NOT NULL,
  `SalesOrderID` int(5) NOT NULL,
  `CustomerID` int(5) NOT NULL,
  `DeliveryDate` date NOT NULL,
  `DeliveryTime` time NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `goodreturnnote`
--

CREATE TABLE `goodreturnnote` (
  `ReturnNoteID` int(5) NOT NULL,
  `SalesOrderID` int(5) NOT NULL,
  `SupplierID` int(5) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `goodreturnnote_item`
--

CREATE TABLE `goodreturnnote_item` (
  `ReturnNoteID` int(5) NOT NULL,
  `ItemID` int(5) NOT NULL,
  `Qty` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `goodsreceivednote`
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
-- Table structure for table `installationorder`
--

CREATE TABLE `installationorder` (
  `InstallationID` int(5) NOT NULL,
  `SalesOrderID` int(5) NOT NULL,
  `CustomerID` int(5) NOT NULL,
  `InstallationDate` date NOT NULL,
  `InstallationTime` time NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `inventorystocklevel`
--

CREATE TABLE `inventorystocklevel` (
  `inventoryStockID` int(5) NOT NULL,
  `itemID` int(5) NOT NULL,
  `itemName` varchar(10) NOT NULL,
  `Quantity` int(3) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `item`
--

CREATE TABLE `item` (
  `ItemID` int(5) NOT NULL,
  `ItemCat` varchar(20) NOT NULL,
  `ItemName` varchar(20) NOT NULL,
  `ItemDesc` varchar(50) NOT NULL,
  `SalePrice` int(11) NOT NULL,
  `SupplierID` int(5) NOT NULL,
  `SupplierPirce` int(20) NOT NULL,
  `WarrantyMonth` int(11) NOT NULL,
  `RequestItemReorderRequestID` int(5) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `item`
--

INSERT INTO `item` (`ItemID`, `ItemCat`, `ItemName`, `ItemDesc`, `SalePrice`, `SupplierID`, `SupplierPirce`, `WarrantyMonth`, `RequestItemReorderRequestID`) VALUES
(1, 'T', 'phone', 'asssbj', 1000, 2, 122, 12, 0),
(2, 'w', 'TV', 'sdf', 10001, 2, 1222, 12, 1);

-- --------------------------------------------------------

--
-- Table structure for table `purchaseorder`
--

CREATE TABLE `purchaseorder` (
  `PurchaseOrderID` int(5) NOT NULL,
  `SupplierID` int(5) NOT NULL,
  `Price` int(5) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `purchaseorder_item`
--

CREATE TABLE `purchaseorder_item` (
  `PurchaseOrderID` int(5) NOT NULL,
  `ItemID` int(5) NOT NULL,
  `Qty` int(11) NOT NULL,
  `SupplierID` int(5) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `reorderrequest`
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
-- Table structure for table `reorderrequest_item`
--

CREATE TABLE `reorderrequest_item` (
  `ItemID` int(5) NOT NULL,
  `ReorderRequestID` int(5) NOT NULL,
  `Qty` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `restockrequest`
--

CREATE TABLE `restockrequest` (
  `RestockRequestID` int(5) NOT NULL,
  `StaffID` int(5) NOT NULL,
  `RequestDate` date NOT NULL,
  `RequestTime` time(6) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `restockrequest`
--

INSERT INTO `restockrequest` (`RestockRequestID`, `StaffID`, `RequestDate`, `RequestTime`) VALUES
(10001, 10001, '2022-06-01', '18:53:08.000000'),
(10002, 10001, '2022-06-03', '08:09:41.000000');

-- --------------------------------------------------------

--
-- Table structure for table `restockrequest_item`
--

CREATE TABLE `restockrequest_item` (
  `RestockRequestID` int(5) NOT NULL,
  `itemID` int(5) NOT NULL,
  `ItemName` varchar(20) NOT NULL,
  `SupplierID` int(5) NOT NULL,
  `SupplierName` varchar(20) NOT NULL,
  `Quantity` int(3) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `restockrequest_item`
--

INSERT INTO `restockrequest_item` (`RestockRequestID`, `itemID`, `ItemName`, `SupplierID`, `SupplierName`, `Quantity`) VALUES
(10001, 1, '', 0, '', 20);

-- --------------------------------------------------------

--
-- Table structure for table `retailstocklevel`
--

CREATE TABLE `retailstocklevel` (
  `retailStockID` int(5) NOT NULL,
  `itemID` int(5) NOT NULL,
  `itemName` varchar(20) NOT NULL,
  `storeName` varchar(10) NOT NULL,
  `Quantity` int(3) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `salesorder`
--

CREATE TABLE `salesorder` (
  `SalesOrderID` int(5) NOT NULL,
  `StoreID` int(5) NOT NULL,
  `StaffID` int(5) NOT NULL,
  `PaidAmt` int(20) NOT NULL,
  `Date` date NOT NULL,
  `Time` time NOT NULL,
  `ExpDate` date NOT NULL,
  `CustomerID` int(5) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `salesorder_item`
--

CREATE TABLE `salesorder_item` (
  `OrderID` int(5) NOT NULL,
  `ItemID` int(5) NOT NULL,
  `SalePrice` int(11) NOT NULL,
  `Qty` int(11) NOT NULL,
  `WarrantyMouth` int(11) DEFAULT NULL,
  `SerialNo` varchar(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `salesreceipt`
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
-- Table structure for table `staff`
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
-- Dumping data for table `staff`
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
-- Table structure for table `store`
--

CREATE TABLE `store` (
  `StoreID` int(5) NOT NULL,
  `Address` varchar(50) NOT NULL,
  `Tel` int(8) NOT NULL,
  `StaffID` int(5) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `supplier`
--

CREATE TABLE `supplier` (
  `SupplierID` int(5) NOT NULL,
  `SupplierName` varchar(20) NOT NULL,
  `Address` varchar(50) NOT NULL,
  `Tel` int(8) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `supplier`
--

INSERT INTO `supplier` (`SupplierID`, `SupplierName`, `Address`, `Tel`) VALUES
(1, 'abc', 'addd', 12345678),
(2, 'aa', 'sdff', 23456789);

-- --------------------------------------------------------

--
-- Table structure for table `useraccount`
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
-- Dumping data for table `useraccount`
--

INSERT INTO `useraccount` (`UserAccountID`, `StaffID`, `UserName`, `Password`, `Email`, `CreateDateTime`, `LastLoginDateTime`) VALUES
(10001, 10001, 'admin', 'qwer1234', 'betterlimited10001@gmail.com', '2022-05-24 20:04:05', '2022-05-28 21:52:14'),
(10008, 10001, 'admin2', 'qwer1234', 'betterlimited10001@gmail.com', '2022-05-27 04:59:15', NULL),
(10011, 10001, 'admin2', 'qwer1234', 'betterlimited10001@gmail.com', '2022-05-27 05:52:37', NULL),
(10012, 10001, 'admin3', 'qwer1234', 'betterlimited10001@gmail.com', '2022-05-27 05:55:06', NULL),
(10014, 10002, 'betterlimited', 'qwer1234', 'betterlimited999@betterlimited.com', '2022-05-28 05:03:40', '2022-05-28 05:04:10'),
(10015, 10002, 'betterlimmited2', 'qwer1234', 'betterlimited999@betterlimited.com', '2022-05-28 05:16:18', NULL);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `customer`
--
ALTER TABLE `customer`
  ADD PRIMARY KEY (`CustomerID`);

--
-- Indexes for table `deliverynote`
--
ALTER TABLE `deliverynote`
  ADD PRIMARY KEY (`DeliveryID`),
  ADD KEY `FKDeliveryNo488459` (`CustomerID`),
  ADD KEY `FKDeliveryNo330361` (`SalesOrderID`);

--
-- Indexes for table `goodreturnnote`
--
ALTER TABLE `goodreturnnote`
  ADD PRIMARY KEY (`ReturnNoteID`),
  ADD KEY `FKGoodReturn385517` (`SupplierID`),
  ADD KEY `FKGoodReturn63513` (`SalesOrderID`);

--
-- Indexes for table `goodreturnnote_item`
--
ALTER TABLE `goodreturnnote_item`
  ADD PRIMARY KEY (`ReturnNoteID`,`ItemID`),
  ADD KEY `FKGoodReturn748003` (`ItemID`);

--
-- Indexes for table `goodsreceivednote`
--
ALTER TABLE `goodsreceivednote`
  ADD PRIMARY KEY (`ReceivedID`,`PurchaseOrderID`),
  ADD KEY `FKGoodsRecei36177` (`PurchaseOrderID`),
  ADD KEY `FKGoodsRecei913086` (`SupplierID`);

--
-- Indexes for table `installationorder`
--
ALTER TABLE `installationorder`
  ADD PRIMARY KEY (`InstallationID`),
  ADD KEY `FKInstallati300044` (`SalesOrderID`),
  ADD KEY `FKInstallati141946` (`CustomerID`);

--
-- Indexes for table `item`
--
ALTER TABLE `item`
  ADD PRIMARY KEY (`ItemID`),
  ADD KEY `FKItem506810` (`SupplierID`);

--
-- Indexes for table `purchaseorder`
--
ALTER TABLE `purchaseorder`
  ADD PRIMARY KEY (`PurchaseOrderID`),
  ADD KEY `FKPurchaseOr510102` (`SupplierID`);

--
-- Indexes for table `purchaseorder_item`
--
ALTER TABLE `purchaseorder_item`
  ADD PRIMARY KEY (`PurchaseOrderID`,`ItemID`),
  ADD KEY `FKPurchaseOr100230` (`ItemID`);

--
-- Indexes for table `reorderrequest`
--
ALTER TABLE `reorderrequest`
  ADD PRIMARY KEY (`ReorderRequestID`),
  ADD KEY `FKReorderReq909591` (`StaffID`);

--
-- Indexes for table `reorderrequest_item`
--
ALTER TABLE `reorderrequest_item`
  ADD PRIMARY KEY (`ItemID`,`ReorderRequestID`),
  ADD KEY `FKReorderReq254158` (`ReorderRequestID`);

--
-- Indexes for table `restockrequest`
--
ALTER TABLE `restockrequest`
  ADD PRIMARY KEY (`RestockRequestID`);

--
-- Indexes for table `salesorder`
--
ALTER TABLE `salesorder`
  ADD PRIMARY KEY (`SalesOrderID`),
  ADD KEY `FKSalesOrder557619` (`CustomerID`),
  ADD KEY `FKSalesOrder841473` (`StoreID`),
  ADD KEY `FKSalesOrder426975` (`StaffID`);

--
-- Indexes for table `salesorder_item`
--
ALTER TABLE `salesorder_item`
  ADD PRIMARY KEY (`OrderID`),
  ADD KEY `FKSalesOrder929714` (`OrderID`),
  ADD KEY `FKSalesOrder804327` (`ItemID`);

--
-- Indexes for table `salesreceipt`
--
ALTER TABLE `salesreceipt`
  ADD PRIMARY KEY (`ReceiptID`),
  ADD KEY `FKSalesRecei652713` (`SalesOrderID`),
  ADD KEY `FKSalesRecei494615` (`CustomerID`);

--
-- Indexes for table `staff`
--
ALTER TABLE `staff`
  ADD PRIMARY KEY (`StaffID`);

--
-- Indexes for table `store`
--
ALTER TABLE `store`
  ADD PRIMARY KEY (`StoreID`),
  ADD KEY `FKStore384954` (`StaffID`);

--
-- Indexes for table `supplier`
--
ALTER TABLE `supplier`
  ADD PRIMARY KEY (`SupplierID`);

--
-- Indexes for table `useraccount`
--
ALTER TABLE `useraccount`
  ADD PRIMARY KEY (`UserAccountID`),
  ADD KEY `FKUserAccoun919948` (`StaffID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `customer`
--
ALTER TABLE `customer`
  MODIFY `CustomerID` int(5) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `deliverynote`
--
ALTER TABLE `deliverynote`
  MODIFY `DeliveryID` int(5) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `goodreturnnote`
--
ALTER TABLE `goodreturnnote`
  MODIFY `ReturnNoteID` int(5) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `goodsreceivednote`
--
ALTER TABLE `goodsreceivednote`
  MODIFY `ReceivedID` int(5) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `installationorder`
--
ALTER TABLE `installationorder`
  MODIFY `InstallationID` int(5) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `item`
--
ALTER TABLE `item`
  MODIFY `ItemID` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `purchaseorder`
--
ALTER TABLE `purchaseorder`
  MODIFY `PurchaseOrderID` int(5) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `reorderrequest`
--
ALTER TABLE `reorderrequest`
  MODIFY `ReorderRequestID` int(5) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `salesorder`
--
ALTER TABLE `salesorder`
  MODIFY `SalesOrderID` int(5) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `salesreceipt`
--
ALTER TABLE `salesreceipt`
  MODIFY `ReceiptID` int(5) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `staff`
--
ALTER TABLE `staff`
  MODIFY `StaffID` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10045;

--
-- AUTO_INCREMENT for table `store`
--
ALTER TABLE `store`
  MODIFY `StoreID` int(5) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `supplier`
--
ALTER TABLE `supplier`
  MODIFY `SupplierID` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `useraccount`
--
ALTER TABLE `useraccount`
  MODIFY `UserAccountID` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10019;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `deliverynote`
--
ALTER TABLE `deliverynote`
  ADD CONSTRAINT `FKDeliveryNo330361` FOREIGN KEY (`SalesOrderID`) REFERENCES `salesorder` (`SalesOrderID`),
  ADD CONSTRAINT `FKDeliveryNo488459` FOREIGN KEY (`CustomerID`) REFERENCES `customer` (`CustomerID`);

--
-- Constraints for table `goodreturnnote`
--
ALTER TABLE `goodreturnnote`
  ADD CONSTRAINT `FKGoodReturn385517` FOREIGN KEY (`SupplierID`) REFERENCES `supplier` (`SupplierID`),
  ADD CONSTRAINT `FKGoodReturn63513` FOREIGN KEY (`SalesOrderID`) REFERENCES `salesorder` (`SalesOrderID`);

--
-- Constraints for table `goodreturnnote_item`
--
ALTER TABLE `goodreturnnote_item`
  ADD CONSTRAINT `FKGoodReturn395895` FOREIGN KEY (`ReturnNoteID`) REFERENCES `goodreturnnote` (`ReturnNoteID`),
  ADD CONSTRAINT `FKGoodReturn748003` FOREIGN KEY (`ItemID`) REFERENCES `item` (`ItemID`);

--
-- Constraints for table `goodsreceivednote`
--
ALTER TABLE `goodsreceivednote`
  ADD CONSTRAINT `FKGoodsRecei36177` FOREIGN KEY (`PurchaseOrderID`) REFERENCES `purchaseorder` (`PurchaseOrderID`),
  ADD CONSTRAINT `FKGoodsRecei913086` FOREIGN KEY (`SupplierID`) REFERENCES `supplier` (`SupplierID`);

--
-- Constraints for table `installationorder`
--
ALTER TABLE `installationorder`
  ADD CONSTRAINT `FKInstallati141946` FOREIGN KEY (`CustomerID`) REFERENCES `customer` (`CustomerID`),
  ADD CONSTRAINT `FKInstallati300044` FOREIGN KEY (`SalesOrderID`) REFERENCES `salesorder` (`SalesOrderID`);

--
-- Constraints for table `item`
--
ALTER TABLE `item`
  ADD CONSTRAINT `FKItem506810` FOREIGN KEY (`SupplierID`) REFERENCES `supplier` (`SupplierID`);

--
-- Constraints for table `purchaseorder`
--
ALTER TABLE `purchaseorder`
  ADD CONSTRAINT `FKPurchaseOr510102` FOREIGN KEY (`SupplierID`) REFERENCES `supplier` (`SupplierID`);

--
-- Constraints for table `purchaseorder_item`
--
ALTER TABLE `purchaseorder_item`
  ADD CONSTRAINT `FKPurchaseOr100230` FOREIGN KEY (`ItemID`) REFERENCES `item` (`ItemID`),
  ADD CONSTRAINT `FKPurchaseOr444232` FOREIGN KEY (`PurchaseOrderID`) REFERENCES `purchaseorder` (`PurchaseOrderID`);

--
-- Constraints for table `reorderrequest`
--
ALTER TABLE `reorderrequest`
  ADD CONSTRAINT `FKReorderReq909591` FOREIGN KEY (`StaffID`) REFERENCES `staff` (`StaffID`);

--
-- Constraints for table `reorderrequest_item`
--
ALTER TABLE `reorderrequest_item`
  ADD CONSTRAINT `FKReorderReq254158` FOREIGN KEY (`ReorderRequestID`) REFERENCES `reorderrequest` (`ReorderRequestID`),
  ADD CONSTRAINT `FKReorderReq782151` FOREIGN KEY (`ItemID`) REFERENCES `item` (`ItemID`);

--
-- Constraints for table `salesorder`
--
ALTER TABLE `salesorder`
  ADD CONSTRAINT `FKSalesOrder426975` FOREIGN KEY (`StaffID`) REFERENCES `staff` (`StaffID`),
  ADD CONSTRAINT `FKSalesOrder557619` FOREIGN KEY (`CustomerID`) REFERENCES `customer` (`CustomerID`),
  ADD CONSTRAINT `FKSalesOrder841473` FOREIGN KEY (`StoreID`) REFERENCES `store` (`StoreID`);

--
-- Constraints for table `salesorder_item`
--
ALTER TABLE `salesorder_item`
  ADD CONSTRAINT `FKSalesOrder804327` FOREIGN KEY (`ItemID`) REFERENCES `item` (`ItemID`),
  ADD CONSTRAINT `FKSalesOrder929714` FOREIGN KEY (`OrderID`) REFERENCES `salesorder` (`SalesOrderID`);

--
-- Constraints for table `salesreceipt`
--
ALTER TABLE `salesreceipt`
  ADD CONSTRAINT `FKSalesRecei494615` FOREIGN KEY (`CustomerID`) REFERENCES `customer` (`CustomerID`),
  ADD CONSTRAINT `FKSalesRecei652713` FOREIGN KEY (`SalesOrderID`) REFERENCES `salesorder` (`SalesOrderID`);

--
-- Constraints for table `store`
--
ALTER TABLE `store`
  ADD CONSTRAINT `FKStore384954` FOREIGN KEY (`StaffID`) REFERENCES `staff` (`StaffID`);

--
-- Constraints for table `useraccount`
--
ALTER TABLE `useraccount`
  ADD CONSTRAINT `FKUserAccoun919948` FOREIGN KEY (`StaffID`) REFERENCES `staff` (`StaffID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

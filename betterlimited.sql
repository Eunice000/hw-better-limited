-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 24, 2022 at 02:16 PM
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
-- Table structure for table `customer`
--

CREATE TABLE `customer` (
  `CustomerID` int(11) NOT NULL,
  `Name` varchar(20) NOT NULL,
  `Address` varchar(50) NOT NULL,
  `Tel` int(8) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `deliverynote`
--

CREATE TABLE `deliverynote` (
  `DeliveryID` int(11) NOT NULL,
  `SalesOrderID` int(11) NOT NULL,
  `CustomerID` int(11) NOT NULL,
  `DeliveryDate` date NOT NULL,
  `DeliveryTime` time NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `goodreturnnote`
--

CREATE TABLE `goodreturnnote` (
  `ReturnNoteID` int(11) NOT NULL,
  `SalesOrderID` int(11) NOT NULL,
  `SupplierID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `goodreturnnote_item`
--

CREATE TABLE `goodreturnnote_item` (
  `ReturnNoteID` int(11) NOT NULL,
  `ItemID` int(11) NOT NULL,
  `Qty` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `goodsreceivednote`
--

CREATE TABLE `goodsreceivednote` (
  `ReceivedID` int(11) NOT NULL,
  `PurchaseOrderID` int(11) NOT NULL,
  `SupplierID` int(11) NOT NULL,
  `InboundDate` int(11) NOT NULL,
  `InboundTime` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `installationorder`
--

CREATE TABLE `installationorder` (
  `InstallationID` int(11) NOT NULL,
  `SalesOrderID` int(11) NOT NULL,
  `CustomerID` int(11) NOT NULL,
  `InstallationDate` date NOT NULL,
  `InstallationTime` time NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `item`
--

CREATE TABLE `item` (
  `ItemID` int(11) NOT NULL,
  `ItemCat` varchar(20) NOT NULL,
  `ItemName` varchar(20) NOT NULL,
  `ItemDesc` varchar(50) NOT NULL,
  `SalePrice` int(11) NOT NULL,
  `SupplierID` int(11) NOT NULL,
  `SupplierPirce` int(20) NOT NULL,
  `WarrantyMonth` int(11) NOT NULL,
  `RequestItemReorderRequestID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `purchaseorder`
--

CREATE TABLE `purchaseorder` (
  `PurchaseOrderID` int(11) NOT NULL,
  `SupplierID` int(11) NOT NULL,
  `Price` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `purchaseorder_item`
--

CREATE TABLE `purchaseorder_item` (
  `PurchaseOrderID` int(11) NOT NULL,
  `ItemID` int(11) NOT NULL,
  `Qty` int(11) NOT NULL,
  `SupplierID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `reorderrequest`
--

CREATE TABLE `reorderrequest` (
  `ReorderRequestID` int(11) NOT NULL,
  `StaffID` int(11) NOT NULL,
  `RequestDate` date NOT NULL,
  `RequestTime` time NOT NULL,
  `PurchaseOrderPurchaseOrderID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `reorderrequest_item`
--

CREATE TABLE `reorderrequest_item` (
  `ItemID` int(11) NOT NULL,
  `ReorderRequestID` int(11) NOT NULL,
  `Qty` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `salesorder`
--

CREATE TABLE `salesorder` (
  `SalesOrderID` int(11) NOT NULL,
  `StoreID` int(11) NOT NULL,
  `StaffID` int(11) NOT NULL,
  `PaidAmt` int(20) NOT NULL,
  `Date` date NOT NULL,
  `Time` time NOT NULL,
  `ExpDate` date NOT NULL,
  `CustomerID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `salesorder_item`
--

CREATE TABLE `salesorder_item` (
  `OrderID` int(11) NOT NULL,
  `ItemID` int(11) NOT NULL,
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
  `ReceiptID` int(11) NOT NULL,
  `SalesOrderID` int(11) NOT NULL,
  `CustomerID` int(11) NOT NULL,
  `Qty` int(11) NOT NULL,
  `Price` int(11) NOT NULL,
  `PaymentType` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `staff`
--

CREATE TABLE `staff` (
  `StaffID` int(11) NOT NULL,
  `StaffName` varchar(20) NOT NULL,
  `Gender` varchar(1) NOT NULL,
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
(10001, 'admin', 'M', '2022-01-01', 24368333, 'betterlimited10001@gmail.com', 'admin', 'admin', NULL);

-- --------------------------------------------------------

--
-- Table structure for table `store`
--

CREATE TABLE `store` (
  `StoreID` int(11) NOT NULL,
  `Address` varchar(50) NOT NULL,
  `Tel` int(8) NOT NULL,
  `StaffID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `supplier`
--

CREATE TABLE `supplier` (
  `SupplierID` int(11) NOT NULL,
  `SupplierName` varchar(20) NOT NULL,
  `Address` varchar(50) NOT NULL,
  `Tel` int(8) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `useraccount`
--

CREATE TABLE `useraccount` (
  `UserAccountID` int(11) NOT NULL,
  `StaffID` int(11) NOT NULL,
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
(10001, 10001, 'admin', 'qwer1234', 'betterlimited10001@gmail.com', '2022-05-24 20:04:05', NULL);

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
  MODIFY `CustomerID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `deliverynote`
--
ALTER TABLE `deliverynote`
  MODIFY `DeliveryID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `goodreturnnote`
--
ALTER TABLE `goodreturnnote`
  MODIFY `ReturnNoteID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `installationorder`
--
ALTER TABLE `installationorder`
  MODIFY `InstallationID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `item`
--
ALTER TABLE `item`
  MODIFY `ItemID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `purchaseorder`
--
ALTER TABLE `purchaseorder`
  MODIFY `PurchaseOrderID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `reorderrequest`
--
ALTER TABLE `reorderrequest`
  MODIFY `ReorderRequestID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `salesorder`
--
ALTER TABLE `salesorder`
  MODIFY `SalesOrderID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `salesreceipt`
--
ALTER TABLE `salesreceipt`
  MODIFY `ReceiptID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `staff`
--
ALTER TABLE `staff`
  MODIFY `StaffID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10002;

--
-- AUTO_INCREMENT for table `store`
--
ALTER TABLE `store`
  MODIFY `StoreID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `supplier`
--
ALTER TABLE `supplier`
  MODIFY `SupplierID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `useraccount`
--
ALTER TABLE `useraccount`
  MODIFY `UserAccountID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10002;

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

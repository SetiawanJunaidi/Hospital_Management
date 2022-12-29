-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Dec 29, 2022 at 03:04 PM
-- Server version: 10.4.21-MariaDB
-- PHP Version: 8.0.10

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `hospital`
--

-- --------------------------------------------------------

--
-- Table structure for table `checkout`
--

CREATE TABLE `checkout` (
  `Id` tinyint(4) NOT NULL,
  `name` varchar(16) DEFAULT NULL,
  `gen` varchar(4) DEFAULT NULL,
  `age` varchar(2) DEFAULT NULL,
  `contact` varchar(11) DEFAULT NULL,
  `addr` varchar(24) DEFAULT NULL,
  `disease` varchar(7) DEFAULT NULL,
  `date_in` varchar(17) DEFAULT NULL,
  `date_out` varchar(17) DEFAULT NULL,
  `build` varchar(4) DEFAULT NULL,
  `r_no` varchar(2) DEFAULT NULL,
  `r_type` varchar(8) DEFAULT NULL,
  `status` varchar(6) DEFAULT NULL,
  `med_price` varchar(5) DEFAULT NULL,
  `total` varchar(5) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `checkout`
--

INSERT INTO `checkout` (`Id`, `name`, `gen`, `age`, `contact`, `addr`, `disease`, `date_in`, `date_out`, `build`, `r_no`, `r_type`, `status`, `med_price`, `total`) VALUES
(2, 'sasuke', 'Male', '21', '0989079', 'probolinggo', 'stroke', '20/12/2022', '27/12/2022', 'stan', '23', 'vip', 'stable', '20000', '30000'),
(3, 'didik s', 'Male', '22', '0910871987', 'jogja', 'dbd', '23/04/2022', '30/04/2022', 'stan', '21', 'mawar 2', 'sakit', '50000', ''),
(5, 'dani', 'Male', '29', '09897789', 'merapi', 'DBD', '23/02/2022', '30/02/2022', 'stan', '12', 'melati', 'sembuh', '15000', '30000');

-- --------------------------------------------------------

--
-- Table structure for table `patient`
--

CREATE TABLE `patient` (
  `Id` tinyint(4) NOT NULL,
  `name` varchar(16) DEFAULT NULL,
  `gen` varchar(6) DEFAULT NULL,
  `age` varchar(2) DEFAULT NULL,
  `date` varchar(17) DEFAULT NULL,
  `cont` varchar(11) DEFAULT NULL,
  `addr` varchar(24) DEFAULT NULL,
  `disease` varchar(7) DEFAULT NULL,
  `status` varchar(6) DEFAULT NULL,
  `r_type` varchar(8) DEFAULT NULL,
  `building` varchar(13) DEFAULT NULL,
  `r_no` varchar(2) DEFAULT NULL,
  `price` varchar(5) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `patient`
--

INSERT INTO `patient` (`Id`, `name`, `gen`, `age`, `date`, `cont`, `addr`, `disease`, `status`, `r_type`, `building`, `r_no`, `price`) VALUES
(1, 'naruto', 'Male', '24', '28/12/2002', '0827678981', 'jogja', 'stroke', 'stable', 'vip', 'standard', '22', '23000'),
(3, 'sasuke', 'Male', '21', '23/1/2001', '0989079', 'probolinggo', 'stroke', 'stable', 'vip', 'standard', '12', '40000'),
(4, 'iwan', 'Male', '20', '27/01/2001', '0822337439', 'bantul', 'cough', 'stable', 'vip', 'standard', '27', '50000'),
(5, 'dio', 'Male', '20', '20/2/2022', '082929129', 'sleman', 'batuk', 'stabil', 'anggrek ', 'standard', '22', '12000'),
(6, 'didik s', 'Male', '22', '12/02/1997', '0910871987', 'jogja', 'dbd', 'sakit', 'mawar 2', 'standard', '21', '21000'),
(8, 'dani', 'Male', '29', '12/05/1995', '09897789', 'merapi', 'DBD', 'sakit', 'melati', 'standard', '12', '15000');

-- --------------------------------------------------------

--
-- Table structure for table `room`
--

CREATE TABLE `room` (
  `Id` tinyint(4) NOT NULL,
  `building` tinyint(4) DEFAULT NULL,
  `r_type` varchar(8) DEFAULT NULL,
  `r_no` varchar(3) DEFAULT NULL,
  `no_bed` tinyint(4) DEFAULT NULL,
  `price` smallint(6) DEFAULT NULL,
  `r_status` varchar(6) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `room`
--

INSERT INTO `room` (`Id`, `building`, `r_type`, `r_no`, `no_bed`, `price`, `r_status`) VALUES
(1, 1, 'ghf', 'fgd', 2, 300, 'ready'),
(3, 0, 'vip', '23', 12, 32767, 'ready'),
(4, 12, 'vip', '30', 4, 20000, 'ready'),
(5, 21, 'sakura', '10', 12, 32767, 'ready'),
(6, 12, 'anggrek', '3', 4, 32767, 'siap');

-- --------------------------------------------------------

--
-- Table structure for table `staff`
--

CREATE TABLE `staff` (
  `Id` tinyint(4) NOT NULL,
  `name` varchar(19) DEFAULT NULL,
  `gender` varchar(6) DEFAULT NULL,
  `position` varchar(11) DEFAULT NULL,
  `salary` mediumint(9) DEFAULT NULL,
  `contact` bigint(20) DEFAULT NULL,
  `address` varchar(15) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `staff`
--

INSERT INTO `staff` (`Id`, `name`, `gender`, `position`, `salary`, `contact`, `address`) VALUES
(4, 'tobi', 'Male', 'manajer', 8388607, 878262728, 'bantul'),
(7, 'roni', 'Male', 'perawat', 3000000, 9878900, 'bantul'),
(9, 'parto', 'Male', 'perawat', 2500000, 980980800, 'bantul');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `checkout`
--
ALTER TABLE `checkout`
  ADD PRIMARY KEY (`Id`);

--
-- Indexes for table `patient`
--
ALTER TABLE `patient`
  ADD PRIMARY KEY (`Id`);

--
-- Indexes for table `room`
--
ALTER TABLE `room`
  ADD PRIMARY KEY (`Id`);

--
-- Indexes for table `staff`
--
ALTER TABLE `staff`
  ADD PRIMARY KEY (`Id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `checkout`
--
ALTER TABLE `checkout`
  MODIFY `Id` tinyint(4) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `patient`
--
ALTER TABLE `patient`
  MODIFY `Id` tinyint(4) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT for table `room`
--
ALTER TABLE `room`
  MODIFY `Id` tinyint(4) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT for table `staff`
--
ALTER TABLE `staff`
  MODIFY `Id` tinyint(4) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

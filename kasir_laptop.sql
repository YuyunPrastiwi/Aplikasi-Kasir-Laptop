-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jul 18, 2024 at 03:08 AM
-- Server version: 10.4.28-MariaDB
-- PHP Version: 8.2.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `kasir_laptop`
--

-- --------------------------------------------------------

--
-- Table structure for table `data_laptop`
--

CREATE TABLE `data_laptop` (
  `kode_barang` char(50) NOT NULL,
  `nama_laptop` varchar(50) NOT NULL,
  `harga_laptop` varchar(100) NOT NULL,
  `jumlah_laptop` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `data_laptop`
--

INSERT INTO `data_laptop` (`kode_barang`, `nama_laptop`, `harga_laptop`, `jumlah_laptop`) VALUES
('001', 'Acer A314', '5.000.000', '20'),
('002', 'Acer EX105', '5.500.000', '10'),
('003', 'Acer G562', '8.000.000', '5'),
('004', 'Lenovo A432', '5.000.000', '11');

-- --------------------------------------------------------

--
-- Table structure for table `data_pembeli`
--

CREATE TABLE `data_pembeli` (
  `nama_pembeli` varchar(100) NOT NULL,
  `NIK` char(50) NOT NULL,
  `jenis_kelamin` varchar(20) NOT NULL,
  `alamat` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `data_pembeli`
--

INSERT INTO `data_pembeli` (`nama_pembeli`, `NIK`, `jenis_kelamin`, `alamat`) VALUES
('Yuyun', '3309287162535', 'perempuan', 'solo'),
('Yuyun', '26632735352', 'perempuan', 'karanganyar'),
('Yuyun', '3286171812', 'perempuan', 'solo'),
('Tiwi', '346867824', 'Perempuan', 'Sragen');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `data_laptop`
--
ALTER TABLE `data_laptop`
  ADD PRIMARY KEY (`kode_barang`),
  ADD UNIQUE KEY `jumlah` (`kode_barang`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

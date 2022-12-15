-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Dec 15, 2022 at 05:46 AM
-- Server version: 10.4.24-MariaDB
-- PHP Version: 8.1.6

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `vb_sistem_penitipan`
--

-- --------------------------------------------------------

--
-- Table structure for table `jenis_tempat`
--

CREATE TABLE `jenis_tempat` (
  `id` int(11) NOT NULL,
  `namaTempat` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `jenis_tempat`
--

INSERT INTO `jenis_tempat` (`id`, `namaTempat`) VALUES
(1, 'Bandara'),
(2, 'Pelabuhan'),
(3, 'Stasiun'),
(4, 'Toko');

-- --------------------------------------------------------

--
-- Table structure for table `jenis_ukuran`
--

CREATE TABLE `jenis_ukuran` (
  `id` int(11) NOT NULL,
  `ukuran` varchar(50) DEFAULT NULL,
  `biaya` int(10) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `jenis_ukuran`
--

INSERT INTO `jenis_ukuran` (`id`, `ukuran`, `biaya`) VALUES
(1, 'Large', 100),
(2, 'Medium', 75),
(3, 'Small', 50);

-- --------------------------------------------------------

--
-- Table structure for table `locker`
--

CREATE TABLE `locker` (
  `id` int(11) NOT NULL,
  `id_ukuran` int(10) DEFAULT NULL,
  `lokasi` varchar(50) DEFAULT NULL,
  `id_tempat` int(11) DEFAULT NULL,
  `status` enum('Terisi','Kosong') DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `locker`
--

INSERT INTO `locker` (`id`, `id_ukuran`, `lokasi`, `id_tempat`, `status`) VALUES
(1, 1, 'Soetta', 1, 'Kosong'),
(2, 2, 'Soetta', 1, 'Kosong'),
(3, 1, 'Bakauheuni', 2, 'Terisi'),
(4, 3, 'Bakauheuni', 2, 'Kosong'),
(5, 2, 'Bakauheuni', 2, 'Terisi');

-- --------------------------------------------------------

--
-- Table structure for table `penyewaan`
--

CREATE TABLE `penyewaan` (
  `id` int(11) NOT NULL,
  `id_locker` int(11) DEFAULT NULL,
  `tanggal_sewa` date DEFAULT NULL,
  `tanggal_kembali` date DEFAULT NULL,
  `bayar_sebelum_pinjam` int(10) DEFAULT NULL,
  `rencana_pinjam` int(10) DEFAULT NULL,
  `kelebihan_pinjam` int(10) DEFAULT NULL,
  `total_bayar` int(10) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `id` int(11) NOT NULL,
  `username` varchar(50) DEFAULT NULL,
  `email` varchar(50) DEFAULT NULL,
  `password` char(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `jenis_tempat`
--
ALTER TABLE `jenis_tempat`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `jenis_ukuran`
--
ALTER TABLE `jenis_ukuran`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `locker`
--
ALTER TABLE `locker`
  ADD PRIMARY KEY (`id`),
  ADD KEY `fk_locker_ukuran` (`id_ukuran`),
  ADD KEY `fk_locker_tempat` (`id_tempat`);

--
-- Indexes for table `penyewaan`
--
ALTER TABLE `penyewaan`
  ADD PRIMARY KEY (`id`),
  ADD KEY `fk_sewa_locker` (`id_locker`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `jenis_tempat`
--
ALTER TABLE `jenis_tempat`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `jenis_ukuran`
--
ALTER TABLE `jenis_ukuran`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `locker`
--
ALTER TABLE `locker`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `penyewaan`
--
ALTER TABLE `penyewaan`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `locker`
--
ALTER TABLE `locker`
  ADD CONSTRAINT `fk_locker_tempat` FOREIGN KEY (`id_tempat`) REFERENCES `jenis_tempat` (`id`) ON DELETE SET NULL ON UPDATE CASCADE,
  ADD CONSTRAINT `fk_locker_ukuran` FOREIGN KEY (`id_ukuran`) REFERENCES `jenis_ukuran` (`id`) ON DELETE SET NULL ON UPDATE CASCADE;

--
-- Constraints for table `penyewaan`
--
ALTER TABLE `penyewaan`
  ADD CONSTRAINT `fk_sewa_locker` FOREIGN KEY (`id_locker`) REFERENCES `locker` (`id`) ON DELETE SET NULL ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Dec 20, 2022 at 09:03 AM
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
-- Table structure for table `jenis_ukuran`
--

CREATE TABLE `jenis_ukuran` (
  `id` int(11) NOT NULL,
  `ukuran` varchar(50) DEFAULT NULL,
  `biaya` int(10) DEFAULT NULL,
  `infoKet` varchar(30) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `jenis_ukuran`
--

INSERT INTO `jenis_ukuran` (`id`, `ukuran`, `biaya`, `infoKet`) VALUES
(1, 'Large', 100, 'Berat barang maks. 3 kg'),
(2, 'Medium', 75, 'Berat barang maks. 2 kg'),
(3, 'Small', 50, 'Berat barang maks. 1 kg');

-- --------------------------------------------------------

--
-- Table structure for table `locker`
--

CREATE TABLE `locker` (
  `id` int(11) NOT NULL,
  `id_ukuran` int(10) DEFAULT NULL,
  `lokasi` varchar(50) DEFAULT NULL,
  `status` enum('Terisi','Kosong') DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `locker`
--

INSERT INTO `locker` (`id`, `id_ukuran`, `lokasi`, `status`) VALUES
(6, 1, 'A-1', 'Kosong'),
(7, 1, 'A-2', 'Kosong'),
(8, 1, 'A-3', 'Kosong'),
(9, 1, 'A-4', 'Kosong'),
(10, 1, 'A-5', 'Kosong'),
(11, 2, 'B-1', 'Terisi'),
(12, 2, 'B-2', 'Kosong'),
(13, 2, 'B-3', 'Kosong'),
(14, 2, 'B-4', 'Kosong'),
(15, 2, 'B-5', 'Kosong');

-- --------------------------------------------------------

--
-- Table structure for table `penyewaan`
--

CREATE TABLE `penyewaan` (
  `id` int(11) NOT NULL,
  `id_locker` int(11) NOT NULL,
  `tanggal_sewa` date DEFAULT NULL,
  `tanggal_kembali` date DEFAULT NULL,
  `bayar_sebelum_pinjam` int(11) DEFAULT NULL,
  `rencana_pinjam` int(10) DEFAULT NULL,
  `kelebihan_pinjam` int(10) DEFAULT NULL,
  `total_bayar` int(10) DEFAULT NULL,
  `ketUser` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `penyewaan`
--

INSERT INTO `penyewaan` (`id`, `id_locker`, `tanggal_sewa`, `tanggal_kembali`, `bayar_sebelum_pinjam`, `rencana_pinjam`, `kelebihan_pinjam`, `total_bayar`, `ketUser`) VALUES
(9, 12, '2022-12-19', '2022-12-24', 225, 3, 2, 245, 'Ini Punya Agus'),
(13, 6, '2022-12-20', '2022-12-26', 300, 3, 3, 330, 'Ini Punya Fares'),
(14, 7, '2022-12-20', '2022-12-24', 200, 2, 2, 220, 'Ini tes');

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
-- Indexes for table `jenis_ukuran`
--
ALTER TABLE `jenis_ukuran`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `locker`
--
ALTER TABLE `locker`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `lokasi_uk` (`lokasi`),
  ADD KEY `fk_locker_ukuran` (`id_ukuran`);

--
-- Indexes for table `penyewaan`
--
ALTER TABLE `penyewaan`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `id_loker_tanggal_sewa` (`id_locker`,`tanggal_sewa`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `jenis_ukuran`
--
ALTER TABLE `jenis_ukuran`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `locker`
--
ALTER TABLE `locker`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;

--
-- AUTO_INCREMENT for table `penyewaan`
--
ALTER TABLE `penyewaan`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=26;

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
  ADD CONSTRAINT `fk_locker_ukuran` FOREIGN KEY (`id_ukuran`) REFERENCES `jenis_ukuran` (`id`) ON DELETE SET NULL ON UPDATE CASCADE;

--
-- Constraints for table `penyewaan`
--
ALTER TABLE `penyewaan`
  ADD CONSTRAINT `fk_sewa_locker` FOREIGN KEY (`id_locker`) REFERENCES `locker` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

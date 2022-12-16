-- --------------------------------------------------------
-- Host:                         localhost
-- Server version:               10.4.25-MariaDB - mariadb.org binary distribution
-- Server OS:                    Win64
-- HeidiSQL Version:             12.1.0.6537
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


-- Dumping database structure for vb_sistem_penitipan
CREATE DATABASE IF NOT EXISTS `vb_sistem_penitipan` /*!40100 DEFAULT CHARACTER SET utf8mb4 */;
USE `vb_sistem_penitipan`;

-- Dumping structure for table vb_sistem_penitipan.jenis_ukuran
CREATE TABLE IF NOT EXISTS `jenis_ukuran` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `ukuran` varchar(50) DEFAULT NULL,
  `biaya` int(10) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- Dumping data for table vb_sistem_penitipan.jenis_ukuran: ~0 rows (approximately)

-- Dumping structure for table vb_sistem_penitipan.locker
CREATE TABLE IF NOT EXISTS `locker` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `id_ukuran` int(10) DEFAULT NULL,
  `lokasi` varchar(50) DEFAULT NULL,
  `status` enum('Terisi','Kosong') DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_locker_ukuran` (`id_ukuran`),
  CONSTRAINT `fk_locker_ukuran` FOREIGN KEY (`id_ukuran`) REFERENCES `jenis_ukuran` (`id`) ON DELETE SET NULL ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- Dumping data for table vb_sistem_penitipan.locker: ~0 rows (approximately)

-- Dumping structure for table vb_sistem_penitipan.penyewaan
CREATE TABLE IF NOT EXISTS `penyewaan` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `id_locker` int(11) DEFAULT NULL,
  `tanggal_sewa` date DEFAULT NULL,
  `tanggal_kembali` date DEFAULT NULL,
  `bayar_sebelum_pinjam` int(10) DEFAULT NULL,
  `rencana_pinjam` int(10) DEFAULT NULL,
  `kelebihan_pinjam` int(10) DEFAULT NULL,
  `total_bayar` int(10) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_locker` (`id_locker`),
  CONSTRAINT `fk_locker` FOREIGN KEY (`id_locker`) REFERENCES `locker` (`id`) ON DELETE SET NULL ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- Dumping data for table vb_sistem_penitipan.penyewaan: ~0 rows (approximately)

-- Dumping structure for table vb_sistem_penitipan.users
CREATE TABLE IF NOT EXISTS `users` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `username` varchar(50) DEFAULT NULL,
  `email` varchar(50) DEFAULT NULL,
  `password` char(50) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- Dumping data for table vb_sistem_penitipan.users: ~0 rows (approximately)

/*!40103 SET TIME_ZONE=IFNULL(@OLD_TIME_ZONE, 'system') */;
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;

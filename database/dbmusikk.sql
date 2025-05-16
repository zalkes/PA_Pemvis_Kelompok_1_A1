-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 16, 2025 at 07:45 PM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `dbmusikk`
--

-- --------------------------------------------------------

--
-- Table structure for table `tbmusik`
--

CREATE TABLE `tbmusik` (
  `id_musik` int(11) NOT NULL,
  `judul` text NOT NULL,
  `genre` varchar(15) NOT NULL,
  `artist` text NOT NULL,
  `tahun_rilis` int(11) NOT NULL,
  `gambar` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbmusik`
--

INSERT INTO `tbmusik` (`id_musik`, `judul`, `genre`, `artist`, `tahun_rilis`, `gambar`) VALUES
(5, 'Love', 'Pop', 'Wave to Earth', 2020, 'Gambar\\ab67616d0000b273c091fe6573f073f2e31b249f.jpg'),
(13, 'Always', 'Dangdut', 'Daniel Caesar', 2019, 'Gambar\\always.jpg'),
(15, 'Seasons', 'Pop', 'Wave to Earth', 2020, 'Gambar\\love.jpg'),
(17, '505', 'Rock', 'Arctict Monkeys', 2019, 'Gambar\\505.jpg'),
(18, 'Here With Me', 'Pop', 'd4vd', 2022, 'Gambar\\here2.jpg');

-- --------------------------------------------------------

--
-- Table structure for table `tbplaylist`
--

CREATE TABLE `tbplaylist` (
  `id_playlist` int(11) NOT NULL,
  `id_musik` int(11) NOT NULL,
  `id_user` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbplaylist`
--

INSERT INTO `tbplaylist` (`id_playlist`, `id_musik`, `id_user`) VALUES
(24, 5, 4),
(31, 5, 6),
(35, 5, 7),
(36, 13, 7);

-- --------------------------------------------------------

--
-- Table structure for table `tbuser`
--

CREATE TABLE `tbuser` (
  `id` int(11) NOT NULL,
  `username` text NOT NULL,
  `password` text NOT NULL,
  `gender` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbuser`
--

INSERT INTO `tbuser` (`id`, `username`, `password`, `gender`) VALUES
(1, 'zal', 'zal', 'pria'),
(2, 'admin', 'admin', ''),
(3, 'afrizal', '123', ''),
(4, 'p', 'p', 'wanita'),
(5, 'i', 'i', ''),
(6, 'keren', 'keren', 'pria'),
(7, 'oke12', 'oke12', 'pria');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tbmusik`
--
ALTER TABLE `tbmusik`
  ADD PRIMARY KEY (`id_musik`);

--
-- Indexes for table `tbplaylist`
--
ALTER TABLE `tbplaylist`
  ADD PRIMARY KEY (`id_playlist`),
  ADD KEY `id_musik` (`id_musik`),
  ADD KEY `id_user` (`id_user`);

--
-- Indexes for table `tbuser`
--
ALTER TABLE `tbuser`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tbmusik`
--
ALTER TABLE `tbmusik`
  MODIFY `id_musik` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=19;

--
-- AUTO_INCREMENT for table `tbplaylist`
--
ALTER TABLE `tbplaylist`
  MODIFY `id_playlist` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=37;

--
-- AUTO_INCREMENT for table `tbuser`
--
ALTER TABLE `tbuser`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `tbplaylist`
--
ALTER TABLE `tbplaylist`
  ADD CONSTRAINT `tbplaylist_ibfk_1` FOREIGN KEY (`id_user`) REFERENCES `tbuser` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `tbplaylist_ibfk_2` FOREIGN KEY (`id_musik`) REFERENCES `tbmusik` (`id_musik`) ON DELETE CASCADE ON UPDATE NO ACTION;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

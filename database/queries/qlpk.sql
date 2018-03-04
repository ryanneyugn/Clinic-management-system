-- phpMyAdmin SQL Dump
-- version 4.7.7
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Mar 04, 2018 at 08:08 AM
-- Server version: 10.1.30-MariaDB
-- PHP Version: 7.2.2

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `qlpk`
--

-- --------------------------------------------------------

--
-- Table structure for table `bacsi`
--

CREATE TABLE `bacsi` (
  `idUser` int(11) NOT NULL,
  `username` varchar(30) NOT NULL,
  `password` varchar(30) NOT NULL,
  `ten_BS` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `bacsi`
--

INSERT INTO `bacsi` (`idUser`, `username`, `password`, `ten_BS`) VALUES
(1, 'ryan', '1', 'Nguyễn Đỗ Bá Vinh');

-- --------------------------------------------------------

--
-- Table structure for table `benhnhan`
--

CREATE TABLE `benhnhan` (
  `idBN` int(10) UNSIGNED NOT NULL,
  `ten` varchar(100) NOT NULL,
  `address` varchar(200) DEFAULT NULL,
  `phone_num` varchar(50) NOT NULL,
  `tuoi` int(3) DEFAULT NULL,
  `PARA` int(4) UNSIGNED DEFAULT NULL,
  `nghe_nghiep` varchar(200) DEFAULT NULL,
  `tiencan_gd` longtext,
  `tiencan_bt` longtext
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `benhnhan`
--

INSERT INTO `benhnhan` (`idBN`, `ten`, `address`, `phone_num`, `tuoi`, `PARA`, `nghe_nghiep`, `tiencan_gd`, `tiencan_bt`) VALUES
(1, 'Thái Minh Thuận', NULL, '012415', NULL, 1234, NULL, NULL, NULL),
(2, 'Thuận', NULL, '0133333', NULL, NULL, NULL, NULL, NULL),
(3, 'Đường Vinh Tài', '', '021218409124', NULL, 0, '', '', ''),
(11, 'Võ Việt Tân', '', '0124124', 23, 0, '', '', ''),
(12, 'Nguyễn Văn A', '', '000', 23, 0, '', '', ''),
(13, 'Trần Văn B', '', '0210124', 24, 123, '', '', ''),
(14, 'Võ Việt Tân', '', '0124214092109', 0, 0, '', '', ''),
(15, 'Đường Vinh Tài', '', '02140912840912', 0, 0, '', '', ''),
(16, 'áafkjhaksjfhkljasf', '', '', 0, 0, '', '', '');

-- --------------------------------------------------------

--
-- Table structure for table `chitietthuoc`
--

CREATE TABLE `chitietthuoc` (
  `idCT_thuoc` int(10) UNSIGNED NOT NULL,
  `idThuoc` int(10) UNSIGNED NOT NULL,
  `tenthuoc` text NOT NULL,
  `so_vien` int(11) NOT NULL,
  `gia_ban` int(10) NOT NULL,
  `sl_trong_ngay` text,
  `moi_lan` varchar(150) DEFAULT NULL,
  `idToaThuoc` int(10) UNSIGNED NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `chitietthuoc`
--

INSERT INTO `chitietthuoc` (`idCT_thuoc`, `idThuoc`, `tenthuoc`, `so_vien`, `gia_ban`, `sl_trong_ngay`, `moi_lan`, `idToaThuoc`) VALUES
(1, 1, 'ABC', 2, 15, '2', '1', 4),
(2, 2, 'ABC', 3, 200, '3', '1', 4);

-- --------------------------------------------------------

--
-- Table structure for table `danhsachcho`
--

CREATE TABLE `danhsachcho` (
  `stt` int(3) UNSIGNED NOT NULL,
  `idBN` int(10) UNSIGNED NOT NULL,
  `khambenh` text,
  `sieuam` text,
  `xetnghiem` text
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `danhsachcho`
--

INSERT INTO `danhsachcho` (`stt`, `idBN`, `khambenh`, `sieuam`, `xetnghiem`) VALUES
(1, 2, '.', '', ''),
(4, 2, '', '.Thai 2D-Ngã âm đạo-Hình thái học-Màu', '');

-- --------------------------------------------------------

--
-- Table structure for table `phieukham`
--

CREATE TABLE `phieukham` (
  `idPhieuKham` int(10) UNSIGNED NOT NULL,
  `ngay_lap` datetime NOT NULL,
  `ten_BS` varchar(100) NOT NULL,
  `chan_doan` varchar(300) NOT NULL,
  `idBN` int(10) UNSIGNED DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `phieukham`
--

INSERT INTO `phieukham` (`idPhieuKham`, `ngay_lap`, `ten_BS`, `chan_doan`, `idBN`) VALUES
(1, '2018-03-04 01:05:48', 'Nguyễn Đỗ Bá Vinh', 'Chẩn đoán đầu tiên', 3),
(2, '2018-03-04 13:31:25', 'Nguyễn Đỗ Bá Vinh', 'Bệnh óc chó mãn tính', 3),
(3, '2018-03-04 13:40:53', 'Nguyễn Đỗ Bá Vinh', 'Khám hoài v má', 3),
(4, '2018-03-04 13:44:18', 'Nguyễn Đỗ Bá Vinh', 'Bệnh gì đó đại đi', 13);

-- --------------------------------------------------------

--
-- Table structure for table `thuoc`
--

CREATE TABLE `thuoc` (
  `idThuoc` int(10) UNSIGNED NOT NULL,
  `ten_thuoc` varchar(100) NOT NULL,
  `dvt` varchar(50) NOT NULL,
  `so_luong` int(11) NOT NULL,
  `gia_mua` double NOT NULL,
  `gia_ban` double NOT NULL,
  `han_sd` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `thuoc`
--

INSERT INTO `thuoc` (`idThuoc`, `ten_thuoc`, `dvt`, `so_luong`, `gia_mua`, `gia_ban`, `han_sd`) VALUES
(1, 'ABC', 'viên', 300, 12, 15, '2 nam'),
(2, 'BSAHDB', 'viên', 30, 10, 200, '3 tháng');

-- --------------------------------------------------------

--
-- Table structure for table `toathuoc`
--

CREATE TABLE `toathuoc` (
  `idToaThuoc` int(10) UNSIGNED NOT NULL,
  `ngay_lap` datetime NOT NULL,
  `so_ngay` int(11) NOT NULL,
  `loi_dan` varchar(300) NOT NULL,
  `tong_tien` double NOT NULL,
  `idPhieuKham` int(10) UNSIGNED DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `toathuoc`
--

INSERT INTO `toathuoc` (`idToaThuoc`, `ngay_lap`, `so_ngay`, `loi_dan`, `tong_tien`, `idPhieuKham`) VALUES
(1, '2018-03-04 01:06:59', 213, 'ABC', 180, 1),
(2, '2018-03-04 13:31:50', 10, 'Sao cũng đc', 630, 2),
(3, '2018-03-04 13:41:31', 1, 'Uống mỗi lần 3 viên, liều dùng trong 1 ngày', 135, 3),
(4, '2018-03-04 13:45:05', 1, 'Uống theo đơn thuốc', 630, 4);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `bacsi`
--
ALTER TABLE `bacsi`
  ADD PRIMARY KEY (`idUser`),
  ADD UNIQUE KEY `username` (`username`);

--
-- Indexes for table `benhnhan`
--
ALTER TABLE `benhnhan`
  ADD PRIMARY KEY (`idBN`);

--
-- Indexes for table `chitietthuoc`
--
ALTER TABLE `chitietthuoc`
  ADD PRIMARY KEY (`idCT_thuoc`);

--
-- Indexes for table `danhsachcho`
--
ALTER TABLE `danhsachcho`
  ADD PRIMARY KEY (`stt`);

--
-- Indexes for table `phieukham`
--
ALTER TABLE `phieukham`
  ADD PRIMARY KEY (`idPhieuKham`);

--
-- Indexes for table `thuoc`
--
ALTER TABLE `thuoc`
  ADD PRIMARY KEY (`idThuoc`);

--
-- Indexes for table `toathuoc`
--
ALTER TABLE `toathuoc`
  ADD PRIMARY KEY (`idToaThuoc`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `bacsi`
--
ALTER TABLE `bacsi`
  MODIFY `idUser` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `benhnhan`
--
ALTER TABLE `benhnhan`
  MODIFY `idBN` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=17;

--
-- AUTO_INCREMENT for table `chitietthuoc`
--
ALTER TABLE `chitietthuoc`
  MODIFY `idCT_thuoc` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `danhsachcho`
--
ALTER TABLE `danhsachcho`
  MODIFY `stt` int(3) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- AUTO_INCREMENT for table `phieukham`
--
ALTER TABLE `phieukham`
  MODIFY `idPhieuKham` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `thuoc`
--
ALTER TABLE `thuoc`
  MODIFY `idThuoc` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `toathuoc`
--
ALTER TABLE `toathuoc`
  MODIFY `idToaThuoc` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

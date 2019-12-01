-- phpMyAdmin SQL Dump
-- version 4.8.3
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3306
-- Generation Time: Nov 18, 2019 at 05:53 AM
-- Server version: 8.0.18
-- PHP Version: 7.2.10

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `employee_attendence`
--

-- --------------------------------------------------------

--
-- Table structure for table `attend`
--

DROP TABLE IF EXISTS `attend`;
CREATE TABLE IF NOT EXISTS `attend` (
  `emp_id` varchar(20) NOT NULL,
  `date` date NOT NULL,
  `in_time` varchar(10) NOT NULL,
  `out_time` varchar(10) NOT NULL,
  `ot_hours` double NOT NULL,
  PRIMARY KEY (`emp_id`,`date`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Dumping data for table `attend`
--

INSERT INTO `attend` (`emp_id`, `date`, `in_time`, `out_time`, `ot_hours`) VALUES
('56201', '2019-03-25', '09:23:58', '15:35:08', 0),
('56328', '2019-03-25', '08:21:21', '15:32:22', 11),
('56328', '2019-03-26', '07:14:28', '16:04:33', 0.21),
('56345', '2019-03-25', '09:22:42', '15:33:39', 0);

-- --------------------------------------------------------

--
-- Table structure for table `attend_im`
--

DROP TABLE IF EXISTS `attend_im`;
CREATE TABLE IF NOT EXISTS `attend_im` (
  `emp_id` varchar(20) NOT NULL,
  `date` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `in_time` varchar(10) NOT NULL,
  `late_mins` double NOT NULL,
  PRIMARY KEY (`emp_id`,`date`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Dumping data for table `attend_im`
--

INSERT INTO `attend_im` (`emp_id`, `date`, `in_time`, `late_mins`) VALUES
('56201', '2019-03-25', '09:23:58', 83),
('56328', '2019-03-25', '08:21:21', 21),
('56345', '2019-03-25', '09:22:42', 82);

-- --------------------------------------------------------

--
-- Table structure for table `attend_out`
--

DROP TABLE IF EXISTS `attend_out`;
CREATE TABLE IF NOT EXISTS `attend_out` (
  `emp_id` varchar(20) NOT NULL,
  `date` varchar(30) NOT NULL,
  `out_time` varchar(10) NOT NULL,
  `ot_mins` double NOT NULL,
  PRIMARY KEY (`emp_id`,`date`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Dumping data for table `attend_out`
--

INSERT INTO `attend_out` (`emp_id`, `date`, `out_time`, `ot_mins`) VALUES
('47472', '2019-03-25', '15:32:22', 32),
('47475', '2019-03-25', '15:32:22', 32),
('47483', '2019-03-25', '15:32:22', 32),
('50672', '2019-03-25', '15:36:44', 0),
('56201', '2019-03-25', '15:35:08', 5),
('56328', '2019-03-25', '15:32:22', 32),
('56345', '2019-03-25', '15:33:39', 33);

-- --------------------------------------------------------

--
-- Table structure for table `database_connect`
--

DROP TABLE IF EXISTS `database_connect`;
CREATE TABLE IF NOT EXISTS `database_connect` (
  `host` varchar(20) NOT NULL,
  `dbase` varchar(20) NOT NULL,
  `username` varchar(20) NOT NULL,
  `password` varchar(20) NOT NULL,
  PRIMARY KEY (`username`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- --------------------------------------------------------

--
-- Table structure for table `departments`
--

DROP TABLE IF EXISTS `departments`;
CREATE TABLE IF NOT EXISTS `departments` (
  `dept_index` int(11) NOT NULL AUTO_INCREMENT,
  `dept` varchar(10) NOT NULL,
  PRIMARY KEY (`dept_index`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Dumping data for table `departments`
--

INSERT INTO `departments` (`dept_index`, `dept`) VALUES
(1, 'dep1'),
(2, 'dep2'),
(3, 'dept3'),
(4, 'dep4'),
(5, 'dept5');

-- --------------------------------------------------------

--
-- Table structure for table `employee`
--

DROP TABLE IF EXISTS `employee`;
CREATE TABLE IF NOT EXISTS `employee` (
  `emp_id` varchar(20) NOT NULL,
  `nic` varchar(15) NOT NULL,
  `name` varchar(200) NOT NULL,
  `gender` varchar(10) NOT NULL,
  `contact` varchar(10) NOT NULL,
  `department` varchar(50) NOT NULL,
  `ot_class` varchar(20) NOT NULL,
  `start_time` varchar(20) NOT NULL,
  `reg_date` date NOT NULL,
  PRIMARY KEY (`emp_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Dumping data for table `employee`
--

INSERT INTO `employee` (`emp_id`, `nic`, `name`, `gender`, `contact`, `department`, `ot_class`, `start_time`, `reg_date`) VALUES
('47475', '', 'bimal', '', '', 'dep1', '15:00', '8:30', '2019-11-17'),
('47483', '', 'charith', '', '', 'dep4', '15:30', '8:00', '2019-11-17'),
('50672', '', 'rajitha', '', '', 'dep4', '16:00', '8:00', '2019-11-17'),
('56201', '', 'kamal', '', '', 'dept3', '15:30', '8:00', '2019-11-17'),
('56328', '', 'chiran', '', '', 'dep1', '15:00', '8:00', '2019-11-17'),
('56345', '', 'damith', '', '', 'dep1', '15:00', '8:00', '2019-11-17');

-- --------------------------------------------------------

--
-- Table structure for table `ot_classes`
--

DROP TABLE IF EXISTS `ot_classes`;
CREATE TABLE IF NOT EXISTS `ot_classes` (
  `ot_index` int(11) NOT NULL AUTO_INCREMENT,
  `class_time` varchar(10) NOT NULL,
  PRIMARY KEY (`ot_index`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Dumping data for table `ot_classes`
--

INSERT INTO `ot_classes` (`ot_index`, `class_time`) VALUES
(1, '15:00'),
(2, '15:30'),
(3, '16:00'),
(4, '16:30'),
(5, '17:00');

-- --------------------------------------------------------

--
-- Table structure for table `start_times`
--

DROP TABLE IF EXISTS `start_times`;
CREATE TABLE IF NOT EXISTS `start_times` (
  `start_index` int(11) NOT NULL AUTO_INCREMENT,
  `start_time` varchar(10) NOT NULL,
  PRIMARY KEY (`start_index`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Dumping data for table `start_times`
--

INSERT INTO `start_times` (`start_index`, `start_time`) VALUES
(1, '7:30'),
(2, '8:00'),
(3, '8:30'),
(4, '9:00'),
(5, '10:00');

-- --------------------------------------------------------

--
-- Table structure for table `user`
--

DROP TABLE IF EXISTS `user`;
CREATE TABLE IF NOT EXISTS `user` (
  `username` varchar(50) NOT NULL,
  `role` varchar(50) NOT NULL,
  `password` varchar(50) NOT NULL,
  PRIMARY KEY (`username`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Dumping data for table `user`
--

INSERT INTO `user` (`username`, `role`, `password`) VALUES
('chiran', 'admin', '1234'),
('lalana', 'admin', '2233');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

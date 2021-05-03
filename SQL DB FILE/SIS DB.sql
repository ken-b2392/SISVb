-- phpMyAdmin SQL Dump
-- version 4.8.5
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jun 25, 2020 at 02:13 AM
-- Server version: 10.1.38-MariaDB
-- PHP Version: 7.3.3

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `phpmyadmin`
--
CREATE DATABASE IF NOT EXISTS `phpmyadmin` DEFAULT CHARACTER SET utf8 COLLATE utf8_bin;
USE `phpmyadmin`;

-- --------------------------------------------------------

--
-- Table structure for table `pma__bookmark`
--

CREATE TABLE `pma__bookmark` (
  `id` int(11) NOT NULL,
  `dbase` varchar(255) COLLATE utf8_bin NOT NULL DEFAULT '',
  `user` varchar(255) COLLATE utf8_bin NOT NULL DEFAULT '',
  `label` varchar(255) CHARACTER SET utf8 NOT NULL DEFAULT '',
  `query` text COLLATE utf8_bin NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin COMMENT='Bookmarks';

-- --------------------------------------------------------

--
-- Table structure for table `pma__central_columns`
--

CREATE TABLE `pma__central_columns` (
  `db_name` varchar(64) COLLATE utf8_bin NOT NULL,
  `col_name` varchar(64) COLLATE utf8_bin NOT NULL,
  `col_type` varchar(64) COLLATE utf8_bin NOT NULL,
  `col_length` text COLLATE utf8_bin,
  `col_collation` varchar(64) COLLATE utf8_bin NOT NULL,
  `col_isNull` tinyint(1) NOT NULL,
  `col_extra` varchar(255) COLLATE utf8_bin DEFAULT '',
  `col_default` text COLLATE utf8_bin
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin COMMENT='Central list of columns';

-- --------------------------------------------------------

--
-- Table structure for table `pma__column_info`
--

CREATE TABLE `pma__column_info` (
  `id` int(5) UNSIGNED NOT NULL,
  `db_name` varchar(64) COLLATE utf8_bin NOT NULL DEFAULT '',
  `table_name` varchar(64) COLLATE utf8_bin NOT NULL DEFAULT '',
  `column_name` varchar(64) COLLATE utf8_bin NOT NULL DEFAULT '',
  `comment` varchar(255) CHARACTER SET utf8 NOT NULL DEFAULT '',
  `mimetype` varchar(255) CHARACTER SET utf8 NOT NULL DEFAULT '',
  `transformation` varchar(255) COLLATE utf8_bin NOT NULL DEFAULT '',
  `transformation_options` varchar(255) COLLATE utf8_bin NOT NULL DEFAULT '',
  `input_transformation` varchar(255) COLLATE utf8_bin NOT NULL DEFAULT '',
  `input_transformation_options` varchar(255) COLLATE utf8_bin NOT NULL DEFAULT ''
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin COMMENT='Column information for phpMyAdmin';

-- --------------------------------------------------------

--
-- Table structure for table `pma__designer_settings`
--

CREATE TABLE `pma__designer_settings` (
  `username` varchar(64) COLLATE utf8_bin NOT NULL,
  `settings_data` text COLLATE utf8_bin NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin COMMENT='Settings related to Designer';

--
-- Dumping data for table `pma__designer_settings`
--

INSERT INTO `pma__designer_settings` (`username`, `settings_data`) VALUES
('root', '{\"relation_lines\":\"true\",\"snap_to_grid\":\"off\",\"angular_direct\":\"direct\",\"full_screen\":\"on\",\"side_menu\":\"false\"}');

-- --------------------------------------------------------

--
-- Table structure for table `pma__export_templates`
--

CREATE TABLE `pma__export_templates` (
  `id` int(5) UNSIGNED NOT NULL,
  `username` varchar(64) COLLATE utf8_bin NOT NULL,
  `export_type` varchar(10) COLLATE utf8_bin NOT NULL,
  `template_name` varchar(64) COLLATE utf8_bin NOT NULL,
  `template_data` text COLLATE utf8_bin NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin COMMENT='Saved export templates';

-- --------------------------------------------------------

--
-- Table structure for table `pma__favorite`
--

CREATE TABLE `pma__favorite` (
  `username` varchar(64) COLLATE utf8_bin NOT NULL,
  `tables` text COLLATE utf8_bin NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin COMMENT='Favorite tables';

-- --------------------------------------------------------

--
-- Table structure for table `pma__history`
--

CREATE TABLE `pma__history` (
  `id` bigint(20) UNSIGNED NOT NULL,
  `username` varchar(64) COLLATE utf8_bin NOT NULL DEFAULT '',
  `db` varchar(64) COLLATE utf8_bin NOT NULL DEFAULT '',
  `table` varchar(64) COLLATE utf8_bin NOT NULL DEFAULT '',
  `timevalue` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `sqlquery` text COLLATE utf8_bin NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin COMMENT='SQL history for phpMyAdmin';

-- --------------------------------------------------------

--
-- Table structure for table `pma__navigationhiding`
--

CREATE TABLE `pma__navigationhiding` (
  `username` varchar(64) COLLATE utf8_bin NOT NULL,
  `item_name` varchar(64) COLLATE utf8_bin NOT NULL,
  `item_type` varchar(64) COLLATE utf8_bin NOT NULL,
  `db_name` varchar(64) COLLATE utf8_bin NOT NULL,
  `table_name` varchar(64) COLLATE utf8_bin NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin COMMENT='Hidden items of navigation tree';

-- --------------------------------------------------------

--
-- Table structure for table `pma__pdf_pages`
--

CREATE TABLE `pma__pdf_pages` (
  `db_name` varchar(64) COLLATE utf8_bin NOT NULL DEFAULT '',
  `page_nr` int(10) UNSIGNED NOT NULL,
  `page_descr` varchar(50) CHARACTER SET utf8 NOT NULL DEFAULT ''
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin COMMENT='PDF relation pages for phpMyAdmin';

-- --------------------------------------------------------

--
-- Table structure for table `pma__recent`
--

CREATE TABLE `pma__recent` (
  `username` varchar(64) COLLATE utf8_bin NOT NULL,
  `tables` text COLLATE utf8_bin NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin COMMENT='Recently accessed tables';

--
-- Dumping data for table `pma__recent`
--

INSERT INTO `pma__recent` (`username`, `tables`) VALUES
('root', '[{\"db\":\"sisdatabase\",\"table\":\"schooladminaccntstbl\"},{\"db\":\"sisdatabase\",\"table\":\"teacherinfotbl\"},{\"db\":\"sisdatabase\",\"table\":\"studinfotbl\"},{\"db\":\"sisdatabase\",\"table\":\"studsubjtbl\"},{\"db\":\"sisdatabase\",\"table\":\"assignedsubjtoteachtbl\"},{\"db\":\"sisdatabase\",\"table\":\"logstbl\"},{\"db\":\"sisdatabase\",\"table\":\"subjectstbl\"},{\"db\":\"sisdatabase\",\"table\":\"systemadmintbl\"},{\"db\":\"sisdatabase\",\"table\":\"tempsubjtbl\"},{\"db\":\"sisdatabase\",\"table\":\"tempSubjtbl\"}]');

-- --------------------------------------------------------

--
-- Table structure for table `pma__relation`
--

CREATE TABLE `pma__relation` (
  `master_db` varchar(64) COLLATE utf8_bin NOT NULL DEFAULT '',
  `master_table` varchar(64) COLLATE utf8_bin NOT NULL DEFAULT '',
  `master_field` varchar(64) COLLATE utf8_bin NOT NULL DEFAULT '',
  `foreign_db` varchar(64) COLLATE utf8_bin NOT NULL DEFAULT '',
  `foreign_table` varchar(64) COLLATE utf8_bin NOT NULL DEFAULT '',
  `foreign_field` varchar(64) COLLATE utf8_bin NOT NULL DEFAULT ''
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin COMMENT='Relation table';

-- --------------------------------------------------------

--
-- Table structure for table `pma__savedsearches`
--

CREATE TABLE `pma__savedsearches` (
  `id` int(5) UNSIGNED NOT NULL,
  `username` varchar(64) COLLATE utf8_bin NOT NULL DEFAULT '',
  `db_name` varchar(64) COLLATE utf8_bin NOT NULL DEFAULT '',
  `search_name` varchar(64) COLLATE utf8_bin NOT NULL DEFAULT '',
  `search_data` text COLLATE utf8_bin NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin COMMENT='Saved searches';

-- --------------------------------------------------------

--
-- Table structure for table `pma__table_coords`
--

CREATE TABLE `pma__table_coords` (
  `db_name` varchar(64) COLLATE utf8_bin NOT NULL DEFAULT '',
  `table_name` varchar(64) COLLATE utf8_bin NOT NULL DEFAULT '',
  `pdf_page_number` int(11) NOT NULL DEFAULT '0',
  `x` float UNSIGNED NOT NULL DEFAULT '0',
  `y` float UNSIGNED NOT NULL DEFAULT '0'
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin COMMENT='Table coordinates for phpMyAdmin PDF output';

-- --------------------------------------------------------

--
-- Table structure for table `pma__table_info`
--

CREATE TABLE `pma__table_info` (
  `db_name` varchar(64) COLLATE utf8_bin NOT NULL DEFAULT '',
  `table_name` varchar(64) COLLATE utf8_bin NOT NULL DEFAULT '',
  `display_field` varchar(64) COLLATE utf8_bin NOT NULL DEFAULT ''
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin COMMENT='Table information for phpMyAdmin';

-- --------------------------------------------------------

--
-- Table structure for table `pma__table_uiprefs`
--

CREATE TABLE `pma__table_uiprefs` (
  `username` varchar(64) COLLATE utf8_bin NOT NULL,
  `db_name` varchar(64) COLLATE utf8_bin NOT NULL,
  `table_name` varchar(64) COLLATE utf8_bin NOT NULL,
  `prefs` text COLLATE utf8_bin NOT NULL,
  `last_update` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin COMMENT='Tables'' UI preferences';

--
-- Dumping data for table `pma__table_uiprefs`
--

INSERT INTO `pma__table_uiprefs` (`username`, `db_name`, `table_name`, `prefs`, `last_update`) VALUES
('root', 'sisdatabase', 'studinfotbl', '{\"CREATE_TIME\":\"2020-04-03 15:11:06\"}', '2020-04-25 20:31:23'),
('root', 'sisdatabase', 'studsubjtbl', '{\"CREATE_TIME\":\"2020-04-26 12:11:54\"}', '2020-05-13 05:05:31');

-- --------------------------------------------------------

--
-- Table structure for table `pma__tracking`
--

CREATE TABLE `pma__tracking` (
  `db_name` varchar(64) COLLATE utf8_bin NOT NULL,
  `table_name` varchar(64) COLLATE utf8_bin NOT NULL,
  `version` int(10) UNSIGNED NOT NULL,
  `date_created` datetime NOT NULL,
  `date_updated` datetime NOT NULL,
  `schema_snapshot` text COLLATE utf8_bin NOT NULL,
  `schema_sql` text COLLATE utf8_bin,
  `data_sql` longtext COLLATE utf8_bin,
  `tracking` set('UPDATE','REPLACE','INSERT','DELETE','TRUNCATE','CREATE DATABASE','ALTER DATABASE','DROP DATABASE','CREATE TABLE','ALTER TABLE','RENAME TABLE','DROP TABLE','CREATE INDEX','DROP INDEX','CREATE VIEW','ALTER VIEW','DROP VIEW') COLLATE utf8_bin DEFAULT NULL,
  `tracking_active` int(1) UNSIGNED NOT NULL DEFAULT '1'
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin COMMENT='Database changes tracking for phpMyAdmin';

-- --------------------------------------------------------

--
-- Table structure for table `pma__userconfig`
--

CREATE TABLE `pma__userconfig` (
  `username` varchar(64) COLLATE utf8_bin NOT NULL,
  `timevalue` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `config_data` text COLLATE utf8_bin NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin COMMENT='User preferences storage for phpMyAdmin';

--
-- Dumping data for table `pma__userconfig`
--

INSERT INTO `pma__userconfig` (`username`, `timevalue`, `config_data`) VALUES
('', '2020-05-07 02:56:54', '{\"Console\\/Mode\":\"collapse\"}'),
('root', '2020-06-23 22:22:29', '{\"Console\\/Mode\":\"collapse\"}');

-- --------------------------------------------------------

--
-- Table structure for table `pma__usergroups`
--

CREATE TABLE `pma__usergroups` (
  `usergroup` varchar(64) COLLATE utf8_bin NOT NULL,
  `tab` varchar(64) COLLATE utf8_bin NOT NULL,
  `allowed` enum('Y','N') COLLATE utf8_bin NOT NULL DEFAULT 'N'
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin COMMENT='User groups with configured menu items';

-- --------------------------------------------------------

--
-- Table structure for table `pma__users`
--

CREATE TABLE `pma__users` (
  `username` varchar(64) COLLATE utf8_bin NOT NULL,
  `usergroup` varchar(64) COLLATE utf8_bin NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin COMMENT='Users and their assignments to user groups';

--
-- Indexes for dumped tables
--

--
-- Indexes for table `pma__bookmark`
--
ALTER TABLE `pma__bookmark`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `pma__central_columns`
--
ALTER TABLE `pma__central_columns`
  ADD PRIMARY KEY (`db_name`,`col_name`);

--
-- Indexes for table `pma__column_info`
--
ALTER TABLE `pma__column_info`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `db_name` (`db_name`,`table_name`,`column_name`);

--
-- Indexes for table `pma__designer_settings`
--
ALTER TABLE `pma__designer_settings`
  ADD PRIMARY KEY (`username`);

--
-- Indexes for table `pma__export_templates`
--
ALTER TABLE `pma__export_templates`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `u_user_type_template` (`username`,`export_type`,`template_name`);

--
-- Indexes for table `pma__favorite`
--
ALTER TABLE `pma__favorite`
  ADD PRIMARY KEY (`username`);

--
-- Indexes for table `pma__history`
--
ALTER TABLE `pma__history`
  ADD PRIMARY KEY (`id`),
  ADD KEY `username` (`username`,`db`,`table`,`timevalue`);

--
-- Indexes for table `pma__navigationhiding`
--
ALTER TABLE `pma__navigationhiding`
  ADD PRIMARY KEY (`username`,`item_name`,`item_type`,`db_name`,`table_name`);

--
-- Indexes for table `pma__pdf_pages`
--
ALTER TABLE `pma__pdf_pages`
  ADD PRIMARY KEY (`page_nr`),
  ADD KEY `db_name` (`db_name`);

--
-- Indexes for table `pma__recent`
--
ALTER TABLE `pma__recent`
  ADD PRIMARY KEY (`username`);

--
-- Indexes for table `pma__relation`
--
ALTER TABLE `pma__relation`
  ADD PRIMARY KEY (`master_db`,`master_table`,`master_field`),
  ADD KEY `foreign_field` (`foreign_db`,`foreign_table`);

--
-- Indexes for table `pma__savedsearches`
--
ALTER TABLE `pma__savedsearches`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `u_savedsearches_username_dbname` (`username`,`db_name`,`search_name`);

--
-- Indexes for table `pma__table_coords`
--
ALTER TABLE `pma__table_coords`
  ADD PRIMARY KEY (`db_name`,`table_name`,`pdf_page_number`);

--
-- Indexes for table `pma__table_info`
--
ALTER TABLE `pma__table_info`
  ADD PRIMARY KEY (`db_name`,`table_name`);

--
-- Indexes for table `pma__table_uiprefs`
--
ALTER TABLE `pma__table_uiprefs`
  ADD PRIMARY KEY (`username`,`db_name`,`table_name`);

--
-- Indexes for table `pma__tracking`
--
ALTER TABLE `pma__tracking`
  ADD PRIMARY KEY (`db_name`,`table_name`,`version`);

--
-- Indexes for table `pma__userconfig`
--
ALTER TABLE `pma__userconfig`
  ADD PRIMARY KEY (`username`);

--
-- Indexes for table `pma__usergroups`
--
ALTER TABLE `pma__usergroups`
  ADD PRIMARY KEY (`usergroup`,`tab`,`allowed`);

--
-- Indexes for table `pma__users`
--
ALTER TABLE `pma__users`
  ADD PRIMARY KEY (`username`,`usergroup`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `pma__bookmark`
--
ALTER TABLE `pma__bookmark`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `pma__column_info`
--
ALTER TABLE `pma__column_info`
  MODIFY `id` int(5) UNSIGNED NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `pma__export_templates`
--
ALTER TABLE `pma__export_templates`
  MODIFY `id` int(5) UNSIGNED NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `pma__history`
--
ALTER TABLE `pma__history`
  MODIFY `id` bigint(20) UNSIGNED NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `pma__pdf_pages`
--
ALTER TABLE `pma__pdf_pages`
  MODIFY `page_nr` int(10) UNSIGNED NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `pma__savedsearches`
--
ALTER TABLE `pma__savedsearches`
  MODIFY `id` int(5) UNSIGNED NOT NULL AUTO_INCREMENT;
--
-- Database: `sisdatabase`
--
CREATE DATABASE IF NOT EXISTS `sisdatabase` DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci;
USE `sisdatabase`;

-- --------------------------------------------------------

--
-- Table structure for table `assignedsubjtoteachtbl`
--

CREATE TABLE `assignedsubjtoteachtbl` (
  `countrsubjassigned` int(4) NOT NULL,
  `subjCode` varchar(15) NOT NULL,
  `subjcountr` int(4) NOT NULL,
  `teachIDNum` varchar(5) NOT NULL,
  `subjDay` varchar(4) NOT NULL,
  `subjRoom` varchar(100) NOT NULL,
  `subjTimefrom` varchar(8) NOT NULL,
  `subjTimeTo` varchar(8) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `assignedsubjtoteachtbl`
--

INSERT INTO `assignedsubjtoteachtbl` (`countrsubjassigned`, `subjCode`, `subjcountr`, `teachIDNum`, `subjDay`, `subjRoom`, `subjTimefrom`, `subjTimeTo`) VALUES
(226, 'GenEd4', 14, '00003', 'Wed', '106', '08:00 AM', '11:00 AM'),
(227, 'SAMPLE1', 22, '00003', 'Mon', '209', '08:00 AM', '11:00 AM'),
(228, 'GenSoc', 19, '00005', 'Mon', '213', '01:00 PM', '04:00 PM'),
(229, 'IT209', 9, '00005', 'Sat', '209', '01:00 PM', '04:00 PM'),
(230, 'MATHIT101', 2, '00001', 'Thu', '213', '05:00 PM', '08:00 PM'),
(231, 'LIT1', 3, '00001', 'Wed', '213', '08:00 AM', '11:00 AM'),
(232, 'IT205(Lec)', 4, '00002', 'Tue', '209', '07:30 AM', '09:30 AM'),
(233, 'IT205(Lab)', 5, '00002', 'Tue', '209', '09:30 AM', '12:30 PM'),
(235, 'IT207(Lec)', 6, '00004', 'Mon', '209', '06:00 PM', '08:00 PM'),
(236, 'IT207(Lab)', 7, '00004', 'Tue', 'COMLAB', '06:00 PM', '09:00 PM'),
(237, 'IT208', 8, '00006', 'Wed', '214', '01:00 PM', '04:00 PM'),
(238, 'IT206', 10, '00006', 'Sat', 'COMLAB', '07:30 AM', '12:30 PM'),
(239, 'PE4', 11, '00007', 'Tue', '108', '03:00 PM', '05:00 PM'),
(240, 'GenEd5', 12, '00007', 'Mon', '102', '08:00 AM', '11:00 AM'),
(241, 'PE2', 13, '00008', 'Mon', '106', '04:00 PM', '06:00 PM'),
(242, 'GenEd2', 15, '00008', 'Thu', '214', '08:00 AM', '11:00 AM'),
(243, 'GenEd3', 16, '00009', 'Sat', '214', '01:00 PM', '04:00 PM'),
(244, 'IT102', 17, '00009', 'Fri', '209', '05:00 PM', '08:00 PM');

-- --------------------------------------------------------

--
-- Table structure for table `logstbl`
--

CREATE TABLE `logstbl` (
  `logcountr` int(3) NOT NULL,
  `controlnum` varchar(6) NOT NULL,
  `username` varchar(20) NOT NULL,
  `pass` varchar(50) NOT NULL,
  `date` varchar(10) NOT NULL,
  `time` varchar(8) NOT NULL,
  `typeoflog` varchar(6) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `logstbl`
--

INSERT INTO `logstbl` (`logcountr`, `controlnum`, `username`, `pass`, `date`, `time`, `typeoflog`) VALUES
(51, '1', 'ad', 'ad', '6/20/2020', '01:01:34', 'Login'),
(52, '1', 'ad', 'ad', '6/20/2020', '01:55:23', 'Login'),
(53, '1', 'ad', 'ad', '6/20/2020', '01:59:00', 'Logout'),
(54, '1', 'ad', 'ad', '6/20/2020', '02:04:30', 'Login'),
(55, '1', 'ad', 'ad', '6/20/2020', '02:06:25', 'Logout'),
(56, '1', 'ad', 'ad', '6/20/2020', '02:37:06', 'Login'),
(57, '1', 'ad', 'ad', '6/20/2020', '02:37:37', 'Logout'),
(58, '1', 'ad', 'ad', '6/20/2020', '02:54:06', 'Login'),
(59, '1', 'ad', 'ad', '6/20/2020', '02:54:37', 'Logout'),
(60, '1', 'ad', 'ad', '6/20/2020', '03:57:56', 'Login'),
(61, '1', 'ad', 'ad', '6/20/2020', '03:58:12', 'Logout'),
(62, '1', 'ad', 'ad', '6/20/2020', '07:37:45', 'Login'),
(63, '1', 'ad', 'ad', '6/20/2020', '07:38:12', 'Logout'),
(64, '1', 'ad', 'ad', '6/20/2020', '07:46:43', 'Login'),
(65, '1', 'ad', 'ad', '6/20/2020', '07:48:33', 'Login'),
(66, '1', 'ad', 'ad', '6/20/2020', '07:49:18', 'Logout'),
(67, '1', 'ad', 'ad', '6/20/2020', '07:50:16', 'Login'),
(68, '1', 'ad', 'ad', '6/20/2020', '07:50:37', 'Logout'),
(69, '1', 'ad', 'ad', '6/20/2020', '07:51:58', 'Login'),
(70, '1', 'ad', 'ad', '6/20/2020', '07:52:48', 'Logout'),
(71, '1', 'ad', 'ad', '6/20/2020', '07:53:43', 'Login'),
(72, '1', 'ad', 'ad', '6/20/2020', '07:54:14', 'Logout'),
(73, '1', 'ad', 'ad', '6/20/2020', '07:54:57', 'Login'),
(74, '1', 'ad', 'ad', '6/20/2020', '07:57:10', 'Login'),
(75, '1', 'ad', 'ad', '6/20/2020', '07:57:41', 'Logout'),
(76, '1', 'ad', 'ad', '6/20/2020', '10:10:43', 'Login'),
(77, '1', 'ad', 'ad', '6/20/2020', '10:11:17', 'Logout'),
(78, '1', 'ad', 'ad', '6/20/2020', '10:13:16', 'Login'),
(79, '1', 'ad', 'ad', '6/20/2020', '10:16:08', 'Login'),
(80, '1', 'ad', 'ad', '6/20/2020', '10:16:59', 'Logout'),
(81, '1', 'ad', 'ad', '6/20/2020', '10:19:55', 'Login'),
(82, '1', 'ad', 'ad', '6/20/2020', '10:20:31', 'Logout'),
(83, '1', 'ad', 'ad', '6/20/2020', '10:22:09', 'Login'),
(84, '1', 'ad', 'ad', '6/20/2020', '10:22:55', 'Logout'),
(85, '1', 'ad', 'ad', '6/20/2020', '10:24:04', 'Login'),
(86, '1', 'ad', 'ad', '6/20/2020', '10:24:42', 'Logout'),
(87, '1', 'ad', 'ad', '6/20/2020', '10:34:34', 'Login'),
(88, '1', 'ad', 'ad', '6/20/2020', '10:38:15', 'Logout'),
(89, '1', 'ad', 'ad', '6/21/2020', '02:43:13', 'Login'),
(90, '1', 'ad', 'ad', '6/21/2020', '02:48:04', 'Login'),
(91, '1', 'ad', 'ad', '6/21/2020', '02:48:43', 'Logout'),
(92, '1', 'ad', 'ad', '6/21/2020', '02:51:32', 'Login'),
(93, '1', 'ad', 'ad', '6/21/2020', '02:51:55', 'Logout'),
(94, '1', 'ad', 'ad', '6/21/2020', '02:53:09', 'Login'),
(95, '1', 'ad', 'ad', '6/21/2020', '02:53:34', 'Logout'),
(96, '1', 'ad', 'ad', '6/21/2020', '02:54:32', 'Login'),
(97, '1', 'ad', 'ad', '6/21/2020', '02:59:20', 'Login'),
(98, '1', 'ad', 'ad', '6/21/2020', '03:01:29', 'Login'),
(99, '1', 'ad', 'ad', '6/21/2020', '03:01:54', 'Logout'),
(100, '1', 'ad', 'ad', '6/21/2020', '03:04:48', 'Login'),
(101, '1', 'ad', 'ad', '6/21/2020', '04:46:36', 'Login'),
(102, '1', 'ad', 'ad', '6/21/2020', '04:47:38', 'Logout'),
(103, '1', 'ad', 'ad', '6/21/2020', '04:50:24', 'Login'),
(104, '1', 'ad', 'ad', '6/21/2020', '04:54:33', 'Login'),
(105, '1', 'ad', 'ad', '6/21/2020', '04:55:34', 'Logout'),
(106, '1', 'ad', 'ad', '6/21/2020', '04:56:32', 'Login'),
(107, '1', 'ad', 'ad', '6/21/2020', '04:57:51', 'Login'),
(108, '1', 'ad', 'ad', '6/21/2020', '04:58:30', 'Logout'),
(109, '1', 'ad', 'ad', '6/21/2020', '05:00:53', 'Login'),
(110, '1', 'ad', 'ad', '6/21/2020', '05:11:31', 'Login'),
(111, '1', 'ad', 'ad', '6/21/2020', '05:19:50', 'Login'),
(112, '1', 'ad', 'ad', '6/21/2020', '05:22:53', 'Login'),
(113, '1', 'ad', 'ad', '6/21/2020', '05:34:59', 'Login'),
(114, '1', 'ad', 'ad', '6/21/2020', '05:37:38', 'Login'),
(115, '1', 'ad', 'ad', '6/21/2020', '05:49:57', 'Login'),
(116, '1', 'ad', 'ad', '6/21/2020', '05:51:52', 'Login'),
(117, '1', 'ad', 'ad', '6/21/2020', '05:54:33', 'Login'),
(118, '1', 'ad', 'ad', '6/21/2020', '06:07:53', 'Login'),
(119, '1', 'ad', 'ad', '6/21/2020', '06:12:57', 'Login'),
(120, '1', 'ad', 'ad', '6/21/2020', '06:23:20', 'Login'),
(121, '1', 'ad', 'ad', '6/21/2020', '06:26:06', 'Login'),
(122, '1', 'ad', 'ad', '6/21/2020', '06:34:09', 'Login'),
(123, '1', 'ad', 'ad', '6/21/2020', '06:40:33', 'Login'),
(124, '1', 'ad', 'ad', '6/21/2020', '07:17:01', 'Login'),
(125, '1', 'ad', 'ad', '6/21/2020', '07:17:20', 'Logout'),
(126, '1', 'ad', 'ad', '6/21/2020', '07:20:04', 'Login'),
(127, '1', 'ad', 'ad', '6/21/2020', '07:20:26', 'Logout'),
(128, '1', 'ad', 'ad', '6/21/2020', '07:22:26', 'Login'),
(129, '1', 'ad', 'ad', '6/21/2020', '07:22:49', 'Logout'),
(130, '1', 'ad', 'ad', '6/21/2020', '07:39:42', 'Login'),
(131, '1', 'ad', 'ad', '6/21/2020', '07:40:16', 'Logout'),
(132, '1', 'ad', 'ad', '6/21/2020', '07:42:26', 'Login'),
(133, '1', 'ad', 'ad', '6/21/2020', '07:43:04', 'Logout'),
(134, '1', 'ad', 'ad', '6/21/2020', '07:49:18', 'Login'),
(135, '1', 'ad', 'ad', '6/21/2020', '07:50:04', 'Logout'),
(136, '1', 'ad', 'ad', '6/21/2020', '07:51:42', 'Login'),
(137, '1', 'ad', 'ad', '6/21/2020', '07:52:12', 'Logout'),
(138, '1', 'ad', 'ad', '6/21/2020', '08:02:34', 'Login'),
(139, '1', 'ad', 'ad', '6/21/2020', '08:03:00', 'Logout'),
(140, '1', 'ad', 'ad', '6/21/2020', '08:09:31', 'Login'),
(141, '1', 'ad', 'ad', '6/21/2020', '08:10:51', 'Logout'),
(142, '1', 'ad', 'ad', '6/21/2020', '08:15:05', 'Login'),
(143, '1', 'ad', 'ad', '6/21/2020', '08:18:02', 'Login'),
(144, '1', 'ad', 'ad', '6/21/2020', '08:18:25', 'Logout'),
(145, '1', 'ad', 'ad', '6/21/2020', '08:20:07', 'Login'),
(146, '1', 'ad', 'ad', '6/21/2020', '08:20:49', 'Logout'),
(147, '1', 'ad', 'ad', '6/21/2020', '08:27:45', 'Login'),
(148, '1', 'ad', 'ad', '6/21/2020', '08:28:08', 'Logout'),
(149, '1', 'ad', 'ad', '6/21/2020', '08:28:48', 'Login'),
(150, '1', 'ad', 'ad', '6/21/2020', '08:29:15', 'Logout'),
(151, '1', 'ad', 'ad', '6/21/2020', '10:00:58', 'Login'),
(152, '1', 'ad', 'ad', '6/21/2020', '10:09:41', 'Logout'),
(153, '1', 'ad', 'ad', '6/21/2020', '10:11:11', 'Login'),
(154, '1', 'ad', 'ad', '6/21/2020', '10:22:03', 'Login'),
(155, '1', 'ad', 'ad', '6/21/2020', '10:22:39', 'Logout'),
(156, '1', 'ad', 'ad', '6/21/2020', '10:23:13', 'Login'),
(157, '1', 'ad', 'ad', '6/21/2020', '10:25:25', 'Logout'),
(158, '1', 'ad', 'ad', '6/21/2020', '10:27:59', 'Login'),
(159, '1', 'ad', 'ad', '6/21/2020', '10:28:19', 'Logout'),
(160, '1', 'ad', 'ad', '6/21/2020', '10:29:42', 'Login'),
(161, '1', 'ad', 'ad', '6/21/2020', '10:31:49', 'Logout'),
(162, '1', 'ad', 'ad', '6/21/2020', '10:33:50', 'Login'),
(163, '1', 'ad', 'ad', '6/21/2020', '10:46:41', 'Login'),
(164, '1', 'ad', 'ad', '6/21/2020', '10:47:09', 'Logout'),
(165, '1', 'ad', 'ad', '6/21/2020', '10:54:52', 'Login'),
(166, '1', 'ad', 'ad', '6/21/2020', '10:55:14', 'Logout'),
(167, '1', 'ad', 'ad', '6/21/2020', '10:57:20', 'Login'),
(168, '1', 'ad', 'ad', '6/21/2020', '11:00:57', 'Logout'),
(169, '1', 'ad', 'ad', '6/21/2020', '11:07:36', 'Login'),
(170, '1', 'ad', 'ad', '6/21/2020', '11:10:19', 'Logout'),
(171, '1', 'ad', 'ad', '6/21/2020', '11:12:46', 'Login'),
(172, '1', 'ad', 'ad', '6/21/2020', '11:13:41', 'Logout'),
(173, '1', 'ad', 'ad', '6/21/2020', '11:21:36', 'Login'),
(174, '1', 'ad', 'ad', '6/21/2020', '11:22:45', 'Logout'),
(175, '1', 'ad', 'ad', '6/21/2020', '11:24:33', 'Login'),
(176, '1', 'ad', 'ad', '6/21/2020', '11:25:31', 'Logout'),
(177, '1', 'admin', 'admin', '6/21/2020', '11:25:35', 'Login'),
(178, '1', 'admin', 'admin', '6/21/2020', '11:44:26', 'Logout'),
(179, '1', 'admin', 'admin', '6/21/2020', '11:48:14', 'Login'),
(180, '1', 'admin', 'admin', '6/22/2020', '12:07:04', 'Logout'),
(181, '1', 'admin', 'admin', '6/22/2020', '12:07:32', 'Login'),
(182, '1', 'admin', 'admin', '6/22/2020', '12:08:14', 'Logout'),
(183, '1', 'admin', 'admin', '6/22/2020', '07:24:06', 'Login'),
(184, '1', 'admin', 'admin', '6/22/2020', '07:29:24', 'Logout'),
(185, '1', 'admin', 'admin', '6/22/2020', '07:30:34', 'Login'),
(186, '1', 'admin', 'admin', '6/22/2020', '07:59:18', 'Login'),
(187, '1', 'admin', 'admin', '6/22/2020', '09:53:18', 'Logout'),
(188, '1', 'admin', 'admin', '6/22/2020', '10:46:22', 'Login'),
(189, '1', 'admin', 'admin', '6/22/2020', '10:47:55', 'Logout'),
(190, '1', 'admin', 'admin', '6/22/2020', '10:48:37', 'Login'),
(191, '1', 'admin', 'admin', '6/22/2020', '10:50:52', 'Login'),
(192, '1', 'admin', 'admin', '6/22/2020', '10:55:11', 'Login'),
(193, '1', 'admin', 'admin', '6/22/2020', '10:56:02', 'Logout'),
(194, '1', 'admin', 'admin', '6/22/2020', '10:59:30', 'Login'),
(195, '1', 'admin', 'admin', '6/22/2020', '10:59:53', 'Logout'),
(196, '1', 'admin', 'admin', '6/22/2020', '11:00:21', 'Login'),
(197, '1', 'admin', 'admin', '6/22/2020', '11:03:33', 'Logout'),
(198, '1', 'admin', 'admin', '6/22/2020', '11:04:47', 'Login'),
(199, '1', 'admin', 'admin', '6/22/2020', '11:06:26', 'Logout'),
(200, '1', 'admin', 'admin', '6/22/2020', '11:09:08', 'Login'),
(201, '1', 'admin', 'admin', '6/22/2020', '11:10:51', 'Logout'),
(202, '1', 'admin', 'admin', '6/22/2020', '11:12:06', 'Login'),
(203, '1', 'admin', 'admin', '6/22/2020', '11:12:52', 'Logout'),
(204, '1', 'admin', 'admin', '6/22/2020', '11:15:42', 'Login'),
(205, '1', 'admin', 'admin', '6/22/2020', '11:21:23', 'Login'),
(206, '1', 'admin', 'admin', '6/22/2020', '11:21:52', 'Logout'),
(207, '1', 'admin', 'admin', '6/22/2020', '11:24:35', 'Login'),
(208, '1', 'admin', 'admin', '6/22/2020', '11:25:05', 'Logout'),
(209, '1', 'admin', 'admin', '6/22/2020', '11:26:40', 'Login'),
(210, '1', 'admin', 'admin', '6/22/2020', '11:31:55', 'Login'),
(211, '1', 'admin', 'admin', '6/22/2020', '11:33:37', 'Logout'),
(212, '1', 'admin', 'admin', '6/22/2020', '11:48:07', 'Login'),
(213, '1', 'admin', 'admin', '6/22/2020', '11:49:41', 'Logout'),
(214, '1', 'admin', 'admin', '6/22/2020', '11:55:06', 'Login'),
(215, '1', 'admin', 'admin', '6/22/2020', '11:56:34', 'Login'),
(216, '1', 'admin', 'admin', '6/22/2020', '11:57:13', 'Logout'),
(217, '1', 'admin', 'admin', '6/22/2020', '12:23:50', 'Login'),
(218, '1', 'admin', 'admin', '6/22/2020', '12:25:10', 'Login'),
(219, '1', 'admin', 'admin', '6/22/2020', '12:26:36', 'Login'),
(220, '1', 'admin', 'admin', '6/22/2020', '12:27:34', 'Login'),
(221, '1', 'admin', 'admin', '6/22/2020', '12:28:30', 'Login'),
(222, '1', 'admin', 'admin', '6/22/2020', '12:31:59', 'Login'),
(223, '1', 'admin', 'admin', '6/22/2020', '12:35:01', 'Login'),
(224, '1', 'admin', 'admin', '6/22/2020', '12:36:40', 'Logout'),
(225, '1', 'admin', 'admin', '6/22/2020', '12:39:04', 'Login'),
(226, '1', 'admin', 'admin', '6/22/2020', '12:39:16', 'Logout'),
(227, '1', 'admin', 'admin', '6/22/2020', '12:39:48', 'Login'),
(228, '1', 'admin', 'admin', '6/22/2020', '12:40:59', 'Logout'),
(229, '1', 'admin', 'admin', '6/22/2020', '12:42:23', 'Login'),
(230, '1', 'admin', 'admin', '6/22/2020', '12:42:57', 'Logout'),
(231, '1', 'admin', 'admin', '6/22/2020', '12:43:41', 'Login'),
(232, '1', 'admin', 'admin', '6/22/2020', '12:44:02', 'Logout'),
(233, '1', 'admin', 'admin', '6/22/2020', '12:44:30', 'Login'),
(234, '1', 'admin', 'admin', '6/22/2020', '12:44:57', 'Logout'),
(235, '1', 'admin', 'admin', '6/22/2020', '12:47:13', 'Login'),
(236, '1', 'admin', 'admin', '6/22/2020', '12:47:46', 'Logout'),
(237, '1', 'admin', 'admin', '6/22/2020', '12:49:40', 'Login'),
(238, '1', 'admin', 'admin', '6/22/2020', '12:49:57', 'Logout'),
(239, '1', 'admin', 'admin', '6/22/2020', '12:51:12', 'Login'),
(240, '1', 'admin', 'admin', '6/22/2020', '12:51:44', 'Logout'),
(241, '1', 'admin', 'admin', '6/22/2020', '12:54:30', 'Login'),
(242, '1', 'admin', 'admin', '6/22/2020', '12:56:20', 'Login'),
(243, '1', 'admin', 'admin', '6/22/2020', '12:57:04', 'Logout'),
(244, '1', 'admin', 'admin', '6/22/2020', '12:58:30', 'Login'),
(245, '1', 'admin', 'admin', '6/22/2020', '12:58:46', 'Logout'),
(246, '1', 'admin', 'admin', '6/22/2020', '01:06:13', 'Login'),
(247, '1', 'admin', 'admin', '6/22/2020', '01:08:58', 'Logout'),
(248, '1', 'admin', 'admin', '6/22/2020', '01:09:24', 'Login'),
(249, '1', 'admin', 'admin', '6/22/2020', '01:17:37', 'Logout'),
(250, '1', 'admin', 'admin', '6/22/2020', '01:25:31', 'Login'),
(251, '1', 'admin', 'admin', '6/22/2020', '01:26:21', 'Logout'),
(252, '1', 'admin', 'admin', '6/22/2020', '01:26:54', 'Login'),
(253, '1', 'admin', 'admin', '6/22/2020', '01:28:29', 'Logout'),
(254, '1', 'admin', 'admin', '6/22/2020', '01:33:28', 'Login'),
(255, '1', 'admin', 'admin', '6/22/2020', '01:36:26', 'Login'),
(256, '1', 'admin', 'admin', '6/22/2020', '01:39:27', 'Logout'),
(257, '1', 'admin', 'admin', '6/22/2020', '01:40:26', 'Login'),
(258, '1', 'admin', 'admin', '6/22/2020', '01:43:44', 'Logout'),
(259, '1', 'admin', 'admin', '6/22/2020', '01:44:50', 'Login'),
(260, '1', 'admin', 'admin', '6/22/2020', '01:44:54', 'Logout'),
(261, '1', 'admin', 'admin', '6/22/2020', '01:45:31', 'Login'),
(262, '1', 'admin', 'admin', '6/22/2020', '01:49:24', 'Logout'),
(263, '1', 'admin', 'admin', '6/22/2020', '03:50:54', 'Login'),
(264, '1', 'admin', 'admin', '6/22/2020', '03:54:10', 'Logout'),
(265, '1', 'admin', 'admin', '6/23/2020', '12:35:53', 'Login'),
(266, '1', 'admin', 'admin', '6/23/2020', '12:49:33', 'Logout'),
(267, '1', 'admin', 'admin', '6/23/2020', '12:52:48', 'Login'),
(268, '1', 'admin', 'admin', '6/23/2020', '12:55:41', 'Logout'),
(269, '1', 'admin', 'admin', '6/23/2020', '03:12:07', 'Login'),
(270, '1', 'admin', 'admin', '6/23/2020', '03:12:20', 'Logout'),
(271, '1', 'admin', 'admin', '6/23/2020', '03:12:40', 'Login'),
(272, '1', 'admin', 'admin', '6/23/2020', '03:12:55', 'Logout'),
(273, '000002', 'staff2', '2', '6/23/2020', '03:13:01', 'Login'),
(274, '000002', 'staff2', '2', '6/23/2020', '03:20:32', 'Logout'),
(275, '000001', 'staff1', '1', '6/24/2020', '05:12:11', 'Login'),
(276, '000001', 'staff1', '1', '6/24/2020', '05:12:16', 'Logout');

-- --------------------------------------------------------

--
-- Table structure for table `schooladminaccntstbl`
--

CREATE TABLE `schooladminaccntstbl` (
  `controlnum` varchar(6) NOT NULL,
  `usern` varchar(20) NOT NULL,
  `userpass` varchar(20) NOT NULL,
  `datecreated` varchar(10) NOT NULL,
  `timecreated` varchar(7) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `schooladminaccntstbl`
--

INSERT INTO `schooladminaccntstbl` (`controlnum`, `usern`, `userpass`, `datecreated`, `timecreated`) VALUES
('000001', 'staff1', '1', '6/20/2020', '10:38:0'),
('000002', 'staff2', '2', '6/18/2020', '06:08:4'),
('000003', 'staff3', '3', '6/18/2020', '06:08:5'),
('000004', 'staff4', '4', '6/18/2020', '06:09:0'),
('000005', 'staff5', '5', '6/18/2020', '06:09:0'),
('000006', 'staff6', '6', '6/18/2020', '06:09:1'),
('000007', 'staff7', '7', '6/18/2020', '06:09:2'),
('000008', 'staff8', '8', '6/18/2020', '06:09:2'),
('000009', 'staff9', '9', '6/18/2020', '06:09:3'),
('000010', 'staff10', '10', '6/18/2020', '06:09:4');

-- --------------------------------------------------------

--
-- Table structure for table `studinfotbl`
--

CREATE TABLE `studinfotbl` (
  `IDNum` varchar(17) NOT NULL,
  `FName` varchar(20) NOT NULL,
  `MidName` varchar(20) NOT NULL,
  `FamName` varchar(20) NOT NULL,
  `Qualifier` varchar(10) NOT NULL,
  `StudGender` varchar(1) NOT NULL,
  `SYFrom` varchar(4) NOT NULL,
  `SYTo` varchar(4) NOT NULL,
  `Semester` varchar(3) NOT NULL,
  `Status` varchar(20) NOT NULL,
  `YearLevel` varchar(4) NOT NULL,
  `ContactNum` varchar(20) NOT NULL,
  `Course` varchar(10) NOT NULL,
  `Birthdate` varchar(10) NOT NULL,
  `Age` varchar(3) NOT NULL,
  `StudNum` varchar(6) NOT NULL,
  `Pic` varchar(999) CHARACTER SET utf8 NOT NULL,
  `CivilStat` varchar(10) NOT NULL,
  `Religion` varchar(100) NOT NULL,
  `EmailAdd` varchar(100) NOT NULL,
  `PlaceBirth` varchar(100) NOT NULL,
  `PresentAdd` varchar(100) NOT NULL,
  `HomeAdd` varchar(100) NOT NULL,
  `FatherName` varchar(100) NOT NULL,
  `FatherOccupation` varchar(100) NOT NULL,
  `FatherContactNum` varchar(100) NOT NULL,
  `MotherName` varchar(100) NOT NULL,
  `MotherOccupation` varchar(100) NOT NULL,
  `MotherContactNum` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `studinfotbl`
--

INSERT INTO `studinfotbl` (`IDNum`, `FName`, `MidName`, `FamName`, `Qualifier`, `StudGender`, `SYFrom`, `SYTo`, `Semester`, `Status`, `YearLevel`, `ContactNum`, `Course`, `Birthdate`, `Age`, `StudNum`, `Pic`, `CivilStat`, `Religion`, `EmailAdd`, `PlaceBirth`, `PresentAdd`, `HomeAdd`, `FatherName`, `FatherOccupation`, `FatherContactNum`, `MotherName`, `MotherOccupation`, `MotherContactNum`) VALUES
('20072008-1-000001', 'Juan', 'Dela', 'Cruz', 'N/A', 'M', '2007', '2008', '1st', 'New Student', '1st', '0916-739-2045', 'BSIT', '2/27/1990', '30', '000001', 'D:\\my files\\SCHOOL\\HCI\\Student Information System\\StudentInformationSystem\\StudentInformationSystem\\bin\\Debug\\StudentPics\\2007000001.jpg', 'Single', 'Roman Catholic', 'juandelacruz@yahoo.com', 'Zone 1, Poblacion, Opol, Misamis Oriental', 'Zone 5, Brgy. Patag, Cagayan de Oro City', 'Zone 1, Poblacion, Opol, Misamis Oriental', 'Juanito A Cruz', 'none', '0977-891-0932', 'Juanita D Cruz', 'none', '0921-234-3432'),
('20082009-2-000001', 'student2 Firstname', 'student2 middlename', 'student2 familyname', 'Jr.', 'M', '2008', '2009', '2nd', 'Old Student', '2nd', '0932-433-2342', 'BSBA', '2/27/1991', '29', '000001', 'D:\\my files\\SCHOOL\\HCI\\Student Information System\\StudentInformationSystem\\StudentInformationSystem\\bin\\Debug\\StudentPics\\2008000001.jpg', 'Married', 'INC', 'student2@gmail.com', 'student2 place of birth', 'student2 present address', 'student2 home addres', 'student2 fathers name', 'student2 fathers occupation', '0923-234-4132', 'student2 mothers name', 'student2 mothers occupation', '0912-323-4543'),
('20092010-2-000001', '3rd fname', '3rd midname', '3rd famname', 'N/A', 'M', '2009', '2010', '2nd', 'New Student', '3rd', '0912-234-1234', 'BSED', '2/27/1992', '28', '000001', 'D:\\my files\\SCHOOL\\HCI\\Student Information System\\StudentInformationSystem\\StudentInformationSystem\\bin\\Debug\\StudentPics\\2009000001.jpg', 'Widower', 'RC', '3rdstudent@yahoo.com', 'opol, mis. or.', 'cdoc', 'opol, mis. or.', '3rd stud father name', '3rd stud father occupation', '_', '3rd stud mother name', '3rd stud mother occupation', '_'),
('20112012-1-000001', '4thstud fname', '4thstud midname', '4thstud famname', 'N/A', 'F', '2011', '2012', '1st', 'New Student', '3rd', '0943-345-2311', 'BSED', '2/27/1994', '26', '000001', 'D:\\my files\\SCHOOL\\HCI\\Student Information System\\StudentInformationSystem\\StudentInformationSystem\\bin\\Debug\\StudentPics\\2011000001.jpg', 'Single', 'rc', '4thstud@gmail.com', '4thstud place of birth', '4thstud present address', '4thstud home address', '4thstud father name', '4thstud father occupation', '_', '4thstud mother name', '4thstud mother occupation', '0912-324-4312'),
('20122013-1-000001', '5thstud fname', '5thstud midname', '5thstud famname', 'III', 'M', '2012', '2013', '1st', 'Old Student', '2nd', '0945-524-2455', 'BSIT', '2/27/1998', '22', '000001', 'D:\\my files\\SCHOOL\\HCI\\Student Information System\\StudentInformationSystem\\StudentInformationSystem\\bin\\Debug\\StudentPics\\2012000001.jpg', 'Single', 'IFI', '5thstud@yahoo.com', '5thstud place of birth', '5thstud present address', '5thstud home address', '5thstud father name', '5thstud father occupation', '0923-432-5342', '5thstud mother name', '5thstud mother occupation', '0954-134-5642'),
('20152016-2-000001', '7thstud fname', '7thstud midname', '7thstud famname', 'I', 'M', '2015', '2016', '2nd', 'Old Student', '2nd', '0942-123-4567', 'BSBA', '2/27/1996', '24', '000001', 'D:\\my files\\SCHOOL\\HCI\\Student Information System\\StudentInformationSystem\\StudentInformationSystem\\bin\\Debug\\StudentPics\\2015000001.jpg', 'Single', 'Roman Catholic', '7thstud@yahoo.com', '7thstud place of birth', '7thstud present address', '7thstud home address', '7thstud father name', '7thstud occupation', '0923-454-2456', '7thstud mother name', '7thstud occupation', '_'),
('20172018-1-000001', '6thstud fname', '6thstud midname', '6thstud famname', 'N/A', 'F', '2017', '2018', '1st', 'New Student', '2nd', '0923-123-4567', 'BSED', '2/27/1997', '23', '000001', 'D:\\my files\\SCHOOL\\HCI\\Student Information System\\StudentInformationSystem\\StudentInformationSystem\\bin\\Debug\\StudentPics\\2017000001.jpg', 'Single', 'INC', '6thstud@gmail.com', '6thstud place of birth', '6thstud present address', '6thstud home address', '6thstud father name', '6thstud father occupation', '_', '6thstud mother name', '6thstud mother occupation', '_'),
('20182019-1-000001', '8thstud fname', '8thstud midname', '8thstud famname', 'N/A', 'M', '2018', '2019', '1st', 'New Student', '2nd', '0942-234-2412', 'BSIT', '2/27/1995', '25', '000001', 'D:\\my files\\SCHOOL\\HCI\\Student Information System\\StudentInformationSystem\\StudentInformationSystem\\bin\\Debug\\StudentPics\\2018000001.jpg', 'Single', 'IFI', '8thstud@gmail.com', '8thstud place of birth', '8thstud present address', '8thstud home address', '8thstud father name', '8thstud father occupation', '_', '8thstud mother name', '8thstud mother occupation', '_'),
('20192020-1-000001', '9thstud fname', '9thstud midname', '9thstud famname', 'N/A', 'M', '2019', '2020', '1st', 'New Student', '1st', '0932-341-3431', 'BSIT', '2/27/1995', '25', '000001', 'D:\\my files\\SCHOOL\\HCI\\Student Information System\\StudentInformationSystem\\StudentInformationSystem\\bin\\Debug\\StudentPics\\2019000001.jpg', 'Single', 'rc', '9thstud@yahoo.com', '9thstud place of birth', '9thstud present address', '9thstud home address', '9thstud father name', '9thstud father occupation', '_', '9thstud mother name', '9thstud mother occupation', '_'),
('20192020-1-000002', 'Juan', 'Tamad', 'Dela Cruz', 'Jr.', 'M', '2019', '2020', '1st', 'New Student', '1st', '0912-345-6789', 'BSIT', '2/27/1993', '27', '000002', 'D:\\my files\\SCHOOL\\HCI\\Student Information System\\StudentInformationSystem\\StudentInformationSystem\\bin\\Debug\\StudentPics\\2019000002.jpg', 'Single', 'Roman Catholic', 'juantamaddelacruzjr@gmail.com', 'Zone 1, Brgy. Patag, Cagayan de Oro City', 'Zone 2, Poblacion, Opol, Misamis Oriental', 'Zone 1, Brgy. Patag, Cagayan de Oro City', 'Juan F Dela Cruz, Sr.', 'none', '0', 'Juanita T Dela Cruz', 'none', '0'),
('20202021-1-000001', '10thstud fname', '10thstud midname', '10thstud famname', 'N/A', 'M', '2020', '2021', '1st', 'New Student', '1st', '0934-543-2435', 'BSIT', '2/27/1997', '23', '000001', 'D:\\my files\\SCHOOL\\HCI\\Student Information System\\StudentInformationSystem\\StudentInformationSystem\\bin\\Debug\\StudentPics\\2020000001.jpg', 'Single', 'rc', '10thstud@gmail.com', '10thstud place of birth', '10thstud present address', '10thstud home address', '10thstud father name', '10thstud father occupation', '0924-342-3421', '10thstud mother name', '10thstud mother occupation', '0934-234-5342'),
('20202021-1-000002', 'Edwin', 'Mildness', 'Thompson', 'N/A', 'M', '2020', '2021', '1st', 'New Student', '1st', '0923-342-1344', 'BSIT', '2/27/1992', '28', '000002', 'D:\\my files\\SCHOOL\\HCI\\Student Information System\\StudentInformationSystem\\StudentInformationSystem\\bin\\Debug\\StudentPics\\2020000002.jpg', 'Single', 'Roman Catholic', 'edwinmildthompson@yahoo.com', 'Zone 5, Brgy. Bulua, Cagayan de Oro City', 'Zone 1, Brgy. Patag, Cagayan de Oro City', 'Zone 5, Brgy. Bulua, Cagayan de Oro City', 'Idle C Thompson', 'Mechanic', '0921-234-4323', 'Carbureta M Thompson', 'Brgy. Captain', '0942-243-4323');

-- --------------------------------------------------------

--
-- Table structure for table `studsubjtbl`
--

CREATE TABLE `studsubjtbl` (
  `StudSubjCount` int(4) NOT NULL,
  `IDNum` varchar(17) NOT NULL,
  `teachIDNum` varchar(5) NOT NULL,
  `subjcountr` int(4) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `studsubjtbl`
--

INSERT INTO `studsubjtbl` (`StudSubjCount`, `IDNum`, `teachIDNum`, `subjcountr`) VALUES
(1, '20072008-1-000001', '00003', 22),
(2, '20072008-1-000001', '00008', 15),
(3, '20072008-1-000001', '00009', 16),
(4, '20072008-1-000001', '00009', 17),
(5, '20082009-2-000001', '00005', 9),
(6, '20082009-2-000001', '00001', 3),
(7, '20082009-2-000001', '00002', 4),
(8, '20082009-2-000001', '00002', 5),
(9, '20082009-2-000001', '00004', 6),
(10, '20082009-2-000001', '00004', 7),
(11, '20082009-2-000001', '00006', 8),
(12, '20082009-2-000001', '00006', 10),
(13, '20082009-2-000001', '00007', 11),
(14, '20152016-2-000001', '00005', 9),
(15, '20152016-2-000001', '00001', 3),
(16, '20152016-2-000001', '00002', 4),
(17, '20152016-2-000001', '00002', 5),
(18, '20152016-2-000001', '00004', 6),
(19, '20152016-2-000001', '00004', 7),
(20, '20152016-2-000001', '00006', 8),
(21, '20152016-2-000001', '00006', 10),
(22, '20152016-2-000001', '00007', 11),
(23, '20192020-1-000001', '00003', 22),
(24, '20192020-1-000001', '00008', 15),
(25, '20192020-1-000001', '00009', 16),
(26, '20192020-1-000001', '00009', 17),
(27, '20192020-1-000002', '00003', 22),
(28, '20192020-1-000002', '00008', 15),
(29, '20192020-1-000002', '00009', 16),
(30, '20192020-1-000002', '00009', 17),
(31, '20202021-1-000001', '00003', 22),
(32, '20202021-1-000001', '00008', 15),
(33, '20202021-1-000001', '00009', 16),
(34, '20202021-1-000001', '00009', 17),
(35, '20202021-1-000002', '00003', 22),
(36, '20202021-1-000002', '00008', 15),
(37, '20202021-1-000002', '00009', 16),
(38, '20202021-1-000002', '00009', 17);

-- --------------------------------------------------------

--
-- Table structure for table `subjectstbl`
--

CREATE TABLE `subjectstbl` (
  `subjcountr` int(4) NOT NULL,
  `subjCode` varchar(15) NOT NULL,
  `subjDescript` varchar(200) NOT NULL,
  `foryearlvl` varchar(4) NOT NULL,
  `forsubjsem` varchar(4) NOT NULL,
  `subjUnit` varchar(1) NOT NULL,
  `subjLecHr` varchar(1) NOT NULL,
  `subjLabHr` varchar(1) NOT NULL,
  `subjTotalHr` varchar(2) NOT NULL,
  `subjDay` varchar(4) NOT NULL,
  `subjRoom` varchar(100) NOT NULL,
  `subjTimefrom` varchar(8) NOT NULL,
  `subjTimeTo` varchar(8) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `subjectstbl`
--

INSERT INTO `subjectstbl` (`subjcountr`, `subjCode`, `subjDescript`, `foryearlvl`, `forsubjsem`, `subjUnit`, `subjLecHr`, `subjLabHr`, `subjTotalHr`, `subjDay`, `subjRoom`, `subjTimefrom`, `subjTimeTo`) VALUES
(2, 'MATHIT101', 'Mathematics and Statistics for IT1', '1st', '2nd', '3', '3', '0', '3', 'Thu', '213', '05:00 PM', '08:00 PM'),
(3, 'LIT1', 'Survey of Philippine Literature in English', '2nd', '2nd', '3', '3', '0', '3', 'Wed', '213', '08:00 AM', '11:00 AM'),
(4, 'IT205(Lec)', 'Introduction to Human Computer Interaction', '2nd', '2nd', '1', '2', '0', '2', 'Tue', '209', '07:30 AM', '09:30 AM'),
(5, 'IT205(Lab)', 'Introduction to Human Computer Interaction', '2nd', '2nd', '2', '0', '3', '3', 'Tue', '209', '09:30 AM', '12:30 PM'),
(6, 'IT207(Lec)', 'Fundamentals of Database Systems', '2nd', '2nd', '1', '2', '0', '2', 'Mon', '209', '06:00 PM', '08:00 PM'),
(7, 'IT207(Lab)', 'Fundamentals of Database Systems', '2nd', '2nd', '2', '0', '3', '3', 'Tue', 'COMLAB', '06:00 PM', '09:00 PM'),
(8, 'IT208', 'Accounting Principles', '2nd', '2nd', '3', '3', '0', '3', 'Wed', '214', '01:00 PM', '04:00 PM'),
(9, 'IT209', 'IT Elective: Technoprenuership', '2nd', '2nd', '3', '3', '0', '3', 'Sat', '209', '01:00 PM', '04:00 PM'),
(10, 'IT206', 'Object Oriented Programming', '2nd', '2nd', '3', '0', '5', '5', 'Sat', 'COMLAB', '07:30 AM', '12:30 PM'),
(11, 'PE4', 'Physical Activity Towards health and Fitness 4', '2nd', '2nd', '2', '2', '0', '2', 'Tue', '108', '03:00 PM', '05:00 PM'),
(12, 'GenEd5', 'The Contemporary World', '1st', '2nd', '3', '3', '0', '3', 'Mon', '102', '08:00 AM', '11:00 AM'),
(13, 'PE2', 'Physical Fitness 2', '1st', '2nd', '3', '2', '0', '2', 'Mon', '106', '04:00 PM', '06:00 PM'),
(14, 'GenEd4', 'Readings in Philippine History', '1st', '2nd', '3', '3', '0', '3', 'Wed', '106', '08:00 AM', '11:00 AM'),
(15, 'GenEd2', 'Purposive Communication', '1st', '1st', '3', '3', '0', '3', 'Thu', '214', '08:00 AM', '11:00 AM'),
(16, 'GenEd3', 'Mathematics in the Modern World', '1st', '1st', '3', '3', '0', '3', 'Sat', '214', '01:00 PM', '04:00 PM'),
(17, 'IT102', 'IT Fundamentals', '1st', '1st', '3', '3', '0', '3', 'Fri', '209', '05:00 PM', '08:00 PM'),
(19, 'GenSoc', 'Gender and Society', '1st', '2nd', '3', '3', '0', '3', 'Mon', '213', '01:00 PM', '04:00 PM'),
(22, 'SAMPLE1', 'Sample subject', '1st', '1st', '3', '3', '0', '3', 'Mon', '209', '08:00 AM', '11:00 AM');

-- --------------------------------------------------------

--
-- Table structure for table `systemadmintbl`
--

CREATE TABLE `systemadmintbl` (
  `admincountnum` int(1) NOT NULL,
  `adminusername` varchar(20) NOT NULL,
  `adminpassword` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `systemadmintbl`
--

INSERT INTO `systemadmintbl` (`admincountnum`, `adminusername`, `adminpassword`) VALUES
(1, 'admin', 'admin');

-- --------------------------------------------------------

--
-- Table structure for table `teacherinfotbl`
--

CREATE TABLE `teacherinfotbl` (
  `teachIDNum` varchar(5) NOT NULL,
  `teachFname` varchar(20) NOT NULL,
  `teachMI` varchar(20) NOT NULL,
  `teachFamname` varchar(20) NOT NULL,
  `teachGender` varchar(6) NOT NULL,
  `teachAddress` varchar(100) NOT NULL,
  `teachnamecode` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `teacherinfotbl`
--

INSERT INTO `teacherinfotbl` (`teachIDNum`, `teachFname`, `teachMI`, `teachFamname`, `teachGender`, `teachAddress`, `teachnamecode`) VALUES
('00001', 'instructor1', 'instruct1', 'ins1', 'Male', 'Patag, CDOC', 'I., Ins1'),
('00002', 'Instructor2', 'Instruct2', 'Ins2', 'Female', 'Bulua, CDOC', 'I., Ins2'),
('00003', 'Instructor3', 'Instruct3', 'Ins3', 'Male', 'Poblacion, Opol', 'I., Ins3'),
('00004', 'Instructor4', 'Instruct4', 'Ins4', 'Female', 'Tagoloan, Misamis Oriental', 'I., Ins4'),
('00005', 'Instructor5', 'Instruct5', 'Ins5', 'Female', 'Brgy. 16, CDOC', 'I., Ins5'),
('00006', 'Instructor6', 'Instruct6', 'Ins6', 'Female', 'Carmen, CDOC', 'I., Ins6'),
('00007', 'Instructor7', 'Instruct7', 'Ins7', 'Male', 'Macabalan, CDOC', 'I., Ins7'),
('00008', 'Instructor8', 'Instruct8', 'Ins8', 'Male', 'Iponan, CDOC', 'I., Ins8'),
('00009', 'Instructor9', 'Instruct9', 'Ins9', 'Male', 'Poblacion, Opol, Misamis Oriental', 'I., Ins9'),
('00010', 'Instructor10', 'Instruct10', 'Ins10', 'Female', 'Poblacion,El Salvador City', 'I., Ins10');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `assignedsubjtoteachtbl`
--
ALTER TABLE `assignedsubjtoteachtbl`
  ADD PRIMARY KEY (`countrsubjassigned`);

--
-- Indexes for table `logstbl`
--
ALTER TABLE `logstbl`
  ADD PRIMARY KEY (`logcountr`);

--
-- Indexes for table `schooladminaccntstbl`
--
ALTER TABLE `schooladminaccntstbl`
  ADD PRIMARY KEY (`controlnum`);

--
-- Indexes for table `studinfotbl`
--
ALTER TABLE `studinfotbl`
  ADD PRIMARY KEY (`IDNum`);

--
-- Indexes for table `studsubjtbl`
--
ALTER TABLE `studsubjtbl`
  ADD PRIMARY KEY (`StudSubjCount`);

--
-- Indexes for table `subjectstbl`
--
ALTER TABLE `subjectstbl`
  ADD PRIMARY KEY (`subjcountr`);

--
-- Indexes for table `systemadmintbl`
--
ALTER TABLE `systemadmintbl`
  ADD PRIMARY KEY (`admincountnum`);

--
-- Indexes for table `teacherinfotbl`
--
ALTER TABLE `teacherinfotbl`
  ADD PRIMARY KEY (`teachIDNum`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `assignedsubjtoteachtbl`
--
ALTER TABLE `assignedsubjtoteachtbl`
  MODIFY `countrsubjassigned` int(4) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=245;

--
-- AUTO_INCREMENT for table `logstbl`
--
ALTER TABLE `logstbl`
  MODIFY `logcountr` int(3) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=277;

--
-- AUTO_INCREMENT for table `studsubjtbl`
--
ALTER TABLE `studsubjtbl`
  MODIFY `StudSubjCount` int(4) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=39;

--
-- AUTO_INCREMENT for table `subjectstbl`
--
ALTER TABLE `subjectstbl`
  MODIFY `subjcountr` int(4) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=23;

--
-- AUTO_INCREMENT for table `systemadmintbl`
--
ALTER TABLE `systemadmintbl`
  MODIFY `admincountnum` int(1) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
--
-- Database: `test`
--
CREATE DATABASE IF NOT EXISTS `test` DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci;
USE `test`;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

-- phpMyAdmin SQL Dump
-- version 4.7.9
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3306
-- Generation Time: 10-Out-2019 às 00:19
-- Versão do servidor: 5.7.21
-- PHP Version: 5.6.35

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `dbex04_091019`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_cliente`
--

DROP TABLE IF EXISTS `tb_cliente`;
CREATE TABLE IF NOT EXISTS `tb_cliente` (
  `ID_CLIENTE` int(11) NOT NULL AUTO_INCREMENT,
  `NOME_CLIENTE` varchar(60) COLLATE utf8_unicode_ci NOT NULL,
  `END_CLIENTE` varchar(120) COLLATE utf8_unicode_ci NOT NULL,
  `UF` char(2) COLLATE utf8_unicode_ci NOT NULL,
  `CPF_CLIENTE` char(14) COLLATE utf8_unicode_ci NOT NULL,
  PRIMARY KEY (`ID_CLIENTE`),
  UNIQUE KEY `UQCPF_CLIENTE` (`CPF_CLIENTE`),
  KEY `UF` (`UF`)
) ENGINE=MyISAM AUTO_INCREMENT=5 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Extraindo dados da tabela `tb_cliente`
--

INSERT INTO `tb_cliente` (`ID_CLIENTE`, `NOME_CLIENTE`, `END_CLIENTE`, `UF`, `CPF_CLIENTE`) VALUES
(1, 'Ana Paula', 'Rua A', 'sp', '111.222.333-44'),
(2, 'Paulo', 'Rua P', 'MG', '222.333.444-55'),
(3, 'Luis Carlos', 'Rua LC', 'RJ', '333.444.555-66'),
(4, 'Ana Paula', 'Rua A', 'sp', '666.777.888-99');

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_estados`
--

DROP TABLE IF EXISTS `tb_estados`;
CREATE TABLE IF NOT EXISTS `tb_estados` (
  `UF` char(2) COLLATE utf8_unicode_ci NOT NULL,
  `UF_DESC` varchar(35) COLLATE utf8_unicode_ci NOT NULL,
  PRIMARY KEY (`UF`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Extraindo dados da tabela `tb_estados`
--

INSERT INTO `tb_estados` (`UF`, `UF_DESC`) VALUES
('SP', 'São Paulo'),
('RJ', 'Rio de Janeiro'),
('MG', 'Minas Gerais');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

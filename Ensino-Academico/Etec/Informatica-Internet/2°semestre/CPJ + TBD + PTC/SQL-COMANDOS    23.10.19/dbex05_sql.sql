-- phpMyAdmin SQL Dump
-- version 4.7.9
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3306
-- Generation Time: 24-Out-2019 às 00:30
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
-- Database: `dbex05_sql`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_aluno`
--

DROP TABLE IF EXISTS `tb_aluno`;
CREATE TABLE IF NOT EXISTS `tb_aluno` (
  `MAT_ALUNO` int(11) NOT NULL,
  `NOME_ALUNO` varchar(60) COLLATE utf8_unicode_ci NOT NULL,
  `NOTA_ALUNO` decimal(3,1) NOT NULL,
  `STATUS_ALUNOS` varchar(35) COLLATE utf8_unicode_ci NOT NULL,
  PRIMARY KEY (`MAT_ALUNO`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Extraindo dados da tabela `tb_aluno`
--

INSERT INTO `tb_aluno` (`MAT_ALUNO`, `NOME_ALUNO`, `NOTA_ALUNO`, `STATUS_ALUNOS`) VALUES
(34567, 'Ana Paula', '9.3', 'REPROVADO'),
(34817, 'Lucas', '6.2', 'EXAME'),
(34938, 'Igor', '5.7', 'EXAME'),
(34947, 'Joao Pedro', '7.9', 'REPROVADO');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

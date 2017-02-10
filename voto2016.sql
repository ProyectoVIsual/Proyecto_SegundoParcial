-- phpMyAdmin SQL Dump
-- version 4.5.1
-- http://www.phpmyadmin.net
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 09-02-2017 a las 09:14:17
-- Versión del servidor: 10.1.9-MariaDB
-- Versión de PHP: 5.6.15

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `voto2016`
--
CREATE DATABASE IF NOT EXISTS `voto2016` DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci;
USE `voto2016`;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `admin`
--

DROP TABLE IF EXISTS `admin`;
CREATE TABLE IF NOT EXISTS `admin` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(25) NOT NULL,
  `user` varchar(25) NOT NULL,
  `pass` varchar(25) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `admin`
--

INSERT INTO `admin` (`id`, `nombre`, `user`, `pass`) VALUES
(1, 'ADMINISTRADOR', 'admin', 'admin123');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `candidato`
--

DROP TABLE IF EXISTS `candidato`;
CREATE TABLE IF NOT EXISTS `candidato` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(25) NOT NULL,
  `user` varchar(25) NOT NULL,
  `pass` varchar(25) NOT NULL,
  `lista` varchar(25) NOT NULL,
  `Votos` int(11) DEFAULT NULL,
  `cedula` int(11) NOT NULL,
  `edad` int(11) NOT NULL,
  `dignidad` varchar(50) NOT NULL,
  `apellido` varchar(25) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=28 DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `candidato`
--

INSERT INTO `candidato` (`id`, `nombre`, `user`, `pass`, `lista`, `Votos`, `cedula`, `edad`, `dignidad`, `apellido`) VALUES
(1, 'fernando', 'fernando', 'fernando123', '1', 0, 1220356846, 30, 'presidente', 'ordoñez'),
(2, 'carlos', 'carlos', 'carlos123', '2', 1, 356589356, 35, 'presidente', 'noboa'),
(3, 'paco', 'pacola20', '123456', '20', 0, 1568854963, 55, 'presidente', 'moncayo'),
(4, 'Edgar ', 'edgja10', 'edgja10', '10', 0, 536356984, 46, 'Parlamento Andino', 'Jara '),
(5, 'Monavel ', 'monma1', 'monma1', '1', 0, 1254564786, 32, 'Parlamento Andino', 'Macias'),
(6, 'Lourdes', 'louti12', 'louti12', '12', 0, 1356535604, 55, 'Parlamento Andino', 'Tiban'),
(7, 'Yaritza', 'yarive1', 'yarive1', '1', 0, 1265358653, 45, 'Parlamento Andino', 'Vera'),
(8, 'jose', 'joserr35', 'joserr35', '35', 0, 1325645565, 48, 'Asambleista', 'Serrano'),
(9, 'Luis', 'luquis35', 'luquis35', '35', 0, 156356689, 36, 'Asambleista', 'Quishpi'),
(10, 'Pubenza', 'pubfuen3', 'pubfuen3', '3', 0, 1325356894, 50, 'Parlamento Andino', 'Fuentes'),
(11, 'Roxana ', 'roxpig6', 'roxpig6', '6', 0, 1356195362, 29, 'Parlamento Andino', 'Piguave '),
(12, 'Wilson ', 'wilsa7', 'wilsa7', '7', 0, 254356456, 48, 'Parlamento Andino', 'Sanchez'),
(13, 'nulo', 'vnulo0', 'vnulo0', '0', 0, 0, 10, 'presidente', 'P'),
(14, 'blanco', 'vblanc0', 'vblanc0', '0', 0, 0, 0, 'presidente', 'P'),
(15, 'Viviana', 'vivibo35', 'vivibo35', '35', 0, 995632359, 30, 'Asambleista', 'Bonilla'),
(16, 'MOISES', 'moitac6', 'moitac6', '6', 0, 653456823, 48, 'Asambleista', 'TACLE'),
(17, 'PAOLA', 'paovin6', 'paovin6', '6', 0, 956234586, 27, 'Asambleista', 'VINTIMILLA'),
(18, 'Guillermo', 'guisan21', 'guisan21', '21', 0, 653569520, 38, 'Asambleista', 'Santos'),
(19, 'Mae', 'maemon21', 'maemon21', '21', 0, 1826552380, 49, 'Asambleista', 'Montaño'),
(20, 'María José', 'majoce5', 'majoce5', '5', 0, 633526405, 28, 'Asambleista', 'Cedeno '),
(21, 'Alex ', 'alalma5', 'alalma5', '5', 0, 56348689, 36, 'Asambleista', 'Almache'),
(22, 'Priscilla', 'prisna17', 'prisna17', '17', 0, 953456850, 31, 'Asambleista', 'Naranjo'),
(23, 'blanco', 'vpablanc0', 'vpablanc0', '0', 0, 11, 0, 'Parlamento Andino', 'PA'),
(24, 'nulo', 'nulpa0', 'nulpa0', '0', 0, 1, 0, 'Parlamento Andino', 'PA'),
(25, 'nulo', 'nulas0', 'nulas0', '0', 0, 12, 0, 'Asambleista', 'A'),
(26, 'blanco', 'blasn0', 'blasn0', '0', 0, 2, 0, 'Asambleista', 'A');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuario`
--

DROP TABLE IF EXISTS `usuario`;
CREATE TABLE IF NOT EXISTS `usuario` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(25) NOT NULL,
  `user` varchar(25) NOT NULL,
  `pass` varchar(25) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `usuario`
--

INSERT INTO `usuario` (`id`, `nombre`, `user`, `pass`) VALUES
(1, 'fernando', 'fernando', 'fernando123'),
(2, 'carlos', 'carlos', 'carlos123'),
(3, 'andres', 'andres', 'andres123');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `votante`
--

DROP TABLE IF EXISTS `votante`;
CREATE TABLE IF NOT EXISTS `votante` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `cedula` int(11) NOT NULL,
  `voto` tinyint(1) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `votante`
--

INSERT INTO `votante` (`id`, `cedula`, `voto`) VALUES
(1, 123456789, 0),
(2, 1234567809, 0),
(3, 123456788, 0),
(4, 987654321, 0),
(5, 12345678, 0),
(6, 99887766, 0),
(7, 55443322, 0);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

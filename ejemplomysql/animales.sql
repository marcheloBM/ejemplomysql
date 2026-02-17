-- phpMyAdmin SQL Dump
-- version 2.6.4-pl4
-- http://www.phpmyadmin.net
-- 
-- Servidor: localhost
-- Tiempo de generación: 25-11-2012 a las 21:33:01
-- Versión del servidor: 5.0.16
-- Versión de PHP: 5.1.1
-- 
-- Base de datos: `animales`
-- 
CREATE DATABASE IF NOT EXISTS `animales` DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci;
USE `animales`;
-- --------------------------------------------------------

-- 
-- Estructura de tabla para la tabla `datos`
-- 

CREATE TABLE `datos` (
  `id` int(11) NOT NULL auto_increment,
  `nombre` varchar(20) NOT NULL,
  `tipo` varchar(20) NOT NULL,
  PRIMARY KEY  (`id`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1 AUTO_INCREMENT=3 ;

-- 
-- Volcar la base de datos para la tabla `datos`
-- 

INSERT INTO `datos` VALUES (1, 'boby', 'perro');
INSERT INTO `datos` VALUES (2, 'minina', 'gata');

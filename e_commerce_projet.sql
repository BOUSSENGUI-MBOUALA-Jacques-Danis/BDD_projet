-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le : mar. 30 jan. 2024 à 10:40
-- Version du serveur : 8.0.31
-- Version de PHP : 8.0.26

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `e_commerce_projet`
--

-- --------------------------------------------------------

--
-- Structure de la table `acheter`
--

DROP TABLE IF EXISTS `acheter`;
CREATE TABLE IF NOT EXISTS `acheter` (
  `idAcheter` int NOT NULL AUTO_INCREMENT,
  `idClient` int DEFAULT NULL,
  `idProduit` int DEFAULT NULL,
  PRIMARY KEY (`idAcheter`),
  KEY `idClient` (`idClient`),
  KEY `idProduit` (`idProduit`)
) 
-- --------------------------------------------------------

--
-- Structure de la table `client`
--

DROP TABLE IF EXISTS `client`;
CREATE TABLE IF NOT EXISTS `client` (
  `idClient` int NOT NULL AUTO_INCREMENT,
  `nomClient` varchar(30) DEFAULT NULL,
  `usernameClient` varchar(30) DEFAULT NULL,
  `numCarte` int DEFAULT NULL,
  `mdpClient` varchar(30) DEFAULT NULL,
  PRIMARY KEY (`idClient`)
) 
-- --------------------------------------------------------

--
-- Structure de la table `commande`
--

DROP TABLE IF EXISTS `commande`;
CREATE TABLE IF NOT EXISTS `commande` (
  `idCommande` int NOT NULL AUTO_INCREMENT,
  `dateCommande` varchar(50) DEFAULT NULL,
  `idPanier` int DEFAULT NULL,
  `idClient` int DEFAULT NULL,
  PRIMARY KEY (`idCommande`),
  KEY `idPanier` (`idPanier`),
  KEY `idClient` (`idClient`)
) 
-- --------------------------------------------------------

--
-- Structure de la table `contenir`
--

DROP TABLE IF EXISTS `contenir`;
CREATE TABLE IF NOT EXISTS `contenir` (
  `idContenir` int NOT NULL AUTO_INCREMENT,
  `idProduit` int DEFAULT NULL,
  `idCommande` int DEFAULT NULL,
  PRIMARY KEY (`idContenir`),
  KEY `idProduit` (`idProduit`),
  KEY `idCommande` (`idCommande`)
)
-- --------------------------------------------------------

--
-- Structure de la table `panier`
--

DROP TABLE IF EXISTS `panier`;
CREATE TABLE IF NOT EXISTS `panier` (
  `idPanier` int NOT NULL AUTO_INCREMENT,
  `idClient` int DEFAULT NULL,
  PRIMARY KEY (`idPanier`),
  KEY `idClient` (`idClient`)
) 
-- --------------------------------------------------------

--
-- Structure de la table `produit`
--

DROP TABLE IF EXISTS `produit`;
CREATE TABLE IF NOT EXISTS `produit` (
  `idProduit` int NOT NULL AUTO_INCREMENT,
  `nomProduit` varchar(50) DEFAULT NULL,
  `prix` varchar(30) DEFAULT NULL,
  `quantite` int DEFAULT NULL,
  PRIMARY KEY (`idProduit`)
) 
-- --------------------------------------------------------

--
-- Structure de la table `stocker`
--

DROP TABLE IF EXISTS `stocker`;
CREATE TABLE IF NOT EXISTS `stocker` (
  `idStocker` int NOT NULL AUTO_INCREMENT,
  `idProduit` int DEFAULT NULL,
  `idPanier` int DEFAULT NULL,
  PRIMARY KEY (`idStocker`),
  KEY `idProduit` (`idProduit`),
  KEY `idPanier` (`idPanier`)
) 
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

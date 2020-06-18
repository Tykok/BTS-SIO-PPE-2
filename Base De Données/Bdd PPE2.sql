-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1
-- Généré le : jeu. 18 juin 2020 à 15:41
-- Version du serveur :  10.4.11-MariaDB
-- Version de PHP : 7.4.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `ppe2`
--

-- --------------------------------------------------------

--
-- Structure de la table `installer`
--

CREATE TABLE `installer` (
  `IdPoste` int(5) NOT NULL,
  `IdLogiciel` int(5) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `installer`
--

INSERT INTO `installer` (`IdPoste`, `IdLogiciel`) VALUES
(1, 10),
(1, 200),
(2, 10),
(2, 200),
(3, 10),
(3, 200),
(4, 20),
(4, 200),
(5, 20),
(5, 200),
(6, 20),
(6, 200),
(7, 40),
(8, 60),
(9, 110),
(9, 140),
(9, 150),
(9, 200),
(10, 40),
(11, 80),
(11, 110),
(11, 140),
(11, 150),
(11, 200),
(12, 70),
(12, 110),
(12, 140),
(12, 150),
(12, 200),
(13, 20),
(13, 110),
(13, 140),
(13, 150),
(13, 200),
(14, 20),
(14, 110),
(14, 140),
(14, 150),
(14, 200),
(15, 20),
(15, 110),
(15, 140),
(15, 150),
(15, 200),
(16, 10),
(16, 110),
(16, 140),
(16, 150),
(16, 200),
(17, 10),
(17, 110),
(17, 140),
(17, 150),
(17, 200),
(18, 10),
(18, 110),
(18, 140),
(18, 150),
(18, 200),
(19, 60),
(20, 40),
(21, 80),
(21, 110),
(21, 140),
(21, 150),
(21, 200),
(22, 70),
(22, 110),
(22, 140),
(22, 150),
(22, 200),
(23, 20),
(23, 110),
(23, 140),
(23, 150),
(23, 200),
(24, 20),
(24, 110),
(24, 140),
(24, 150),
(24, 200),
(25, 20),
(25, 110),
(25, 140),
(25, 150),
(25, 200),
(26, 10),
(26, 110),
(26, 140),
(26, 150),
(26, 200),
(27, 60),
(28, 20),
(28, 110),
(28, 140),
(28, 150),
(28, 200),
(29, 20),
(29, 110),
(29, 140),
(29, 150),
(29, 200),
(30, 40),
(999, 90),
(999, 110),
(999, 120),
(999, 130),
(999, 140),
(999, 150);

-- --------------------------------------------------------

--
-- Structure de la table `logiciel`
--

CREATE TABLE `logiciel` (
  `IdLogiciel` int(5) NOT NULL,
  `Editeur` varchar(20) NOT NULL,
  `Version` varchar(40) NOT NULL,
  `Licence` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `logiciel`
--

INSERT INTO `logiciel` (`IdLogiciel`, `Editeur`, `Version`, `Licence`) VALUES
(10, 'Microsoft', 'Windows XP', 'site'),
(20, 'Microsoft', 'Windows 2000', 'site'),
(30, 'Debian', 'Squeeze 6.0.6', 'libre'),
(40, 'Microsoft', 'Windows Server 2008', 'site'),
(50, 'Ubuntu', 'Precise Pangolin 12.04', 'libre'),
(60, 'Apple', 'OS X 10.8', '5 postes'),
(70, 'Debian', 'Wheezy 7.4', 'libre'),
(80, 'Ubuntu', 'Utopic Unicorn 14.10', 'libre'),
(90, 'Microsoft', 'Windows 10 Professional', ''),
(100, 'Kaspersky', 'Small Office Security', '25 postes'),
(110, 'pdfforge GmbH', 'PDF Creator 3.3.0.15261', 'Libre'),
(120, 'Mozilla', 'Firefox 18.5.0.0', 'Libre'),
(130, 'Microsoft', 'OpenOffice', 'Libre'),
(140, 'Libre Document Fonda', 'Libre Office 6.0', 'Libre'),
(150, 'Mozilla', 'Thunderbird 18.5.0.0', 'Libre'),
(160, 'Microsoft', 'Edge', 'Libre'),
(170, '', 'VLC media Player', 'Libre'),
(180, 'Panda Security S.4', 'Pandadome 15.14.4.0', 'Propriétaire'),
(200, 'Microsoft', 'Office 2007', '50 postes'),
(210, 'pfSense', '2.2.0', 'libre'),
(220, 'Opera', 'Opera Mail v1.0', 'freeware');

-- --------------------------------------------------------

--
-- Structure de la table `poste`
--

CREATE TABLE `poste` (
  `IdPoste` int(5) NOT NULL,
  `NumService` int(1) NOT NULL,
  `commentaire` text NOT NULL,
  `Marque` varchar(20) NOT NULL,
  `Processeur` varchar(20) NOT NULL,
  `TailleMemoire` varchar(10) NOT NULL,
  `DisqueDur` varchar(15) NOT NULL,
  `IP` varchar(15) DEFAULT NULL,
  `CarteGraphique` varchar(25) NOT NULL,
  `Garantie` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `poste`
--

INSERT INTO `poste` (`IdPoste`, `NumService`, `commentaire`, `Marque`, `Processeur`, `TailleMemoire`, `DisqueDur`, `IP`, `CarteGraphique`, `Garantie`) VALUES
(1, 1, '', 'Acer', 'Intel i5', '4 Go', '500 Go', '172.16.0.1', 'NVIDIA Quadro 1000M', 1),
(2, 1, '', 'Acer', 'Intel i5', '4 Go', '500 Go', '172.16.0.2', 'NVIDIA Quadro 1000M', 1),
(3, 1, 'Problème de connexion au poste 3', 'Acer', 'Intel i5', '4 Go', '500 Go', '172.16.0.3', 'NVIDIA Quadro 1000M', 0),
(4, 1, '', 'Asus', 'Intel i5', '6 Go', '500 Go', '172.16.0.4', 'Mobile Intel HM77', 0),
(5, 1, '', 'Asus', 'Intel i5', '6 Go', '500 Go', '172.16.0.5', 'Mobile Intel HM77', 1),
(6, 1, '', 'Acer', 'Intel i7', '6 Go', '1 To', '172.16.0.6', 'NVIDIA GeForce GTX550Ti ', 1),
(7, 1, 'Probléme de connexion', 'Acer', 'Intel i7', '10 Go', '2 To', '172.16.0.7', 'NVIDIA GeForce GTX570', 1),
(8, 1, '', 'Apple', 'A6X', '6 Go', '64 Go', '172.16.0.8', 'Puce graphique', 1),
(9, 1, '', 'Compaq', 'Athlon II P360', '4 Go', '320 Go', '172.16.0.9', 'ATI Mobility Radeon HD 42', 1),
(10, 1, '', 'Compaq', 'Athlon II P360', '8 Go', '600 Go', '172.16.15.254', 'ATI Mobility Radeon HD 42', 1),
(11, 2, '', 'Acer', 'Intel i5', '4 Go', '500 Go', '172.16.16.1', 'NVIDIA Quadro 1000M', 1),
(12, 2, '', 'Compaq', 'Athlon II P360', '8 Go', '600 Go', '172.16.16.2', 'ATI Mobility Radeon HD 42', 1),
(13, 2, '', 'Acer', 'Intel i5', '4 Go', '500 Go', '172.16.16.3', 'NVIDIA Quadro 1000M', 1),
(14, 2, '', 'Acer', 'Intel i5', '4 Go', '500 Go', '172.16.16.4', 'NVIDIA Quadro 1000M', 0),
(15, 2, '', 'Asus', 'Intel i5', '6 Go', '500 Go', '172.16.16.5', 'Mobile Intel HM77', 0),
(16, 2, '', 'Asus', 'Intel i5', '6 Go', '500 Go', '172.16.16.6', 'Mobile Intel HM77', 1),
(17, 2, '', 'Acer', 'Intel i7', '6 Go', '1 To', '172.16.16.7', 'NVIDIA GeForce GTX550Ti ', 1),
(18, 2, '', 'Acer', 'Intel i7', '10 Go', '2 To', '172.16.16.8', 'NVIDIA GeForce GTX570', 1),
(19, 2, '', 'Apple', 'A6X', '6 Go', '64 Go', '172.16.16.9', 'Puce graphique', 1),
(20, 2, '', 'Acer', 'Intel i5', '4 Go', '500 Go', '172.16.31.254', 'NVIDIA Quadro 1000M', 1),
(21, 3, '', 'Acer', 'Intel i5', '4 Go', '500 Go', '172.16.160.1', 'NVIDIA Quadro 1000M', 1),
(22, 3, '', 'Acer', 'Intel i5', '4 Go', '500 Go', '172.16.160.2', 'NVIDIA Quadro 1000M', 0),
(23, 3, '', 'Asus', 'Intel i5', '6 Go', '500 Go', '172.16.160.3', 'Mobile Intel HM77', 0),
(24, 3, '', 'Asus', 'Intel i5', '6 Go', '500 Go', '172.16.160.4', 'Mobile Intel HM77', 1),
(25, 3, '', 'Acer', 'Intel i7', '6 Go', '1 To', '172.16.160.5', 'NVIDIA GeForce GTX550Ti ', 1),
(26, 3, '', 'Acer', 'Intel i7', '10 Go', '2 To', '172.16.160.6', 'NVIDIA GeForce GTX570', 1),
(27, 3, '', 'Apple', 'A6X', '6 Go', '64 Go', '172.16.160.7', 'Puce graphique', 1),
(28, 3, '', 'Compaq', 'Athlon II P360', '4 Go', '320 Go', '172.16.160.8', 'ATI Mobility Radeon HD 42', 1),
(29, 3, '', 'Compaq', 'Athlon II P360', '8 Go', '600 Go', '172.16.160.9', 'ATI Mobility Radeon HD 42', 1),
(30, 3, '', 'Compaq', 'Athlon II P360', '8 Go', '600 Go', '172.16.175.254', 'ATI Mobility Radeon HD 42', 1),
(999, 1, '', 'Machine Virtuelle', 'Machine Virtuelle', 'Machine Vi', 'Machine Virtuel', 'A preciser', 'Machine Virtuelle', 0);

-- --------------------------------------------------------

--
-- Structure de la table `service`
--

CREATE TABLE `service` (
  `NumService` int(1) NOT NULL,
  `NomService` varchar(15) CHARACTER SET cp1251 NOT NULL,
  `Batiment` varchar(20) COLLATE utf8mb4_unicode_ci NOT NULL,
  `adresse` varchar(15) COLLATE utf8mb4_unicode_ci NOT NULL,
  `masque` varchar(15) COLLATE utf8mb4_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Déchargement des données de la table `service`
--

INSERT INTO `service` (`NumService`, `NomService`, `Batiment`, `adresse`, `masque`) VALUES
(1, 'Administration', 'A 1er étage', '172.16.0.0', '255.255.240.0'),
(2, 'Logistique', 'A 2ème étage', '172.16.16.0', '255.255.240.0'),
(3, 'Projet', 'B 1er étage', '172.16.160.0', '255.255.240.0');

--
-- Index pour les tables déchargées
--

--
-- Index pour la table `installer`
--
ALTER TABLE `installer`
  ADD PRIMARY KEY (`IdPoste`,`IdLogiciel`),
  ADD KEY `IdLogiciel` (`IdLogiciel`);

--
-- Index pour la table `logiciel`
--
ALTER TABLE `logiciel`
  ADD PRIMARY KEY (`IdLogiciel`),
  ADD KEY `IdLogiciel` (`IdLogiciel`),
  ADD KEY `IdLogiciel_2` (`IdLogiciel`),
  ADD KEY `IdLogiciel_3` (`IdLogiciel`),
  ADD KEY `IdLogiciel_4` (`IdLogiciel`);

--
-- Index pour la table `poste`
--
ALTER TABLE `poste`
  ADD PRIMARY KEY (`IdPoste`),
  ADD UNIQUE KEY `IP` (`IP`),
  ADD KEY `IdPoste` (`IdPoste`),
  ADD KEY `NumService` (`NumService`);

--
-- Index pour la table `service`
--
ALTER TABLE `service`
  ADD PRIMARY KEY (`NumService`),
  ADD UNIQUE KEY `adresse` (`adresse`),
  ADD KEY `NumService` (`NumService`);

--
-- AUTO_INCREMENT pour les tables déchargées
--

--
-- AUTO_INCREMENT pour la table `service`
--
ALTER TABLE `service`
  MODIFY `NumService` int(1) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- Contraintes pour les tables déchargées
--

--
-- Contraintes pour la table `installer`
--
ALTER TABLE `installer`
  ADD CONSTRAINT `installer_ibfk_2` FOREIGN KEY (`IdLogiciel`) REFERENCES `logiciel` (`IdLogiciel`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `installer_ibfk_3` FOREIGN KEY (`IdPoste`) REFERENCES `poste` (`IdPoste`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Contraintes pour la table `poste`
--
ALTER TABLE `poste`
  ADD CONSTRAINT `poste_ibfk_1` FOREIGN KEY (`NumService`) REFERENCES `service` (`NumService`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

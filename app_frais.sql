-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1
-- Généré le : ven. 09 mai 2025 à 16:29
-- Version du serveur : 10.4.32-MariaDB
-- Version de PHP : 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `frais`
--

-- --------------------------------------------------------

--
-- Structure de la table `contenir`
--

CREATE TABLE `contenir` (
  `idDepense` int(11) NOT NULL,
  `moisAnnee` char(6) NOT NULL,
  `matricule` char(10) NOT NULL,
  `quantite` int(11) NOT NULL DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Déchargement des données de la table `contenir`
--

INSERT INTO `contenir` (`idDepense`, `moisAnnee`, `matricule`, `quantite`) VALUES
(1, '122024', 'NRD/125-09', 9);

-- --------------------------------------------------------

--
-- Structure de la table `fonctione`
--

CREATE TABLE `fonctione` (
  `id` int(11) NOT NULL,
  `libele` varchar(25) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Déchargement des données de la table `fonctione`
--

INSERT INTO `fonctione` (`id`, `libele`) VALUES
(1, 'visiteur'),
(2, 'comptable'),
(3, 'admin'),
(4, 'directeur');

-- --------------------------------------------------------

--
-- Structure de la table `forfait`
--

CREATE TABLE `forfait` (
  `id` int(11) NOT NULL,
  `type` varchar(23) NOT NULL,
  `montant` double NOT NULL DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Déchargement des données de la table `forfait`
--

INSERT INTO `forfait` (`id`, `type`, `montant`) VALUES
(1, 'Nuitée', 80),
(2, 'Repas Midi', 29),
(3, 'Étape', 109),
(4, 'Véhicule 4CV Diesel', 0.52),
(5, 'Véhicule 5/6CV Diesel', 0.58),
(6, 'Véhicule 4CV Essence', 0.62),
(7, 'Véhicule 5/6CV Essence', 0.67);

-- --------------------------------------------------------

--
-- Structure de la table `frais`
--

CREATE TABLE `frais` (
  `moisannee` char(6) NOT NULL,
  `matricule` char(10) NOT NULL,
  `nbJustificatifs` int(11) DEFAULT 0,
  `dateoperation` date NOT NULL DEFAULT current_timestamp(),
  `montanttotal` double NOT NULL DEFAULT 0,
  `idDescription` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Déchargement des données de la table `frais`
--

INSERT INTO `frais` (`moisannee`, `matricule`, `nbJustificatifs`, `dateoperation`, `montanttotal`, `idDescription`) VALUES
('122024', 'NRD/125-09', 2, '2024-12-06', 0, 1);

-- --------------------------------------------------------

--
-- Structure de la table `hor_forfait`
--

CREATE TABLE `hor_forfait` (
  `id` int(11) NOT NULL,
  `libelle` varchar(50) NOT NULL,
  `montant` double NOT NULL DEFAULT 0,
  `dateDep` date NOT NULL,
  `moisAnnee` char(6) NOT NULL,
  `matricule` char(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Déchargement des données de la table `hor_forfait`
--

INSERT INTO `hor_forfait` (`id`, `libelle`, `montant`, `dateDep`, `moisAnnee`, `matricule`) VALUES
(1, 'Repas Représentation', 156, '2024-12-18', '122024', 'NRD/125-09'),
(2, 'Achat Fleuriste Soirée \"MediLog\"', 120.3, '2024-12-22', '122024', 'NRD/125-09');

-- --------------------------------------------------------

--
-- Structure de la table `situation`
--

CREATE TABLE `situation` (
  `id` int(11) NOT NULL,
  `description` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Déchargement des données de la table `situation`
--

INSERT INTO `situation` (`id`, `description`) VALUES
(1, 'Créée'),
(2, 'Clôturée'),
(3, 'Validée'),
(4, 'Mise en paiement'),
(5, 'Remboursée');

-- --------------------------------------------------------

--
-- Structure de la table `utilisateur`
--

CREATE TABLE `utilisateur` (
  `id` char(10) NOT NULL,
  `nom` varchar(50) NOT NULL,
  `prenom` varchar(20) NOT NULL,
  `dateNaiss` date NOT NULL,
  `dateEmbauche` date NOT NULL,
  `email` varchar(100) DEFAULT NULL,
  `telephone` char(10) DEFAULT NULL,
  `adresse` varchar(100) NOT NULL,
  `codepostal` char(5) NOT NULL,
  `ville` varchar(50) NOT NULL,
  `login` varchar(50) NOT NULL,
  `motdepasse` varchar(50) NOT NULL,
  `idPoste` int(11) NOT NULL,
  `idVehicule` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Déchargement des données de la table `utilisateur`
--

INSERT INTO `utilisateur` (`id`, `nom`, `prenom`, `dateNaiss`, `dateEmbauche`, `email`, `telephone`, `adresse`, `codepostal`, `ville`, `login`, `motdepasse`, `idPoste`, `idVehicule`) VALUES
('NRD/125-01', 'Iraj', 'Jean', '2005-04-03', '2024-10-08', 'irajjean@gmail.com', '670165954', '8 avenue Paul ', '75020', 'paris', 'IJ', 'iraj123', 4, 3),
('NRD/125-02', 'Gaus', 'Lim', '1965-09-13', '2024-10-08', 'gaus@gmail.com', '765342513', '12 rue Paul', '76019', 'paris', 'Gl', 'gaus123', 1, 1),
('NRD/125-03', 'alex', 'in', '2000-03-08', '2024-10-08', 'alexin@gmail.com', '632459882', '4 rue de Paris', '75000', 'Blancmesnil', 'Pokemon', 'alex123', 2, 1),
('NRD/125-04', 'Leo', 'Lan', '1987-09-13', '2024-10-08', 'leo@gmail.com', '845165984', '25 rue des Pacrettes', '95788', 'Gargouville', 'Ll', 'leo123', 1, 1),
('NRD/125-05', 'Atom', 'Louis', '1997-11-27', '2024-10-08', 'atlouis22@gmail.com', '566565565', '4 rue Merdalla', '22300', 'Tolbiac', 'Atominos', 'Tolbiac22300', 1, 4),
('NRD/125-06', 'yaya', 'ba', '1998-11-27', '2024-10-08', 'yaya@gmail.com', '220202020', '16 avenue du Fion', '14800', 'Constantinople', 'AtoutoutA', 'Constantinople14800', 2, 1),
('NRD/125-07', 'rayan', 'ray', '2008-11-27', '2024-10-08', 'ray@gmail.com', '332255665', '16 rue du Btrou', '32000', 'max', 'maxi', 'max123', 3, 4),
('NRD/125-08', 'Lo', 'Ro', '1888-11-27', '2024-10-08', 'polygo@gmail.com', '999396989', '16 avenue de Poligote', '98000', 'RUBOS', 'Lr', 'Lo123', 3, 2),
('NRD/125-09', 'sam', 'jo', '2024-12-06', '2024-12-06', 'sam.jo@medoc.com', '123456789', '86 rue de Silly', '92100', 'Boulogne-Billancourt', 'Sj', 'Sam123', 1, 3),
('NRD/125-10', 'Doe', 'Jane', '2024-12-06', '2024-12-06', 'jane.doe@medoc.com', '987654321', '8 route des Postillons', '92310', 'Sèvres', 'jane.doe', 'Sèvres92310', 2, 1);

--
-- Index pour les tables déchargées
--

--
-- Index pour la table `contenir`
--
ALTER TABLE `contenir`
  ADD PRIMARY KEY (`idDepense`,`moisAnnee`,`matricule`),
  ADD KEY `moisAnnee` (`moisAnnee`,`matricule`),
  ADD KEY `idDepense` (`idDepense`) USING BTREE;

--
-- Index pour la table `fonctione`
--
ALTER TABLE `fonctione`
  ADD PRIMARY KEY (`id`);

--
-- Index pour la table `forfait`
--
ALTER TABLE `forfait`
  ADD PRIMARY KEY (`id`);

--
-- Index pour la table `frais`
--
ALTER TABLE `frais`
  ADD PRIMARY KEY (`moisannee`,`matricule`),
  ADD KEY `matricule` (`matricule`),
  ADD KEY `idStatut` (`idDescription`);

--
-- Index pour la table `hor_forfait`
--
ALTER TABLE `hor_forfait`
  ADD PRIMARY KEY (`id`),
  ADD KEY `moisAnnee` (`moisAnnee`,`matricule`);

--
-- Index pour la table `situation`
--
ALTER TABLE `situation`
  ADD PRIMARY KEY (`id`) USING BTREE;

--
-- Index pour la table `utilisateur`
--
ALTER TABLE `utilisateur`
  ADD PRIMARY KEY (`id`),
  ADD KEY `idPoste` (`idPoste`),
  ADD KEY `idVehicule` (`idVehicule`);

--
-- AUTO_INCREMENT pour les tables déchargées
--

--
-- AUTO_INCREMENT pour la table `contenir`
--
ALTER TABLE `contenir`
  MODIFY `idDepense` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT pour la table `fonctione`
--
ALTER TABLE `fonctione`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT pour la table `forfait`
--
ALTER TABLE `forfait`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;

--
-- AUTO_INCREMENT pour la table `hor_forfait`
--
ALTER TABLE `hor_forfait`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT pour la table `situation`
--
ALTER TABLE `situation`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- Contraintes pour les tables déchargées
--

--
-- Contraintes pour la table `contenir`
--
ALTER TABLE `contenir`
  ADD CONSTRAINT `contenir_ibfk_1` FOREIGN KEY (`idDepense`) REFERENCES `forfait` (`id`),
  ADD CONSTRAINT `contenir_ibfk_2` FOREIGN KEY (`moisAnnee`,`matricule`) REFERENCES `frais` (`moisannee`, `matricule`);

--
-- Contraintes pour la table `frais`
--
ALTER TABLE `frais`
  ADD CONSTRAINT `frais_ibfk_1` FOREIGN KEY (`matricule`) REFERENCES `utilisateur` (`id`),
  ADD CONSTRAINT `frais_ibfk_2` FOREIGN KEY (`idDescription`) REFERENCES `situation` (`id`);

--
-- Contraintes pour la table `hor_forfait`
--
ALTER TABLE `hor_forfait`
  ADD CONSTRAINT `hor_forfait_ibfk_1` FOREIGN KEY (`moisAnnee`,`matricule`) REFERENCES `frais` (`moisannee`, `matricule`);

--
-- Contraintes pour la table `utilisateur`
--
ALTER TABLE `utilisateur`
  ADD CONSTRAINT `utilisateur_ibfk_1` FOREIGN KEY (`idPoste`) REFERENCES `fonctione` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

use BDB56Projet1MJ

-- SUPPRIME LES TABLES SI ELLES EXISTENT DEJA POUR LES RECRÉER PAR LA SUITE
DROP TABLE IF EXISTS assistantSoin;
DROP TABLE IF EXISTS assistant;
DROP TABLE IF EXISTS reservationChambre;
DROP TABLE IF EXISTS planifSoin;
DROP TABLE IF EXISTS soin;
DROP TABLE IF EXISTS chambre;
DROP TABLE IF EXISTS utilisateur;
DROP TABLE IF EXISTS typeChambre;
DROP TABLE IF EXISTS typeSoin;
DROP TABLE IF EXISTS typeUtilisateur;
DROP TABLE IF EXISTS invite;
DROP TABLE IF EXISTS client;

-- CRÉATION DES TABLES

-- TABLES CLIENT ET INVITE
CREATE TABLE client (
	noClient int PRIMARY KEY CHECK (noClient % 10 = 0),
	nomClient varchar(50),
	prenomClient varchar(50),
	villeClient varchar(50),
	paysClient varchar(50),
	adresseClient varchar(50),	
	codePostalClient varchar(6),
	dateInscriptionClient datetime,
);
CREATE TABLE invite (
	noInvite int PRIMARY KEY CHECK (noInvite % 10 <> 0),
	nomPrenomInvite varchar(100),
	noClient int,
	FOREIGN KEY (noClient) REFERENCES client(noClient) ON DELETE NO ACTION,
);


-- TABLE TYPE D'UTILISATEUR
CREATE TABLE typeUtilisateur (
	noTypeUtilisateur int PRIMARY KEY,
	descriptionTypeUtilisateur varchar(20),
);
-- INSERTION DES VALEURS DE TYPE D'UTILISATEURS
INSERT INTO typeUtilisateur (noTypeUtilisateur, descriptionTypeUtilisateur) VALUES (1, 'Admin'), (2, 'Préposé');


-- TABLE TYPE DE CHAMBRE
CREATE TABLE typeChambre (
	noTypeChambre int PRIMARY KEY,
	descriptionTypeChambre varchar(255) UNIQUE,
	prixHauteSaison numeric(10,2),
	prixBasseSaison numeric(10,2),
	prixMoyenneSaison numeric(10,2),
);

-- TABLES UTILISATEUR, CHAMBRE ET ASSISTANT
CREATE TABLE utilisateur (
	noUtilisateur int PRIMARY KEY,
	nomUtilisateur varchar(50) UNIQUE,
	mdpUtilisateur varchar(50),
	noTypeUtilisateur int FOREIGN KEY REFERENCES typeUtilisateur(noTypeUtilisateur) ON DELETE NO ACTION,
);

CREATE TABLE chambre (
	noChambre int PRIMARY KEY,
	noTypeChambre int FOREIGN KEY REFERENCES typeChambre(noTypeChambre) ON DELETE NO ACTION,
	emplacement varchar(255),
	decorations varchar(255)	
);

CREATE TABLE assistant (
	noAssistant int PRIMARY KEY,
	nomAssistant varchar(50),
	prenomAssistant varchar(50),
	specialites varchar(255),
	remarques varchar(255),
);


-- TABLE TYPE DE SOINS
CREATE TABLE typeSoin (
	noTypeSoin int PRIMARY KEY,
	descriptionTypeSoin varchar(20),
);
-- INSERTION DES VALEURS DE TYPE DE SOINS
INSERT INTO typeSoin (noTypeSoin, descriptionTypeSoin) VALUES (1, 'Beauté'), (2, 'Santé');


-- TABLE SOIN
CREATE TABLE soin (
	noSoin int PRIMARY KEY,
	description varchar(255),
	dureeMinuteSoin int DEFAULT 60,
	noTypeSoin int FOREIGN KEY REFERENCES typeSoin(noTypeSoin) ON DELETE NO ACTION,
	prix numeric(10,2)
);


-- TABLES PLANIFICATION DES SOINS, ASSISTANT ET LEURS SOINS ET RESERVATION DE CHAMBRES
CREATE TABLE planifSoin (
	noPersonne int,
	noAssistant int FOREIGN KEY REFERENCES assistant(noAssistant) ON DELETE NO ACTION,
	dateHeureReservation datetime PRIMARY KEY,
	noSoin int FOREIGN KEY REFERENCES soin(noSoin) ON DELETE NO ACTION,
);

CREATE TABLE assistantSoin (
	noAssistant int FOREIGN KEY REFERENCES assistant(noAssistant) ON DELETE NO ACTION,
	noSoin int FOREIGN KEY REFERENCES soin(noSoin) ON DELETE NO ACTION
);

CREATE TABLE reservationChambre (
	noClient int FOREIGN KEY REFERENCES client(noClient) ON DELETE NO ACTION,
	noChambre int FOREIGN KEY REFERENCES chambre(noChambre) ON DELETE NO ACTION,
	dateDebutReserv datetime PRIMARY KEY,
	dateFinReserv datetime,
	nbPersonnes int
);


-- INSERTION D'AU MOINS UN ADMINISTRATEUR ET UN PRÉPOSÉ
INSERT INTO utilisateur VALUES (1,'BobLaroute', 'Password1', 1)
INSERT INTO utilisateur VALUES (2,'RogDeschamps', 'Password1', 2)
USE master;
GO

IF DB_ID(N'BestellundLagermanagement') IS NULL
  CREATE DATABASE BestellundLagermanagement;
GO

USE BestellundLagermanagement;
GO
IF OBJECT_ID('Verzeichnis') IS NOT NULL
  DROP TABLE Verzeichnis;
GO
IF OBJECT_ID('Mitarbeiterprofil') IS NOT NULL
  DROP TABLE Mitarbeiterprofil ;
GO
IF OBJECT_ID('Lieferanten') IS NOT NULL
  DROP TABLE Lieferanten ;
GO
IF OBJECT_ID('Bestellung') IS NOT NULL
  DROP TABLE Bestellung;
GO
IF OBJECT_ID('Materiallager') IS NOT NULL
  DROP TABLE Materiallager;
GO

CREATE TABLE Mitarbeiterprofil (
  Mitarbeiternummer INT PRIMARY KEY,
  Benutzername NVARCHAR(100),
  Passwort Nvarchar(500),
  Vorname Nvarchar(100),
  Nachname Nvarchar(100),
  E_Mail Nvarchar(100),
  Telefon Nvarchar(100),
  Diensthandy Nvarchar(100)
)

CREATE TABLE Lieferanten (
  Lieferantennummer INT PRIMARY KEY,
  FrimenName NVARCHAR(100),
  FirmenSitze Nvarchar(100),
  Preis Decimal(10,2),
  Lieferzeit Nvarchar(100),
  WelcheWarensindverfuegbar NVARCHAR(100),
  Mitarbeiternummer INT
 
);


CREATE TABLE Bestellung(
  Bestellnummer INT PRIMARY KEY,
  BestellungBezeichung NVARCHAR(100),
  Anzahl int,
  Lieferantennummer INT,
  Bestelldatum Nvarchar(100),
  Lagerort NVARCHAR(100),
  BestellStatus Nvarchar(100),
  Mitarbeiternummer INT
 
);

CREATE TABLE Materiallager(
  Lagernummer INT PRIMARY KEY,
  MaterialWarenbezeichnung NVARCHAR(100),
  Laenge NVARCHAR(100),
  Breite NVARCHAR(100),
  Hoehe NVARCHAR(100),
  Anzahl int,
  Mindesbestand INT,
  Lagerort Nvarchar(100),
  Mitarbeiternummer INT
 
);
CREATE TABLE Verzeichnis(
  VerzeichnisID INT,
  verwaltungsnummrer int,
  CONSTRAINT pk_VerzeichnisID PRIMARY KEY (VerzeichnisID, verwaltungsnummrer),
  Lagerort nvarchar(100)
 -- CONSTRAINT fk_Verzeichnis
	--FOREIGN KEY (VerzeichnisID)
	--REFERENCES Mitarbeiterprofil(Mitarbeiternummer)
	);

	INSERT INTO [dbo].Mitarbeiterprofil (Mitarbeiternummer ,Benutzername,Passwort,Vorname,Nachname,E_Mail,Telefon,Diensthandy) VALUES  (000500, 'Markus','799b095aecdfc406bc71976b144e0a868ef5b72c5bc15c2baf746010841941de','Markus','Hausberger','markus.hausberg@fmail.de','647857995','06812587158563');
	INSERT INTO [dbo].Mitarbeiterprofil (Mitarbeiternummer ,Benutzername,Passwort,Vorname,Nachname,E_Mail,Telefon,Diensthandy) VALUES  (000501, 'Lukas','fdb139ef4ccf4940ddd9048f69f7eea4b59c5bf39f689048bd00a3cfbe518baf','Lukas','Landhaus','lukas.landahus@fmail.de','647478532','06812587148974');
	INSERT INTO [dbo].Mitarbeiterprofil (Mitarbeiternummer ,Benutzername,Passwort,Vorname,Nachname,E_Mail,Telefon,Diensthandy) VALUES  (100501, 'Tim','d1e60a586ff98a74bd52af6609ce11d832dad4823a6844de053a7d20ed44bfcc','Tim','Bergbach','tim.bergbach@fmail.de','64789783','06812587163247');

	INSERT INTO [dbo].Lieferanten (Lieferantennummer ,FrimenName,FirmenSitze,Preis,Lieferzeit,WelcheWarensindverfuegbar,Mitarbeiternummer) VALUES  (111111, 'Stahltr‰gerGmbh','Bachberg 10','15.5','5 Tage','Stahltr‰ger','100501');
	INSERT INTO [dbo].Lieferanten (Lieferantennummer ,FrimenName,FirmenSitze,Preis,Lieferzeit,WelcheWarensindverfuegbar,Mitarbeiternummer) VALUES  (111112, 'StahlroheGmbh','Westpreuﬂen 10','20.5','7 Tage','Stahlrohe','100501');
	INSERT INTO [dbo].Lieferanten (Lieferantennummer ,FrimenName,FirmenSitze,Preis,Lieferzeit,WelcheWarensindverfuegbar,Mitarbeiternummer) VALUES  (111113, 'StahlseileGmbh','Rotenhaus 10','10.5','10 Tage','Stahlseile','100501');
	INSERT INTO [dbo].Lieferanten (Lieferantennummer ,FrimenName,FirmenSitze,Preis,Lieferzeit,WelcheWarensindverfuegbar,Mitarbeiternummer) VALUES  (111114, 'StahlschraubenGmbh','Runinhaus 10','5.5','6 Tage','Stahlschrauben','100501');
	INSERT INTO [dbo].Lieferanten (Lieferantennummer ,FrimenName,FirmenSitze,Preis,Lieferzeit,WelcheWarensindverfuegbar,Mitarbeiternummer) VALUES  (111115, 'StahlmutternGmbh','Seehaus 10','3.5','3 Tage','Stahlmutteren','100501');
	INSERT INTO [dbo].Lieferanten (Lieferantennummer ,FrimenName,FirmenSitze,Preis,Lieferzeit,WelcheWarensindverfuegbar,Mitarbeiternummer) VALUES  (111116, 'StahldrahtGmbh','Berghaus 10','20.5','2 Tage','Stahldraht','100501');

	INSERT INTO [dbo].Bestellung (Bestellnummer ,BestellungBezeichung,Anzahl,Lieferantennummer,Bestelldatum,Lagerort,BestellStatus,Mitarbeiternummer) VALUES  (124578, 'Stahltr‰ger','10','111111','02.01.2022','Rotenberg 10','geliefert','100501');
	INSERT INTO [dbo].Bestellung (Bestellnummer ,BestellungBezeichung,Anzahl,Lieferantennummer,Bestelldatum,Lagerort,BestellStatus,Mitarbeiternummer) VALUES  (124536, 'Stahlrohe','50','111112','11.11.2022','Rotenberg 10','geliefert','100501');
	INSERT INTO [dbo].Bestellung (Bestellnummer ,BestellungBezeichung,Anzahl,Lieferantennummer,Bestelldatum,Lagerort,BestellStatus,Mitarbeiternummer) VALUES  (124584, 'Stahlseile','5','111113','24.04.2023','Rotenberg 10','geliefert','100501');
	INSERT INTO [dbo].Bestellung (Bestellnummer ,BestellungBezeichung,Anzahl,Lieferantennummer,Bestelldatum,Lagerort,BestellStatus,Mitarbeiternummer) VALUES  (124587, 'Stahltr‰ger','50','111111','21.04.2025','Rotenberg 10','offen','100501');

	INSERT INTO [dbo].Materiallager (Lagernummer ,MaterialWarenbezeichnung,Laenge,Breite,Hoehe,Anzahl,Mindesbestand,Lagerort,Mitarbeiternummer) VALUES  (254889, 'Stahltr‰ger','500 m','10 m','5 m','30','5','Rotenberg 10','000501');
	INSERT INTO [dbo].Materiallager (Lagernummer ,MaterialWarenbezeichnung,Laenge,Breite,Hoehe,Anzahl,Mindesbestand,Lagerort,Mitarbeiternummer) VALUES  (254848, 'Stahlrohe','500 m','10 m','5 m','30','5','Rotenberg 10','000501');
	INSERT INTO [dbo].Materiallager (Lagernummer ,MaterialWarenbezeichnung,Laenge,Breite,Hoehe,Anzahl,Mindesbestand,Lagerort,Mitarbeiternummer) VALUES  (254987, 'Stahlseile','500 m','1 cm','2 cm','300','30','Rotenberg 10','000501');
	INSERT INTO [dbo].Materiallager (Lagernummer ,MaterialWarenbezeichnung,Laenge,Breite,Hoehe,Anzahl,Mindesbestand,Lagerort,Mitarbeiternummer) VALUES  (254453, 'Stahlschrauben','2 cm','1 cm','5 cm','1000','250','Rotenberg 10','000501');
	INSERT INTO [dbo].Materiallager (Lagernummer ,MaterialWarenbezeichnung,Laenge,Breite,Hoehe,Anzahl,Mindesbestand,Lagerort,Mitarbeiternummer) VALUES  (259874, 'Stahlmutteren','1 cm','1 cm','2 mm','500','100','Rotenberg 10','000501');
	INSERT INTO [dbo].Materiallager (Lagernummer ,MaterialWarenbezeichnung,Laenge,Breite,Hoehe,Anzahl,Mindesbestand,Lagerort,Mitarbeiternummer) VALUES  (253547, 'Stahldraht','250 m','1 mm','1 mm','150','50','Rotenberg 10','000501');

	INSERT INTO [dbo].Verzeichnis (VerzeichnisID ,verwaltungsnummrer,Lagerort) VALUES  (1,'000500','Rotenberg 10');
	INSERT INTO [dbo].Verzeichnis (VerzeichnisID ,verwaltungsnummrer,Lagerort) VALUES  (2,'100002','Rotenberg 10');
	INSERT INTO [dbo].Verzeichnis (VerzeichnisID ,verwaltungsnummrer,Lagerort) VALUES  (3,'100003','Rotenberg 10');
#------------------------------------------------------------
#        Script MySQL.
#------------------------------------------------------------


#------------------------------------------------------------
# Table: Vendeur
#------------------------------------------------------------

CREATE TABLE Vendeur(
        numVendeur    Int NOT NULL ,
        nomVendeur    Varchar (50) NOT NULL ,
        prenomVendeur Varchar (50) NOT NULL
	,CONSTRAINT Vendeur_PK PRIMARY KEY (numVendeur)
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: Client
#------------------------------------------------------------

CREATE TABLE Client(
        numClient         Int NOT NULL ,
        nomClient         Varchar (50) NOT NULL ,
        prenomClient      Varchar (50) NOT NULL ,
        adresseClient     Varchar (200) NOT NULL ,
        identifiantClient Varchar (50) NOT NULL
	,CONSTRAINT Client_PK PRIMARY KEY (numClient)
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: Voiture
#------------------------------------------------------------

CREATE TABLE Voiture(
        numImmat        Varchar (50) NOT NULL ,
        nouveauVehicule Varchar (50) NOT NULL ,
        ancienVehicule  Varchar (50) NOT NULL ,
        ageVehicule     Int NOT NULL ,
        datePremImmat   Datetime NOT NULL ,
        anneeModele     Int NOT NULL ,
        numSerie        Int NOT NULL ,
        puissance       Float NOT NULL ,
        vendu           Bool NOT NULL ,
        numClient       Int NOT NULL
	,CONSTRAINT Voiture_PK PRIMARY KEY (numImmat)

	,CONSTRAINT Voiture_Client_FK FOREIGN KEY (numClient) REFERENCES Client(numClient)
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: Niveau
#------------------------------------------------------------

CREATE TABLE Niveau(
        cNiv      Int NOT NULL ,
        libNiveau Varchar (50) NOT NULL ,
        tauxComm  Int NOT NULL
	,CONSTRAINT Niveau_PK PRIMARY KEY (cNiv)
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: Credit
#------------------------------------------------------------

CREATE TABLE Credit(
        numCredit     Int NOT NULL ,
        taux          Float NOT NULL ,
        montFin       Float NOT NULL ,
        mensualite    Int NOT NULL ,
        nbMensualites Int NOT NULL ,
        dateOuv       Date NOT NULL ,
        numVendeur    Int NOT NULL ,
        cNiv          Int NOT NULL ,
        numClient     Int NOT NULL
	,CONSTRAINT Credit_PK PRIMARY KEY (numCredit)

	,CONSTRAINT Credit_Vendeur_FK FOREIGN KEY (numVendeur) REFERENCES Vendeur(numVendeur)
	,CONSTRAINT Credit_Niveau0_FK FOREIGN KEY (cNiv) REFERENCES Niveau(cNiv)
	,CONSTRAINT Credit_Client1_FK FOREIGN KEY (numClient) REFERENCES Client(numClient)
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: Vendre
#------------------------------------------------------------

CREATE TABLE Vendre(
        numClient  Int NOT NULL ,
        numVendeur Int NOT NULL
	,CONSTRAINT Vendre_PK PRIMARY KEY (numClient,numVendeur)

	,CONSTRAINT Vendre_Client_FK FOREIGN KEY (numClient) REFERENCES Client(numClient)
	,CONSTRAINT Vendre_Vendeur0_FK FOREIGN KEY (numVendeur) REFERENCES Vendeur(numVendeur)
)ENGINE=InnoDB;
--La liste d�taill�e des postes qui ne sont pas pourvus de processeur de type Intel ;
SELECT *
FROM poste
WHERE Processeur NOT LIKE "%Intel%";


--La liste d�taill�e des postes qui ont au plus 4Go de RAM ou 500 Go de HD ; 
SELECT *
FROM poste
WHERE TailleMemoire<=4 OR DisqueDur <=500
GROUP BY Marque;

--Le nombre de logiciels recens�s par �diteur ;
SELECT Editeur, COUNT(idlogiciel)
FROM logiciel
GROUP BY Editeur;

--Cr�ation des nouvelles tables:
--INSTALLER
CREATE tables installer
ALTER TABLE `installer` ADD FOREIGN KEY ( `IdPoste` ) REFERENCES `eqe_db`.`poste` (
`IdPoste` 
) ON DELETE CASCADE ON UPDATE CASCADE ;

--Mettre des champs en index (pouvoir faire ensuite les relations)
ALTER TABLE `logiciel` ADD INDEX ( `IdLogiciel` ) ;

--L��diteur et la version des logiciels install�s sur le poste pr�par� � la mission 1 ;
SELECT poste.IdPoste, logiciel.Version, Editeur
FROM poste INNER JOIN installer
ON poste.IdPoste=installer.IdPoste
INNER JOIN logiciel
ON installer.IdLogiciel=logiciel.IdLogiciel

--Le nombre de logiciels install�s par poste ; 
SELECT poste.IdPoste, COUNT(logiciel.IdLogiciel) AS "Nombre de logiciels par poste"
FROM poste INNER JOIN installer
ON poste.IdPoste=installer.IdPoste
INNER JOIN logiciel
ON installer.IdLogiciel=logiciel.IdLogiciel
GROUP BY poste.IdPoste

--Nombre de postes regroup� par marque de l'ordinateur
SELECT Marque, COUNT(Marque) AS "Nombres de poste par marque"
FROM poste
GROUP BY Marque

--M�me que la pr�c�dente mais par service
SELECT NomService, Marque, COUNT(Marque) AS "Nombres de poste par marque"
FROM poste INNER JOIN service
ON poste.NumService=service.NumService
GROUP BY Marque, NomService

--Donner combien de postes il y as par service
SELECT count poste.IdPoste as "Nombre de postes par service"
FROM poste inner join service
on poste.numservice=service.numservice
group by service.numservice

--Nombres de logiciels par postes regroupé par Batiment
SELECT NomService,Ip, COUNT(L.idLogiciel) AS "Nombre de logiciels par postes"
FROM poste P INNER JOIN installer I
ON P.idposte = I.idPoste
INNER JOIN logiciel L
ON I.IdLogiciel=L.IdLogiciel
INNER JOIN service S
ON P.NumService=S.NumService
GROUP BY P.idposte, S.NumService


--Cr�ation de l'int�grit� r�ferrentielle entres les tables logiciels et installer et poste et installer
ALTER TABLE `installer` ADD FOREIGN KEY (`IdPoste`) REFERENCES `eqC_db`.`poste`(`IdPoste`) ON DELETE CASCADE ON UPDATE CASCADE;


--Cr�ation des donn�es de la table installer
INSERT INTO `eqC_db`.`installer` (`IdPoste`, `IdLogiciel`) VALUES ('P1', '10');
INSERT INTO `eqC_db`.`installer` (`IdPoste`, `IdLogiciel`) VALUES ('P2', '10');
INSERT INTO `eqC_db`.`installer` (`IdPoste`, `IdLogiciel`) VALUES ('P3', '10');
INSERT INTO `eqC_db`.`installer` (`IdPoste`, `IdLogiciel`) VALUES ('P4', '10');
INSERT INTO `eqC_db`.`installer` (`IdPoste`, `IdLogiciel`) VALUES ('P5', '10');
INSERT INTO `eqC_db`.`installer` (`IdPoste`, `IdLogiciel`) VALUES ('P6', '10');
INSERT INTO `eqC_db`.`installer` (`IdPoste`, `IdLogiciel`) VALUES ('P7', '10');
INSERT INTO `eqC_db`.`installer` (`IdPoste`, `IdLogiciel`) VALUES ('P8', '10');
INSERT INTO `eqC_db`.`installer` (`IdPoste`, `IdLogiciel`) VALUES ('P9', '10');
INSERT INTO `eqC_db`.`installer` (`IdPoste`, `IdLogiciel`) VALUES ('P10', '10');
INSERT INTO `eqC_db`.`installer` (`IdPoste`, `IdLogiciel`) VALUES ('P1', '10');
INSERT INTO `eqC_db`.`installer` (`IdPoste`, `IdLogiciel`) VALUES ('P2', '10');
INSERT INTO `eqC_db`.`installer` (`IdPoste`, `IdLogiciel`) VALUES ('P3', '10');



--Rendre le champs IP unique (�viter les erreurs de duplication d'adresses IP
ALTER TABLE `poste` ADD UNIQUE (
`IP` 
);


--Insertion de donn�es dans la table installer
INSERT INTO `ppe2`.`installer` (`IdPoste`, `IdLogiciel`)
 VALUES ('1', '10'), ('1', '200'), ('2', '10'), ('2', '200'), ('3', '10'), ('3', '200'), ('4', '20'), 
 ('4', '200'), ('5', '20'), ('5', '200'), ('6', '20'), ('6', '200'), ('7', '40'), ('8', '60');

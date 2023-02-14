-- use hebergement;

-- INSERT INTO Roles VALUES ('Admin');
-- INSERT INTO Roles (role_id) VALUES ('Admin');

INSERT INTO Roles 
(role_nom) 
VALUES 
('Admin'), -- 1
('Directeur'), -- 2
('M�decin'), -- 3
('�ducateur'), -- 4
('R�sident'), -- 5
('Gardien'), -- 6
('Technicien'), -- 7
('Cuisinier'); -- 8

-- V1
INSERT INTO Personnes 
(personne_nom, personne_prenom, personne_ddn, role_id) 
VALUES 
('DEV', 'Mike', '1981-11-12', 2),
('Thiry', 'Sophie', '1980-12-31', 8),
('Neymar', 'Jean', '1977-12-06', 7),
('Noah', 'Yannick', '1965-01-02', 6),
('Faronne', 'Sarah', '1985-07-04', 6),
('Holems', 'Cathy', '1990-07-21', 3),
('Mannheim', 'Luc', '1982-07-14', 3),
('Kipr�', 'Abdou', '1982-03-16', 3),
('Martin', 'Val�rie', '1984-11-02', 4),
('Deloin', 'Alain', '1981-11-22', 4),
('Bahl', 'Tarik', '1990-04-02', 4),
('Goldman', 'Estelle', '1992-01-23', 4),
('Durand', 'Gabriel', '1990-10-17', 5); -- r�sident

-- V2
INSERT INTO Personnes
(personne_nom, personne_prenom, personne_ddn, role_id) 
VALUES 
('Nixon', 'Tiger', '2005-12-08', 5),
('Garett', 'Winters', '2004-05-19', 5),
('Ashton', 'Cox', '2003-05-14', 5),
('Cedric', 'Kelly', '2002-02-22', 5),
('Airi', 'Satou', '2001-05-14', 5),
('Brielle', 'William', '2005-09-29', 5),
('Herrod', 'Chandler', '2005-10-01', 5),
('Rhona', 'Davidson', '2006-10-30', 5),
('Frost', 'Sonya', '2006-02-28', 5),
('Gaines', 'Jena', '2000-06-05', 5),
('Flynn', 'Quinn', '2002-06-12', 5);

INSERT INTO Residents 
(personne_id, medecin_id, medecin_consultation, resident_date_arrivee, resident_num_chambre, resident_date_visite_med) 
VALUES 
(14, NULL, 6, GETDATE(), 101, GETDATE()),
(15, 7	 , 6, GETDATE(), 102, GETDATE()),
(16, NULL, 6, GETDATE(), 103, GETDATE()),
(17, 7	 , 6, GETDATE(), 104, GETDATE()),
(18, NULL, 6, GETDATE(), 105, GETDATE()),
(19, NULL, 6, GETDATE(), 201, GETDATE()),
(20, NULL, 6, GETDATE(), 202, GETDATE()),
(21, NULL, 6, GETDATE(), 203, GETDATE()),
(22, NULL, 6, GETDATE(), 205, GETDATE()),
(23, NULL, 6, GETDATE(), 206, GETDATE()),
(24,	8, 6, GETDATE(), 207, GETDATE());

INSERT INTO Etats 
(etat_intitule) 
VALUES
('Ouvert'),
('Termin�'),
('Annul�');

SELECT * FROM Roles;
SELECT * FROM Personnes;
SELECT * FROM etats;


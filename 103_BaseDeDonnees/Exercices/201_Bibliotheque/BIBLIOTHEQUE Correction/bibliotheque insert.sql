use db201_bibliotheque;

/* DML Data Modeling Language
	INSERT : insérer des données dans une table
	UPDATE : modifier les données existantes
	DELETE : supprimer des données
	TRUNCATE vider une table et reinitialiser les compteurs ( auto increment)
*/

-- truncate table auteurs;
-- truncate table editeurs;

delete from editeurs;

dbcc checkident('editeurs', reseed, 0);

insert into editeurs
values
('toto')
,('tata')
,('titi')
;

insert into auteurs
(auteur_prenom, auteur_nom)
values
('David', 'CRAVO')
,('john', 'doe')
,('jane', 'rambo')
;

-- insert into auteurs values ('CRAVO', 'David');

update auteurs set auteur_nom = 'EtAutreChose' where auteur_id = 1;
update auteurs set auteur_nom = 'Nouveau' where auteur_id <> 1;

select * from editeurs;
select * from auteurs;
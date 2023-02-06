use db204_clubvideo;

delete from nominatifs;
dbcc checkident ('nominatifs', reseed, 0);

insert into nominatifs
(nominatif_nom, nominatif_prenom)
values
('Picard', 'Jeannine')
,('Baudry', 'Alfred')
,('Lopez', 'Tristan')
,('Valentin', 'Alexandre')
,('Roy', 'Nicolas')
,('Olivier', 'Aurore')
,('Guillet', 'Carolina')
,('Mercier', 'André')
,('Peron', 'Louis')
,('Le Clerc', 'Constance')
,('Dijoux', 'Zoé')
,('Bouvier', 'Brigitte')
,('Girard', 'Elise')
,('André','Benoit')
,('Diallo', 'Sébastien')
,('Lacombe', 'Françoise')
,('Michaud', 'Camille')
,('Gillet', 'Suzanne')
,('Delorme', 'Alphonse')
,('Herbert', 'Philippe')
;

delete from realisateurs;
dbcc checkident('realisateur', reseed, 0);

insert into realisateurs
(nominatif_id)
values
(6)
,(7)
,(8)
,(9)
,(10)
;

delete from acteurs;
dbcc checkident('acteurs', reseed, 0);

insert into acteurs
(nominatif_id)
values
(1)
,(2)
,(3)
,(4)
,(5)
;

delete from adresses;
dbcc checkident('adresses', reseed, 0);

insert into adresses
(adresse_numero, adresse_intitule_voie, adresse_complement_remise, adresse_complement_distribution, adresse_code_postal, adresse_localite, adresse_pays)
values
(822 ,'rue', 'Klocko Branch', 'Apt. 208',  null, '76996', 'Monroe', 'FR')
,(11, 'boulevard', 'Albin Durand', null, null, '71100', 'chalon-sur-saône', 'FR')
,(8, 'avenue', 'Maréchal Juin', null, null, '06700', 'saint-laurent_du-var', 'FR')
;
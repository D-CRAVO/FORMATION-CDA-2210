use db_commandes;

select * from client;

-- SELECT FROM client WHERE SUBSTRING([password], 1, 60 = HASHBYTES('SHA1', 'test11')


-- SELECT HASHBYTES('SHA1', 'test11');

-- 2
-- Obtenir la liste de tous les produits qui sont présent sur plusieurs commandes.

select 
	nom
	,COUNT(commande_id) as nb_commandes
from commande_ligne
group by 
	nom
having count(commande_id) > 1
order by 
	nb_commandes asc

-- 3
-- Obtenir la liste de tous les produits qui sont présent sur plusieurs commandes et y ajouter une colonne qui liste les 
-- identifiants des commandes associées.

select 
	cl1.nom
	,cl1.commande_id
	,COUNT(cl2.nom) as nb_commandes
from commande_ligne as cl1
	inner join commande_ligne as cl2 on cl2.nom = cl1.nom
group by 
	cl1.nom
	,cl1.commande_id
having count(cl2.nom) > 1
order by 
	nom asc

-- 4
-- Enregistrer le prix total à l’intérieur de chaque ligne des commandes, en fonction du prix unitaire et de la quantité.

update commande_ligne
set prix_total = quantite * prix_unitaire
	

-- 5
-- Obtenir le montant total pour chaque commande et y voir facilement la date associée à cette commande ainsi que le 
-- prénom et nom du client associé.

select 
	cli.nom
	,prenom
	,date_achat
	,sum(prix_total) as total_commande
from commande_ligne as cl
	inner join commande as co on cl.commande_id = co.id
	inner join client as cli on co.client_id = cli.id
group by 
	commande_id
	,co.id
	,client_id
	,cli.nom
	,prenom
	,date_achat
order by
	cli.nom

-- 6
-- (Difficulté très haute) Enregistrer le montant total de chaque commande dans le champ intitulé “cache_prix_total”.

select 
	commande_id
	,cache_prix_total
	,prix_total
	,replace (cache_prix_total, cache_prix_total, (select commande_id, sum(prix_total) from commande_ligne group by commande_id))
from commande as co
	inner join commande_ligne as cl on cl.commande_id = co.id

-- 7
-- Obtenir le montant global de toutes les commandes, pour chaque mois.

select 
	month (date_achat)
	,sum(cache_prix_total)
from commande
group by 
	month(date_achat)

-- 8
-- Obtenir la liste des 10 clients qui ont effectué le plus grand montant de commandes, et obtenir ce montant total pour 
-- chaque client.

select top 10
	client_id
	,count(id) as nb_commandes
	,sum(cache_prix_total)
from commande
group by
	client_id
order by 
	nb_commandes desc

-- 9
-- Obtenir le montant total des commandes pour chaque date.



select * from commande_ligne

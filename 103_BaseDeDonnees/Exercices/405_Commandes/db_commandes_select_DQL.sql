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
	nb_commandes desc

-- contrôle

select
	nom
from commande_ligne
where nom = 'Produit 6D'

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
	nb_commandes desc

select 
	nom
	--,COUNT(nom) as nb_commandes
	,STRING_AGG(commande_id, ' , ') 
from commande_ligne
group by 
	nom
	
having count(nom) > 1
/*order by 
	nb_commandes desc*/

-- contrôle

select
	nom
	,commande_id
from commande_ligne
where nom = 'Produit 6D'

-- 4
-- Enregistrer le prix total à l’intérieur de chaque ligne des commandes, en fonction du prix unitaire et de la quantité.

update commande_ligne
set prix_total = quantite * prix_unitaire
	

-- 5
-- Obtenir le montant total pour chaque commande et y voir facilement la date associée à cette commande ainsi que le 
-- prénom et nom du client associé.

select 
	co.id
	,cli.nom
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

-- contrôle

select 
	commande_id
	,prix_total
	,date_achat
from commande_ligne as cl
	inner join commande as co on cl.commande_id = co.id
	inner join client as cli on co.client_id = cli.id
where commande_id = 22

-- résultat 308.64+695.24+611.55+292.6+20.56 = 1928.59

-- 6
-- (Difficulté très haute) Enregistrer le montant total de chaque commande dans le champ intitulé “cache_prix_total”.

update commande
set cache_prix_total = (SELECT  sum(prix_total) FROM commande_ligne WHERE commande_ligne.commande_id = commande.id) 



-- 7
-- Obtenir le montant global de toutes les commandes, pour chaque mois.

select 
	month (date_achat)
	,sum(cache_prix_total)
from commande
group by 
	month(date_achat)

-- sans cache_prix_total

select 
	month (date_achat)
	,sum(prix_total)
from commande as co
	inner join commande_ligne as cl on co.id = cl.commande_id
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

-- sans cache_prix_total

select top 10
	client_id
	,count(co.id) as nb_commandes
	,sum(prix_total)
from commande as co
	inner join commande_ligne as cl on co.id = cl.commande_id
group by
	client_id
order by 
	nb_commandes desc

-- contrôle

select 
	client_id
	,prix_total
from commande as co
	inner join commande_ligne as cl on co.id = cl.commande_id
where client_id = 4

-- résultat client 6 : 612.56+861.4+323.84+237.6+54.78+632.38+590.94 = 3313.5
-- résultat client 4 : 97+121.92+775.44+98.4+68.1+651.44 = 1812.3

select
	client_id
	,cache_prix_total
from commande
where client_id = 4

-- résultat client 97+995.76+719.54 = 1812.3

-- 9
-- Obtenir le montant total des commandes pour chaque date.

select 
	date_achat
	,sum(prix_total)
from commande as co
	inner join commande_ligne as cl on co.id = cl.commande_id
group by 
	date_achat

-- contrôle date 2019-01-01 34.96 + 148.71 + 324.96 = 508.63

select 
	date_achat
	,prix_total
from commande as co
	inner join commande_ligne as cl on co.id = cl.commande_id
where date_achat = '2019-01-01'


select * from commande_ligne

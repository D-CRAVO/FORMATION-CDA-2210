-- 2
-- Obtenir la liste de tous les produits qui sont pr�sent sur plusieurs commandes.
select
	nom
	,count(commande_id) as nb_commandes
from commande_ligne
group by
	nom
having count(commande_id) > 1

-- 3
-- Obtenir la liste de tous les produits qui sont pr�sent sur plusieurs commandes et y ajouter une colonne qui liste les 
-- identifiants des commandes associ�es.

select
	nom
	,string_agg(commande_id, ',') as commande_ids
	,count(commande_id) as nb_commandes
from commande_ligne
group by
	nom
having count(commande_id) > 1


-- 4
-- Enregistrer le prix total � l�int�rieur de chaque ligne des commandes, en fonction du prix unitaire et de la quantit�.

update commande_ligne
set prix_total = quantite * prix_unitaire

-- 5
-- Obtenir le montant total pour chaque commande et y voir facilement la date associ�e � cette commande ainsi que le 
-- pr�nom et nom du client associ�.

select
	cli.nom
	,prenom
	,date_achat
	,sum(prix_total) as Prix_commande
from commande_ligne as cl
	inner join commande as co on cl.commande_id = co.id
	inner join client as cli on co.client_id = cli.id
group by
	cli.nom
	,prenom
	,date_achat


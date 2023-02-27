use db_commandes;

select * from client;

-- SELECT FROM client WHERE SUBSTRING([password], 1, 60 = HASHBYTES('SHA1', 'test11')


-- SELECT HASHBYTES('SHA1', 'test11');

select 
	nom
	,COUNT(commande_id) as nb_commandes
from commande_ligne
group by 
	nom
having count(commande_id) > 1
order by 
	nb_commandes asc


select 
	nom
	,commande_id
	--,COUNT(commande_id) as nb_commandes
from commande_ligne
group by 
	nom
	,commande_id
having count(commande_id) > 1
order by 
	nb_commandes asc


select 
	cl1.nom
	,cl1.commande_id
	--,COUNT(cl1.commande_id) as nb_commandes
from commande_ligne as cl1
	--inner join commande_ligne as cl2 on cl2.id = cl1.id
group by 
	cl1.nom
	,cl1.commande_id
having count(cl1.commande_id) > 1
--order by 
	--nb_commandes asc
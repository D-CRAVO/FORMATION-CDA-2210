using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jeu1
{
    public class Ihm
    {
        private readonly IConsole _console;
        private readonly ILanceurDeDe _lanceurDeDe;
        private readonly IFournisseurMeteo _fournisseurMeteo;
        private readonly IFabriqueDeMonstres _fabriqueDeMonstres;

        public Ihm(IConsole console, ILanceurDeDe lanceurDeDe, IFournisseurMeteo fournisseurMeteo, IFabriqueDeMonstres fabriqueDeMonstres) 
        { 
            _console = console;
            _lanceurDeDe = lanceurDeDe;
            _fournisseurMeteo = fournisseurMeteo;
            _fabriqueDeMonstres = fabriqueDeMonstres;   
        }

        public void Demarre()
        {
            Jeu jeu = new Jeu(_fournisseurMeteo, _fabriqueDeMonstres);
            _console.EcrireLigne($"A l'attaque : points/vie {jeu.Heros.Points}/{jeu.Heros.PointDeVies}");
            while (!jeu.EstTermine())
            {
                var resultat = jeu.Tour(_lanceurDeDe.Lance(), _lanceurDeDe.Lance());
                switch (resultat)
                {
                    case Resultat.Gagne:
                        _console.Ecrire($"Monstre battu");
                        break;
                    case Resultat.Perdu:
                        _console.Ecrire($"Combat perdu");
                        break;
                    default:
                        throw new NotImplementedException();
                }
                _console.EcrireLigne($": points/vie {jeu.Heros.Points}/{jeu.Heros.PointDeVies}");
            }
            if (jeu.Heros.PointDeVies > 0)
            {
                _console.EcrireLigne("Le joueur est vainqueur !! Félicitations...");
            }
            else
            {
                _console.EcrireLigne("Après un courageusx combat, le joueur a malheureusement été vaincu...");
            }
        }
    }
}

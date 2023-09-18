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

        public Ihm(IConsole console, ILanceurDeDe lanceurDeDe) 
        { 
            _console = console;
            _lanceurDeDe = lanceurDeDe;
        }

        public void Demarre()
        {
            // De de = new De();
            // FauxDe de = new FauxDe();
            // var jeu = new Jeu();
            Jeu jeu = new Jeu(new FournisseurMeteo());
            // Console.WriteLine($"A l'attaque : points/vie {jeu.Heros.Points}/{jeu.Heros.PointDeVies}");
            _console.EcrireLigne($"A l'attaque : points/vie {jeu.Heros.Points}/{jeu.Heros.PointDeVies}");
            while (jeu.Heros.PointDeVies > 0)
            {
                // var resultat = jeu.Tour(de.Lance(), de.Lance());
                var resultat = jeu.Tour(_lanceurDeDe.Lance(), _lanceurDeDe.Lance());
                switch (resultat)
                {
                    case Resultat.Gagne:
                        // Console.WriteLine($"Monstre battu");
                        _console.Ecrire($"Monstre battu");
                        break;
                    case Resultat.Perdu:
                        // Console.WriteLine($"Combat perdu");
                        _console.Ecrire($"Combat perdu");
                        break;
                }
                _console.EcrireLigne($": points/vie {jeu.Heros.Points}/{jeu.Heros.PointDeVies}");
            }
        }
    }
}

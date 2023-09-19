using Jeu1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectJeu
{
    internal class FausseFabriqueDeMonstres : IFabriqueDeMonstres
    {
        private IMonstre[] _monstres;

        public FausseFabriqueDeMonstres()
        {
            _monstres = new IMonstre[] {new FauxMonstre(), new FauxMonstre(), new Monstre(), new Monstre() };
        }
        
        public IEnumerable<IMonstre> GetMonstres()
        {
            for(var i=0; i< _monstres.Length; i++)
            {
                yield return _monstres[i];
            }
            
        }
    }
}

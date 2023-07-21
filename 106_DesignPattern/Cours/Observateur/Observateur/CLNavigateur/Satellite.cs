﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLNavigateur
{
    public class Satellite : ISujet
    {
        private List<IObservateur> mesObservateurs;
        private int precision;
        private string position;

        public int Precision { get { return precision; } }
        public string Position { get { return position; } }

        public Satellite(int _precision, string _position)
        {
            mesObservateurs = new List<IObservateur>();
            precision = _precision;
            position = _position;
        }

        public void AjouterObservateur(IObservateur _observateur)
        {
            mesObservateurs.Add(_observateur);
        }

        public void SupprimerObservateur(IObservateur _observateur)
        {
            mesObservateurs.Remove(_observateur);
        }

        public void NotifierObservateur()
        {
            foreach (IObservateur o in mesObservateurs) 
            {
                o.Actualiser(this);
            }
        }
    }
}

using CLNavigateur;
using System.Resources;


Navigateur n = new Navigateur();
Satellite s = new Satellite(10, "essai");
s.AjouterObservateur(n);
s.NotifierObservateur();

using CLNavigateur;
using System.Resources;


Navigateur n = new Navigateur();
Satellite s = new Satellite(10, "41°24'12.2\"N 2°10'26.5\"E");
s.AjouterObservateur(n);
s.NotifierObservateur();

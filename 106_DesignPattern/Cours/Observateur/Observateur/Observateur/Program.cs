using CLNavigateur;
using System.Resources;

Satellite s = new Satellite(10, "41°24'12.2\"N 2°10'26.5\"E");

Navigateur n = new Navigateur();
s.AjouterObservateur(n);

s.SetPrecision(20);

s.SetPosition("43°26'12.2\"N 12°05'26.5\"E");

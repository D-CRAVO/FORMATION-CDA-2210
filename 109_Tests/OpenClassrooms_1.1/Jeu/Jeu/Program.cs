﻿using Jeu1;

// var ihm = new Ihm();
// var ihm = new Ihm(new ConsoleDeSortie(), new De());
var ihm = new Ihm(new ConsoleDeSortie(), new De(), new FournisseurMeteo(), new FabriqueDeMonstres());
ihm.Demarre();

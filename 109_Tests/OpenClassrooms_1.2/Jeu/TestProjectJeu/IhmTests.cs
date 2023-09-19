using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using Jeu1;

namespace TestProjectJeu
{
    [TestClass]
    public class IhmTests
    {
        [TestMethod]
        public void Ihm_AvecAucunJeuDeDonnees_LeJoueurGagne()
        {
            // Arrange
            var fausseConsole = new FausseConsole();
            var ihm = new Ihm(fausseConsole, new FauxDe());

            // Act
            ihm.Demarre();

            // Assert
            var resultat = fausseConsole.StringBuilder.ToString();
            resultat.Should().StartWith("A l'attaque : points/vie 0/15");
            resultat.Should().EndWith("Combat perdu: points/vie 9/0\r\n");
            //resultat.Should().HaveLength(560);
        }
    }
}

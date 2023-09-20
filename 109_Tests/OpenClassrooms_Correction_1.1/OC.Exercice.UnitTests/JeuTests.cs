using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace OC.Exercice.UnitTests
{
    [TestClass]
    public class JeuTests
    {
        private IFournisseurMeteo _fournisseurMeteo;
        private IFabriqueDeMonstres _fabriqueDeMonstres;
        private Jeu _jeu;

        [TestInitialize]
        public void InitTests()
        {
            // Arrange
            _fournisseurMeteo = Mock.Of<IFournisseurMeteo>();
            _fabriqueDeMonstres = Mock.Of<IFabriqueDeMonstres>();
            Mock.Get(_fabriqueDeMonstres).Setup(x => x.GetMonstres()).Returns(() => new IMonstre[] { new Monstre() });
            _jeu = new Jeu(_fournisseurMeteo, _fabriqueDeMonstres);
        }

        [TestMethod]
        [Description("Etant donné un tour de jeu, lorsque j'ai un lancer supérieur au second, alors le résultat est gagné avec un point sans perdre de points de vie")]
        public void Tour_AvecUnDeSuperieurAuSecond_RetourneGagneAvecUnPointEtSansPerdreDePointsDeVie()
        {
            // Arrange, voir InitTests()

            // Act
            var resultat = _jeu.Tour(6, 1);

            // Assert
            resultat.Should().Be(Resultat.Gagne);
            _jeu.Heros.Points.Should().Be(1);
            _jeu.Heros.PointDeVies.Should().Be(15);
        }

        [TestMethod]
        [Description("Etant donné un tour de jeu, lorsque j'ai un lancer égal au second, alors le résultat est gagné avec un point sans perdre de points de vie")]
        public void Tour_AvecUnDeEgalAuSecond_RetourneGagneAvecUnPointEtSansPerdreDePointsDeVie()
        {
            // Arrange, voir InitTests()

            // Act
            var resultat = _jeu.Tour(5, 5);

            // Assert
            resultat.Should().Be(Resultat.Gagne);
            _jeu.Heros.Points.Should().Be(1);
            _jeu.Heros.PointDeVies.Should().Be(15);
        }

        [TestMethod]
        [Description("Etant donné un tour de jeu, lorsque j'ai un lancer inférieur au second et du soleil, alors le résultat est perdu, sans points et en perdant des points de vie")]
        public void Tour_AvecUnDeInferieurAuSecond_RetournePerduSansPointEnPerdantDesPointsDeVie()
        {
            // Arrange, voir InitTests()

            // Act
            var resultat = _jeu.Tour(2, 4);

            // Assert
            resultat.Should().Be(Resultat.Perdu);
            _jeu.Heros.Points.Should().Be(0);
            _jeu.Heros.PointDeVies.Should().Be(13);
        }

        [TestMethod]
        [Description("Etant donné un tour de jeu, lorsque j'ai un lancer inférieur au second et de la pluie, alors le résultat est perdu, sans points et en classiquement des points de vie")]
        public void Tour_AvecUnDeInferieurAuSecond_EtDuVent_RetournePerduSansPointEnPerdantClassiquementDesPointsDeVie()
        {
            // Arrange, voir InitTests()
            Mock.Get(_fournisseurMeteo).Setup(m => m.QuelTempsFaitIl()).Returns(Meteo.Pluie);

            // Act
            var resultat = _jeu.Tour(2, 4);

            // Assert
            resultat.Should().Be(Resultat.Perdu);
            _jeu.Heros.Points.Should().Be(0);
            _jeu.Heros.PointDeVies.Should().Be(13);
        }

        [TestMethod]
        [Description("Etant donné un tour de jeu, lorsque j'ai un lancer inférieur au second et du vent, alors le résultat est perdu, sans points et en perdant deux fois plus de points de vie")]
        public void Tour_AvecUnDeInferieurAuSecond_EtDuVent_RetournePerduSansPointEnPerdantDeuxFoisPlusDePointsDeVie()
        {
            // Arrange, voir InitTests()
            Mock.Get(_fournisseurMeteo).Setup(m => m.QuelTempsFaitIl()).Returns(Meteo.Tempete);

            // Act
            var resultat = _jeu.Tour(2, 4);

            // Assert
            resultat.Should().Be(Resultat.Perdu);
            _jeu.Heros.Points.Should().Be(0);
            _jeu.Heros.PointDeVies.Should().Be(11);
        }
    }
}
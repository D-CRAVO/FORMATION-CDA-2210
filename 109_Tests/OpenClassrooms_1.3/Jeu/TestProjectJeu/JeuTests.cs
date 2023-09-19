using Jeu1;
using FluentAssertions;
using Moq;

namespace TestProjectJeu
{
    [TestClass]
    public class JeuTests
    {
        [TestMethod]
        [Description("Etant donn� un tour de jeu, lorsque j'ai un lancer sup�rieur au second, alors le r�sultat est gagn� avec un point sans perdre de points de vie")]
        public void Tour_AvecUnDeSuperieurAuSecond_RetourneGagneAvecUnPointEtSansPerdreDePointsDeVie()
        {
            // Arrange
            Jeu jeu = new Jeu(new FournisseurMeteo(),new FausseFabriqueDeMonstres());

            // Act
            var resultat = jeu.Tour(6, 1);

            // Assert
            resultat.Should().Be(Resultat.Gagne, "Il faut absolument que le r�sultat soit gagn�");
            jeu.Heros.Points.Should().Be(1, "Il faut absolument que le Hero marque un point");
            jeu.Heros.PointDeVies.Should().Be(15, "Il faut absolument que le Hero ne perde aucun point de vie");
        }

        [TestMethod]
        [Description("Etant donn� un tour de jeu, lorsque j'ai un lancer �gal au second, alors le r�sultat est gagn� avec un point sans perdre de points de vie")]
        public void Tour_AvecUnDeEgalAuSecond_retourneGagneAvecUnPointEtSansPerdreDePointsDeVie()
        {
            // Arange
            Jeu jeu = new Jeu(new FournisseurMeteo(), new FausseFabriqueDeMonstres());

            // Act
            var resultat = jeu.Tour(5, 5);

            // Assert
            resultat.Should().Be(Resultat.Gagne, "Il faut absolument que le r�sultat soit gagn�");
            jeu.Heros.Points.Should().Be(1, "Il faut absolument que le h�ro marque un point");
            jeu.Heros.PointDeVies.Should().Be(15, "Il faut absolument que le h�ro ne perde aucun point de vie");
        }

        [TestMethod]
        [Description("Etant donn� un tour de jeu, lorsque j'ai un lancer inf�rieur au second, alors le r�sultat est perdu avec aucun point et en perdant deux points de vie")]
        public void Tour_AvecUnDeInferieurAuSecond_retournePerduAvecAucunPointEtEnperdantDeuxPointsDeVie()
        {
            // Arrange
            var fournisseurMeteo = Mock.Of<IFournisseurMeteo>();
            Mock.Get(fournisseurMeteo).Setup(m => m.QuelTempsFaitIl()).Returns(Meteo.Pluie);
            Jeu jeu = new Jeu(fournisseurMeteo, new FausseFabriqueDeMonstres());

            // Act
            var resultat = jeu.Tour(2, 4);

            // Assert
            resultat.Should().Be(Resultat.Perdu, "Il faut absolument que le r�sultat soit perdu");
            jeu.Heros.Points.Should().Be(0, "Il faut absolument que le h�ro ne marque aucun point");
            jeu.Heros.PointDeVies.Should().Be(13, "Il faut absolument que le h�ro perde deux points de vie");
        }
        [TestMethod]
        [Description("Etant donn� un tour de jeu, lorsque j'ai un lancer inf�rieur au second, alors le r�sultat est perdu avec aucun point et en perdant deux points de vie")]
        public void Tour_AvecUnDeInferieurAuSecond_retournePerduAvecAucunPointEtEnperdantQuatrePointsDeVie()
        {
            // Arrange
            var fournisseurMeteo = Mock.Of<IFournisseurMeteo>();
            Mock.Get(fournisseurMeteo).Setup(m => m.QuelTempsFaitIl()).Returns(Meteo.Tempete);
            Jeu jeu = new Jeu(fournisseurMeteo, new FausseFabriqueDeMonstres());

            // Act
            var resultat = jeu.Tour(2, 4);

            // Assert
            resultat.Should().Be(Resultat.Perdu, "Il faut absolument que le r�sultat soit perdu");
            jeu.Heros.Points.Should().Be(0, "Il faut absolument que le h�ro ne marque aucun point");
            jeu.Heros.PointDeVies.Should().Be(11, "Il faut absolument que le h�ro perde deux points de vie");
        }

        
    }
}
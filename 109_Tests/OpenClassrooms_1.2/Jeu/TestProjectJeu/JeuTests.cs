using Jeu1;
using FluentAssertions;
using Moq;

namespace TestProjectJeu
{
    [TestClass]
    public class JeuTests
    {
        [TestMethod]
        [Description("Etant donné un tour de jeu, lorsque j'ai un lancer supérieur au second, alors le résultat est gagné avec un point sans perdre de points de vie")]
        public void Tour_AvecUnDeSuperieurAuSecond_RetourneGagneAvecUnPointEtSansPerdreDePointsDeVie()
        {
            // Arrange
            /* Jeu jeu = new Jeu(); */
            var fournisseurMeteo = Mock.Of<IFournisseurMeteo>();
            Jeu jeu = new Jeu(fournisseurMeteo);

            // Act
            var resultat = jeu.Tour(6, 1);

            // Assert
            /*
            if (resultat != Resultat.Gagne)
                Assert.Fail();
            if (jeu.Heros.Points != 1)
                Assert.Fail();
            if (jeu.Heros.PointDeVies != 15)
                Assert.Fail();
            */
            /*
            Assert.AreEqual(Resultat.Gagne, resultat, "Il faut absolument que le résultat soit gagné");
            Assert.AreEqual(1, jeu.Heros.Points, "Il faut absolument que le Hero marque un point");
            Assert.AreEqual(15, jeu.Heros.PointDeVies, "Il faut absolument que le Hero ne perde aucun point de vie");
            */
            resultat.Should().Be(Resultat.Gagne, "Il faut absolument que le résultat soit gagné");
            jeu.Heros.Points.Should().Be(1, "Il faut absolument que le Hero marque un point");
            jeu.Heros.PointDeVies.Should().Be(15, "Il faut absolument que le Hero ne perde aucun point de vie");
        }

        [TestMethod]
        [Description("Etant donné un tour de jeu, lorsque j'ai un lancer égal au second, alors le résultat est gagné avec un point sans perdre de points de vie")]
        public void Tour_AvecUnDeEgalAuSecond_retourneGagneAvecUnPointEtSansPerdreDePointsDeVie()
        {
            // Arange
            /* Jeu jeu = new Jeu(); */
            var fournisseurMeteo = Mock.Of<IFournisseurMeteo>();
            Jeu jeu = new Jeu(fournisseurMeteo);

            // Act
            var resultat = jeu.Tour(5, 5);

            // Assert
            /*
            if (resultat != Resultat.Gagne)
                Assert.Fail();
            if (jeu.Heros.Points != 1)
                Assert.Fail();
            if (jeu.Heros.PointDeVies != 15)
                Assert.Fail();
            */
            /*
            Assert.AreEqual(resultat, Resultat.Gagne, "Il faut absolument que le résultat soit gagné");
            Assert.AreEqual(1, jeu.Heros.Points, "Il faut absolument que le héro marque un point");
            Assert.AreEqual(15, jeu.Heros.PointDeVies, "Il faut absolument que le héro ne perde aucun point de vie");
            */
            resultat.Should().Be(Resultat.Gagne, "Il faut absolument que le résultat soit gagné");
            jeu.Heros.Points.Should().Be(1, "Il faut absolument que le héro marque un point");
            jeu.Heros.PointDeVies.Should().Be(15, "Il faut absolument que le héro ne perde aucun point de vie");
        }

        [TestMethod]
        [Description("Etant donné un tour de jeu, lorsque j'ai un lancer inférieur au second, alors le résultat est perdu avec aucun point et en perdant deux points de vie")]
        public void Tour_AvecUnDeInferieurAuSecond_retournePerduAvecAucunPointEtEnperdantDeuxPointsDeVie()
        {
            // Arrange
            /* Jeu jeu = new Jeu(); */
            var fournisseurMeteo = Mock.Of<IFournisseurMeteo>();
            Mock.Get(fournisseurMeteo).Setup(m => m.QuelTempsFaitIl()).Returns(Meteo.Pluie);
            Jeu jeu = new Jeu(fournisseurMeteo);

            // Act
            var resultat = jeu.Tour(2, 4);

            // Assert
            /*
            if (resultat != Resultat.Perdu)
                Assert.Fail();
            if (jeu.Heros.Points != 0)
                Assert.Fail();
            if (jeu.Heros.PointDeVies != 13)
                Assert.Fail();
            */
            /*
            Assert.AreEqual(resultat, Resultat.Perdu, "Il faut absolument que le résultat soit perdu");
            Assert.AreEqual(0, jeu.Heros.Points, "Il faut absolument que le héro ne marque aucun point");
            Assert.AreEqual(13, jeu.Heros.PointDeVies, "Il faut absolument que le héro perde deux points de vie");
            */
            resultat.Should().Be(Resultat.Perdu, "Il faut absolument que le résultat soit perdu");
            jeu.Heros.Points.Should().Be(0, "Il faut absolument que le héro ne marque aucun point");
            jeu.Heros.PointDeVies.Should().Be(13, "Il faut absolument que le héro perde deux points de vie");
        }
        [TestMethod]
        [Description("Etant donné un tour de jeu, lorsque j'ai un lancer inférieur au second, alors le résultat est perdu avec aucun point et en perdant deux points de vie")]
        public void Tour_AvecUnDeInferieurAuSecond_retournePerduAvecAucunPointEtEnperdantQuatrePointsDeVie()
        {
            // Arrange
            /* Jeu jeu = new Jeu(); */
            var fournisseurMeteo = Mock.Of<IFournisseurMeteo>();
            Mock.Get(fournisseurMeteo).Setup(m => m.QuelTempsFaitIl()).Returns(Meteo.Tempete);
            Jeu jeu = new Jeu(fournisseurMeteo);

            // Act
            var resultat = jeu.Tour(2, 4);

            // Assert
            /*
            if (resultat != Resultat.Perdu)
                Assert.Fail();
            if (jeu.Heros.Points != 0)
                Assert.Fail();
            if (jeu.Heros.PointDeVies != 11)
                Assert.Fail();
            */
            /*
            Assert.AreEqual(resultat, Resultat.Perdu, "Il faut absolument que le résultat soit perdu");
            Assert.AreEqual(0, jeu.Heros.Points, "Il faut absolument que le héro ne marque aucun point");
            Assert.AreEqual(11, jeu.Heros.PointDeVies, "Il faut absolument que le héro perde deux points de vie");
            */
            resultat.Should().Be(Resultat.Perdu, "Il faut absolument que le résultat soit perdu");
            jeu.Heros.Points.Should().Be(0, "Il faut absolument que le héro ne marque aucun point");
            jeu.Heros.PointDeVies.Should().Be(11, "Il faut absolument que le héro perde deux points de vie");
        }

        // Autres exemples

        /*
        Assert.AreEqual(1, 1); // égalité entre entier
        Assert.AreEqual(3.14, 6.28  /2 ); // égalité entre double
        Assert.AreEqual("une chaine", "une " + "chaine"); // égalité entre chaînes
        Assert.AreNotEqual(1, 2); // inégalité
        Assert.IsFalse(1 == 2); // booléen vaut faux
        Assert.IsTrue(1 <= 2); // booléen vaut vrai
        Jeu jeu1 = new Jeu();
        Jeu jeu2 = jeu1;
        Assert.AreSame(jeu1, jeu2); // les références de l'objet sont identiques
        jeu2 = new Jeu();
        Assert.AreNotSame(jeu1, jeu2); // les références ne sont pas identiques
        Assert.IsInstanceOfType(jeu1, typeof(Jeu)); // comparaison de type
        Assert.IsNotInstanceOfType(jeu1, typeof(De)); // différence de type
        Assert.IsNotNull(jeu); // différence à null
        jeu1 = null;
        Assert.IsNull(jeu1); // comparaison à null
        */

        /*
        var valeur = -1;
        valeur.Should().BeNegative();

        Math.PI.Should().BeApproximately(3.14, 0.1);
        valeur.Should().BeInRange(-5, 5);
        "chaine".Should().Contain("i").And.Contain("e").And.NotStartWith("p");
        jeu.Should().BeOfType<Jeu>().Which.Heros.PointDeVies.Should().Be(15);

        string email = "nico@openclassrooms.com";
        email.Should().Match("*@*.com");

        DateTime.Now.Should().BeAfter(new DateTime(2000, 1, 1));
        var dateDeLivraison = DateTime.Now.AddDays(3);
        DateTime.Now.Should().BeAtLeast(2.Days()).Before(dateDeLivraison);
        */
    }
}
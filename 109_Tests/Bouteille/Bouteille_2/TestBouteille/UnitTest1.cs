using CLBouteille;
using CLBouteille.ExceptionsBouteille;

namespace TestBouteille
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [ExpectedException(typeof(ContenanceValeurNegativeOuZeroException))]
        public void Given_contenanceValeurNegative_When_newBouteille_Then_ContenanceValeurNegativeOuZeroException()
        {
            //Arrange
            Bouteille bouteille = new Bouteille(-1,0,true);
            //Act
            //Assert
        }

        [TestMethod]
        [ExpectedException(typeof(ContenanceValeurNegativeOuZeroException))]
        public void Given_contenanceZero_When_newBouteille_Then_ContenanceValeurNegativeOuZeroException()
        {
            //Arrange
            Bouteille bouteille = new Bouteille(0,0,false);
            //Act
            //Assert
        }

        [TestMethod]
        [ExpectedException(typeof(ContenuValeurNegativeException))]
        public void Given_contenuNegatif_When_newBouteille_Then_ContenuValeurNegativeException()
        {
            //Arrange
            Bouteille bouteille = new Bouteille(1,-2,true);
            //Act
            //Assert
        }

        [TestMethod]
        [ExpectedException(typeof(ContenuSuperieurContenanceException))]
        public void Given_contenuSuperieurContenant_When_newBouteille_Then_ContenuSuperieurContenanceException()
        {
            // Arrange
            Bouteille b = new Bouteille(1, 2, false);
            // Act
            // Assert

        }

        [TestMethod]
        public void Given_bouteilleFermee_When_ouvrir_Then_ReturnTrueAndBouteilleOuverte()
        {
            // Arrange
            Bouteille b = new Bouteille(1, 1, false);
            // Act
            bool retour = b.Ouvrir();
            // Assert
            Assert.IsTrue(retour);
            Assert.IsTrue(b.Ouvert);
        }

        [TestMethod]
        public void Given_bouteilleOuverte_When_ouvrir_Then_ReturnFalse()
        {
            //Arrange
            Bouteille b = new Bouteille(1,1, true);
            //Act
            bool retour = b.Ouvrir();
            //Assert
            Assert.IsFalse(retour);
        }

        [TestMethod]
        public void Given_bouteilleOuverte_When_fermer_Then_returnsTrue()
        {
            // Arrange
            Bouteille b = new Bouteille(1, 1, true);
            // Act
            bool retour = b.Fermer();
            // Assert
            Assert.IsTrue(retour);
        }

        [TestMethod]
        public void Given_bouteilleFermee_When_fermer_Then_returnsFalse()
        {
            // Arrange
            Bouteille b = new Bouteille(1, 1, false);
            // Act
            bool retour = b.Fermer();
            // Assert
            Assert.IsFalse(retour);
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentValeurNegativeException))]
        public void Given_QuantiteNegative_When_remplir_Then_ArgumentValeurNegativeException()
        {
            // Arrange
            Bouteille b = new Bouteille(1,1,true);
            // Act
            b.Remplir(-1);
            // Assert
            
        }

        [TestMethod]
        [ExpectedException (typeof(ArgumentValeurNegativeException))]
        public void Given_quantiteNegative_When_vider_Then_ExceptionValeurNegative()
        {
            //Arrange
            Bouteille b = new Bouteille (1,1,true);
            //Act
            b.Vider(-1);
            //Assert
        }
    }
}
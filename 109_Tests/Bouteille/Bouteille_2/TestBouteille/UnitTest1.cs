using CLBouteille;
using CLBouteille.ExceptionsBouteille;

namespace TestBouteille
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [ExpectedException(typeof(ExceptionValeurContenuIncorrecte))]
        public void Given_contenuBouteilleIncorrecte_When_newBouteille_Then_ExceptionValeurContenuIncorrecte()
        {
            // Arrange
            Bouteille b = new Bouteille(1, 2, false);
            // Act
            // Assert
        }

        [TestMethod]
        [ExpectedException(typeof (ExceptionValeurContenanceIncorrecte))]
        public void Given_contenanceBouteilleIncorrecte_When_newBouteille_Then_ExceptionValeurContenanceIncorrecte()
        {
            // Arrange
            Bouteille b = new Bouteille(-1, 0, false);
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
        [ExpectedException(typeof(ExceptionQuantiteAjouterTropImportante))]
        public void Given_QuantiteTropImortante_When_remplir_Then_ExceptionQuantiteAjouterTropImportante()
        {
            //Arrange
            Bouteille b = new Bouteille(1, 1, true);
            //Act
            b.Remplir(1);
            //Assert
        }
    }
}
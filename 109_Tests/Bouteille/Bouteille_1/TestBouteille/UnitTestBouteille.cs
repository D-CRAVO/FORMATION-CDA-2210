using Bouteille_1;

namespace TestBouteille
{
    [TestClass]
    public class UnitTestBouteille
    {
        [TestMethod]
        public void Given_bouteilleOuverte_When_ouvrir_Then_ReturnTrueAndBouteilleOuvert()
        {
            // Arrange
            Bouteille b = new Bouteille(1, 1, false);
            // Act
            bool retour = b.Ouvrir();
            // Assert
            Assert.IsTrue(retour);
            Assert.IsTrue(b.Ouvert);
        }
    }
}
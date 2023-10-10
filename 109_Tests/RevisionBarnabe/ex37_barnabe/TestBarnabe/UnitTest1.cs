using exercice_3_7_barnabe;

namespace TestBarnabe
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Given_SommeStrictementNegative_When_NbMagasinRealisePArBarnabe_Then_ArgumentOutOfRangeException()
        {
            //Arrange
            float somme = -10;
            int nbMagasins;
            CalculNbMagasins calculNbMagasins = new CalculNbMagasins();

            //Act
            nbMagasins = calculNbMagasins.NbMagasinRealisePArBarnabe(somme);

            //Assert
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Given_SommeStrictementInferieurAUn_When_NbMagasinRealisePArBarnabe_Then_ArgumentOutOfRangeException()
        {
            //Arrange
            float somme = 0.5f;
            int nbMagasins;
            CalculNbMagasins calculNbMagasins= new CalculNbMagasins();

            //Act
            nbMagasins = calculNbMagasins.NbMagasinRealisePArBarnabe(somme);

            //Assert
        }

        [TestMethod]
        public void Given_SommeEgaleADeux_When_NbMagasinRealisePArBarnabe_Then_nbMagasinsEgalAUn()
        {
            //Arrange
            float somme = 2;
            int nbMagasins;
            CalculNbMagasins calculNbMagasins = new CalculNbMagasins();

            //Act
            nbMagasins = calculNbMagasins.NbMagasinRealisePArBarnabe(somme);

            //Assert
            Assert.AreEqual(1, nbMagasins);
        }

        [TestMethod]
        public void Given_SommeEgaleADix_When_NbMagasinRealisePArBarnabe_Then_nbMagasinsEgalAUn()
        {
            //Arrange
            float somme = 10;
            int nbMagasins;
            CalculNbMagasins calculNbMagasins = new CalculNbMagasins();

            //Act
            nbMagasins = calculNbMagasins.NbMagasinRealisePArBarnabe(somme);

            //Assert
            Assert.AreEqual(3, nbMagasins);
        }
    }
}
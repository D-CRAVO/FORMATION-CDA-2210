using LibraryCompte;

namespace TestCompte
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Constructeur_DecouvertNegatif_InstanciationOK()
        {
            Compte monCompteDeTest = new Compte(1234, "Bertrant", 500, -1000);
            Assert.IsNotNull(monCompteDeTest);
        }

        [TestMethod]
        public void Constructeur_DecouvertAZero_InstanciationOk()
        {
            Compte monCompteDeTest = new Compte(1234, "Bertrant", 500, 0);
            Assert.IsNotNull(monCompteDeTest);
        }

        [TestMethod]
        public void Constructeur_DecouvertPositif_ExceptionInstanciationNull()
        {
            Compte? monCompteDeTest = null;
            try
            {
                monCompteDeTest = new Compte(1234, "Bertrant", 500, 500);
                Assert.Fail("Echec du test: Il doit etre impossible d'instancier un compte avec un découvert autorisé positif, une Exception CreateAccountException doit être soulevé");
            }
            catch (Exception e)
            {
                Assert.IsNull(monCompteDeTest, "Probleme d'etat lors de l'instanciation d'un compte bancaire avec un decouvert autorisé positif, résultat attendu = refus d'instanciation + exception");
            }
        }

    }
}
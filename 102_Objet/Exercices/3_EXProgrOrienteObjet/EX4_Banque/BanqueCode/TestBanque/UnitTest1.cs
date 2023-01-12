using LibraryBanque;

namespace TestBanque
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Banque ca = new Banque("Crédit Agricole", "Mulhouse");
            ca.AjouteCompte(1245, "Robert", 2000, -300);
            ca.AjouteCompte(2568, "Denis", 1000, -300);

            Assert.IsTrue(ca.Transferer(1245, 2568, 1000), "Test"); // true

        }
    }
}
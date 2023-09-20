using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace OC.Exercice.UnitTests
{
    [TestClass]
    public class IhmTests
    {
        private FausseConsole _fausseConsole;
        private ILanceurDeDe _fauxDe;
        private IFournisseurMeteo _fournisseurMeteo;
        private IFabriqueDeMonstres _fabriqueDeMonstres;
        private Ihm _ihm;

        [TestInitialize]
        public void InitTests()
        {
            // Arrange
            _fausseConsole = new FausseConsole();
            _fauxDe = Mock.Of<ILanceurDeDe>();
            var sequence = Mock.Get(_fauxDe).SetupSequence(de => de.Lance());
            foreach (var lancer in new[] { 4, 5, 1, 1, 4, 3, 5, 6, 6, 6, 1, 2, 4, 2, 3, 2, 6, 4, 5, 1, 1, 4, 3, 5, 6, 6, 6, 1, 2, 4, 2, 3, 2, 6 })
            {
                sequence.Returns(lancer);
            }
            _fournisseurMeteo = Mock.Of<IFournisseurMeteo>();
            _fabriqueDeMonstres = Mock.Of<IFabriqueDeMonstres>();
            _ihm = new Ihm(_fausseConsole, _fauxDe, _fournisseurMeteo, _fabriqueDeMonstres);
        }

        [TestMethod]
        public void Ihm_AvecUnJeuDeDonnees_LeJoueurGagne()
        {
            // Arrange, voir InitTests()
            Mock.Get(_fabriqueDeMonstres).Setup(x => x.GetMonstres()).Returns(() => new IMonstre[] { new Monstre() });

            // act
            _ihm.Demarre();

            // assert
            var resultat = _fausseConsole.StringBuilder.ToString();
            resultat.Should().StartWith("A l'attaque : points/vie 0/15");
            resultat.Should().EndWith("Le joueur est vainqueur !! Félicitations...\r\n");
            resultat.Should().HaveLength(139);
        }

        [TestMethod]
        public void Ihm_AvecUnJeuDeDonnees_LeJoueurPerds()
        {
            // Arrange, voir InitTests()
            Mock.Get(_fabriqueDeMonstres).Setup(x => x.GetMonstres()).Returns(() => new IMonstre[]
                { new Monstre(), new MonstreCostaud(5), new MonstreCostaud(4), new Monstre(), new Monstre(), new MonstreCostaud(7)});

            // act
            _ihm.Demarre();

            // assert
            var resultat = _fausseConsole.StringBuilder.ToString();
            resultat.Should().Be(@"A l'attaque : points/vie 0/15
Combat perdu: points/vie 0/14
Monstre battu: points/vie 1/14
Monstre battu: points/vie 2/14
Combat perdu: points/vie 2/13
Monstre battu: points/vie 3/13
Combat perdu: points/vie 3/12
Monstre battu: points/vie 4/12
Monstre battu: points/vie 5/12
Monstre battu: points/vie 6/12
Monstre battu: points/vie 7/12
Combat perdu: points/vie 7/9
Combat perdu: points/vie 7/7
Monstre battu: points/vie 8/7
Monstre battu: points/vie 9/7
Combat perdu: points/vie 9/5
Combat perdu: points/vie 9/4
Combat perdu: points/vie 9/0
Après un courageux combat, le joueur a malheureusement été vaincu ...
");
            resultat.Should().HaveLength(631);
        }
    }
}
using CLFizzBuzz;

namespace TestFizzBuzz
{
    [TestClass]
    public class UnitTestFizzBuzz
    {
        [TestMethod]
        public void Given_nombre_When_FizzBuzzPourUnNombre_Then_returnNombreString()
        {
            // Arrange
            FizzBuzz fizzBuzz = new FizzBuzz();
            string retour;
            int nombre = 1;

            // Act
            retour = fizzBuzz.FizzBuzzPourUnNombre(nombre);

            // Assert
            Assert.AreEqual("1", retour);
        }

        [TestMethod]
        public void Given_nombre3_When_FizzBuzzPourUnNombre_Then_ReturnFizzString()
        {
            // Arrange
            FizzBuzz fizzBuzz = new FizzBuzz();
            string retour;
            int nombre = 3;

            // Act
            retour = fizzBuzz.FizzBuzzPourUnNombre(nombre);

            // Assert
            Assert.AreEqual("Fizz", retour);
        }

        [TestMethod]
        public void Given_nombre5_When_FizzBuzzPourUnNombre_Then_ReturnBuzzString()
        {
            // Arrange
            FizzBuzz fizzBuzz = new FizzBuzz();
            string retour;
            int nombre = 5;

            // Act
            retour = fizzBuzz.FizzBuzzPourUnNombre(nombre);

            // Assert
            Assert.AreEqual("Buzz", retour);
        }

        [TestMethod]
        public void Given_nombre15_When_FizzBuzzPourUnNombre_ThenReturnFizzBuzzString()
        {
            // Arrange
            FizzBuzz fizzBuzz = new FizzBuzz();
            string retour;
            int nombre = 15;

            // Act
            retour = fizzBuzz.FizzBuzzPourUnNombre(nombre);

            // Assert
            Assert.AreEqual("FizzBuzz", retour);
        }
    }
}
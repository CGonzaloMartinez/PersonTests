using NUnit.Framework;

using UnitTestAndDebug;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CorrectNameVerifyer() // Cambiá el nombre para indicar qué estás probando
        {
            Person testingPerson = new Person("name","5.342.187-9");
            string expectedName = "name";
            string actualName = testingPerson.Name;
            Assert.AreEqual(expectedName, testingPerson);
        }

          public void IncorrectNameVerifyer() // Cambiá el nombre para indicar qué estás probando
        {
            Person testingPerson = new Person("","5.342.187-9");
            string expectedName = "";
            string actualName = testingPerson.Name;
            Assert.AreEqual(expectedName, testingPerson);
        }

         public void CorrectIdVerifyer() // Cambiá el nombre para indicar qué estás probando
        {
            Person testingPerson = new Person("","5.342.187-9");
            string expectedName = "5.342.187-9";
            string actualName = testingPerson.Name;
            Assert.AreEqual(expectedName, testingPerson);
        }

         public void IncorrectIdVerifyer() // Cambiá el nombre para indicar qué estás probando
        {
            Person testingPerson = new Person("","5.342.187-8");
            string expectedName = "";
            string actualName = testingPerson.Name;
            Assert.AreEqual(expectedName, testingPerson);
        }

    }
}
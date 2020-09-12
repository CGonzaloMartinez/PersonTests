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
        public void CorrectNameVerifyer() 
        {
            Person testingPerson = new Person("name","5.342.187-9");
            string expectedName = "name";
            string actualName = testingPerson.Name;
            Assert.AreEqual(expectedName, actualName);
        }

        [Test]
          public void IncorrectNameVerifyer() 
        {
            Person testingPerson = new Person("","5.342.187-9");
            string expectedName = null;
            string actualName = testingPerson.Name;
            Assert.AreEqual(expectedName, actualName);
        }


        [Test]
         public void CorrectIdVerifyer() 
        {
            Person testingPerson = new Person("Gonzalo","5.342.187-9");
            string expectedId = "5.342.187-9";
            string actualId = testingPerson.ID;
            Assert.AreEqual(expectedId, actualId);
        }

        [Test]
         public void IncorrectIdVerifyer() 
        {
            Person testingPerson = new Person("","5.342.187-8");
            string expectedId = null;
            string actualId = testingPerson.ID;
            Assert.AreEqual(expectedId, actualId);
        }

        [Test]
        public void ChangeToCorrectNameVerifyer() 
        {
            Person testingPerson = new Person("name","5.342.187-9");
            testingPerson.Name =  "newCorrectName";
            string expectedName = "newCorrectName";
            string actualName = testingPerson.Name;
            Assert.AreEqual(expectedName, actualName);
        }

        [Test]
          public void ChangeToIncorrectNameVerifyer() 
        {
            Person testingPerson = new Person("name","5.342.187-9");
            testingPerson.Name =  "";
            string expectedName = "name";
            string actualName = testingPerson.Name;
            Assert.AreEqual(expectedName, actualName);
        }

        [Test]
          public void ChangeToCorrectIdVerifyer() 
        {
            Person testingPerson = new Person("name","6.000.000-8");
            testingPerson.ID =  "5.900.000-9";
            string expectedId = "5.900.000-9";
            string actualId = testingPerson.ID;
            Assert.AreEqual(expectedId, actualId);
        }

        [Test]
          public void ChangeToInorrectId() 
        {
            Person testingPerson = new Person("name","6.000.000-8");
            testingPerson.ID =  "5.900.000-1";
            string expectedId = "6.000.000-8";
            string actualId = testingPerson.ID;
            Assert.AreEqual(expectedId, actualId);
        }

        [Test]
          public void ChangeToNullIdVerifyer() 
        {
            Person testingPerson = new Person("name","6.000.000-8");
            testingPerson.ID =  "";
            string expectedId = "6.000.000-8";
            string actualId = testingPerson.ID;
            Assert.AreEqual(expectedId, actualId);
        }
    }
}
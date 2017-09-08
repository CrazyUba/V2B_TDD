using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using MyLibrary;

namespace NUnitTest
{
    [TestFixture]
    [Ignore("")]
    public class PersonTest
    {
        Person p;

        [OneTimeSetUp]  // Will be called just once
        public void OneTimeSetup()
        {
            
        }

        [SetUp] // Will be called before every testmethod
        public void Setup()     
        {
            p = new Person();
        }

        [Test]
        public void TestAge()
        {
            Assert.That(p.Age, Is.GreaterThan(0));
        }

        [Test]
        public void TestCity()
        {
            StringAssert.StartsWith("K", p.City);
        }

        [TearDown]  // Will be called after every testmethod
        public void TearDown()
        {

        }

        [OneTimeTearDown] // Will be called once after all tests are done
        public void OneTimeTearDown()
        {

        }

    }

}

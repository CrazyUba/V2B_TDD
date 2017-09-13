using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedGreenRefactor_Test
{
    /* 1 -> "1"
     * Teilbar durch 3 -> Fizz
     * Teilbar durch 5 -> Buzz
     * Teilbar durch 15 -> FizzBuzz 
     */

    [TestFixture]
    public class FizzBuzzTests
    {
        FizzBuzzConverter sut;

        [OneTimeSetUp]
        public void Initialize()
        {
            sut = new FizzBuzzConverter();
        }

        [Test]
        public void If1IsGiven1IsReturnedAsString()
        {
            string actualValue = sut.Convert(1);
            Assert.AreEqual("1", actualValue);
        }

        [Test]
        public void If3IsGivenFizzIsReturned()
        {
            string actualValue = sut.Convert(3);
            Assert.AreEqual("Fizz", actualValue);
        }

        [Test]
        public void If5IsGivenBuzzIsReturned()
        {
            string actualValue = sut.Convert(5);
            Assert.AreEqual("Buzz", actualValue);
        }

        [Test]
        public void If15IsGivenFizzBuzzIsReturned()
        {
            string actualValue = sut.Convert(15);
            Assert.AreEqual("FizzBuzz", actualValue);
        }
    }
}

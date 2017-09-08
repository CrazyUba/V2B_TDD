using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using MyStackLib;

namespace MyStack_Test
{
    [TestFixture]
    public class MyStack_Test
    {
        MyStack sut;

        [OneTimeSetUp]
        public void Init()
        {
            sut = new MyStack();
        }

        [Test]
        public void If1WasAdded1ShouldBeReturned()
        {
            sut.Push(1);
            int actual = sut.Pop();

            Assert.AreEqual(1, actual);            
        }

        [Test]
        public void If2WasAdded2ShouldBeReturned()
        {
            sut.Push(2);
            int actual = sut.Pop();

            Assert.AreEqual(2, actual);
        }

        [Test]
        public void NoElementShouldReturnInCount0()
        {
            //sut.Push(2);
            int actual = sut.Count;

            Assert.AreEqual(0, actual);
        }

        [Test]
        public void OneElementShouldReturnInCount1()
        {
            sut.Push(5);
            int actual = sut.Count;

            Assert.AreEqual(1, actual);
        }

        [Test]
        public void If1_2WasAdded2_1ShouldBeReturned()
        {
            sut.Push(1);
            sut.Push(2);
            int actual1 = sut.Pop();
            int actual2 = sut.Pop();

            Assert.AreEqual(2, actual1);
            Assert.AreEqual(1, actual2);
        }
    }
}

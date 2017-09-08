using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NUnitTest
{
    [TestFixture]  
    [Ignore("")]
    public class Tests
    {
        [Test]
        public void MyFirstTest()
        {
            Assert.AreEqual(2, 2);
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using w3schools_Practice_Problems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace w3schools_Practice_Problems.Tests
{
    [TestClass()]
    public class Basic1Tests
    {
        [TestMethod()]
        public void SayHello_NoNamePassed()
        {
            Basic1 greeter = new Basic1();
            Assert.AreEqual("Hello!", greeter.Greeting);
        }

        [TestMethod()]
        public void SayHello_NamePassed()
        {
            Basic1 greeter = new Basic1("Josh Hollandsworth");
            Assert.AreEqual("Hello: Josh Hollandsworth", greeter.Greeting);
        }
    }
}
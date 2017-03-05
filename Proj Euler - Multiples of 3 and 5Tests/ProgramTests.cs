using Microsoft.VisualStudio.TestTools.UnitTesting;
using Proj_Euler___Multiples_of_3_and_5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj_Euler___Multiples_of_3_and_5.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void sumThreesAndFivesTest()
        {
            int testNum = 10;
            int actual = Program.sumThreesAndFives(testNum);
            int expected = 23;

            Assert.AreEqual(expected, actual);
        }
    }
}
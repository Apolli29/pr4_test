using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using pr4_test.Pages;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Page1_Test()
        {
            var p = new Page1();
            double result = p.Calculate(0.5, 1, 2);
            Assert.IsTrue(result != 0);
        }
        [TestMethod]
        public void Page2_Test()
        {
            var p = new Page2();
            double result = p.Calculate(2, 2);
            Assert.AreEqual(4, result, 0.001);
        }
        [TestMethod]
        public void Page3_Test()
        {
            var p = new Page3();
            double result = p.Calculate(1, 1);
            Assert.IsTrue(result > 0);
        }
    }
}

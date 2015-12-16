using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Composite;

namespace CompositeTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAverage()
        {
            int[] t = new[] { 1, 12, 31, 6 };
            Assert.AreEqual(12.5, Calc.Moy(t));
        }
    }
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Races;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] a = { 2, 3, -5, 2, -4, -6 };
            int max = 3;
            int min = -6;
            int expected = -9;
            int actual = MainForm.Swap(a, min, max);
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod2()
        {
            int a =2000;

            int expected = 366;
            int actual = MainForm.Write(a);
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod3()
        {
            string inp = "asfsd sd sg";
            char sumb = 's';
            int expected = 4;
            int actual = MainForm.Sourcce(inp, sumb);
            Assert.AreEqual(expected, actual);
        }
    }
}

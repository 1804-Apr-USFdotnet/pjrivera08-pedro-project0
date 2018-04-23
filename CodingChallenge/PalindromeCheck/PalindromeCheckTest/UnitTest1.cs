using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PalindromeCheck;


namespace PalindromeCheckTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestPalindromeCheck0()
        {
            string test = "racecar";
            bool expected = true;

            bool actual = Program.PalindromeCheckMethod(test);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestPalindromeCheck1()
        {
            string test = "Racecar";
            bool expected = true;

            bool actual = Program.PalindromeCheckMethod(test);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestPalindromeCheck2()
        {
            string test = "1221";
            bool expected = true;

            bool actual = Program.PalindromeCheckMethod(test);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestPalindromeCheck3()
        {
            string test = "never Odd, or Even.";
            bool expected = true;

            bool actual = Program.PalindromeCheckMethod(test);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestPalindromeCheck4()
        {
            string test = "1231";
            bool expected = false;

            bool actual = Program.PalindromeCheckMethod(test);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestPalindromeCheck5()
        {
            string test = "aBc";
            bool expected = false;

            bool actual = Program.PalindromeCheckMethod(test);

            Assert.AreEqual(expected, actual);
        }
    }
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PalindromeCheck;


namespace PalindromeCheckTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestPalindromeCheck()
        {
            string racecar = "racecar";
            bool expected = true;

            bool actual = Program.PalindromeCheckMethod(racecar);

            Assert.AreEqual(expected, actual);
            

        }
    }
}

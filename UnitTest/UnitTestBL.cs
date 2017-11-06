using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusinessLayer;
namespace UnitTest
{
    [TestClass]
    public class UnitTestBL
    {
        [TestMethod]
        public void TestMethodAddNum1()
        {

            int expected, actual;
            expected = 30;
            WinForm  WinF = new WinForm();
            actual = WinF.AddNum (10,20);
            Assert.AreEqual(expected, actual);
            }
        [TestMethod]
        public void TestMethodAddNum2()
        {

            int expected, actual;
            expected = 30;
            WinForm WinF = new WinForm();
            actual = WinF.AddNum(20, 20);
            Assert.AreEqual(expected, actual);
        }

    }
}

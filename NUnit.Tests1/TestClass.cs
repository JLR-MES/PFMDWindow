using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer;
namespace NUnit.Tests1
{
    [TestFixture]
    public class TestClass
    {
        [Test]
        public void AddNum1()
        {
            // TODO: Add your test code here
            int expected, actual;
            expected = 30;
            WinForm WinF = new WinForm();
            actual = WinF.AddNum(10, 20);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void AddNum2()
        {
            // TODO: Add your test code here
            int expected, actual;
            expected = 40;
            WinForm WinF = new WinForm();
            actual = WinF.AddNum(20, 20);
            Assert.AreEqual(expected, actual);
        }
    }
}

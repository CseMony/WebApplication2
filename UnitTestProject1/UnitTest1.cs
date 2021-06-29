using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WebApplication2;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        { //Arrange:Initialize objects. Creates an instance of the class
            Class1 tp = new Class1();
            //assert part
            Assert.AreEqual(tp.Name, "Unit Testing");
        }
    }
}

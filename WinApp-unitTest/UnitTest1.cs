using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace WinApp_unitTest
{
    [TestClass]
    public class UnitTest1
    {
        

        [TestMethod]
        public void TestMethod1()
        {
            //
           ClassWinF Cls = new ClassWinF();
           int result = Cls.Add();
           Assert.AreEqual(10, result);
        }
    }
}

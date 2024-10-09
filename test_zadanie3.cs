using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace TestProject1{
    [TestClass]    
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1(){
            Point A = new Point(0, 0);            
            Point B = new Point(4, 0);
            Point C = new Point(4, 3);
            Figure tr = new Figure(A, B, C);
            Assert.AreEqual(12, tr.PerimeterCalculator());
        }    
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.GoogeRA.Sprint1.Task1.V9.Lib;

namespace Tyuiu.GoogeRA.Sprint1.Task1.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 5.0;
            double y = 1.0;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(4, res);
        }
    }
}

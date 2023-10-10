using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.GoogeRA.Sprint1.Task4.V18.Lib;


namespace Tyuiu.GoogeRA.Sprint1.Task4.V18.Test
{
    [TestClass]
    public class DataServviceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 3;
            double y = 1;
            double wait = 0.272;

            var res = ds.Calculate(x, y);

            Assert.AreEqual(wait, res);
        }
    }
}

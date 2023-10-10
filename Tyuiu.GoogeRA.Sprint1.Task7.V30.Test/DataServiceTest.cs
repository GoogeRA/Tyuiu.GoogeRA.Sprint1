using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.GoogeRA.Sprint1.Task7.V30.Lib;

namespace Tyuiu.GoogeRA.Sprint1.Task7.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 1;

            double y = 5346.453;

            double res = ds.Calculate(x, y);

            double result = Convert.ToDouble(res);

            double wait = 0.004;

            Assert.AreEqual(wait, result);
        }
    }
}

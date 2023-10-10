using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.GoogeRA.Sprint1.Task2.V6.Lib;

namespace Tyuiu.GoogeRA.Sprint1.Task2.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 600;
            var res = ds.ConvertMToKm(x);
            Assert.AreEqual(0.600, res);
        }
    }
}

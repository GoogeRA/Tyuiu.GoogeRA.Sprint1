using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.GoogeRA.Sprint1.Task3.V17.Lib;

namespace Tyuiu.GoogeRA.Sprint1.Task3.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double n = 23.098;
            Assert.AreEqual(true, ds.ZeroCheck(n));
        }
    }
}

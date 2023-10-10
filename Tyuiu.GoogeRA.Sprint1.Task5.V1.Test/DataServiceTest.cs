using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.GoogeRA.Sprint1.Task5.V1.Lib;



namespace Tyuiu.GoogeRA.Sprint1.Task5.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x1 = 4;
            double y1 = 2;
            double x2 = 3;
            double y2 = 1;
            double res = ds.DistanceBetweenDots(x1, y1, x2, y2);

            int result = Convert.ToInt32(res);

            int wait = 1;
            Assert.AreEqual(wait, result);



        }
    }
}

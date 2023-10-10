﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.GoogeRA.Sprint1.Task6.V6.Lib;

namespace Tyuiu.GoogeRA.Sprint1.Task6.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string strTest = "Привет мир!";
            DataService ds = new DataService();
            string res = ds.DeleteFirstLetter(strTest);
            string wait = "ривет ир! ";
            Assert.AreEqual(wait, res);
        }
    }
}

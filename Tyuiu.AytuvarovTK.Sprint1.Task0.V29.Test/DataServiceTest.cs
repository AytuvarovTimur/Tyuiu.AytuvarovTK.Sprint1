﻿using Tyuiu.AytuvarovTK.Sprint1.Task0.V29.Lib;

namespace Tyuiu.AytuvarovTK.Sprint1.Task0.V29.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            var res = ds.Calculate();
            Assert.AreEqual(32, res);
        }
    }
}

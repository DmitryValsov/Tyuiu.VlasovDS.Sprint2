﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.VlasovDS.Sprint2.Task2.V6;
using Tyuiu.VlasovDS.Sprint2.Task2.V6.Lib;

namespace Tyuiu.VlasovDS.Sprint2.Task2.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();
            int x = 3;
            int y = 3;

            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = true;

            Assert.AreEqual(wait, res);

        }
    }
}

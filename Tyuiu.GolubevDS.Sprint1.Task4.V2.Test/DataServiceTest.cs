using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.GolubevDS.Sprint1.Task4.V2.Lib;
namespace Tyuiu.GolubevDS.Sprint1.Task4.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 49;
            double wait = 0.1;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}

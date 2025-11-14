using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.LevakovaAA.Sprint4.Task7.V22.Lib;
using System;
namespace Tyuiu.LevakovaAA.Sprint4.Task7.V22.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            int rows = 3;
            int columns = 5;
            int[,] mtrx = new int[rows, columns];
            string str = "695324951753684";
            DataService ds = new DataService();
            int res = ds.Calculate(rows, columns, str);
            Assert.AreEqual(9216, res);
        }
    }
}

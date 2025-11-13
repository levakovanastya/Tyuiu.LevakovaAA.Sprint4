using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.LevakovaAA.Sprint4.Task5.V12.Lib;
using System;
namespace Tyuiu.LevakovaAA.Sprint4.Task5.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            int[,] mas = new int[5, 5] { { -3, 2, 4, 4, 4 }, { 2, 6, -6, 3, 2 }, { 4, 2, 5, 5, 3 }, { 5, 5, 6, 4, 3 }, { 2, 6, 5, 6, 2 } };
            int res = ds.Calculate(mas);
            Assert.AreEqual(2, res);
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.LevakovaAA.Sprint4.Task2.V19.Lib;
using System;
namespace Tyuiu.LevakovaAA.Sprint4.Task1.V21.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void validCalc()
        {
            DataService ds = new DataService();
            int[] numsArray = { 2, 4, 8, 5, 2, 6, 5, 8, 8, 6, 6, 3, 3, 5};
            int res = ds.Calculate(numsArray);
            Assert.AreEqual(21, res);
        }
    }
}

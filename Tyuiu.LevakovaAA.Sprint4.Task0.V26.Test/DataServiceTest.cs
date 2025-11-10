using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.LevakovaAA.Sprint4.Task0.V26.Lib;
using System;
namespace Tyuiu.LevakovaAA.Sprint4.Task0.V26.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void validCalc()
        {
            DataService ds = new DataService();
            int[] numsArray = { 9, 3, 7, 1, 5, 5, 3, 2, 1, 7 };
            int res = ds.GetSumOddArrEl(numsArray);
            Assert.AreEqual(42, res);
        }
    }
}

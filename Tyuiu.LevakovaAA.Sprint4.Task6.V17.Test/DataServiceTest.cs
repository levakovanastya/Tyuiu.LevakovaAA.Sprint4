using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.LevakovaAA.Sprint4.Task6.V17.Lib;
using System;
namespace Tyuiu.LevakovaAA.Sprint4.Task6.V17.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void Validcalc()
        {
            DataService ds = new DataService();
            var p = new string[]{"Python", "JavaScript", "Java", "C#", "Swift", "Kotlin", "Ruby"};
            int res = ds.Calculate(p);
            Assert.AreEqual(2, res);
        }
    }
}

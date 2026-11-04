using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json.Linq;
using tyuiu.denisovld.sprint3.Task2.V3.Lib;
namespace tyuiu.denisovld.sprint3.Task0.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double exp = Math.Round((((Math.Pow(4, 2) * 1) + 1) + ((Math.Pow(4, 2) * 2) + 1) + ((Math.Pow(4, 2) * 3) + 1)), 3);
            double res = ds.GetSumSeries(4, 1, 3);
            Assert.AreEqual(exp, res);
        }
    }
}

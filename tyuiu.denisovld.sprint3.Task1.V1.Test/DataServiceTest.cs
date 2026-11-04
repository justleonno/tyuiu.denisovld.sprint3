using Microsoft.VisualStudio.TestTools.UnitTesting;
using tyuiu.denisovld.sprint3.Task1.V1.Lib;
namespace tyuiu.denisovld.sprint3.Task0.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double exp = Math.Round(Math.Pow((Convert.ToDouble(3) / Convert.ToDouble(1)), -2) * Math.Pow((Convert.ToDouble(3) / Convert.ToDouble(2)), -2), 3);
            double res = ds.GetMultiplySeries(1, 2);
            Assert.AreEqual(exp, res);
        }
    }
}

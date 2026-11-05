using Microsoft.VisualStudio.TestTools.UnitTesting;
using tyuiu.denisovld.sprint3.Task4.V6.Lib;
namespace tyuiu.denisovld.sprint3.Task4.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double res = ds.Calculate(-2, 2);
            double exp = (-2 / (Math.Cos(-2) - Math.Sin(-2))) + (-1 / (Math.Cos(-1) - Math.Sin(-1))) + (1 / (Math.Cos(1) - Math.Sin(1))) + (2 / (Math.Cos(2) - Math.Sin(2)));
            exp = Math.Round(exp, 3);
            Assert.AreEqual(res, exp);
        }
    }
}

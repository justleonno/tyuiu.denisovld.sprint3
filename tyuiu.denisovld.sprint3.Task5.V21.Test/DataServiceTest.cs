using Microsoft.VisualStudio.TestTools.UnitTesting;
using tyuiu.denisovld.sprint3.Task5.V21.Lib;
namespace tyuiu.denisovld.sprint3.Task5.V21.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double res = ds.GetSumSumSeries(2, 1, 1, 3, 10);
            Assert.AreEqual(res, res);
        }
    }
}

using tyuiu.denisovld.sprint3.Task0.V4.Lib;
namespace tyuiu.denisovld.sprint3.Task0.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double exp = Math.Round((Math.Sin(0.1) + 1) * (Math.Sin(0.1) + 2),3);
            double res = ds.GetMultiplySeries(1, 2);
            Assert.AreEqual(exp, res);
        }
    }
}

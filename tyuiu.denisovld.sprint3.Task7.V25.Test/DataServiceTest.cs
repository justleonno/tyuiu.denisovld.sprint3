using Microsoft.VisualStudio.TestTools.UnitTesting;
using tyuiu.denisovld.sprint3.Task7.V25.Lib;
namespace tyuiu.denisovld.sprint3.Task7.V25.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double[] exp = { Math.Round((Math.Cos(-1) + ((4 * -1) / 2) - Math.Sin(-1) * 3 * -1), 2), Math.Round((Math.Cos(0) + ((4 * 0) / 2) - Math.Sin(0) * 3 * 0), 2) , Math.Round((Math.Cos(1) + ((4 * 1) / 2) - Math.Sin(1) * 3 * 1), 2) };
            double[] res = ds.GetMassFunction(-1, 1);
            CollectionAssert.AreEqual(exp, res);
        }   
    }
}

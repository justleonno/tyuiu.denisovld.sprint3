using Microsoft.VisualStudio.TestTools.UnitTesting;
using tyuiu.denisovld.sprint3.Task6.V12.Lib;
namespace tyuiu.denisovld.sprint3.Task6.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int res = ds.GetSumTheDivisors(2, 4);
            int exp = 1 + 2 + 1 + 3 + 1 + 2 + 4;
        }
    }
}

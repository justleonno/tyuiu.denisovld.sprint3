using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json.Linq;
using tyuiu.denisovld.sprint3.Task3.V25.Lib;
namespace tyuiu.denisovld.sprint3.Task3.V25.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string str = "lalau aaa lolouu uudd u u";
            int res = 4;
            int lol = ds.GetMinCharCount(str, 'u');
            Assert.AreEqual(res, lol);
        }
    }
}

using Tyuiu.ShmidtAA.Sprint1.Task0.V18.Lib;

namespace Tyuiu.ShmidtAA.Sprint1.Task0.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            var res = ds.Calculate();
            Assert.AreEqual(3, res);
        }
    }
}
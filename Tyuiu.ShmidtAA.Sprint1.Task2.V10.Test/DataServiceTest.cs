using Tyuiu.ShmidtAA.Sprint1.Task2.V10.Lib;

namespace Tyuiu.ShmidtAA.Sprint1.Task2.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int num = 5;
            double res = Math.Round((num * 39.37),3) ;
            Assert.AreEqual(res, ds.ConvertMetreToInchs(num));
        }
    }
}
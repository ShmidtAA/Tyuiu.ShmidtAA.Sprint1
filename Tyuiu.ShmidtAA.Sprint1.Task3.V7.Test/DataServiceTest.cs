using Tyuiu.ShmidtAA.Sprint1.Task3.V7.Lib;
namespace Tyuiu.ShmidtAA.Sprint1.Task3.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
           DataService ds = new DataService();
            double num = 1;
            Assert.AreEqual(Math.Round((num * 1.0668),3), ds.VerstsToKilometers(num));

        }
    }
}
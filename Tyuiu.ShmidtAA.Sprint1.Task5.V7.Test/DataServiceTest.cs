using Tyuiu.ShmidtAA.Sprint1.Task5.V7.Lib;
namespace Tyuiu.ShmidtAA.Sprint1.Task5.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService(); 
            double x = 30;
            Assert.AreEqual((Convert.ToInt32(x*2 / 60)), ds.AngleToHoursMinutes(x));
        }
    }
}
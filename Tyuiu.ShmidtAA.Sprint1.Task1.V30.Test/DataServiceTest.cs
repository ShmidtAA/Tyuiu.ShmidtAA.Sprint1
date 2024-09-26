using Tyuiu.ShmidtAA.Sprint1.Task1.V30.Lib;
namespace Tyuiu.ShmidtAA.Sprint1.Task1.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            var res = ds.Calculate(2);


            Assert.AreEqual(2,res);

        }
    }
}
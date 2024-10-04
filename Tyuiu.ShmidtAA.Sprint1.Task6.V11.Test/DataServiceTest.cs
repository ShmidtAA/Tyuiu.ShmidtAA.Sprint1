using Tyuiu.ShmidtAA.Sprint1.Task6.V11.Lib;
namespace Tyuiu.ShmidtAA.Sprint1.Task6.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string str = "ннкарп";
            Assert.AreEqual(true,ds.CheckeFirstLetterRepetition(str));

        }
    }
}
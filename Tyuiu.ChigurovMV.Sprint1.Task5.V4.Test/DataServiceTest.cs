using Tyuiu.ChigurovMV.Sprint1.Task5.V4.Lib;

namespace Tyuiu.ChigurovMV.Sprint1.Task5.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestHours()
        {
            DataService ds = new DataService();
            int k = 13257;

            int wait = 3;
            int res = ds.SecondsToHours(k);
            Assert.AreEqual(wait, res);
        }
    }
}
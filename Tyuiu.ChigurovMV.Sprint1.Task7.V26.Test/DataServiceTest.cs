using Tyuiu.ChigurovMV.Sprint1.Task7.V26.Lib;

namespace Tyuiu.ChigurovMV.Sprint1.Task7.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CalcTest()
        {
            DataService ds = new DataService();
            int x = 4;
            int y = 4;

            double wait = 0.6624193366669869;
            double res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
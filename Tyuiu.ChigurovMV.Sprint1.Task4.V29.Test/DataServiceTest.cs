using Tyuiu.ChigurovMV.Sprint1.Task4.V29.Lib;

namespace Tyuiu.ChigurovMV.Sprint1.Task4.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 1;
            int y = 2;

            double wait = 0.186;
            double res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
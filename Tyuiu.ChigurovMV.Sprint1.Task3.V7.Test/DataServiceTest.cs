using Tyuiu.ChigurovMV.Sprint1.Task3.V7.Lib;

namespace Tyuiu.ChigurovMV.Sprint1.Task3.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double verst = 100;

            var res = ds.VerstsToKilometers(verst);
            Assert.AreEqual(1.0668, res);
        }
    }
}
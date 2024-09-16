using Tyuiu.ChigurovMV.Sprint1.Task1.V29.Lib;
namespace Tyuiu.ChigurovMV.Sprint1.Task1.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double a = 1.0;
            double b = 2.0;
            double c = 3.0;
            var res = ds.Calculate(a, b, c);
            Assert.AreEqual(1, res);
        }
    }
}

using Tyuiu.ChigurovMV.Sprint1.Task2.V12.Lib;


namespace Tyuiu.ChigurovMV.Sprint1.Task2.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int a = 2;
            int b = 3;
            int c = 4;

            int res = ds.CalculateParallelepipedVolume(a, b, c);
            Assert.AreEqual(24, res);
        }
    }
}
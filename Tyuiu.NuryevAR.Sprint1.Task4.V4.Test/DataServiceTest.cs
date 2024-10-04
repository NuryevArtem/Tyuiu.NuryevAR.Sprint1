using Tyuiu.NuryevAR.Sprint1.Task4.V4.Lib;

namespace Tyuiu.NuryevAR.Sprint1.Task4.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 5;
            double y = 7;
            double wait = 5.143;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
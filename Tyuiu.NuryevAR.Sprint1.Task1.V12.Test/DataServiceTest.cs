using Tyuiu.NuryevAR.Sprint1.Task1.V12.Lib;

namespace Tyuiu.NuryevAR.Sprint1.Task1.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 4.0;
            double y = 8.0;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(2, res);
        }
    }
}
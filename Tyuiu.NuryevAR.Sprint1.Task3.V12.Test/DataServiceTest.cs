using Tyuiu.NuryevAR.Sprint1.Task3.V12.Lib;

namespace Tyuiu.NuryevAR.Sprint1.Task3.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 4;
            double y = 8;
            double wait = 16;
            var res = ds.TriangleArea(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
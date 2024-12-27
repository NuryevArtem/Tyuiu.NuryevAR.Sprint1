using Tyuiu.NuryevAR.Sprint1.Task7.V1.Lib;

namespace Tyuiu.NuryevAR.Sprint1.Task7.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 4;
            double z = 5;
            double wait = 0.3;
            var res = ds.Calculate(x, y, z);
            Assert.AreEqual(wait, res);
        }
    }
}
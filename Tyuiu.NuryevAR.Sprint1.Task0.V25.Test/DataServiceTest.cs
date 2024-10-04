using Tyuiu.NuryevAR.Sprint1.Task0.V25.Lib;

namespace Tyuiu.NuryevAR.Sprint1.Task0.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var res = ds.Calculate();
            Assert.AreEqual(3, res);
        }
    }
}
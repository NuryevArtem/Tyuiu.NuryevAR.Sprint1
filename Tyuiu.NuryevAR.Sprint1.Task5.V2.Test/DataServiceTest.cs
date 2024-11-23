using Tyuiu.NuryevAR.Sprint1.Task5.V2.Lib;

namespace Tyuiu.NuryevAR.Sprint1.Task5.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            double temp = 50;
            DataService ds = new DataService();
            double res = ds.FahrenheitTo—elsius(temp);

            int result = Convert.ToInt32(res);

            int wait = 10;
            Assert.AreEqual(wait, result);
        }
    }
}
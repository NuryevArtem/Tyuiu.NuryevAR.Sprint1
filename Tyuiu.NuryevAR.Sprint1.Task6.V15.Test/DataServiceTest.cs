using Tyuiu.NuryevAR.Sprint1.Task6.V15.Lib;

namespace Tyuiu.NuryevAR.Sprint1.Task6.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            
            string input = "Hura!";

            
            DataService ds = new DataService();

            
            bool res = ds.CheckLettersCount(input);

            
            bool wait = true; 

            
            if (res == wait)
            {
                Console.WriteLine("Проверка совпала с ожиданием.");
            }
            else
            {
                Console.WriteLine("Результат не совпал с ожиданием.");
            }

            
            if (res)
            {
                Console.WriteLine("В строке больше букв, чем знаков препинания.");
            }
            else
            {
                Console.WriteLine("В строке меньше или столько же букв, сколько знаков препинания.");
            }
        }
    }
}
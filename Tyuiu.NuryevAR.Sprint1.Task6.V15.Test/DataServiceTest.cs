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
                Console.WriteLine("�������� ������� � ���������.");
            }
            else
            {
                Console.WriteLine("��������� �� ������ � ���������.");
            }

            
            if (res)
            {
                Console.WriteLine("� ������ ������ ����, ��� ������ ����������.");
            }
            else
            {
                Console.WriteLine("� ������ ������ ��� ������� �� ����, ������� ������ ����������.");
            }
        }
    }
}
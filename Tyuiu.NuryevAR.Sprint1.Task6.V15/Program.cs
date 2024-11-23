using Tyuiu.NuryevAR.Sprint1.Task6.V15.Lib;

namespace Tyuiu.NuryevAR.Sprint1.Task6.V15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Нурыев А. Р. | ИИПб-24-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #15                                                             *");
            Console.WriteLine("* Выпонил: Нурыев Артём Радикович | ИИПб-24-2                             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу:                                                     *");
            Console.WriteLine("* пользователь вводит текст. Проверить, что в строке больше букв, чем     *");
            Console.WriteLine("* знаков.                                                                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите строку:");
            string str = Console.ReadLine();


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            
            Console.WriteLine(ds.CheckLettersCount(str));

            Console.ReadKey();
        }
    }
}

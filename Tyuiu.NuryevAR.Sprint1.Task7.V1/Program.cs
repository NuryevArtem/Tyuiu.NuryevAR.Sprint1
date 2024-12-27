using Tyuiu.NuryevAR.Sprint1.Task7.V1.Lib;

namespace Tyuiu.NuryevAR.Sprint1.Task7.V1
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
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #1                                                              *");
            Console.WriteLine("* Выпонил: Нурыев Артём Радикович | ИИПб-24-2                             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет математическое выражение по       *");
            Console.WriteLine("* исходным значениям данных, вводимых пользователем. Ответ округлите до 3 *");
            Console.WriteLine("* знаков после запятой.                                                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*     y + √y^2 + 4 x z                                                    *");
            Console.WriteLine("* f = ---------------- - x^3 z + y^-2                                     *");
            Console.WriteLine("*            2x                                                           *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите значение x: ");

            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение y: ");

            double y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение z: ");

            double z = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("*****************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                            *");
            Console.WriteLine("*****************************************************************************************");

            Console.WriteLine($"f = {ds.Calculate(x, y, z)}");

            Console.ReadKey();
        }
    }
}

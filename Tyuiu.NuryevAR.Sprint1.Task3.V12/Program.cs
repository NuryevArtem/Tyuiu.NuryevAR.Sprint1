using Tyuiu.NuryevAR.Sprint1.Task3.V12.Lib;

namespace Tyuiu.NuryevAR.Sprint1.Task3.V12
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
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #12                                                             *");
            Console.WriteLine("* Выпонил: Нурыев Артём Радикович | ИИПб-24-2                             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу для вычисления площади прямоугольного треугольника по*");
            Console.WriteLine("* длинам двух катетов. Ответ округлите до 3 знаков после запятой.         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            double lengthCathetus1 = 14.537;
            double lengthCathetus2 = 19.382;


            Console.WriteLine("Сторона катета 1 = " + lengthCathetus1);
            Console.WriteLine("Сторона катета 2 = " + lengthCathetus2);


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ                                                               *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Площадь треугольника = " + ds.TriangleArea(lengthCathetus1, lengthCathetus2));

            Console.ReadLine();
        }
    }
}

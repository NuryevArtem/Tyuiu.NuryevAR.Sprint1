using Tyuiu.NuryevAR.Sprint1.Task2.V25.Lib;

namespace Tyuiu.NuryevAR.Sprint1.Task2.V25
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
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #12                                                             *");
            Console.WriteLine("* Выпонил: Нурыев Артём Радикович | ИИПб-24-2                             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
            Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране              *");
            Console.WriteLine("* Формулировка задания: Известен угол в радианах. Перевести угол в        *");
            Console.WriteLine("* градусы. Ответ округлите до 3 знаков после запятой                      *");
            Console.WriteLine("* Что пользователь вводит? Угол в радианах (целое число)                  *");
            Console.WriteLine("* Что программа печатает на экране? Угол в градусах (вещественное число)  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int x;

            Console.WriteLine("Введите угол в радианах X:");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ                                                               *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Угол в градусах X = " + ds.ConvertRadsToDegrees(x));

            Console.ReadLine();
        }
    }
}

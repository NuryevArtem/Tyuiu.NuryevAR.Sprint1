using Tyuiu.NuryevAR.Sprint1.Task5.V2.Lib;

namespace Tyuiu.NuryevAR.Sprint1.Task5.V2
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
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #2                                                              *");
            Console.WriteLine("* Выпонил: Нурыев Артём Радикович | ИИПб-24-2                             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая решает следующую задачу:                    *");
            Console.WriteLine("* Дано значение температуры в градусах Фаренгейта. Определить значение    *");
            Console.WriteLine("* этой же температуры в градусах Цельсия. Ответ привести к целому с       *");
            Console.WriteLine("* помощью класса Convert.                                                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите значение X:");
            double temp = Convert.ToInt32(Console.ReadLine());
    

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int res = Convert.ToInt32(ds.FahrenheitToСelsius(temp));
            Console.WriteLine(res);

            Console.ReadKey();
        }
    }
}

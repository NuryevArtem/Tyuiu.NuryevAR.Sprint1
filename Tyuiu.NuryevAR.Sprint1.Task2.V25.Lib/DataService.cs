using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.NuryevAR.Sprint1.Task2.V25.Lib
{
    public class DataService : ISprint1Task2V25
    {
        public double ConvertRadsToDegrees(int value)
        {
            double degrees = value * 57.2958;
            return Math.Round(degrees, 3);
        }
    }
}

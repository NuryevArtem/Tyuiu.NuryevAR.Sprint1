using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.NuryevAR.Sprint1.Task7.V1.Lib
{
    public class DataService : ISprint1Task7V1
    {
        public double Calculate(double x, double y, double z)
        {
            double res = (y + Math.Sqrt(Math.Pow(y, 2) + 4 * x * z)) / (2 * x) - Math.Pow(x, 3) * z + Math.Pow(y, -2);
            return Math.Round(res, 3);
        }
    }
}

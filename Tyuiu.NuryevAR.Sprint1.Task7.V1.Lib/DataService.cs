using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.NuryevAR.Sprint1.Task7.V1.Lib
{
    public class DataService : ISprint1Task7V1
    {
        public double Calculate(double x, double y, double z)
        {
            double res = (y - x) * ((y - z / y - x) / (1 + Math.Pow((y - x), 2)));
            return res;
        }
    }
}

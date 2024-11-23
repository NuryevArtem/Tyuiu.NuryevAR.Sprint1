using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.NuryevAR.Sprint1.Task6.V15.Lib
{
    public class DataService : ISprint1Task6V15
    {
        public bool CheckLettersCount(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                return false;
            }

            int letterCount = value.Count(char.IsLetter);
            int punctuationCount = value.Count(char.IsPunctuation);

            return letterCount > punctuationCount;
        }
    }
}

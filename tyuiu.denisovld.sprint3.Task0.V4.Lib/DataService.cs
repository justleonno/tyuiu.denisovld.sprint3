using System.Diagnostics.CodeAnalysis;
using tyuiu.cources.programming.interfaces.Sprint2;
using tyuiu.cources.programming.interfaces.Sprint3;
namespace tyuiu.denisovld.sprint3.Task0.V4.Lib
{
    public class DataService : ISprint3Task0V4
    {
        public double GetMultiplySeries(int startValue, int stopValue)
        {
            double sum = 1;
            for (int k = startValue; k <= stopValue; k++)
            {
                double p = Math.Sin(0.1) + k;
                sum *= p;

            }
            return Math.Round(sum, 3);
        }
    }
}

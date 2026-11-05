using tyuiu.cources.programming.interfaces.Sprint1;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace tyuiu.denisovld.sprint3.Task5.V21.Lib
{
    public class DataService : ISprint3Task5V21
    {
        public double GetSumSumSeries(int x, int startValue1, int startValue2, int stopValue1, int stopValue2)
        {
            double sum = 0;
            for (int i = startValue1; i <= stopValue1; i++)
            {
                double sum2 = 0;
                for (int k = startValue2; k <= stopValue2; k++)
                {
                    sum2 += ((Math.Pow(x, 3) * Math.Cos(k)) + 2);
                }
                sum += sum2;
            }
            return Math.Round(sum, 3);
        }
    }
}

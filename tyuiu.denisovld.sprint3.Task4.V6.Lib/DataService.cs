using tyuiu.cources.programming.interfaces.Sprint3;
namespace tyuiu.denisovld.sprint3.Task4.V6.Lib
{
    public class DataService : ISprint3Task4V6
    {
        public double Calculate(int startValue, int stopValue)
        {
            double sum1 = 0;
            double sum2 = 0;
            for (int i = startValue; i <= 0; i++)
            {
                sum1 += (i / (Math.Cos(i) - Math.Sin(i)));

                if (i == 0)
                {
                    break;
                }

            }
            for (int i = 1; i <= stopValue; i++)
            {

                sum2 += (i / (Math.Cos(i) - Math.Sin(i)));

            }
            return Math.Round(sum1 + sum2, 3);
        }
    }
}

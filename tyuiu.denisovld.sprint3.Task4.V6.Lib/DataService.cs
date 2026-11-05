using tyuiu.cources.programming.interfaces.Sprint3;
namespace tyuiu.denisovld.sprint3.Task4.V6.Lib
{
    public class DataService : ISprint3Task4V6
    {
        public double Calculate(int startValue, int stopValue)
        {
            double sum1 = 0;
            for (int i = startValue; i <= 0; i++)
            {
                if (i != 0)
                {
                    sum1 += (i / (Math.Cos(i) - Math.Sin(i)));
                }
                else
                {
                    break;
                }
            }

            return Math.Round(sum1, 3);
        }
    }
}

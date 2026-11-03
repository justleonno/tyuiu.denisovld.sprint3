using tyuiu.cources.programming.interfaces.Sprint3;
namespace tyuiu.denisovld.sprint3.Task1.V1.Lib
{
    public class DataService : ISprint3Task1V1
    {
        public double GetMultiplySeries(int startValue, int stopValue)
        {
            double res = 1;
            int k = startValue;
            while (k <= stopValue)
            {
                res *= Math.Pow((3/k), -2);
                k++;
            }
            return Math.Round(res, 3);
        }
    }
}

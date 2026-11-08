using tyuiu.cources.programming.interfaces.Sprint3;
namespace tyuiu.denisovld.sprint3.Task7.V25.Lib
{
    public class DataService : ISprint3Task7V25
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            List<double> res = new List<double> { };
            for (int i = startValue; i <= stopValue; i++)
            {
                if (2 != 0)
                {
                    double f = (Math.Cos(i) + ((4 * i) / 2) - Math.Sin(i) * 3 * i);
                    f = Math.Round(f, 2);
                    res.Add(f);
                }
                else 
                {
                    double f = 0;
                    res.Add(f);
                }
            }
            double[] res2 = res.ToArray();
            return res2;
        }
    }
}

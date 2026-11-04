using tyuiu.cources.programming.interfaces.Sprint3;
namespace tyuiu.denisovld.sprint3.Task3.V25.Lib
{
    public class DataService : ISprint3Task3V25
    {
        public int GetMinCharCount(string value, char item)
        {
            char pres = Convert.ToChar(" ");
            int count = 0;
            foreach (char c in value)
            {
                if (c == 'u' & c == pres)
                {
                    count += 2;
                }
                pres = c;
            }
            return count;
        }
    }
}

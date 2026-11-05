using tyuiu.cources.programming.interfaces.Sprint3;
namespace tyuiu.denisovld.sprint3.Task3.V25.Lib
{
    public class DataService : ISprint3Task3V25
    {
        public int GetMinCharCount(string value, char item) ///lalau aaa lolouu uudd u u
        {
            string pres = " ";
            int count = 0;
            int lastcount = 0;
            foreach (char c in value)
            {
                if (c == item & c == pres[^1])
                {
                    count++;
                }
                else
                {
                    if (count > 0)
                    {
                        lastcount = count;
                    }
                    count = 0;
                    pres = " ";
                }
                pres += c;
            }
            return lastcount;
        }
    }
}

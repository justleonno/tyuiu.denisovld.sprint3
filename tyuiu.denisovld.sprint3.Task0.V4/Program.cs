using tyuiu.denisovld.sprint3.Task0.V4.Lib;
namespace tyuiu.denisovld.sprint1.Task1.V6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Title = "Спринт 1 | Выполнено by Денисов Л. Д. | АСОиУб-26-1";
            Console.WriteLine("*************************************************************************************************");
            Console.WriteLine("* Спринт #3                                                                                     *");
            Console.WriteLine("* Тема: Оператор цикла for                                                                      *");
            Console.WriteLine("* Задание #0                                                                                    *");
            Console.WriteLine("* Вариант #4                                                                                   *");
            Console.WriteLine("* Выполнено by Денисов Л. Д. | АСОиУб-26-1                                                      *");
            Console.WriteLine("*************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                      *");
            Console.WriteLine("* Написать программу используя цикл for, которая вычисляет произведение ряда по формуле         *");
            Console.WriteLine("*                                                                                               *");
            Console.WriteLine("*************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                              *");
            Console.WriteLine("*************************************************************************************************");


            Console.WriteLine("*************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                    *");
            Console.WriteLine("*************************************************************************************************");
            Console.WriteLine(ds.GetMultiplySeries(1, 7));

            Console.ReadLine();
        }
    }
}
using tyuiu.denisovld.sprint3.Task7.V25.Lib;

Console.OutputEncoding = System.Text.Encoding.UTF8;
DataService ds = new DataService();

Console.Title = "Спринт 3 | Выполнено by Денисов Л. Д. | АСОиУб-26-1";
Console.WriteLine("*************************************************************************************************");
Console.WriteLine("* Спринт #3                                                                                     *");
Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                                       *");
Console.WriteLine("* Задание #7                                                                                    *");
Console.WriteLine("* Вариант #25                                                                                   *");
Console.WriteLine("* Выполнено by Денисов Л. Д. | АСОиУб-26-1                                                      *");
Console.WriteLine("*************************************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                                      *");
Console.WriteLine("* Напишите программу, которая выводит таблицу значений функции с табуляцией на диапозоне [-5;5] *");
Console.WriteLine("*                                                                                               *");
Console.WriteLine("*                                                                                               *");
Console.WriteLine("*************************************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                              *");
Console.WriteLine("*************************************************************************************************");


Console.WriteLine("*************************************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                    *");
Console.WriteLine("*************************************************************************************************");

double[] massive = ds.GetMassFunction(-5, 5);
for (int i = 0; i < massive.Length; i++)
{
    Console.WriteLine(massive[i]);
}

Console.WriteLine(ds.GetMassFunction(-5, 5));

Console.ReadKey();






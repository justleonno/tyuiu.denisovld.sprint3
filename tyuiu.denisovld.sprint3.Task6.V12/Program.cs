using tyuiu.denisovld.sprint3.Task6.V12.Lib;

Console.OutputEncoding = System.Text.Encoding.UTF8;
DataService ds = new DataService();

Console.Title = "Спринт 3 | Выполнено by Денисов Л. Д. | АСОиУб-26-1";
Console.WriteLine("*************************************************************************************************");
Console.WriteLine("* Спринт #3                                                                                     *");
Console.WriteLine("* Тема: Обработка целочисленной информации                                                      *");
Console.WriteLine("* Задание #6                                                                                    *");
Console.WriteLine("* Вариант #12                                                                                   *");
Console.WriteLine("* Выполнено by Денисов Л. Д. | АСОиУб-26-1                                                      *");
Console.WriteLine("*************************************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                                      *");
Console.WriteLine("* Напишите программу, которая ищет среди целых чисел, принадлежащих числовому                   *");
Console.WriteLine("* отрезку[9, 18] сумму всех делителей                                                           *");
Console.WriteLine("*                                                                                               *");
Console.WriteLine("*************************************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                              *");
Console.WriteLine("*************************************************************************************************");


Console.WriteLine("*************************************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                    *");
Console.WriteLine("*************************************************************************************************");
Console.WriteLine(ds.GetSumTheDivisors(9, 18));

Console.ReadKey();






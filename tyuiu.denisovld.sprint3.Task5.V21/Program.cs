using tyuiu.denisovld.sprint3.Task5.V21.Lib;

Console.OutputEncoding = System.Text.Encoding.UTF8;
DataService ds = new DataService();

Console.Title = "Спринт 3 | Выполнено by Денисов Л. Д. | АСОиУб-26-1";
Console.WriteLine("*************************************************************************************************");
Console.WriteLine("* Спринт #3                                                                                     *");
Console.WriteLine("* Тема: Вложенные циклы                                                                         *");
Console.WriteLine("* Задание #5                                                                                    *");
Console.WriteLine("* Вариант #21                                                                                   *");
Console.WriteLine("* Выполнено by Денисов Л. Д. | АСОиУб-26-1                                                      *");
Console.WriteLine("*************************************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                                      *");
Console.WriteLine("* Формула суммы сумм                                                                            *");
Console.WriteLine("*                                                                                               *");
Console.WriteLine("*************************************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                              *");
Console.WriteLine("*************************************************************************************************");


Console.WriteLine("*************************************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                    *");
Console.WriteLine("*************************************************************************************************");
Console.WriteLine(ds.GetSumSumSeries(2, 1, 1, 3, 10));

Console.ReadKey();






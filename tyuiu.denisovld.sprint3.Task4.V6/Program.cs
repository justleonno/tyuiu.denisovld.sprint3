using tyuiu.denisovld.sprint3.Task4.V6.Lib;

Console.OutputEncoding = System.Text.Encoding.UTF8;
DataService ds = new DataService();

Console.Title = "Спринт 3 | Выполнено by Денисов Л. Д. | АСОиУб-26-1";
Console.WriteLine("*************************************************************************************************");
Console.WriteLine("* Спринт #3                                                                                     *");
Console.WriteLine("* Тема: Операторы continue and break                                                            *");
Console.WriteLine("* Задание #4                                                                                    *");
Console.WriteLine("* Вариант #6                                                                                    *");
Console.WriteLine("* Выполнено by Денисов Л. Д. | АСОиУб-26-1                                                      *");
Console.WriteLine("*************************************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                                      *");
Console.WriteLine("* На отрезке, где x принимает значения от -5 - 5, вычислить значение функции y=x/(cos(x)-sin(x))*");
Console.WriteLine("*                                                                                               *");
Console.WriteLine("*************************************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                              *");
Console.WriteLine("*************************************************************************************************");


Console.WriteLine("*************************************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                    *");
Console.WriteLine("*************************************************************************************************");
Console.WriteLine(ds.Calculate(-5, 5));

Console.ReadKey();






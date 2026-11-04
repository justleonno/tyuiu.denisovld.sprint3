using tyuiu.denisovld.sprint3.Task2.V3.Lib;

Console.OutputEncoding = System.Text.Encoding.UTF8;
DataService ds = new DataService();

Console.Title = "Спринт 3 | Выполнено by Денисов Л. Д. | АСОиУб-26-1";
Console.WriteLine("*************************************************************************************************");
Console.WriteLine("* Спринт #3                                                                                     *");
Console.WriteLine("* Тема: Оператор цикла do-while                                                                 *");
Console.WriteLine("* Задание #2                                                                                    *");
Console.WriteLine("* Вариант #3                                                                                    *");
Console.WriteLine("* Выполнено by Денисов Л. Д. | АСОиУб-26-1                                                      *");
Console.WriteLine("*************************************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                                      *");
Console.WriteLine("* Написать программу используя цикл do...while, которая вычисляет сумму ряда по формуле, при х=4*");
Console.WriteLine("*                                                                                               *");
Console.WriteLine("*************************************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                              *");
Console.WriteLine("*************************************************************************************************");

int x;
int y;

Console.WriteLine("Введите начальное значение");
x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите конечное значение");
y = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("*************************************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                    *");
Console.WriteLine("*************************************************************************************************");
Console.WriteLine(ds.GetSumSeries(4,1,15));

Console.ReadKey();






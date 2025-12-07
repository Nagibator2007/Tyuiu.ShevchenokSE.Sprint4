using Tyuiu.ShevchenokSE.Sprint4.Task3.V22.Lib;
namespace Tyuiu.ShevchenokSE.Sprint4.Task3.V22
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнил: Шевченок С. Е. | СМАРТб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Двумерные массивы (статический ввод)                              *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #22                                                             *");
            Console.WriteLine("* Выполнил: Шевченок Сергей Евгеньевич | СМАРТб-25-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
            Console.WriteLine("* статическими значениями в диапазоне от 4 до 9.                          *");
            Console.WriteLine("* Найдите максимальный элемент в первой строке массива.                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Random rnd = new Random();
            Console.WriteLine("Введите количество элементов в массиве");
            int len = Convert.ToInt32(Console.ReadLine());
            int[] numsArray = new int[len];
            for (int i = 0; i <= len - 1; i++)
            {
                numsArray[i] = rnd.Next(2, 8);
            }
            Console.WriteLine();
            Console.WriteLine("Массив: ");
            for (int i = 0; i <= len - 1; i++)
            {
                Console.Write(numsArray[i] + "\t");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("Сумма нечётных элементов массива: ");
            Console.WriteLine(ds.Calculate(numsArray));
            Console.ReadKey();
        }
    }
}
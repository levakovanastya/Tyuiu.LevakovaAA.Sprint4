using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.LevakovaAA.Sprint4.Task3.V20.Lib;
namespace Tyuiu.LevakovaAA.Sprint4.Task3.V20
{
    class Programm
    {
        static void Main(string[] args)
        {
            int[,] mas = new int[5, 5] { { 8, 7, 7, 8, 5 }, 
                                         { 4, 3, 5, 3, 6 }, 
                                         { 5, 3, 8, 6, 3 },
                                         { 6, 3, 8, 5, 4 }, 
                                         { 3, 6, 8, 3, 4 } };
            int rows = mas.GetUpperBound(0) + 1;
            int columns = mas.Length / rows;
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнила: Левакова А.А. | СМАРТб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Одномерные массивы (ввод с клавиатуры)                                  *");
            Console.WriteLine("* Задание 3                                                               *");
            Console.WriteLine("* Вариант #20                                                             *");
            Console.WriteLine("* Выполнила: Левакова А.А. | СМАРТб-25-1                                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
            Console.WriteLine("* статическими значениями в диапазоне от 3 до 8. Найдите минимальный      *");
            Console.WriteLine("* элемент в первом столбце массива.                                       *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Массив:");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{mas[i, j]} \t");
                }
            }

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int res = ds.Calculate(mas);

            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}

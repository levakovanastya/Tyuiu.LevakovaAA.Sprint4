using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.LevakovaAA.Sprint4.Task0.V26.Lib;
namespace Tyuiu.LevakovaAA.Sprint4.Task0.V26
{
    class Programm
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнила: Левакова А.А. | СМАРТб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Одномерные массивы (статический ввод)                                   *");
            Console.WriteLine("* Задание 0                                                               *");
            Console.WriteLine("* Вариант #26                                                             *");
            Console.WriteLine("* Выполнила: Левакова А.А. | СМАРТб-25-1                                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 10 элементов заполненный         *");
            Console.WriteLine("* статическими значениями в диапазоне от 0 до 9 подсчитать сумму нечетных *");
            Console.WriteLine("* элементов массива.  {9 ,3 ,7 ,1 ,5 ,5 ,3 ,2 ,1 ,7}                      *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[] numsArray = { 9, 3, 7, 1, 5, 5, 3, 2, 1, 7 };

            Console.WriteLine("Исходный массив:");

            for (int i = 0; i < numsArray.Length; i++)
            {
                Console.WriteLine(numsArray[i]);
            }


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int nums;
            nums = ds.GetSumOddArrEl(numsArray);

            Console.WriteLine(nums);
            Console.ReadKey();
        }
    }
}

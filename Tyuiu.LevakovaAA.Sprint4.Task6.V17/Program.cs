using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.LevakovaAA.Sprint4.Task6.V17.Lib;
namespace Tyuiu.LevakovaAA.Sprint4.Task6.V17
{
    class Programm
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Random rnd = new Random();

            Console.Title = "Спринт #4 | Выполнила: Левакова А.А. | СМАРТб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Одномерные массивы (ввод с клавиатуры)                                  *");
            Console.WriteLine("* Задание 6                                                               *");
            Console.WriteLine("* Вариант #17                                                             *");
            Console.WriteLine("* Выполнила: Левакова А.А. | СМАРТб-25-1                                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Дан строковый массив данных [Python, JavaScript, Java, C#, Swift,Kotlin *");
            Console.WriteLine("* Ruby] используя класс Array подсчитайте количество элементов,           *");
            Console.WriteLine("* длина которых равна 6.                                                  *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            var p = new string[] { "Python", "JavaScript", "Java", "C#", "Swift", "Kotlin", "Ruby" };

            Console.WriteLine("Исходный массив: ");
            for (int i = 0; i <= p.Length - 1; i++)
            {
                Console.WriteLine(p[i]);
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int res = ds.Calculate(p);

            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}


using Tyuiu.ShmidtAA.Sprint1.Task7.V24.Lib;
namespace Tyuiu.ShmidtAA.Sprint1.Task7.V24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #1 | Выполнил: Шмидт А.А. | ИБКСб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Преобразование классов и тип Convert                              *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #24                                                             *");
            Console.WriteLine("* Выполнил: Шмидт Андрей Андреевич | ИБКСб-24-1                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет математическое выражение по исходным значениям данных                         *");
            Console.WriteLine("* вводимых пользователем. Ответ округлите до 3 знаков после запятой.      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:   x,y (double)                                         *");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                     1+cos(sqrt(x+1))                                    *");
            Console.WriteLine("*                  ----------------------                                 *");
            Console.WriteLine("*                         sin(15y-4)                                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                 double       *");
            Console.WriteLine("***************************************************************************");




            DataService ds = new DataService();

            Console.Write("x=");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("y=");
            double y = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine(ds.Calculate(x,y));
        }
    }
}

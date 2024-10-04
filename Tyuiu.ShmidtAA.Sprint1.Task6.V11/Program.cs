using Tyuiu.ShmidtAA.Sprint1.Task6.V11.Lib;
namespace Tyuiu.ShmidtAA.Sprint1.Task6.V11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #1 | Выполнил: Шмидт А.А. | ИБКСб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: работа со строками класс String                                   *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #7                                                              *");
            Console.WriteLine("* Выполнил: Шмидт Андрей Андреевич | ИБКСб-24-1                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу :пользователь вводит текст.                          *");
            Console.WriteLine("* Проверить, что первая буква строки входит в нее еще раз.                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:   string                                               *");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:      true/false                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();

            string str = Console.ReadLine();

            Console.WriteLine(ds.CheckeFirstLetterRepetition(str));

        }
    }
}

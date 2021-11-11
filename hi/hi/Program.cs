using System;

namespace hi
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0; int num2 = 0;

            Console.WriteLine("Введите первое число:");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите второе число:");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Меню:");

            Console.WriteLine("\ta - выполнить операцию «+»");
            Console.WriteLine("\tb - выполнить операцию «-»");
            Console.WriteLine("\tc - выполнить операцию «*»");
            Console.WriteLine("\td - выполнить операцию «/»");

            Console.WriteLine("Выберите, что вы хотите сделать!!!!!");

            Console.ReadKey();
        }
    }
}

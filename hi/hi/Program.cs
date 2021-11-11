using System;

namespace hi
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0; int num2 = 0;

            Console.WriteLine("Меню:");

            Console.WriteLine("\ta - выполнить операцию «+»");
            Console.WriteLine("\tb - выполнить операцию «-»");
            Console.WriteLine("\tc - выполнить операцию «*»");
            Console.WriteLine("\td - выполнить операцию «/»");

            Console.WriteLine("Выберите, что вы хотите сделать!!!!!");

            switch (Console.ReadLine())
            {
                case "b":
                    Console.WriteLine($"Ваш результат: {num1} - {num2} = " + (num1 - num2));
                    break;
            }

            Console.ReadKey();
        }
    }
}

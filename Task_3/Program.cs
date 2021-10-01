using System;

namespace Task_3
{
   /*
    * Требуется реализовать рекурсивную версию и версию без рекурсии (через цикл).
    */

    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Числа Фибоначчи. Введите число: ");
            int num = int.Parse(Console.ReadLine());
            Fibonacci fib = new();

            if (num >= 45)
            {
                Console.WriteLine(fib.FibonacciSecond(num));
            }
            else
            {
                Console.WriteLine(fib.FibonacciFirst(num));
            }

            Console.ReadKey();
        }       
       
    }
}

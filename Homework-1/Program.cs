using System;

namespace Task_1
{
    /*
     * Требуется реализовать на C# функцию согласно блок-схеме.
     * Блок-схема описывает алгоритм проверки, простое число или нет.
     */
    class Program
    {

        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            NumberBuilder UsersNumber = new(Console.ReadLine());

            UsersNumber.GetTypeOfNumber();

            Console.ReadKey();
        }
    }
}
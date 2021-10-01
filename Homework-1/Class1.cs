using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class NumberBuilder
    {
        public int d = 0;
        int i = 2;
        int input;

        public NumberBuilder(string num) { input = Convert.ToInt32(num); }


        public void GetTypeOfNumber()
        {
            while (i < input)
            {
                if (input % i == 0)
                {
                    d++;
                    i++;
                }
                else i++;
            }
            if (d == 0) Console.WriteLine("Простое");
            else Console.WriteLine("Не простое");
        }
    }
}

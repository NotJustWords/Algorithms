using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Fibonacci
    {
        public long FibonacciFirst(int num) 
        {
            if (num == 0) return 0;
            if (num == 1) return 1;
            else return FibonacciFirst(num - 2) + FibonacciFirst(num - 1);
        }

        public  long FibonacciSecond(int num)
        {
            long[] arr = new long[num + 1];
            arr[0] = 0;
            arr[1] = 1;
            for (int i = 2; i <= num; i++)
            {
                arr[i] = arr[i - 2] + arr[i - 1];
            }
            return arr[num];
        }
    }
}

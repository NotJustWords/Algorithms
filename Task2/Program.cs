using System;

namespace Task2
{
    /*
     * O(n)- линейная зависимость
     */
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new();
            BinarySearch Searcher = new();
            int[] Arr = new int[r.Next(0,10)];
            for (int i = 0; i < Arr.Length; i++)
            {
                Arr[i] = r.Next(0, 11);
                Console.WriteLine(Arr[i]);
            }
            Array.Sort(Arr);
            Console.WriteLine(Searcher.GetNumber(Arr, 3) ); 
        }

        class BinarySearch
        {

            public int GetNumber(int[] inputArr, int searchValue)
            {
                int min = 0;
                int max = inputArr.Length - 1;
                while (min <= max)
                {
                    int mid = (min + max) / 2;
                    if (searchValue == inputArr[mid])
                    {
                        return mid;
                    }
                    else if (searchValue < inputArr[mid])
                    {
                        max = mid - 1;
                    }
                    else
                    {
                        min = mid + 1;
                    }
                }
                return -1;
            }
        }
    }
}

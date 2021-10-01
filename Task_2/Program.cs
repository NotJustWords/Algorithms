﻿using System;

namespace Task_2
{
    class Program
    {        

        public static int StrangeSum(int[] inputArray)
        {
            int sum = 0;                                        //O(1)
            for (int i = 0; i < inputArray.Length; i++)         //O(N)
            {
                for (int j = 0; j < inputArray.Length; j++)     //O(N)
                {
                    for (int k = 0; k < inputArray.Length; k++) //O(N)
                    {
                        int y = 0;                              

                        if (j != 0)                             
                        {
                            y = k / j;                          
                        }

                        sum += inputArray[i] + i + k + j + y;   //O(1  )
                    }
                }
            }

            return sum;                                        //O(1)
            
            /*
             * Сложность алгоритма состовляет: 
             * 
             * 
             * O(N^3)
             * 
             * 
             */
        }
    }
}

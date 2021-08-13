using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
     public int[] solution(int[] A, int K)
        {
            if (A.Length == 0)
            {
                return A;
            }
            int[] temp = new int[A.Length];
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            for (int i = 0; i < K; i++)
            {
                temp = new int[A.Length];
                temp[0] = A[A.Length - 1];


                for (int j = 0; j < A.Length - 1; j++)
                {
                    temp[j + 1] = A[j];
                }

                A = temp;
            }
            return A;
        }
}

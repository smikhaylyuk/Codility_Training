using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A) {
        if (A.Length == 0)
        {
            return 1;
        }
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        int sum1 = 0;
        int sum2 = 0;
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        for (int i = 0; i < A.Length;)
        {
            sum1 = sum1 + (i + 1);
            sum2 = sum2 + A[i];
            i++;
            if (i >= A.Length)
            {
                sum1 = sum1 + (i + 1);
            }
        }
        return sum1 - sum2;
    }
}

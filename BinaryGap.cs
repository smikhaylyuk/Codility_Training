using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int N)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            String binary = Convert.ToString(N, 2);

            int maxGap = 0;
            int currentGap = 0;
            string delimeter = "none";

            for (int i = 0; i < binary.Length; i++)
            {
                if (binary.ToCharArray()[i].Equals('1'))
                {
                    if (delimeter.Equals("none"))
                    {
                        delimeter = "open";
                    }
                    else if (delimeter.Equals("open"))
                    {
                        delimeter = "closed";
                    }

                    if (delimeter.Equals("closed"))
                    {
                        delimeter = "open";
                        if (currentGap > maxGap)
                        {
                            maxGap = currentGap;
                        }
                        currentGap = 0;
                    }

                }
                else if (delimeter.Equals("open") && binary.ToCharArray()[i].Equals('0'))
                {
                    currentGap++;
                }

            }
            return maxGap;
        }
}

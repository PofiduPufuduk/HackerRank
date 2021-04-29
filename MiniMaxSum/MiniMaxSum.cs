using System;
using System.Collections.Generic;
using System.Linq;

class MiniMaxSumSolution
{
    public static void MiniMaxSum(List<int> arr)
    {
        Console.WriteLine(MinValue(arr) + " " + MaxValue(arr));
    }

    static long MaxValue(List<int> arr)
    {
        long Max = 0;
        foreach (var x in arr)
        {
            Max = x + Max;
        }
        Max -= arr.Min();
        return Max;
    }

    static long MinValue(List<int> arr)
    {
        long Min = 0;
        foreach (var x in arr)
        {
            Min = x + Min;
        }
        Min -= arr.Max();
        return Min;
    }
}

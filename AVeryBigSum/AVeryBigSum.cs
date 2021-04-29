using System;
using System.Collections.Generic;

internal class AVeryBigSumSolution
{
    public static long AVeryBigSum(List<long> ar)
    {
        long total = 0;
        foreach (long x in ar)
        {
            total += x;
        }
        return total;
    }
}

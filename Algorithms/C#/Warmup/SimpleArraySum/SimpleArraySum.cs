using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

internal class SimpleArraySumSolution
{
    public static int SimpleArraySum(List<int> ar)
    {
        int total = 0;

        foreach (int x in ar)
        {
            total += x;
        }

        return total;
    }
}

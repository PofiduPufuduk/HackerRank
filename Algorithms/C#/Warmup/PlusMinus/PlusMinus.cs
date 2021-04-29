using System;
using System.Collections.Generic;

internal class PlusMinusSolution
{

    /*
    * I think this solution is bad. It can be solved in a better way. (En)
    *
    * Bu çözümün kötü olduğunu düşünüyorum. Daha iyi bir şekilde çözülebilir. (Tr)
    */

    public static void PlusMinus(List<int> arr)
    {
            decimal positive = 0;
            decimal negative = 0;
            decimal zero = 0;

            foreach (var x in arr)
            {
                if (x > 0)
                {
                    positive++;
                }
                else if (x < 0)
                {
                    negative++;
                }
                else
                {
                    zero++;
                }
            }
            positive /= arr.Count;
            negative /= arr.Count;
            zero /= arr.Count;

            Console.WriteLine(positive);
            Console.WriteLine(negative);
            Console.WriteLine(zero);
    }
}
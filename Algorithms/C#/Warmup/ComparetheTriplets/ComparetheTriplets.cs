using System;
using System.Collections.Generic;
internal class ComparetheTripletsSolutions
{
        static readonly List<int> Point = new List<int>();
        public static List<int> CompareTriplets(List<int> a, List<int> b)
        {
            int alice = 0;
            int bob = 0;

            for (int i = 0; (i < a.Count || i < b.Count); i++)
            {

                if (a[i] > b[i])
                {
                    alice++;
                }
                else if (a[i] < b[i])
                {
                    bob++;
                }
                else
                {
                    // No point
                }

            }

            Point.Add(alice);
            Point.Add(bob);

            return Point;

        }
}

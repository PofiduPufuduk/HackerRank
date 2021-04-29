using System;
using System.Collections.Generic;
using System.Linq;

class BirthdayCakeCandlesSolution
{
    static int bigNum;
    static int candle;
    public static int BirthdayCakeCandles(List<int> candles)
    {
        bigNum = candles.Max();

        foreach (int x in candles)
        {
            if (x == bigNum)
            {
                candle++;
            }
        }
        return candle;
    }
}

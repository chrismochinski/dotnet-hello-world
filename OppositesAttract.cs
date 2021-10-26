using System;

public class LoveDetector
{
    public static bool lovefunc(int flower1, int flower2)
    {
        if ((flower1 % 2 == 0) && (flower2 % 2 == 1))
        {
            return true;

        }
        else if ((flower2 % 2 == 0) && (flower1 % 2 == 1))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
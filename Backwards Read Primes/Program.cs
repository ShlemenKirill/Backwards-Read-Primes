using System;

namespace Backwards_Read_Primes
{
    public class BackWardsPrime
    {

        public static string BackwardsPrime(long start, long end)
        {
            string res = "";
            for (long i = start; i <= end; i++)
            {
                if (IsPrime(i) && IsPrime(Revers(i)) && i != Revers(i))
                {
                    res = res + i + " ";

                }
            }

            return res.Trim();
        }

        public static bool IsPrime(long number)
        {

            if (number > 2 && number % 2 == 0) return false;
            int top = (int)Math.Sqrt(number) + 1;
            for (long j = 3; j < top; j += 2)
            {

                if (number % j == 0)
                {
                    return false;

                }

            }

            return true;
        }
        public static long Revers(long number)
        {
            string s = "";

            while (number > 0)
            {
                s += number % 10;
                number /= 10;

            }


            return long.Parse(s);
        }
    }
    
}
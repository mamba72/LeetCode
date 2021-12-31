using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediumProblems
{
    internal class ImplementingPow
    {
        //solving this problem: https://leetcode.com/problems/powx-n/
        public static void PowTester()
		{
            double x = 1.00001;
            int n = 123456;
            Console.WriteLine(MyPow(x, n));
		}

        public static double MyPow(double x, int n)
        {
            if (x == 0 || x == 1)
                return x;

            if (n > 15000)
                return CoolAdditionChain(x, n); //IterativePower(x, n);
            else if (n < -15000)
                return 1 / CoolAdditionChain(x, n);

            if (n == 0)
                return 1;

            if(n > 0) // if positive
			{
                return RecPower(x, n);
			}else if (n == int.MinValue)
			{
                return 1 / RecPower(x * x, Math.Abs(n + 1));
			}
            else // if n is negative
			{
                return 1 / RecPower(x, Math.Abs(n));
			}
        }

        public static double RecPower(double x, int n)
		{
            if (n == 1)
                return x;
            return x * RecPower(x, n - 1);
        }

        public static double IterativePower(double x, int n)
		{
            double total = 1;
            if(n == int.MinValue)
			{
                total = x;
                n += 1;
			}

            for(int i = 0; i < Math.Abs(n); i++)
			{
                total *= x;
			}
            if (n > 0)
                return total;
            else
                return 1 / total;
		}

        public static double CoolAdditionChain(double x, int n)
		{
            double total = 1;
            double curX = x;


            if(n == int.MinValue)
			{
                n += 1;
                total = x;
			}
            n = Math.Abs(n);

            if (n > 1)
            {
                curX *= x;
            }
            else
			{
                return x;
			}

            //iterate through the exponent, but increment by 2.
            int i;//out here so I can use it again for the if statement
            for (i = 0; i < n / 2; ++i)
			{
                total = Math.Round(total * curX, 7);

                if (total == double.PositiveInfinity)
                    return double.PositiveInfinity;
			}

            //if i is still less than n, which it should only be by 1, then multiply by the og x
            if(i != n)
                total *= x;

            return total;

		}

  //      public static double RecAddChain(double x, int n)
		//{
  //          if (n == 1)
  //              return x;
  //          if(n > 4)
  //          return x*x * RecAddChain(x)
		//}
    }
}

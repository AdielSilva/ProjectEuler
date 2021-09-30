using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public class LargestPrimeFactor
    {
        public static void Calculate()
        {
            long result = GetLargestNumber(600851475143L);

            Console.WriteLine(result);
            Console.ReadKey();
        }


        public static long GetLargestNumber(long number)
        {
            for (long i = 2; i < number; i++)
            {
                while (number % i == 0)
                {//for yes
                    number = number / i;

                }
            }
            return number;
        }


    }
}

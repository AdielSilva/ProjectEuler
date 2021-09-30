using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    //If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.

    //Find the sum of all the multiples of 3 or 5 below 1000.

    // I used SOLID here, that is the reason for the extensive code
    public class Multiple3or5
    {
        public static void Calculate()
        {
            List<int> numbers = FindNumbers(1000);
            int result = Sum(numbers);

            Console.WriteLine(result);
            Console.ReadKey();
        }
       

        public static List<int> FindNumbers(int number)
        {
            //result of number divide by 5 == 0 || result of number divide by 3 == 0
            var numbers = new List<int>();
            for (int i = 0; i < number; i++)
            {
                if(i % 3 == 0 || i % 5 == 0)
                {
                    numbers.Add(i);
                }
            }
            return numbers;
        }

        public static int Sum (List<int> numbers)
        {
            int result = 0;
            foreach (var item in numbers)
            {
                result += item;
            }

            return result;
        }
    }
}

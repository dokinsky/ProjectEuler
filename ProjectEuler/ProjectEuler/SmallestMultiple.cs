using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler
{
    class SmallestMultiple : Question
    {
        // 2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
        // What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?
        public SmallestMultiple() 
        {
            question = @"2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.  What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?";

            long number = 1;
            bool repeat = true;
            while (repeat)
            {
                number++;
                int div = 20;
                for (int i = 1; i <= div; i++)
                {
                    if (number % i != 0)
                        break;
                    if (i == div)
                        repeat = false;
                }
            }

            answer = number.ToString(); ;
            Console.WriteLine(A);

        }
    }
}

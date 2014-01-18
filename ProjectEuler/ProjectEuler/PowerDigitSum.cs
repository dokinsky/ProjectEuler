using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ProjectEuler
{
    //2^15 = 32768 and the sum of its digits is 3 + 2 + 7 + 6 + 8 = 26.
    //What is the sum of the digits of the number 21000?

    class PowerDigitSum : Question
    {
        public PowerDigitSum()
        {
            
            question = @"2^15 = 32768 and the sum of its digits is 3 + 2 + 7 + 6 + 8 = 26.
What is the sum of the digits of the number 2^1000?";

            int exp = 15;
            double number = (double)Math.Pow(2, exp);

            Console.WriteLine(number);
            string numberString = number.ToString();

            int sum = 0;
            foreach (var n in numberString)
            {
                sum += int.Parse(n.ToString());
            }

            Console.WriteLine(sum);

            
        }
    }
}

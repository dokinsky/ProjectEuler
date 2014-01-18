using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler
{
    class DoubleBasePalindrome : Question
    {
        //he decimal number, 585 = 10010010012 (binary), is palindromic in both bases.
        //Find the sum of all numbers, less than one million, which are palindromic in base 10 and base 2.
        //(Please note that the palindromic number, in either base, may not include leading zeros.)

        public DoubleBasePalindrome()
        {
            question = @"he decimal number, 585 = 10010010012 (binary), is palindromic in both bases.
Find the sum of all numbers, less than one million, which are palindromic in base 10 and base 2.
(Please note that the palindromic number, in either base, may not include leading zeros.)";

            number = 36;
            int doublePalindromeSum = 0;

            for (int i = 1; i <= 1000000; i++)
            {
                string binary = Convert.ToString(i, 2);

                if (isPalindrome(i.ToString()) && isPalindrome(binary))
                {
                    //Console.WriteLine(i + " : " + binary);
                    doublePalindromeSum += i;
                }
            
            }

            answer = doublePalindromeSum.ToString();

            display();

        }

        public bool isPalindrome(string s)
        {
            for (int i = 0; i < s.Length / 2; i++)
            {
                if (s[i] != s[s.Length - i - 1])
                    return false;
            }
            return true;
        }
    }
}

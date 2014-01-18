using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler
{
    class _10001stprime : Question
    {
        //By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.
        //What is the 10 001st prime number?
        
        List<long> primeNumbers = new List<long>();
        public _10001stprime()
        {
            question = @"By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.  What is the 10 001st prime number?";
            number = 7;
            primeNumbers.Add(2);
            int highestPrimeNum = 10001;
            int i = 1;
            while (primeNumbers.Count < highestPrimeNum) 
            {
                i++;
                bool prime = false;
                for (int j = 0; j < primeNumbers.Count; j++)
                {
                    if (i % primeNumbers[j] == 0)
                        break;

                    if (primeNumbers.Count - 1 == j)
                        prime = true;
                }
                if (prime)
                    primeNumbers.Add(i);
                
            }

            answer = primeNumbers[highestPrimeNum - 1].ToString();

            display();
        }
    }
}

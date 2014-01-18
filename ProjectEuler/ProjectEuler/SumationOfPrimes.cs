using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler
{
    //The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.
    //Find the sum of all the primes below two million.
    
    class SumationOfPrimes : Question
    {
        public SumationOfPrimes()
        {
            question = "The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17. Find the sum of all the primes below two million.";
            number = 10;

            List<long> primeNumbers = new List<long>();

            primeNumbers.Add(2);
            int highestNumber = 2000000;
            int i = 1;
            while (i < highestNumber)
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

            long sum = 0;
            foreach (var p in primeNumbers)
            {
                sum += p;
            }

            Console.WriteLine(sum);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler
{
    class TriangleProblem : Question
    {
        public TriangleProblem()
        {
            int divs = 0;
            
            long num = 0;
            int count = 0;
            while(divs <= 500)
            {
                count++;
                num = factorial(count);
                divs = findDivisors(num);
                if (divs > 300) Console.WriteLine(count + ":" + num + ":" + divs);
            }

            Console.WriteLine("ANSWER");
            Console.WriteLine(num);
            

        }

        public long factorial(long x)
        {
            long sum = 0;
            for (long i = 1; i <= x; i++)
            {
                sum += i;
            }

            return sum;
        }

        public int findDivisors(long x)
        {
            if (x % 2 == 0) x = x / 2;
            int div = 1;
            int count = 0;

            while (x % 2 == 0)
            {
                count++;
                x = x / 2;
                    
            }

            div = div * (count + 1);
            int p = 3;

            while (x != 1)
            {
                count = 0;
                while (x % p == 0)
                {
                    count = 0;
                    x = x / p;
                }
                div = div * (count + 1);
                p += 2;
            }


            return div;
            
        }
    }
}

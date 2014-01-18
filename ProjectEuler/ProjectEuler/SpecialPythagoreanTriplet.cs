using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler
{
    //A Pythagorean triplet is a set of three natural numbers, a < b < c, for which,
    //a2 + b2 = c2
    //For example, 32 + 42 = 9 + 16 = 25 = 52.

    //There exists exactly one Pythagorean triplet for which a + b + c = 1000.
    //Find the product abc.

    class SpecialPythagoreanTriplet : Question
    {
        public SpecialPythagoreanTriplet()
        {
            number = 9;
            question = 
@"
A Pythagorean triplet is a set of three natural numbers, a < b < c, for which,
           a2 + b2 = c2
           For example, 32 + 42 = 9 + 16 = 25 = 52.
                       
There exists exactly one Pythagorean triplet for which a + b + c = 1000.
Find the product abc.";

            //List<triplet> tripletList = new List<triplet>();

            triplet newTrip = findTriple(1000);

            answer = newTrip.product.ToString();
            
            display();
            

            

        }

        public triplet findTriple(int tripSum)
        {
            for (int i = 1; i < 1000; i++)
            {
                for (int j = 1; j < 1000; j++)
                {
                    if (j > i)
                    {
                        double k = Math.Sqrt((i * i) + (j * j));
                        if (k % 1 == 0)
                        {
                            triplet trip = new triplet(i, j, (int)k);
                            if (trip.sum == tripSum)
                                return  trip;
                        }
                    }
                }
            }
            return new triplet(0, 0, 0);
        }

        
        
    }
    public class triplet
    {
        public int a;
        public int b;
        public int c;

        public triplet(int i, int j, int k)
        {
            a = i;
            b = j;
            c = k;
        }

        public int sum
        {
            get { return a + b + c; }
        }

        public int product
        {
            get { return a * b * c; }
        }

        public override string ToString()
        {
            return a + ":" + b + ":" + c;
        }

    }
}

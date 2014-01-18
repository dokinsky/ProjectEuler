using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler
{
    class DiceGame : Question
    {
        public DiceGame()
        {
            Roller Peter = new Roller(9, 4);
            Roller Colin = new Roller(6, 6);

            Random r = new Random();

            List<double> percentList = new List<double>();

            for (int x = 0; x < 20; x++)
            {
                long rolls = 1000000000;
                int peteWins = 0;
                for (int i = 0; i < rolls; i++)
                {
                    int P = Peter.RollDice(r);
                    int C = Colin.RollDice(r);
                    if (P > C)
                        peteWins++;
                }

                double percent = (double)peteWins / (double)rolls;

                Console.WriteLine(percent);
                percentList.Add(percent);
            }

            Console.WriteLine("");
            
            Console.WriteLine(percentList.Average());
            
            

        }
    }

    class Roller
    {
        List<Die> diceList = new List<Die>();

        public Roller(int diceCount, int dieSides)
        {
            while (diceList.Count <= diceCount)
                diceList.Add(new Die(dieSides));
        }

        public int RollDice(Random r)
        {
            int sum = 0;
            foreach (var d in diceList)
            {
                sum += d.roll(r);
            }

            return sum;
        }

    }

    class Die
    {
        public int sides;

        public Die(int s)
        {
            sides = s;
        }

        public int roll(Random r)
        {
            return r.Next(1, sides);
        }
    
    }
}

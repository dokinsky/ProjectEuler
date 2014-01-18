using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler
{
    class CountingSundays : Question
    {
        //You are given the following information, but you may prefer to do some research for yourself.

        //1 Jan 1900 was a Monday.
        //Thirty days has September,
        //April, June and November.
        //All the rest have thirty-one,
        //Saving February alone,
        //Which has twenty-eight, rain or shine.
        //And on leap years, twenty-nine.
        //A leap year occurs on any year evenly divisible by 4, but not on a century unless it is divisible by 400.
        //How many Sundays fell on the first of the month during the twentieth century (1 Jan 1901 to 31 Dec 2000)?


        public CountingSundays()
        {
            number = 19;
            question = @"You are given the following information, but you may prefer to do some research for yourself.

1 Jan 1900 was a Monday.
Thirty days has September,
April, June and November.
All the rest have thirty-one,
Saving February alone,
Which has twenty-eight, rain or shine.
And on leap years, twenty-nine.
A leap year occurs on any year evenly divisible by 4, but not on a century unless it is divisible by 400.
How many Sundays fell on the first of the month during the twentieth century (1 Jan 1901 to 31 Dec 2000)?";

            int year = 01;
            int day = 2;
            int sundays = 0;
            int[] months = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            if (year % 4 == 0)
                months = new int[] { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            while (year <= 100)
            {
                int sundaysPerYear = 0;
                for (int m = 0; m < months.Length; m++)
                {
                    for (int d = 0; d < months[m]; d++)
                    {
                        if (day == 7) day = 0;
                        if (d == 0 && day == 0)
                            sundaysPerYear++;
                        day++;
                    }
                }
                //Console.WriteLine(sundaysPerYear + " : " + year);
                sundays += sundaysPerYear;
                year++;
            }

            answer = sundays.ToString();



            display();
                
        }
    }
}

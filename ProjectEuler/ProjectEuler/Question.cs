using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler
{
    class Question
    {
        public string question;
        public string answer;
        public int number;
        public Question()
        {
            
        }

        public string Q
        {
            get { return "Question " + number.ToString() + ": " + question; }
        }

        public string A
        {
            get { return  "Answer: " + answer; }
        }

        public string Number
        {
            get { return "Question Number: " + number; }
        }

        public void display()
        {
            //Console.WriteLine(Number);
            Console.WriteLine(Q);
            Console.WriteLine("");
            Console.WriteLine(A);
        }
    }
}

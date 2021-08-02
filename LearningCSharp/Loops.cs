using System;
using System.Collections.Generic;
using System.Text;

namespace LearningCSharp
{
    class Loops
    {
        public void UseWhile(int num)  // num = 5;
        {
            int i = 0; // Initialization
            while (i < num)  // Condition
            {
                Console.WriteLine(i);
                i++; // Terminating Condition
            }
        }

        public void UseDoWhile(int num)
        {
            int i = 0;
            do
            {
                Console.WriteLine(i);
                i++;
            } while (i < num);
        }

        public void UseFor(int num)
        {
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine(i);
            }
        }

        public void Factorial(int num)
        {
            int fact = 1;
            
            for (int i = 1; i <= num; i++)
            {
                fact = fact * i;                    
            }
            Console.WriteLine(fact);
        }
        //Palindrome  ==> 121 11  ==> Naman, Madam , Malayalam, xyzabccbazyx , xyzmadamyx
        //Armstrong Number
        // Swap
        //Anagram   ==> cat  tac  atc  



    }
}

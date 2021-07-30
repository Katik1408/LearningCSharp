using System;
using System.Collections.Generic;
using System.Text;

namespace LearningCSharp
{
    class ControlStatement
    {
        //Press F10
        public void useIf(int a, int b)
        {
            if (a > b)
            {
                Console.WriteLine("A is greater");
            }
            else
            {
                Console.WriteLine("B is greater");
            }
        }

        public void UseNestedIf(int a, int b, int c)
        {
            // 14,5,6
            if (a > b)
            {
                if (a > c)
                {
                    Console.WriteLine("A is greatest");
                }
                else
                {
                    Console.WriteLine("A is greater than b but less than c ");
                }
            }
            else
            {
                Console.WriteLine("A is less than B");
            }
        }

        //== means the comparison operator
        public void useLadderIf(int a, int b)
        {

            if (a > b)
            {
                Console.WriteLine("A is greater");
            }
            else if(a == b)
            {
                Console.WriteLine("A and B both are Same");
            }
            else
            {
                Console.WriteLine("B is greater");
            }
        }


        public void Calc(int a,int b,char c)
        {

            Arithmatic arith = new Arithmatic();

            switch (c)
            {
                case '+':
                    Console.WriteLine(arith.Add(a, b));
                    break;
                default:
                    Console.WriteLine("Invalid Character");
                    break;
                case '-':
                    int res = a - b;
                    Console.WriteLine(res);
                    break;
            }
        }


    }
}

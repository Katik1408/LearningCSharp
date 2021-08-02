using System;
using System.Collections.Generic;
using System.Text;

namespace LearningCSharp
{
    class Arithmatic
    {

        public Arithmatic()
        {
            Console.WriteLine("Inside Arithmetic Class");
        } //Non-Parametrized Ctor

       
        public int Add(int a,int b)
        {

            return a + b;
        }


        public void Sub(int a,int b)
        {
            int c = a - b;
       
            Console.WriteLine(c);
        }




    }
}

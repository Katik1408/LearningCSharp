using System;
using System.Collections.Generic;
using System.Text;

namespace LearningCSharp.OOPS.Polymorphism
{
    class B : A
    {
        public override void GetData()
        {
            Console.WriteLine("Inside the GetData of class B");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace LearningCSharp.OOPS.Polymorphism
{
    class Example
    {
        string name;

        public void Show()
        {
            name = "John";
            Console.WriteLine("Name is {0} " , name);
        }

        public void Show(string name)
        {
            this.name = name;
            Console.WriteLine("Name is {0} ",this.name);
        }


    }
}

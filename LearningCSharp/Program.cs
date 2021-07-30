using System;

namespace LearningCSharp
{
    class Program
    {
        static int yoe;  // Global Variable for this class

        const float pi = 3.14F;
        readonly int f;
        int _a;
        int a;
        int A;
        bool IsEmployed = true;
        static void Main(string[] args)
        {
            yoe = 6;
            int d = 7;   // Local Variable
            //Console.WriteLine("Learning CSharp");   // Strings

            //ClassName obj = new ClassName(); 

            //Arithmatic arith = new Arithmatic();


            Console.WriteLine("Enter 2 values");

            int num1 = Convert.ToInt32(Console.ReadLine());

            int num2 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Enter Operator from +,-");

            char sign = Convert.ToChar(Console.ReadLine());

            ControlStatement cs = new ControlStatement();

            // cs.useIf(num1,num2);
            cs.Calc(num1,num2,sign);


            //Console.WriteLine("Substraction is");
            //arith.Sub(num1, num2);

            //Console.WriteLine(arith.Add());
        }

        //Function
    }
}


//Data Members and Member Function
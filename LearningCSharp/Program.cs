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


            //Console.WriteLine("Enter a value");

            //int num1 = Convert.ToInt32(Console.ReadLine());

            //Loops loop = new Loops();
            //loop.UseWhile(num1);
            //loop.UseDoWhile(num1);
            //loop.UseFor(num1);
            //loop.Factorial(num1);
            //int num2 = Convert.ToInt32(Console.ReadLine());


            //Console.WriteLine("Enter Operator from +,-");

            //char sign = Convert.ToChar(Console.ReadLine());

            //ControlStatement cs = new ControlStatement();

            //// cs.useIf(num1,num2);
            //cs.Calc(num1,num2,sign);


            //Console.WriteLine("Substraction is");
            //arith.Sub(num1, num2);

            //Console.WriteLine(arith.Add());


            //int[] arr = new int[5];
            string[] cars = new string[5];
            //arr[0] = 1;
            //arr[1] = 2;
            //arr[2] = 3;
            //arr[3] = 4;
            //arr[4] = 5;
            Console.WriteLine("Enter 5  values");

            for (int i = 0; i < cars.Length; i++)
            {
                cars[i] = Console.ReadLine();
            }


            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine(cars[i]);
            }


            //foreach (string car in cars)
            //{
            //    Console.WriteLine(car);
            //}

            
        }

        //Function
    }
}


//Data Members and Member Function
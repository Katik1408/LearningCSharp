using System;
using System.Collections.Generic;
using System.Text;

namespace LearningCSharp.OOPS
{
    class Employee
    {
        int EmpId;
        string Name;
        long Contact;
        string Place;
        DateTime DoJ;
        // DateTime DoB;
        int d;

        //this is a special Keyword which holds the current class object

        public Employee()
        {
            Console.WriteLine("Inside Employee Constructor");
        }


        public Employee(int EmpId, string Name, long Contact, string Place, DateTime DoJ)
        {
            this.EmpId = EmpId;
            this.Name = Name;
            this.Contact = Contact;
            this.Place = Place;
            this.DoJ = DoJ;
            //this.DoB = DoB;
        }


        public void GetEmployeeName()
        {
            Console.WriteLine("EmployeeName --->  {0} DateOfJoining ----> {1} , Age ---> {2} ", Name, DoJ);
        }

        public int GetAge(DateTime dob)
        {
            //Logic to Calculate the Date
            return 0;
        }

    }
}

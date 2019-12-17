using System;

namespace PartialClassAndMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            //partial class
            /*
            PartialEmployee emp = new PartialEmployee();
            emp.FirstName = "Pranaya";
            emp.LastName = "Rout";
            emp.Salary = 100000;
            emp.Gender = "Male";
            emp.DisplayFullName();
            emp.DisplayEmployeeDetails();
            Console.WriteLine("Press any key to exist.");
            */

            //partial method
            PartialClass SC = new PartialClass();
            SC.PublicMethod();
        
            Console.WriteLine("Press any key to exist.");
            Console.ReadKey();

            Console.ReadKey();


        }
    }

}

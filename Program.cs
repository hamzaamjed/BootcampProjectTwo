using System;

namespace BootcampProjectTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp;
            int chooseDesignation;
            Console.WriteLine(" ***** CureMD *****");
            Console.WriteLine("\nEmployees Designations: ");
            Console.WriteLine(" 1. Engineer \n 2. Manager \n 3. Analyst ");
            Console.Write("\n Choose Your Designation For GrossSalary: ");
            chooseDesignation = Convert.ToInt32(Console.ReadLine());

            switch (chooseDesignation)
            {
                case 1:

                    emp = new Engineer();
                    Console.WriteLine("Gross Salary: " + emp.CreateSalarySlip());

                    break;
                case 2:

                    emp = new Manager();
                    Console.WriteLine("Gross Salary: " + emp.CreateSalarySlip());

                    break;
                case 3:

                    emp = new Analyst();
                    Console.WriteLine("Gross Salary: " + emp.CreateSalarySlip());
                    break;
                default:
                    break;
            }
        }
    }
}

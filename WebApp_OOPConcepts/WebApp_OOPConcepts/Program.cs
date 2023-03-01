using System;

namespace WebApp_OOPConcepts
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("*********************");
                Console.WriteLine("*My first Date Class*");
                Console.WriteLine("*********************");
                Console.WriteLine("");

                Console.WriteLine("Please type your year: ");
                int year = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");

                Console.WriteLine("Please type your month: ");
                int month = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");

                Console.WriteLine("Please type your day: ");
                int day = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");

                var dateObject = new Date(year, month, day);
                Console.WriteLine("The date entered is: " + dateObject);
                Console.WriteLine("");

                Employee salaryEmployee = new SalaryEmployee()
                {
                    Id = 1,
                    FirstName = "Patricia",
                    LastName = "Álvarez",
                    BirthDate = dateObject,
                    HiringDate = dateObject,
                    IsActive = true,
                    Salary = 1160000
                };

                Console.WriteLine(salaryEmployee);
                Console.WriteLine("");

                Employee commissionEmployee = new CommissionEmployee()
                {
                    Id = 1,
                    FirstName = "Julio",
                    LastName = "Pérez",
                    BirthDate = dateObject,
                    HiringDate = dateObject,
                    IsActive = false,
                    CommissionPercentage = 5,
                    Sales = 20000000
                };

                Console.WriteLine(commissionEmployee);

            }
            catch (Exception message)
            {
                Console.WriteLine(message);
            }
        }
    }
}

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
            }
            catch (Exception message)
            {
                Console.WriteLine(message);
            }
        }
    }
}

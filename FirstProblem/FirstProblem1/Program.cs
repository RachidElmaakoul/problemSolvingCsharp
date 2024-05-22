using System.Diagnostics;

namespace FirstProblem1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double Tax = 0.03;

            Console.Write("First Name : ");
            var fName = Console.ReadLine();

            Console.Write("Last Name : ");
            var LName = Console.ReadLine();

            Console.Write("Wage : ");
            var Wage = Convert.ToDouble(Console.ReadLine());

            Console.Write("LoggedHours : ");
            var LoggedHoures = Convert.ToDouble(Console.ReadLine());

            var NetSalary = Wage * LoggedHoures - (Wage * LoggedHoures * Tax);



            Console.WriteLine("\n==============================================\n");

            Console.WriteLine($"First Name   : {fName}");
            Console.WriteLine($"Last Name    : {LName}");
            Console.WriteLine($"Wage         : {Wage}");
            Console.WriteLine($"LoggedHoures : {LoggedHoures}");
            Console.WriteLine($"Nat Sallary  : {NetSalary}");





        }
    }
}

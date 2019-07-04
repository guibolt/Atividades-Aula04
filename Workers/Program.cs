using System;
using Workers.Entities;
using Workers.Entities.Enums;
using System.Globalization;
namespace Workers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter department's name");
            string dept = Console.ReadLine();
            Console.WriteLine("Enter worker data");
            Console.WriteLine("Name");
            string name = Console.ReadLine();
            Console.WriteLine("Level: JUNIOR, MIDLEVEL OR SENIOR");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine().ToUpper());
            Console.WriteLine("Base Salary:");
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Department d = new Department(dept);
            Worker t = new Worker(name, level, salario, d);

            Console.WriteLine("How many contracts to this worker");
            int n = Convert.ToInt32(Console.ReadLine());




            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} contract data:");
                Console.WriteLine("Date (DD)/MM/YYYY):");
                DateTime data = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Value per hour");
                double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("Duration(HRS)");
                int hrs = int.Parse(Console.ReadLine());

                HourContract contrato = new HourContract(data, value, hrs);

                t.AddContract(contrato);
              

                Console.WriteLine($" Contract Validation Code:{Guid.NewGuid()}");

            }

            Console.WriteLine();
            Console.WriteLine("Enter the date to calculate MM/YY");
            string mesEano = Console.ReadLine();
            int month = int.Parse(mesEano.Substring(0, 2));
            int year = int.Parse(mesEano.Substring(3));


            Console.WriteLine($"Name: {t.Name}");
            Console.WriteLine($"Department:{t.Department.Name}");
            Console.WriteLine($"Income: {t.Income(month, year)}");

        }
    }
}

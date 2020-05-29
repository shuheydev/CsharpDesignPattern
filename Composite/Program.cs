using System;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            var john = new Developer("John Doe", 12000);
            var jane = new Designer("Jane Doe", 15000);

            var organization = new Organization();
            organization.AddEmployee(john);
            organization.AddEmployee(jane);

            Console.WriteLine($"正味の給与: {organization.GetNetSalaries()}");
        }
    }
}

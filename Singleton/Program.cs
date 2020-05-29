using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            var president1 = President.GetInstance();

            var president2 = President.GetInstance();

            Console.WriteLine(president1 == president2);//True
        }
    }
}

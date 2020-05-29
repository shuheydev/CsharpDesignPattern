using System;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            var darkTheme = new DarkTheme();
            var aquaTheme = new AquaTheme();

            var about = new About(darkTheme);
            var careers = new Carrers(aquaTheme);

            Console.WriteLine(about.GetContent());
            Console.WriteLine(careers.GetContent());
        }
    }
}

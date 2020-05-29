using System;

namespace SimpleFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            var door = DoorFactory.MakeDoor(100, 200);

            Console.WriteLine($"{door.GetWidth()}  {door.GetHeight()}");
        }
    }
}

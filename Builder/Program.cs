using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            var burgerBuilder = new BurgerBuilder(24);

            var burger = burgerBuilder.AddCheese()
                .AddPepperoni()
                .AddTomato()
                .Build();

            burger.Description();
        }
    }
}

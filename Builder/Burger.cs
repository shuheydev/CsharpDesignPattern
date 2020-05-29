using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public class Burger
    {
        int size;
        bool cheese;
        bool pepperoni;
        bool lettuce;
        bool tomato;

        public Burger(BurgerBuilder builder)
        {
            this.size = builder.Size;
            this.cheese = builder.Cheese;
            this.pepperoni = builder.Pepperoni;
            this.lettuce = builder.Lettuce;
            this.tomato = builder.Tomato;
        }

        public void Description()
        {
            Console.WriteLine($"Order:\n" +
                            $"size:{this.size}\n" +
                            $"cheese:{this.cheese}\n" +
                            $"pepperoni:{this.pepperoni}\n" +
                            $"lettuce:{this.lettuce}\n" +
                            $"tomato:{this.tomato}");
        }
    }
}

namespace Builder
{
    public class BurgerBuilder
    {
        public int Size;

        public bool Cheese = false;
        public bool Pepperoni = false;
        public bool Lettuce = false;
        public bool Tomato = false;


        public BurgerBuilder(int size)
        {
            this.Size = size;
        }

        public BurgerBuilder AddPepperoni()
        {
            this.Pepperoni = true;
            return this;
        }

        public BurgerBuilder AddLettuce()
        {
            this.Lettuce = true;
            return this;
        }

        public BurgerBuilder AddCheese()
        {
            this.Cheese = true;
            return this;
        }

        public BurgerBuilder AddTomato()
        {
            this.Tomato = true;
            return this;
        }

        public Burger Build()
        {
            return new Burger(this);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    class Human
    {
        public string Name;
        public int Height = -1;
        public int Weight = -1;
        public int Age = -1;

        public Human(string name,int height,int weight,int age)
        {
            this.Name = name;
            this.Height = height;
            this.Weight = weight;
            this.Age = age;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    class NewHumanComparator
    {
        private IComparator comparator;

        public NewHumanComparator(IComparator comparator)
        {
            this.comparator = comparator;
        }

        public string Compare(Human h1, Human h2)
        {
            return this.comparator.Compare(h1, h2) switch
            {
                1 => $"{h1.Name} だよ",
                0 => $"{h1.Name} と {h2.Name} は同じだよ",
                -1 => $"{h2.Name} だよ",
                _ => throw new InvalidOperationException()
            };
        }
    }



    interface IComparator
    {
        public int Compare(Human h1, Human h2);
    }

    class AgeComparator : IComparator
    {
        public int Compare(Human h1, Human h2)
        {
            //年齢の比較
            if (h1.Age > h2.Age)
            {
                return 1;
            }
            else if (h1.Age == h2.Age)
            {
                return 0;
            }
            else
            {
                return -1;
            }
        }
    }

    class HeightComparator : IComparator
    {
        public int Compare(Human h1, Human h2)
        {
            //年齢の比較
            if (h1.Height > h2.Height)
            {
                return 1;
            }
            else if (h1.Height == h2.Height)
            {
                return 0;
            }
            else
            {
                return -1;
            }
        }
    }

    class WeightComparator : IComparator
    {
        public int Compare(Human h1, Human h2)
        {
            //年齢の比較
            if (h1.Weight > h2.Weight)
            {
                return 1;
            }
            else if (h1.Weight == h2.Weight)
            {
                return 0;
            }
            else
            {
                return -1;
            }
        }
    }
}

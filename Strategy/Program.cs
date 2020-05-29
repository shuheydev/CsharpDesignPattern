using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            //使う側はスッキリ

            //年齢で比較する
            var newHC = new NewHumanComparator(new AgeComparator());

            Human john = new Human("John", 180, 90, 23);
            Human tom = new Human("Tom", 170, 65, 40);

            Console.WriteLine(newHC.Compare(john, tom));//Tomだよ
        }
    }
}

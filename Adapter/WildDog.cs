using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    //これをゲームに加える必要がある
    class WildDog
    {
        public void Bark()
        {
            Console.WriteLine($"わんわん");
        }
    }

    class WildDogAdapter:ILion
    {
        private readonly WildDog dog;

        public WildDogAdapter(WildDog dog)
        {
            this.dog = dog;
        }

        //Roarメソッドの中でBarkメソッドを呼ぶ
        public void Roar()
        {
            this.dog.Bark();
        }
    }
}

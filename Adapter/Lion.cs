using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    public interface ILion
    {
        void Roar();
    }

    class AfricanLion : ILion
    {
        public void Roar()
        {
            Console.WriteLine("がおー");
        }
    }

    class AsianLion : ILion
    {
        public void Roar()
        {
            Console.WriteLine("ぐおー");
        }
    }
}

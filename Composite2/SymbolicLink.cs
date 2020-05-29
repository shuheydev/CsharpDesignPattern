using System;
using System.Collections.Generic;
using System.Text;

namespace Composite2
{
    class SymbolicLink : IDirectoryEntry
    {
        private string name;

        public SymbolicLink(string name)
        {
            this.name = name;
        }

        public void Remove()
        {
            Console.WriteLine($"{name} を削除しました.");
        }
    }
}

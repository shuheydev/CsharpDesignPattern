using System;
using System.Collections.Generic;
using System.Text;

namespace Composite2
{
    class File : IDirectoryEntry
    {
        private string name;

        public File(string name)
        {
            this.name = name;
        }

        public void Remove()
        {
            Console.WriteLine($"{name} を削除しました.");
        }
    }
}

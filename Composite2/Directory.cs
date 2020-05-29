using System;
using System.Collections.Generic;
using System.Text;

namespace Composite2
{
    class Directory : IDirectoryEntry
    {
        private List<IDirectoryEntry> list;
        private readonly string name;

        public Directory(string name)
        {
            this.name = name;
            list = new List<IDirectoryEntry>();
        }

        public void Add(IDirectoryEntry dirEntry)
        {
            list.Add(dirEntry);
        }

        public void Remove()
        {
            var en = list.GetEnumerator();

            while (en.MoveNext())
            {
                IDirectoryEntry dirEntry = en.Current;

                //switch (dirEntry)
                //{
                //    case File target:
                //        target.Remove();
                //        break;
                //    case Directory target:
                //        target.Remove();
                //        break;
                //    default:
                //        Console.WriteLine("削除できません.");
                //        break;
                //}

                //これだけですむ.
                //分岐が不要になった
                dirEntry.Remove();

                Console.WriteLine($"{name} を削除しました.");
            }
        }
    }
}

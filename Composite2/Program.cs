using System;

namespace Composite2
{
    class Program
    {
        static void Main(string[] args)
        {
            File file1 = new File("file1");
            File file2 = new File("file2");
            File file3 = new File("file3");
            File file4 = new File("file4");

            Directory dir1 = new Directory("dir1");
            dir1.Add(file1);
            Directory dir2 = new Directory("dir2");
            dir2.Add(file2);
            dir2.Add(file3);
            dir1.Add(dir2);
            dir1.Add(file4);

            SymbolicLink sym1 = new SymbolicLink("sym1");
            SymbolicLink sym2 = new SymbolicLink("sym2");

            dir2.Add(sym1);

            dir1.Add(sym2);

            dir1.Remove();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drevo
{
    class Program
    {
        static void Main(string[] args)
        {
            var bt = new btree();

            bt.Insert(5);
            bt.Insert(2);
            bt.Insert(7);
            bt.Insert(0);
            bt.Insert(3);
            bt.Insert(6);
            bt.Insert(8);

            bt.Print1();
            Console.ReadKey();
            //Console.WriteLine(bt.root.left.right.val);


        }
    }
}

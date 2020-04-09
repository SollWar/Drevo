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
            bt.Insert(8);

            bt.Insert(4);
            bt.Insert(12);

            bt.Insert(2);
            bt.Insert(6);
            bt.Insert(10);
            bt.Insert(14);

            bt.Insert(1);
            bt.Insert(3);
            bt.Insert(5);
            bt.Insert(7);
            bt.Insert(9);
            bt.Insert(11);
            bt.Insert(13);
            bt.Insert(15);
            bt.Print();
            //Console.WriteLine(bt.root.left.right.val);


        }
    }
}

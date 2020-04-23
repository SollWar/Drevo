using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drevo
{
    class Program
    {
        //delegate int tr(int x);
        //delegate int re(int x, int y);
        
        static void Main(string[] args)
        {
            /*
            tr sq = x => x * x;
            Console.WriteLine(sq(3));
            Console.WriteLine(sq.Invoke(3));

            re sq2 = (a, b) => a + b;
            Console.WriteLine(sq2(3, 4));

            System.Action<int, int> ss = null;
            int k = 0;
            ss = (x, y) => { k++; };
            ss(3, 4);
            Console.WriteLine(k);

            System.Func<int, int, int> f1 = null;
            f1 = (a, b) => {
                if (a == 5)
                    return a*2 + b;
                else
                    return a + b;
            };
            Console.WriteLine(f1(5, 6));

            var lst = new List<int>() { 1, 2, 3, 4 };
            lst.ForEach(x => Console.Write(x + "\t"));
            Console.WriteLine("\n");

            */

            var bt = new btree();

            bt.Insert(10);
            bt.Insert(13);
            bt.Insert(8);
            bt.Insert(9);
            bt.Insert(7);

            Console.WriteLine("Contains(9) " + bt.Contains(9));
            Console.WriteLine("Max " + bt.Max());
            Console.WriteLine("Min " + bt.Min());
            Console.WriteLine("Size " + bt.Size());
            Console.WriteLine();

            bt.Print1();
            Console.ReadKey();
        }
    }
}

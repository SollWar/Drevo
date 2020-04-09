using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drevo
{
    public class btree
    {
        public Node root;

        public void Insert(int x)
        {
            if (root == null)
                root = new Node(x);
            else
                insert(x, root);
        }

        private void insert(int x, Node leaf)
        {
            if (x < leaf.val)
            {
                if (leaf.left == null)
                    leaf.left = new Node(x);
                else
                    insert(x, leaf.left);
            }
            else
            {
                if (leaf.right == null)
                    leaf.right = new Node(x);
                else
                    insert(x, leaf.right);
            }
        }

        public void Print()
        {
            if (root != null)
                print(root, 0);
        }

        private void print(Node n, int step)
        {

            if (n.right != null)
                print(n.right, step + 1);

            for (int i = 0; i != step; i++)
                Console.Write("  ");
            Console.WriteLine(n.val);

            if (n.left != null)
                print(n.left, step + 1);
        }

    }
}

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

        public void Print1()
        {
            var lst = new List<List<int>>();
            lst.Add(new List<int>());
            print1(root, 0 , lst);
            
            var max = lst.Max(obj => obj.Count);
            for (int i = 0; i < lst.Count; i++)
            {
                var t = Enumerable.Repeat(-1, max - lst[i].Count).ToList();
                lst[i].AddRange(t);
            }


            var temp = new List<List<int>>();
            for (int i = 0; i < max; i++)
            {
                temp.Add(Enumerable.Repeat(-1, lst.Count).ToList());
            }
            for (int i = 0; i != lst.Count; i++)
                for (int j = 0; j != lst[i].Count; j++)
                    temp[j][lst.Count - i - 1] = lst[i][j];

            
            int ml = lst.Max(row => row.Max()).ToString().Length;
            for(int i = 0; i < lst.Count; i++)
            {
                var tt = new System.Text.StringBuilder();
                if (lst[i].Max() < 0)
                    continue;
                for(int j = 0; j < lst[i].Count; j++)
                {
                    if (lst[i][j] == -1)
                        tt.Append(string.Concat(Enumerable.Repeat(' ', ml)).ToCharArray());
                    else
                    {
                        tt.Append(lst[i][j].ToString());
                        tt.Append(string.Concat(Enumerable.Repeat(' ', ml - lst[i][j].ToString().Length)).ToCharArray());
                    }
                }
            }

            foreach (var i in temp)
            {
                foreach (var j in i)
                {
                    if (j >= 0)
                        Console.Write(j + " ");
                    else
                        Console.Write(" ");
                }
                Console.Write("\n");
            }
        }

        public bool Contains(int x)
        {
            return contains(x, root);
        }

        private bool contains(int x, Node n)
        {
            bool result = false;

            if (x == n.val)
                result = true;
            if (x > n.val)
                if (n.right != null)
                    result = contains(x, n.right);
            if (x < n.val)
                if (n.left != null)
                    result = contains(x, n.left);
            return result;
        }

        public int Max()
        {
            return max(root.val, root);
        }

        private int max(int x, Node n)
        {
            int m = x;
            if (n.right != null)
                if (n.right.val > m)
                    m = max(n.right.val, n.right);
            return m;
        }

        public int Min()
        {
            return min(root.val, root);
        }

        private int min(int x, Node n)
        {
            int m = x;
            if (n.left != null)
                if (n.left.val < m)
                    m = min(n.left.val, n.left);
            return m;
        }

        public int Size()
        {
            int h = size(0,root);
            return h;
        }

        private int size(int x, Node n)
        {
            x++;
            if (n.right != null)
            {
                x = size(x, n.right);
            }
            if (n.left != null)
            {
                x = size(x, n.left);
            }
            return x;
        }

        private void print1(Node n, int step, List<List<int>> lst)
        {
            if (n.right != null)
                print1(n.right, step + 1, lst);

            for (int i = 0; i != step; i++)
                lst.Last().Add(-1);
            lst.Last().Add(n.val);
            lst.Add(new List<int>());

            if (n.left != null)
                print1(n.left, step + 1, lst);
        }

    }
}

﻿using System;
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

            int h = 0;
            int w = 0;
            foreach (var i in temp)
            {
                h++;
                w = 0;
                foreach (var j in i)
                {
                    w++;
                    if (j >= 0)
                        Console.Write(j + " ");
                    else
                        Console.Write(" ");
                }
                Console.Write("\n");
            }
            Console.WriteLine(h);
            Console.WriteLine(w);
        }

        public bool Contains(int x)
        {
            bool result = false;
            if (root.val == x)
                result = true;
            else
                result = contains(x, root);
            return result;
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

using System;

namespace MetinYazariBelirleme
{
    public class Tree
    {
        public treeNode root;

        public Tree()
        {
            root = null;
        }

        public void Print()
        {
            Print(root, 4);
        }

        public void Print(treeNode p, int padding)
        {
            if (p != null)
            {
                if (p.right != null)
                {
                    Print(p.right, padding + 4);
                }
                if (padding > 0)
                {
                    Console.Write(" ".PadLeft(padding));
                }
                if (p.right != null)
                {
                    Console.Write("/\n");
                    Console.Write(" ".PadLeft(padding));
                }
                Console.Write(p.data.ToString() + "\n ");
                if (p.left != null)
                {
                    Console.Write(" ".PadLeft(padding) + "\\\n");
                    Print(p.left, padding + 4);
                }
            }
        }

        public bool Add(string data, int adet)
        {
            treeNode before = null, after = root;

            while (after != null)
            {
                before = after;
                if (data.Length <= after.data.Length) 
                    after = after.left;
                else if (data.Length > after.data.Length) 
                    after = after.right;
                else
                {
                   
                    return false;
                }
            }

            treeNode newNode = new treeNode(data, adet);

            if (this.root == null) 
                this.root = newNode;
            else
            {
                if (data.Length <= before.data.Length)
                    before.left = newNode;
                else
                    before.right = newNode;
            }

            return true;
        }

    }
}
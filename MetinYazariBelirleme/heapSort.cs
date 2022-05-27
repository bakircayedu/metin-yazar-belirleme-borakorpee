using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;

namespace MetinYazariBelirleme
{
    public class heapSort
    {
        public int size;
        public heapNode root;

        public heapSort()
        {
            root = null;
            size = 0;

        }
        
        public int insertHeight()
        {
            int i = 1;
            int sum = 0;
            while (this.size > sum + (1 << i))
            {
                sum += (1 << i);
                i++;
            }
            return i;
        }
        public void swapNode(heapNode first, heapNode second)
        {
            int kacTane = first.kacTane;
            first.kacTane = second.kacTane;
            second.kacTane = kacTane;
        }
       
        public void arrangeNode(heapNode root)
        {
            if (root.left != null && root.left.kacTane > root.kacTane)
            {
                swapNode(root, root.left);
            }
            if (root.right != null && root.right.kacTane > root.kacTane)
            {
                swapNode(root, root.right);
            }
        }
        public Boolean addNode(heapNode root, int height, int level, int kacTane, string kelime)
        {
            if (level >= height)
            {
                return false;
            }
            if (root != null)
            {
                if (level - 1 == height && root.left == null || root.right == null)
                {
                    if (root.left == null)
                    {
                        root.left = new heapNode(kacTane, kelime);
                    }
                    else
                    {
                        root.right = new heapNode(kacTane, kelime);
                    }
                    arrangeNode(root);
                    return true;
                }
                if (addNode(root.left, height, level + 1, kacTane, kelime) ||
                  addNode(root.right, height, level + 1, kacTane, kelime))
                {
                    arrangeNode(root);
                    return true;
                }
            }
            return false;
        }

        public void insert(int kacTane, string kelime)
        {
            

            if (root == null)
            {
                root = new heapNode(kacTane, kelime);
            }
            else
            if (root.left == null)
            {
                root.left = new heapNode(kacTane, kelime);
                arrangeNode(root);
            }
            else
            if (root.right == null)
            {
                root.right = new heapNode(kacTane, kelime);
                arrangeNode(root);
            }
            else
            {
                int height = insertHeight();
                addNode(root, height, 0, kacTane, kelime);
            }
            this.size++;
        }
        public void inorder(heapNode root)
        {
            if (root != null)
            {
                inorder(root.left);
                Console.Write(" " + root.kacTane + root.kelime);
                inorder(root.right);

            }
        }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetinYazariBelirleme
{
    public class treeNode
    {
        public string data;
        public int kacTane;
        public treeNode left;
        public treeNode right;

        public treeNode(string data, int kacTane)
        {
            this.data = data;
            this.kacTane = kacTane;
            left = null;
            right = null;
        }

    }
}
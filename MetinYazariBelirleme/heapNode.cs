using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetinYazariBelirleme
{
    public class heapNode
    {
        
        public heapNode left;
        public heapNode right;
       
        public int kacTane;
        public string kelime;
        public heapNode(int kacTane, string kelime)
        {
            this.kacTane = kacTane;
            this.kelime = kelime;
            left = null;
            right = null;
        }
    }
}
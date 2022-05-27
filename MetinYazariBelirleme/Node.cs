using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetinYazariBelirleme
{
    public class Node
    {
        public string Data { get; set; }
        public Node Next { get; set; }

        public Node(string value)
        {
            this.Data = value;
        }

        
    }
}
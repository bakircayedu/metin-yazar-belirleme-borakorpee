using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetinYazariBelirleme
{
    public class hashNode
    {

        public int key;
        public string kelime;
        public hashNode next;
        public hashNode()
        {
            this.next = null;

        }

        public hashNode(int key, string kelime)
        {
            this.key = key;
            this.kelime = kelime;
            this.next = null;
        }

    }
}
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetinYazariBelirleme
{
    public class myStack : myStackADT
    {
        Node top;
        public int size;

        public myStack()
        {
            this.top = null;
        }

        public override void Push(string value)
        {
            Node newNode = new Node(value);

            if (top == null)
            {
                newNode.Next = null;
            }
            else
            {
                newNode.Next = top;
            }
            top = newNode;
            size++;
        }

       

        public void print()
        {
            Node temp = top;
            while (temp != null)
            {
                Console.WriteLine("\n" + temp.Data + "\n");
                temp = temp.Next;
            }
        }

        public int adetBul(string kelime)
        {
            int adet_sayac = 0;
            Node temp = top;
            while (temp != null)
            {
                if (kelime.ToLower() == temp.Data.ToLower())
                {
                    adet_sayac += 1;
                }
                temp = temp.Next;
            }

            return adet_sayac;
        }

    }
}
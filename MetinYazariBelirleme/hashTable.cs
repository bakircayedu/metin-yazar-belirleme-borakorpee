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
    public class hashTable : Form1
    {

        int size;

        public hashNode[] dizi;

        public hashTable(int size)
        {
            this.size = size;
            dizi = new hashNode[size];

            for (int i = 0; i < size; i++)
            {

                dizi[i] = new hashNode();
            }
        }

        int indexUret(int isimuzunluk)
        {

            return isimuzunluk % size;
        }

        public void ekle(int key, string isim)
        {
            hashNode eleman = new hashNode(key, isim);
            int indis = indexUret(isim.Length);

            hashNode temp = dizi[indis];

            if (temp.next == null)
            {
                temp.next = eleman;
            }
            else
            {
                while (temp.next != null)
                {
                    temp = temp.next;

                }

                temp.next = eleman;
            }

        }

        public void yazdır()
        {
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.GetType() == typeof(Form1))
                {
                    Form1 frmTemp = (Form1)frm;

                    for (int i = 0; i < size; i++)
                    {
                        hashNode temp = dizi[i];
                        frmTemp.SetText($"Dizi [{i}] -> ");
                        while (temp.next != null)
                        {
                            temp = temp.next;

                            frmTemp.SetText($"{temp.key}  {temp.kelime} ->");

                        }
                        frmTemp.SetText(Environment.NewLine);
                    }

                }
            }

        }

    }
}
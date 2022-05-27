using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetinYazariBelirleme
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        OpenFileDialog file = new OpenFileDialog();

        // Textboxların boyutunun dinamik şekilde ayarlanması
        public void reSize(TextBox textbox)
        {
            Size t = TextRenderer.MeasureText(textbox.Text, textbox.Font);
            textbox.Width = t.Width;
            textbox.Height = t.Height;

        }
        private void dosyaSec_Click(object sender, EventArgs e)
        {
            file.Filter = "Metin Belgesi |*.txt";

            DialogResult result = file.ShowDialog();
            if (result == DialogResult.OK)
            {
                dosyaOku.Enabled = true;
            }
            else if (result == DialogResult.Cancel)
            {

            }

            string dosyaAdi = file.SafeFileName;
            string dosyaYolu = file.FileName;

            fileNameTXT.Text = dosyaAdi;
            filePathTXT.Text = dosyaYolu;

            reSize(filePathTXT);
            reSize(fileNameTXT);
        }

        myStack kelimelerStack = new myStack();

        private void dosyaOku_Click(object sender, EventArgs e)
        {
            agacaAktar.Enabled = true;
            hashOlusturBTN.Enabled = true;

            metinIcerikTXT.Text = " ";
            string dosyaAdi = file.SafeFileName;
            string dosyaYolu = file.FileName;

            StreamReader streamReader = new StreamReader(dosyaYolu);
            myStack cumlelerStack = new myStack();

            string dosya = streamReader.ReadToEnd();
            string[] cumleler = Regex.Split(dosya, @"(?<=[\.!\?])\s+");
            string[] kelimeler = Regex.Split(dosya, @"\W+");

            float cumleSayisi = 0;
            int cumledeki_kelime_sayisi = 1;
            float toplam_kelime_sayisi = 0;
            float ort;
            for (int i = 0; i < cumleler.Length; i++)
            {
                cumlelerStack.Push(cumleler[i]);
                cumleSayisi += 1;

                int a = 0;

                while (a <= cumleler[i].Length - 1)
                {
                    if (cumleler[i][a] == ' ' || cumleler[i][a] == '\n' || cumleler[i][a] == '\t' || cumleler[i][a] == '\'')
                    {
                        cumledeki_kelime_sayisi++;
                    }
                    a++;
                }

                metinIcerikTXT.Text += $"{i + 1}. cümledeki kelime sayısı: {cumledeki_kelime_sayisi}" + Environment.NewLine;
                cumledeki_kelime_sayisi = 1;
                a = 0;

            }

            for (int i = 0; i < kelimeler.Length - 1; i++)
            {
                toplam_kelime_sayisi += 1;
                kelimelerStack.Push(kelimeler[i]);
            }
            ort = toplam_kelime_sayisi / cumleSayisi;

            metinIcerikTXT.Text += $"Cümlelerdeki ortalama kelime sayisi: {Math.Ceiling(ort)}" + Environment.NewLine;
            metinIcerikTXT.Text += $"Toplam Kelime sayısı: {toplam_kelime_sayisi}" + Environment.NewLine;

            for (int k = 0; k < kelimeler.Length - 1; k++)
            {
                kelimeler[k] = kelimeler[k].ToLower();

            }

            string[] filtered_kelimeler = kelimeler.Distinct().ToArray();

            for (int i = 0; i < filtered_kelimeler.Length - 1; i++)
            {
                kelimeTXT.Text += $"{filtered_kelimeler[i]} adet {kelimelerStack.adetBul(filtered_kelimeler[i])} " + Environment.NewLine;
            }

            reSize(kelimeTXT);
            reSize(metinIcerikTXT);
        }

        Tree tree = new Tree();

        private void agacaAktar_Click(object sender, EventArgs e)
        {

            enSikKullanilanKelimeler.Enabled = true;

            string dosyaYolu = file.FileName;
            StreamReader streamReader = new StreamReader(dosyaYolu);
            string dosya = streamReader.ReadToEnd();
            string[] kelimeler = Regex.Split(dosya, @"\W+");

            for (int k = 0; k < kelimeler.Length - 1; k++)
            {
                kelimeler[k] = kelimeler[k].ToLower();

            }
            string[] filtered_kelimeler = kelimeler.Distinct().ToArray();

            for (int i = 0; i < filtered_kelimeler.Length - 1; i++)
            {
                tree.Add(filtered_kelimeler[i], kelimelerStack.adetBul(filtered_kelimeler[i]));
            }

        }

        private void enSikKullanilanKelimeler_Click(object sender, EventArgs e)
        {
            enSikKullanilanKelimelerTXT.Text = " ";

            string dosyaYolu = file.FileName;
            StreamReader streamReader = new StreamReader(dosyaYolu);
            string dosya = streamReader.ReadToEnd();
            string[] kelimeler = Regex.Split(dosya, @"\W+");

            heapSort heap1 = new heapSort();

            int istenen = Convert.ToInt32(kelimeSayisiTXT.Text);
            for (int k = 0; k < kelimeler.Length - 1; k++)
            {
                kelimeler[k] = kelimeler[k].ToLower();

            }
            string[] filtered_kelimeler = kelimeler.Distinct().ToArray();
            int[] adetler = new int[filtered_kelimeler.Length];
            int[] adetlerCopy = new int[filtered_kelimeler.Length];

            for (int i = 0; i < filtered_kelimeler.Length - 1; i++)
            {
                heap1.insert(kelimelerStack.adetBul(filtered_kelimeler[i]), filtered_kelimeler[i]);
            }
            int toplamKelimeSayisi = 0;
            for (int k = 0; k < filtered_kelimeler.Length - 1; k++)
            {
                adetler[k] = kelimelerStack.adetBul(filtered_kelimeler[k]);
                toplamKelimeSayisi += kelimelerStack.adetBul(filtered_kelimeler[k]);
            }
            Array.Copy(adetler, adetlerCopy, filtered_kelimeler.Length);

            int sıra = 1;
            float yuzde = 0;
            if (istenen < filtered_kelimeler.Length)
            {
                while (istenen != 0)
                {
                    int maxValue = adetlerCopy.Max();
                    int maxIndex = adetlerCopy.ToList().IndexOf(maxValue);

                    yuzde = (maxValue * 100) / toplamKelimeSayisi;

                    enSikKullanilanKelimelerTXT.Text += $" En fazla kullanılan {sıra}. kelime ' -> {filtered_kelimeler[maxIndex]} <- '  kullanılma sayisi: {adetlerCopy[maxIndex]} metindeki tüm kelimelerin %{yuzde} " + Environment.NewLine;

                    adetlerCopy[maxIndex] = -1;
                    istenen--;
                    sıra++;
                }
                reSize(enSikKullanilanKelimelerTXT);
            }
            else
            {
                MessageBox.Show("Geçersiz büyüklükte sayı girdiniz");
            }

        }

        public void SetText(string text)
        {
            hashTableTXT.Text += text;
        }

        private void hashOlusturBTN_Click(object sender, EventArgs e)
        {
            hashTableTXT.Text = " ";
            uyari.Visible = true;
            string dosyaYolu = file.FileName;
            StreamReader streamReader = new StreamReader(dosyaYolu);
            string dosya = streamReader.ReadToEnd();
            string[] kelimeler = Regex.Split(dosya, @"\W+");

            for (int k = 0; k < kelimeler.Length - 1; k++)
            {
                kelimeler[k] = kelimeler[k].ToLower();

            }
            string[] filtered_kelimeler = kelimeler.Distinct().ToArray();

            hashTable hash = new hashTable(filtered_kelimeler.Length - 1);

            for (int i = 0; i < filtered_kelimeler.Length - 1; i++)
            {
                hash.ekle(kelimelerStack.adetBul(filtered_kelimeler[i]), filtered_kelimeler[i]);
            }

            hash.yazdır();

        }
    }
}
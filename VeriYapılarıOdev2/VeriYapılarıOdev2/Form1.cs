using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VeriYapılarıOdev2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Dosya Seçiniz";
            openFileDialog1.FileName = "Dosya Seç";
            openFileDialog1.InitialDirectory = @"C:\Users\halil\OneDrive\Masaüstü";   
            openFileDialog1.Filter = "Metin dosyaları (.txt)|*.txt|Tüm dosyalar (.)|.";
        }
        /// <summary>
        /// *///
        /// </summary>

        private void btnDosyaYukle_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                txtYol.Text = openFileDialog1.FileName;

                Metin += System.IO.File.ReadAllText(openFileDialog1.FileName);

               
                //*//
            }
        }
        /// <summary>
        /// /////*///////
        /// </summary>
        string Metin = " ";
        Stack stackKelime = new Stack();
        Stack stackCumle = new Stack();
        Stack stackUniqueKelime = new Stack();
        private void button1_Click(object sender, EventArgs e)
        {
            btnHeap.Enabled = true;
            string cumle = "";
            int kelimeSayisi = 0;
            foreach (var harf in Metin)
            {
                if (harf.ToString() == "\n")
                {
                    stackCumle.Push(cumle, kelimeSayisi);
                    kelimeSayisi = 0;

                    cumle = "";
                }
                else
                {
                    if (harf.ToString() == " ")
                    {
                        cumle += harf.ToString();
                       kelimeSayisi++;
                    }
                    else
                    {
                        cumle += harf.ToString();
                    }

                }

            }


            stackCumle.Push(cumle, kelimeSayisi);
            txtCumle.Text = stackCumle.cumleYazdir();

            string[] kelime_dizi = Metin.Split(' ');
            foreach (var kelime in kelime_dizi)
            {
                stackUniqueKelime.Push(kelime.ToLower(), kelimeSayisi, true);
                stackKelime.Push(kelime.ToLower(), kelimeSayisi);
            }
            txtKelime.Text = stackKelime.KelimeYazdir();

            txtFrekans.Text = stackKelime.frekansYazdir();
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriYapılarıOdev2
{
    public class Node
    {
        public string Deger;

        public string process;

        public int kelimeSayisi;

        public int frekans = 1;

        public Node Next;


        public Node()
        {

        }
        public Node(string deger, int kelime)
        {
            Deger = deger;

            Next = null;

            kelimeSayisi = kelime;

        }
        public Node(string deger, int kelime, string process)
        {
            Deger = deger;

            kelimeSayisi = kelime;

            this.process = process;

            this.Next = null;
        }


    }
}

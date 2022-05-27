using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriYapılarıOdev2
{
    public class Stack
    {
       
        public int size = 0;

        Node top;


        public void Push(string value, int kelime, bool uniqueKelime)
        {
            string process = string.Empty;
            foreach (var Harf in value)
            {
                if (Char.IsPunctuation(Harf))
                {
                    break;
                }

                process += Harf;

                //**//

            }
            Node node = new Node(value, kelime, process);
            if (top == null)
            {
                top = node;

                size++;

                return;
                //**//
            }

            Node kontrol = TekrarBul(node);
            if (kontrol == null)
            {
                node.Next = top;

                top = node;

                size++;

            }
            else
            {
                Sayac(node);
            }
            //**//

        }
        public bool Pop()
        {
            if (top == null)
                return false;
            else
            {
                top = top.Next;
                return true;
            }
            //**//
        }

        public string Peek()
        {
            return top.Deger;
        }
        public int Size()
        {
            return size;

            //**//
        }

        public Stack()
        {
            top = null;
        }
        public void Push(string Data, int kelime)
        {
            Node dugum = new Node(Data, kelime);
            if (top == null)
                top = dugum;
            else
            {
                dugum.Next = top;
                top = dugum;
            }
            size++;
            //**//
        }

        public Node TekrarBul(Node control)
        {
            Node temp = new Node();
            temp = top;
            while (temp.Next != null)
            {
                if (String.Equals(temp.process, control.process))
                {

                    return temp;

                }

                temp = temp.Next;

            }
            if (String.Equals(temp.process, control.process))
            {

                return temp;

            }
            return null;
            //**//
        }

        public int Sayac(Node node)
        {
            Node ilk = new Node();
            ilk = top;
            while (ilk.Next != null)
            {
                if (String.Equals(ilk.Next.process, node.process))
                {
                    int frekanskelime = ilk.Next.frekans;
                    ilk.Next.frekans = ++frekanskelime;
                }
                ilk = ilk.Next;
            }
            return ilk.frekans;
            //**//
        }
        public string cumleYazdir()
        {
            Node temp = new Node(null, 0);

            temp = top;

            string cumle = "";

            while (temp.Next != null)
            {

                if (temp.kelimeSayisi != 0)

                    cumle += temp.Deger + "==" + temp.kelimeSayisi + Environment.NewLine;


                temp = temp.Next;
            }
            cumle += temp.Deger + "== " + temp.kelimeSayisi + Environment.NewLine;

            return cumle;
            //**//
        }
        public string frekansYazdir()
        {

            Node temp = new Node(null, 0);
            temp = top;

            string frekans = "";

            while (temp.Next != null)
            {
                temp.frekans = Sayac(temp);

                frekans += temp.Deger + " frekansı=" + temp.frekans + Environment.NewLine;

                temp = temp.Next;


            }
            return frekans;
            //**//
        }
        public string KelimeYazdir()
        {
            Node temp = new Node(null, 0);
            temp = top;
            string kelime = "";
            while (temp.Next != null)
            {

                kelime += temp.Deger + Environment.NewLine;
                temp = temp.Next;

            }
            return kelime;

        }//**//

    }
}

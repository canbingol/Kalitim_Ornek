using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Kalıtım
{
    internal class EskenarDortgen : Sekiller, Iİşlemler
    {
        private int _yükseklik;
        public int yükseklik
        {
            get { return _yükseklik; }
            set { _yükseklik = value; }
        }

        private int _genislik;
        public int genislik
        {
            get { return _genislik; }
            set { _genislik = value; }
        }
        public EskenarDortgen()
        {
            Console.WriteLine(" KARE OLUŞTURULDU");
        }

        public EskenarDortgen(int yükseklik, int genişlik)
        {
            Console.WriteLine(" KARE OLUŞTURULDU");

            this.yükseklik = yükseklik;
            this.genislik = genislik;
        }
        public void Ciz()
        {
            if ( genislik!= yükseklik)
            {
                Console.WriteLine(" GİRDİĞİNİZ DEĞERLER BİR KAREYE AİT DEĞİL ÇİZİM YAPILAMIYOR");
                return;
            }
            for (int i = 0; i < yükseklik; i++)
            {
                for (int j = 0; j < genislik; j++)
                {
                    if (doluMu == true)
                    {
                        Console.Write(sembol);
                    }
                    else
                    {
                        if (i == 0 || i == yükseklik - 1 || j == 0 || j == genislik - 1)
                        {
                            Console.Write(sembol);
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }

                }
                Console.WriteLine();
            }
        }
        public double CevreHesapla()
        {
            double cevre = yükseklik*4;
            return cevre;
        }
        public double AlanHesapla()
        {
            double alan = Math.Sqrt(yükseklik);
            return alan;
        }
        public string Ozellikyazdır()
        {
            string ozellik = oluşturmaTarihi.ToString() + " tarihinde oluşturulan Dikdörtgen sınıfı ---> Genişlik = " + genislik +
               " yükseklik = " + yükseklik + " Çevre = " + CevreHesapla() + " Alan = " + AlanHesapla();
            return ozellik;
        }




    }
}

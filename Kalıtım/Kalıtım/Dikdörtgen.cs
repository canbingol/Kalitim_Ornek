using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalıtım
{
    internal class Dikdörtgen : Sekiller, Iİşlemler
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

        public Dikdörtgen()
        {
            Console.WriteLine(" DİKDÖRTGEN OLUŞTURULDU");

        }
        public Dikdörtgen(int genişlik, int yükseklik)
        {
            Console.WriteLine(" DİKDÖRTGEN OLUŞTURULDU");

            this.yükseklik = _yükseklik;
            this.genislik = _genislik;
        }
        public double AlanHesapla()
        {
            return _genislik * _yükseklik;
        }
        public double CevreHesapla()
        {
            double cevre = (_genislik * _yükseklik) * 2;
            return cevre;
        }
        public void Ciz()
        {
            Console.WriteLine("Nesne Çizdiriliyor..");
            for (int i = 0; i < yükseklik; i++)
            {
                for (int j = 0; j < genislik; j++)
                {
                    if (doluMu)
                    {
                        Console.Write(sembol);
                    }
                    else
                    {
                        if (i==0 || i==_yükseklik-1 || j==0 || j== _genislik -1)
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


        public string Ozellikyazdır()
        {
            string ozellik = oluşturmaTarihi.ToString() + " tarihinde oluşturulan Dikdörtgen sınıfı ---> Genişlik = " + _genislik +
                " yükseklik = " + _yükseklik + " Çevre = " + CevreHesapla() + " Alan = " + AlanHesapla();
            return ozellik;
        }
    }
}

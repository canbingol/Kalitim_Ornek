using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Kalıtım
{
    internal class EskenarUcgen : Sekiller, Iİşlemler
    {
        public int Kenar { get; set; }
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

        public EskenarUcgen() {
            Console.WriteLine(" EŞKENAR ÜÇGEN OLUŞTURULDU");
        }

        public EskenarUcgen(int kenar)
        {
            Console.WriteLine(" EŞKENAR ÜÇGEN OLUŞTURULDU");

            Kenar = kenar;
        }

        public double AlanHesapla()
        {
            double alan = (yükseklik * genislik) / 2.0;
            return alan;
        }

        public double CevreHesapla()
        {
            double cevre = Kenar * 3;
            return cevre;
        }

        public void Ciz()
        {
            if (genislik!= yükseklik)
            {
                Console.WriteLine(" EŞKENAR ÜÇGENDE YÜKSEKLİK VE GENİŞLİK EŞİT OLMALI");
                return;
            }
            if (genislik == 0 || string.IsNullOrEmpty(genislik.ToString()))
            {
                if (yükseklik % 2 == 1)
                {
                    for (int i = 1; i <= yükseklik; i += 2)
                    {
                        int atla = (yükseklik - i) / 2;
                        for (int j = 0; j < atla; j++)
                            Console.Write(" ");
                        for (int j = 0; j < i; j++)
                            Console.Write(sembol);
                        for (int j = 0; j < atla; j++)
                            Console.Write(" ");

                        Console.WriteLine();
                    }
                }
                else
                {
                    Console.WriteLine("Çizim yapılamıyor. Kenar sayısı tek olmalıdır.");
                }
            }
            else
            {
                if (yükseklik % 2 == 1)
                {
                    for (int i = 1; i <= yükseklik; i += 2)
                    {
                        int atla = (yükseklik - i) / 2;
                        for (int j = 0; j < atla; j++)
                            Console.Write(" ");
                        for (int j = 0; j < i; j++)
                            Console.Write(sembol);
                        for (int j = 0; j < atla; j++)
                            Console.Write(" ");

                        Console.WriteLine();
                    }
                    for (int i = yükseklik-2; i >= 1; i -= 2)
                    {
                        int atla = (yükseklik - i) / 2;
                        for (int j = 0; j < atla; j++)
                            Console.Write(" ");
                        for (int j = 0; j < i;  j++)
                            Console.Write(sembol);
                        for (int j = 0; j < atla; j++)
                            Console.Write(" ");

                        Console.WriteLine();
                    }
                }
                else
                {
                    Console.WriteLine("Çizim yapılamıyor. Kenar sayısı tek olmalıdır.");
                }


            }

        }

        public string OzellikYazdir()
        {
            return yükseklik.ToString();
        }

        public string Ozellikyazdır()
        {
            string ozellik = oluşturmaTarihi.ToString() + " tarihinde oluşturulan Dikdörtgen sınıfı ---> Genişlik = " + _genislik +
                " yükseklik = " + _yükseklik + " Çevre = " + CevreHesapla() + " Alan = " + AlanHesapla();
            return ozellik;
        }
    }
}

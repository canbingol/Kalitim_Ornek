using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Kalıtım
{
    internal class Program
    {
        int secim;
        int islemSecim;
        static void Main(string[] args)
        {
            Program program = new Program();
            program.ÜstMenü();
            Console.ReadLine();
        }
        public void ÜstMenü()
        {
            Console.WriteLine(" 1-) Dikdörtgen \n 2-) Eşkenar  Üçgen \n 3-) Eşkenar Dörtgen \n 4-) Çıkış");
            secim = int.Parse(Console.ReadLine());
            Secme();
        }
        void Secme()
        {
            switch (secim)
            {
                case 1:
                    Dikdörtgen dikdörtgen = new Dikdörtgen();

                    Console.Write("Dikdörtgenin Genişliğini Girin ");
                    int genişlik = int.Parse((string)Console.ReadLine());
                    Console.Write("Dikdörtgenin Yüksekliğini Girin ");
                    int yükseklik = int.Parse((string)Console.ReadLine());
                    dikdörtgen.yükseklik = yükseklik;
                    dikdörtgen.genislik = genişlik;
                    if (secim == 4)
                    {
                        return;
                        Console.WriteLine(" ÇIKIŞ YAPILIYOR");
                    }
                    
                    while (secim != 4)
                    {
                        İşlemler();
                        DikdörtgenİslemSecme
                            (dikdörtgen);
                        if (secim == 4)
                        {
                            Console.WriteLine(" ÇIKIŞ YAPILIYOR");
                            return;
                        }
                    }
                    break;
                case 2:
                    EskenarDortgen kare = new EskenarDortgen();

                    Console.Write("Dikdörtgenin Genişliğini Girin ");
                    int genişlik1 = int.Parse((string)Console.ReadLine());
                    Console.Write("Dikdörtgenin Yüksekliğini Girin ");
                    int yükseklik1 = int.Parse((string)Console.ReadLine());
                    kare.yükseklik = yükseklik1;
                    kare.genislik = genişlik1;
                    if (secim == 4)
                    {
                        Console.WriteLine(" ÇIKIŞ YAPILIYOR");
                        return;
                    }
                    while (secim != 4)
                    {
                        İşlemler();
                        EskenarDörtgenİslemSecme(kare);
                        if (secim == 4)
                        {
                            Console.WriteLine(" ÇIKIŞ YAPILIYOR");
                            return;
                        }
                    }
                    break;
                case 3:
                    EskenarUcgen ucgen = new EskenarUcgen();

                    Console.Write("Dikdörtgenin Genişliğini Girin ");
                    int genişlik2 = int.Parse((string)Console.ReadLine());
                    Console.Write("Dikdörtgenin Yüksekliğini Girin ");
                    int yükseklik2 = int.Parse((string)Console.ReadLine());
                    ucgen.yükseklik = yükseklik2;
                    ucgen.genislik = genişlik2;

                    if (secim == 4)
                    {
                        Console.WriteLine(" ÇIKIŞ YAPILIYOR");
                        return;
                    }
                    while (secim != 4)
                    {
                        İşlemler();
                        EskenarUcgenİslemSecme(ucgen);
                        if (secim == 4)
                        {
                            Console.WriteLine(" ÇIKIŞ YAPILIYOR");
                            return;
                        }
                    }
                    break;
                case 4:
                    Console.WriteLine(" ÇIKIŞ YAPILIYOR");
                    return;


                    break;

            }
        }
        void İşlemler()
        {
            Console.WriteLine(" 1-) Cevre Hesapla \n 2-) Alan Hesapla \n 3-) Çiz \n 4-) Genişlik Değiştir\n" +
            " 5-) Uzunluk Değiştir \n 6-) Karakter değiştir \n 7-) Dolumu Değiştir \n" +
            " 8-) Bilgileri Yazdır\n 9-) Üst Menü");
            islemSecim = int.Parse(Console.ReadLine());

        }
        /*  işlem seçme metodlarını tek bir tane yazıp Sekiller sınıfı üzerinden kalıtımı kullanarak yapmaya çalışyım 
         ama olmadı/ yapamadım bu yüzden farklı 3 metod yazdım */
        public void DikdörtgenİslemSecme(Dikdörtgen sekil)
        {
            switch (islemSecim)
            {
                case 1:
                    Console.WriteLine("  DİKDÖRTEGENİN CEVRESİ =  " + sekil.CevreHesapla());
                    break;
                case 2:
                    Console.WriteLine("  DİKDÖRTEGENİN ALANI  =  " + sekil.AlanHesapla());
                    break;
                case 3:
                    sekil.Ciz();
                    break;
                case 4:
                    Console.WriteLine(" YENİ GENİŞLİK DEĞERİNİ GİRİNİZ");
                    int yeniDeger = int.Parse(Console.ReadLine());
                    sekil.genislik = yeniDeger;
                    Console.WriteLine("  YENİ GEMİŞLİK DEĞERİ " + sekil.genislik);
                    break;
                case 5:
                    Console.WriteLine(" YENİ YÜKSEKLİK DEĞERİNİ GİRİNİZ");
                    int yeniYükdeklik = int.Parse(Console.ReadLine());
                    sekil.yükseklik = yeniYükdeklik;
                    Console.WriteLine("  YENİ YÜKSEKLİK DEĞERİ " + sekil.yükseklik);
                    break;
                case 6:
                    Console.WriteLine(" YENİ SEMBOLÜ GİRİNİZ");
                    char sembol = char.Parse(Console.ReadLine());
                    sekil.sembol = sembol;
                    Console.WriteLine("  YENİ SEMBOL  " + sekil.sembol);
                    break;
                case 7:
                    while (true)
                    {
                        Console.WriteLine(" SEKİL DURUMU NASIL OLSUN ? \n 1-) DOLU \n 2-) BOŞ");
                        int doluluk = int.Parse(Console.ReadLine());
                        if (doluluk == 1)
                        {
                            sekil.doluMu = true;
                            Console.WriteLine(" MEVCUT DURUM : DOLU");

                            return;
                        }

                        else if (doluluk == 2)
                        {
                            sekil.doluMu = false;
                            Console.WriteLine(" MEVCUT DURUM : BOŞ");

                            return;
                        }

                        else
                            Console.WriteLine(" GEÇERSİZ GİRİŞ ");
                    }
                    break;
                case 8:
                    sekil.Ozellikyazdır();
                    break;
                case 9:
                    ÜstMenü();
                    break;
                default:
                    Console.WriteLine(" GEÇERSİZ GİRİŞ");
                    break;
            }
        }
        public void EskenarUcgenİslemSecme(EskenarUcgen sekil)
        {
            switch (islemSecim)
            {
                case 1:
                    Console.WriteLine("  DİKDÖRTEGENİN CEVRESİ =  " + sekil.CevreHesapla());
                    break;
                case 2:
                    Console.WriteLine("  DİKDÖRTEGENİN ALANI  =  " + sekil.AlanHesapla());
                    break;
                case 3:
                    sekil.Ciz();
                    break;
                case 4:
                    Console.WriteLine(" YENİ GENİŞLİK DEĞERİNİ GİRİNİZ");
                    int yeniDeger = int.Parse(Console.ReadLine());
                    sekil.genislik = yeniDeger;
                    Console.WriteLine("  YENİ GEMİŞLİK DEĞERİ " + sekil.genislik);
                    break;
                case 5:
                    Console.WriteLine(" YENİ YÜKSEKLİK DEĞERİNİ GİRİNİZ");
                    int yeniYükdeklik = int.Parse(Console.ReadLine());
                    sekil.yükseklik = yeniYükdeklik;
                    Console.WriteLine("  YENİ YÜKSEKLİK DEĞERİ " + sekil.yükseklik);
                    break;
                case 6:
                    Console.WriteLine(" YENİ SEMBOLÜ GİRİNİZ");
                    char sembol = char.Parse(Console.ReadLine());
                    Console.WriteLine("  YENİ SEMBOL  " + sekil.sembol);
                    break;
                case 7:
                    while (true)
                    {
                        Console.WriteLine(" SEKİL DURUMU NASIL OLSUN ? \n -1) DOLU \n 2-) BOŞ");
                        int doluluk = int.Parse(Console.ReadLine());
                        if (doluluk == 1)
                        {
                            sekil.doluMu = true;
                            return;
                        }

                        else if (doluluk == 2)
                        {
                            sekil.doluMu = false;
                            return;
                        }

                        else
                            Console.WriteLine(" GEÇERSİZ GİRİŞ ");
                    }
                    break;
                case 8:
                    sekil.Ozellikyazdır();
                    break;
                case 9:
                    ÜstMenü();
                    break;
                default:
                    Console.WriteLine(" GEÇERSİZ GİRİŞ");
                    break;
            }
        }
        public void EskenarDörtgenİslemSecme(EskenarDortgen sekil)

        {
            switch (islemSecim)
            {
                case 1:
                    Console.WriteLine("  DİKDÖRTEGENİN CEVRESİ =  " + sekil.CevreHesapla());
                    break;
                case 2:
                    Console.WriteLine("  DİKDÖRTEGENİN ALANI  =  " + sekil.AlanHesapla());
                    break;
                case 3:
                    sekil.Ciz();
                    break;
                case 4:
                    Console.WriteLine(" YENİ GENİŞLİK DEĞERİNİ GİRİNİZ");
                    int yeniDeger = int.Parse(Console.ReadLine());
                    sekil.genislik = yeniDeger;
                    Console.WriteLine("  YENİ GEMİŞLİK DEĞERİ " + sekil.genislik);
                    break;
                case 5:
                    Console.WriteLine(" YENİ YÜKSEKLİK DEĞERİNİ GİRİNİZ");
                    int yeniYükdeklik = int.Parse(Console.ReadLine());
                    sekil.yükseklik = yeniYükdeklik;
                    Console.WriteLine("  YENİ YÜKSEKLİK DEĞERİ " + sekil.yükseklik);
                    break;
                case 6:
                    Console.WriteLine(" YENİ SEMBOLÜ GİRİNİZ");
                    char sembol = char.Parse(Console.ReadLine());
                    Console.WriteLine("  YENİ SEMBOL  " + sekil.sembol);
                    break;
                case 7:
                    while (true)
                    {
                        Console.WriteLine(" SEKİL DURUMU NASIL OLSUN ? \n -1) DOLU \n 2-) BOŞ");
                        int doluluk = int.Parse(Console.ReadLine());
                        if (doluluk == 1)
                        {
                            sekil.doluMu = true;
                            return;
                        }

                        else if (doluluk == 2)
                        {
                            sekil.doluMu = false;
                            return;
                        }

                        else
                            Console.WriteLine(" GEÇERSİZ GİRİŞ ");
                    }
                    break;
                case 8:
                    sekil.Ozellikyazdır();
                    break;
                case 9:
                    ÜstMenü();
                    break;
                default:
                    Console.WriteLine(" GEÇERSİZ GİRİŞ");
                    break;
            }
        }
    }
}

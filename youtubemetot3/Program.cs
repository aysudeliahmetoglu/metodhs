using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace youtubemetot3
{
    class Program
    {
        static void Main(string[] args)
        {
            //metotlar metot1 = new metotlar();
            //int sonuc = metot1.topla(5, 8);
            //Console.Write(sonuc);
            //Console.ReadKey();
            BASADON:
            Console.Write("1. sayıyı giriniz?");
            double sayi1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("2.sayıyı giriniz?");
            double sayi2 = Convert.ToDouble(Console.ReadLine());
            DORTISLEMSEC:

            Console.Write("SEÇİMİNİZİ YAPINIZ? (Toplama:1 Çıkarma:2 Bölme:3 Çarpma:4 )");
            char dortislemsec = Convert.ToChar(Console.ReadLine());
            switch (dortislemsec)
            {
                case '1':
                    dortislem toplamaislemi = new dortislem();
                    double toplam = toplamaislemi.topla(sayi1, sayi2);
                    Console.WriteLine("toplama sonucu:{0}", toplam);
                    break;
                case '2':
                    dortislem cikarmaislemi = new dortislem();
                    double fark = cikarmaislemi.cikar(sayi1, sayi2);
                    Console.WriteLine("fark sonucu:{0}", fark);
                    break;
                case '3':
                    dortislem bolmeislemi = new dortislem();
                    double bolum = bolmeislemi.bol(sayi1, sayi2);
                    Console.WriteLine("bölme sonucu:{0}", bolum);
                    break;
                case '4':
                    dortislem carpmaislemi = new dortislem();
                    double carpim = carpmaislemi.carp(sayi1, sayi2);
                    Console.WriteLine("çarpma sonucu:{0}", carpim);
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("YANLIŞ SEÇİM YAPTINIZ .TEKRAR DENEYİNİZ");
                    goto DORTISLEMSEC;

            }
            DEVAMSECİM:
            Console.Write("YENİDEN İŞLEM YAPMAK İSTER MİSİNİZ?(EVET:E HAYIR:E)");
            char devamsec = Convert.ToChar(Console.ReadLine());
            if (devamsec=='E' || devamsec=='e')
            {
                Console.Clear();
                goto BASADON;
            }
            else if (devamsec=='H' ||devamsec=='h')
            {
                Console.Write("iyi günler");
            }
            else
            {
                Console.Write("YANLIŞ SEÇİM YAPTINIZ TEKRAR DENEYİNİZ");
                goto DEVAMSECİM;
            }
            Console.ReadKey();



        }
        //class metotlar
        //{
        //    public  int topla(int s1,int s2) // static kullanmazsak newlememiz gerekir
        //    {
        //        return (s1 + s2);
        //    }
        //}

        class dortislem
        {
            public double topla(double s1,double s2)
            {
                return (s1 + s2);
            }
            public double cikar(double s1,double s2)
            {
                return (s1 - s2);
            }
            public double bol(double s1,double s2)
            {
                return (s1 / s2);
            }
            public double carp(double s1,double s2)
            {
                return (s1 * s2);
            }
        }


    }
}

using MaskeTakip.Business.Abstract;
using MaskeTakip.Business.Concrete;
using MaskeTakip.Entities.Concrete;
using System;
using System.Collections.Generic;

namespace WorkSpace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variables();

            // ClassAndMethod();

            //Arrays_Values_And_Referance_Types();


            //Yabancılar için eczaneden alıncak maske sistemi
            //Vatandaşlar için Ptt den alınacak maske sistemi
            Person person = new Person();
            person.FirstName="Muhammed Ali";
            person.LastName="KALENDER";
            person.DateOfBirthYear=2002;
            person.NationalIdentity=424713707092;

            Foreign foreign1 = new Foreign();
            foreign1.FirstName="Muhammed Ali";
            foreign1.LastName="KALENDER";
            foreign1.ForeignIdentityNumber=20;

            ISupplierService<Person> supplierService = new PttManager(new PersonManager());
            ISupplierService<Foreign> supplierService2 = new MedicalManager(new ForeignerManager());
            supplierService.GiveMask(person);
            supplierService2.GiveMask(foreign1);
        }

        private static void Arrays_Values_And_Referance_Types()
        {
            //Diziler-Arrays
            string ogrenci1 = "Ali";
            string ogrenci2 = "Talat";
            string ogrenci3 = "Yusuf";
            string ogrenci4 = "Elif";
            Console.WriteLine(ogrenci1);
            Console.WriteLine(ogrenci2);
            Console.WriteLine(ogrenci3);
            Console.WriteLine(ogrenci4);

            string[] ogrenciler = new string[3];
            ogrenciler[0]="Ali";
            ogrenciler[1]="Talat";
            ogrenciler[2]="Yusuf";

            ogrenciler=new string[4]; // new'lediğim için önceki verileri sildi..
            ogrenciler[3]="Elif";

            for (int i = 0; i < ogrenciler.Length; i++)
            {
                Console.WriteLine(ogrenciler[i]);
            }

            string[] sehirler1 = new[]
            {
                "Ankara","İstanbul","İzmir"
            };

            string[] sehirler2 = new[]
            {
                "Bursa","Antalya","Diyarbakır"
            };


            sehirler2=sehirler1;//burada sehirler1'in referansı sehirler2'ye aktarıldı. burada referans etme mantığı.

            sehirler1[0] = "Adana";
            Console.WriteLine(sehirler2[0]);
            // array, list, class, interface, abstract class --> referans tiptir

            int sayi1 = 10;
            int sayi2 = 20;
            sayi2=sayi1; // burda sayi1'in değeri sayi2'ye aktarıldı.
            sayi1=30;
            Console.WriteLine(sayi2);
            // int, double, bool --> değer tiptir. (stack üzerinde olur)

            foreach (var item in sehirler1)
            {
                Console.WriteLine(item);
            }

            List<string> yeniSehirler1 = new List<string> { "Ankara 1", "İstanbul 1", "İzmir 1" };
            yeniSehirler1.Add("Adana 1");
            foreach (var item in yeniSehirler1)
            {
                Console.WriteLine(item);
            }
        }

        private static void ClassAndMethod()
        {
            Vatandas vatandas1 = new Vatandas();
            vatandas1.Ad="Ali";
            vatandas1.Soyad="KALENDER";
            vatandas1.DogumYili=2002;
            vatandas1.TcNo=13245678910;

            //SOLID 

            SelamVer("ali");
            SelamVer("ahmet");
            SelamVer("talat");
            SelamVer("melike");
            SelamVer();

            int total = Topla(10, 20);
            Console.WriteLine("Sonuç : "+total);
            // geriye dönen(sonuc) değerini total değişkeni ile yakaladım ve programatik akışta kullandım.
        }

        static void SelamVer(string isim = "isimsiz") // default parametre isimsiz
        {
            // sadece işi yapar. void geriye değer döndürmez
            Console.WriteLine("Merhaba " + isim);
        }

        static int Topla(int sayi1, int sayi2)
        {
            int sonuc = sayi1+sayi2;
            return sonuc;
        }

        private static void Variables()
        {
            /* Don't Repeat Yourself!*/
            string mesaj = "Selam";
            double tutar = 100300; //db den gelir
            int sayi = 100;
            bool girisYapmisMi = false;

            string ad = "Ali";
            string soyAd = "KALENDER";
            int dogumYili = 2002;
            long tcNo = 12345678910;

            Console.WriteLine(mesaj);
            Console.WriteLine(mesaj);
            Console.WriteLine(mesaj);

            Console.WriteLine(tutar*1.18);
            Console.WriteLine(tutar*1.18);
        }
    }

    // PascalCasing
    public class Vatandas
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int DogumYili { get; set; }
        public long TcNo { get; set; }
    }
}

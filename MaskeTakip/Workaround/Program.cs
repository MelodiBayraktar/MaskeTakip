// See https://aka.ms/new-console-template for more information

using Business.Concrete;
using Entities.Concrete;

internal class Program
{
    public static void Main(string[] args)
    {
       // Degiskenler();
       
       SelamVer("Engin");
       SelamVer();
       int sonuc = Topla(50);
       //Diziler /Arrays

       string ogrenci1 = "Engin";
       string ogrenci2 = "Kerem";
       string ogrenci3 = "Berkay";

       string[] ogrenciler = new string[3];
       ogrenciler[0] = "Engin";
       ogrenciler[1] = "Kerem";
       ogrenciler[2] = "Berkay";
       //Console.WriteLine(ogrenci1);
       ogrenciler = new string[4];
       ogrenciler[3] = "İlker";

       for (int i = 0; i < ogrenciler.Length; i++)
       {
           Console.WriteLine(ogrenciler[0]);
       }
       // foreach (var ogrenci in ogrenciler)
       // {
       //     Console.WriteLine(ogrenci);
       // }

       string[] sehirler1 = new[] { "Ankara", "İstanbul" };
       string[] sehirler2 = new[] { "Bursa", "Antalya" };

       sehirler2 = sehirler1;
       sehirler1[0] = "Adana";
       Console.WriteLine(sehirler2[0]);

       int sayi1 = 10;
       int sayi2 = 20;
       sayi2 = sayi1;
       sayi1 = 30;
       Console.WriteLine(sayi2);

       Person person1 = new Person();
       person1.FirstName = "Engin";
       person1.LastName = "Demiroğ";
       person1.NationalIdentity = 123;
       person1.DateOfBirthYear = 1985;
       
       Person person2 = new Person();
       person2.FirstName = "Murat";

       foreach (var sehir in sehirler1)
       {
           Console.WriteLine(sehir);
       }

       List<string> yeniSehirler1 = new List<string>() { "Ankara", "İstanbul" };
       yeniSehirler1.Add("Muğla");
       foreach (var sehir in yeniSehirler1)
       {
           Console.WriteLine(sehir);
       }

       PttManager pttManager = new PttManager(new PersonManager());
       pttManager.GiveMask(person1);
    }

    static void SelamVer(string isim="isimsiz")
    {
        Console.WriteLine("Merhaba " + isim);
    }

    static int Topla(int sayi1, int sayi2=5)
    {
        int sonuc = sayi1 + sayi2;
        Console.WriteLine("Toplam: " + sonuc.ToString());
        return sonuc;
    }

    private static void Degiskenler()
    {
        string mesaj = "Selam";
        double tutar = 100000;
        int sayi = 100;
        bool girisYapmisMi = false;

        string ad = "Engin";
        string soyad = "Demiroğ";
        int dogumYili = 1985;
        long tcNo = 12345678910;

        Console.WriteLine(mesaj);
        Console.WriteLine(mesaj);
    }
}


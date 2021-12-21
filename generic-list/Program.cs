using System;
using System.Collections.Generic;

namespace generic_list
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sayiListesi = new List<int>();
            sayiListesi.Add(2);
            sayiListesi.Add(32);
            sayiListesi.Add(12);
            sayiListesi.Add(10);
            sayiListesi.Add(5);

            List<string> renkListesi = new List<string>();
            renkListesi.Add("mavi");
            renkListesi.Add("yesil");
            renkListesi.Add("kirmizi");
            renkListesi.Add("pembe");
            renkListesi.Add("sari");

            Console.WriteLine(renkListesi.Count);
            Console.WriteLine(sayiListesi.Count);

            foreach (var item in sayiListesi)
            {
                Console.WriteLine(item);
            }

            foreach (var item2 in renkListesi)
            {
                Console.WriteLine(item2);
            }

            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));

            sayiListesi.Remove(4);
            renkListesi.Remove("yesil");

            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            renkListesi.ForEach(renk => Console.WriteLine(renk));
            
            sayiListesi.RemoveAt(4);
            renkListesi.RemoveAt(2);

            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            renkListesi.ForEach(renk => Console.WriteLine(renk));
            
            if(sayiListesi.Contains(12))
                Console.WriteLine("12 bulundu");

            Console.WriteLine(renkListesi.BinarySearch("sari"));

            //Diziyi listeye cevirme;
            string[] hayvanlar = {"kedi", "kopek", "kus"};

            List<string> hayvanlarListesi = new List<string>(hayvanlar);

            hayvanlarListesi.Clear();

            //List icinde nesne tutmak

            List<Kullanicilar> kullaniciListesi = new List<Kullanicilar>();

            Kullanicilar k1 = new Kullanicilar();
            k1.Isim = "Ayse";
            k1.Soyisim = "Deniz";
            k1.Yas = 22;

            Kullanicilar k2 = new Kullanicilar();
            k2.Isim = "Seda";
            k2.Soyisim = "Demir";
            k2.Yas = 28;

            kullaniciListesi.Add(k1);
            kullaniciListesi.Add(k2);

            List<Kullanicilar> yeniListe = new List<Kullanicilar>();

            yeniListe.Add(new Kullanicilar() {
                Isim="Deniz",
                Soyisim = "Arda",
                Yas=24
            });

            kullaniciListesi.ForEach(kullanici => Console.WriteLine(kullanici.Isim + " " + kullanici.Soyisim + " " + kullanici.Yas));
            yeniListe.ForEach(kullanici => Console.WriteLine(kullanici.Isim + " " + kullanici.Soyisim + " " + kullanici.Yas));
            kullaniciListesi.Clear();
            yeniListe.Clear();
            
            
        }


    }

    public class Kullanicilar {
        private string isim;
        private string soyisim;

        private int yas;

        public string Isim { get => isim; set => isim = value;}
        public string Soyisim { get => soyisim; set => soyisim = value;}
        public int Yas { get => yas; set => yas = value;}



    }
}

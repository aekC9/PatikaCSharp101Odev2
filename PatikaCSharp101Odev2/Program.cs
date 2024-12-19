using System;
using System.Collections;
namespace PatikaCSharp101Odev2Soru1
{
    class Solution
    {
        static void Main(string[] args)
        {
            ArrayList asalSayilar = new ArrayList();
            ArrayList asalOlmayanSayilar = new ArrayList();
            int sayac = 0;
            while (sayac < 20)
            {
                System.Console.WriteLine($"Lütfen {sayac + 1}.pozitif sayı giriniz: ");
                string enter = Console.ReadLine();

                if (int.TryParse(enter, out int sayi) && sayi > 0)
                {
                    if (AsalMi(sayi))
                    {
                        asalSayilar.Add(sayi);
                    }
                    else
                    {
                        asalOlmayanSayilar.Add(sayi);
                    }
                    sayac++;
                }
                else
                {
                    System.Console.WriteLine("Geçersiz giriş, Lütfen pozitif sayı giriniz!");
                }
            }
            asalSayilar.Sort();
            asalSayilar.Reverse();
            asalOlmayanSayilar.Sort();
            asalOlmayanSayilar.Reverse();

            System.Console.WriteLine("\nAsal Sayılar(Büyükten küçüğe):");
            foreach (int sayi in asalSayilar)
            {
                System.Console.WriteLine(sayi);
            }
            System.Console.WriteLine("\nAsal Olmayan Sayılar(Büyükten küçüğe):");
            foreach (int sayi in asalOlmayanSayilar)
            {
                System.Console.WriteLine(sayi);
            }

            System.Console.WriteLine($"Ortalama (Asal sayılar): {OrtalamaHesapla(asalSayilar)}");
            System.Console.WriteLine($"Ortalama (Asal Olmayan sayılar): {OrtalamaHesapla(asalOlmayanSayilar)}");
        }
        static bool AsalMi(int sayi)
        {
            if (sayi < 2) return false;
            for (int i = 2; i <= Math.Sqrt(sayi); i++)
            {
                if (sayi % i == 0) return false;
            }
            return true;
        }
        static double OrtalamaHesapla(ArrayList liste)
        {
            if (liste.Count == 0) return 0;
            int toplam = 0;
            foreach (int sayi in liste)
            {
                toplam += sayi;
            }
            return (double)toplam / liste.Count;
        }
    }
}
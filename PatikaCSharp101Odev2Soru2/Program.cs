using System;
using System.Globalization;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = new int[20];
            System.Console.WriteLine("Lütfen 20 adet sayı giriniz:");
            for (int i = 0; i < 20; i++)
            {
                System.Console.WriteLine($"Sayı {i + 1}: ");
                sayilar[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(sayilar);

            int[] enKucukUcSayi = { sayilar[0], sayilar[1], sayilar[2] };
            int[] enBuyukUcSayi = { sayilar[17], sayilar[18], sayilar[19] };

            double enKucukUcSayiOrtalamasi = (double)(enKucukUcSayi[0] + enKucukUcSayi[1] + enKucukUcSayi[2]);
            double enBuyukUcSayiOrtalamasi = (double)(enBuyukUcSayi[0] + enBuyukUcSayi[1] + enBuyukUcSayi[2]);

            double ToplamOrtalama = enBuyukUcSayiOrtalamasi + enKucukUcSayiOrtalamasi;

            System.Console.WriteLine($"\nEn küçük üç sayı: {string.Join(", ", enKucukUcSayi)}");
            System.Console.WriteLine($"\nEn büyük üç sayı: {string.Join(", ", enBuyukUcSayi)}");
            System.Console.WriteLine($"En küçük üç sayı ortalamsı: {enKucukUcSayiOrtalamasi:F2}");
            System.Console.WriteLine($"En büyük üç sayı ortalamsı: {enBuyukUcSayiOrtalamasi:F2}");
            System.Console.WriteLine($"Toplam Ortalma: {ToplamOrtalama:F2}");
        }
    }
}
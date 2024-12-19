using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaCSharp101Odev2Soru3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] sesliHarfler = { 'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü' };

            Console.Write("Bir kelime giriniz: ");
            string kelime = Console.ReadLine();

            List<char> bulunanSesliHarfler = new List<char>();
            foreach(char harf in kelime.ToLower())
            {
                if (sesliHarfler.Contains(harf))
                {
                    bulunanSesliHarfler.Add(harf);
                }
            }
            bulunanSesliHarfler.Sort();
            Console.WriteLine($"Bulunan sesli harfler: {string.Join(",",bulunanSesliHarfler)}");
        }
    }
}

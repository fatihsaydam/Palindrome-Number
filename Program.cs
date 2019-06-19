using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrom
{
    class Program
    {
        static void Main(string[] args)
        {
            KarsilamaYap();
            KontrolluSayiAl("\n"+"Lütfen bir sayı giriniz= ", "Girdiğiniz değer tam sayı değildir. Lütfen tam sayı giriniz.");
            Bekle();
        }

        static void KarsilamaYap()
        {
            Console.Write("**********Palindrom Sayı Hesaplama Aracı********" + "\n");
        }

        static int KontrolluSayiAl(string istekMesaji, string hataMesaji)
        {
            int Sayi, Mod, AraDeger = 0, Temp;
            EkranaYaz(istekMesaji);
            string input = EkrandanOku();
            bool donustuMu = int.TryParse(input, out Sayi);
            if (donustuMu)
            {
                Temp = Sayi;
                while (Sayi > 0)
                {
                    Mod = Sayi % 10;
                    Sayi = Sayi / 10;
                    AraDeger = AraDeger * 10 + Mod;
                }
                if (Temp == AraDeger)
                {
                    SatirBasiYap();
                    EkranaYaz("Girdiğiniz sayı Palindromdur.");
                    Bekle();
                }
                else
                {
                    SatirBasiYap();
                    EkranaYaz("Girdiğiniz sayı Palindrom değildir.");
                    Bekle();
                }
            }
            EkranaYaz(hataMesaji);
            SatirBasiYap();
            return KontrolluSayiAl(istekMesaji, hataMesaji);
        }

        static void SatirBasiYap()
        {
            Console.WriteLine();
        }

        static void Bekle()
        {
            Console.ReadKey();
        }
        static void EkranaYaz(string metin)
        {
            Console.Write(metin);
        }
        static string EkrandanOku()
        {
            return Console.ReadLine();
        }
    }
}

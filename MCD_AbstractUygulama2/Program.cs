using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_AbstractUygulama2
{
    class Program
    {
        static void Main(string[] args)
        {
            Gitar G1 = new Gitar()
            {
                Markasi = "Fender",
                MuzikAletiAdı  = "Gitar"
            };

            Flut F1 = new Flut();
            F1.Markasi = "Yamaha";
            F1.MuzikAletiAdı = "Flüt";

            Muzisyen M1 = new Muzisyen();
            M1.AdiSoyadi = "Onur Şan";
            M1.CaldigiMuzikAleti = G1;

            Muzisyen M2 = new Muzisyen()
            {
                CaldigiMuzikAleti = F1,
                AdiSoyadi = "Leman Sam"
            };

            Console.WriteLine(M1 .AdiSoyadi + " "+ M1 .CaldigiMuzikAleti.MuzikAletiAdı + " çalıyor...");
            M1.CaldigiMuzikAleti.Cal();

            Console.WriteLine(M2.AdiSoyadi + " " + M2.CaldigiMuzikAleti.MuzikAletiAdı  + " çalıyor...");
            M2.CaldigiMuzikAleti.Cal();

            Console.ReadKey();
        }
    }
}

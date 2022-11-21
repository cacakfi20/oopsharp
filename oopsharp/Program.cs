using System;

namespace oopsharp
{
    class Program
    {
        static void Main()
        {
            /*
                Objekt - cokoliv
                Třída - definice objektu, podle třídy vytváříme instance
                Instance - 1 konkrétní objekt z definice třídy
                Atributy - popisují co v sobě třída nese
                Metody - popisují jak se třída chová
            */
            
            Zak zak1 = new Zak();
            zak1.Jmeno = "Filip";
            zak1.Prijmeni = "Cacák";
            zak1.RokNarozeni = 2004;

            Zak zak2 = new Zak()
            {
                Jmeno = "Jan",
                Prijmeni = "Novák",
                RokNarozeni = 1998
            };

            Zak zak3 = new Zak("Petr", "Novotný", 1633);
            
            Zak zak4 = new Zak("Honza", "Černý");
            
            zak1.Pozdrav();
            zak1.VypisVek();
            
        }
    }
}
//Enrick De Munter 5ITN nr3 19/11/19
/* OPGAVE
 * ======
 * Vraag de geboortedatum van de gebruiker en toon de leeftijd zowel in jaren (vereenvoudigde berekening, m.a.w. 
 * je houdt geen rekening met het feit of de verjaardag al voorbij is) als in dagen, als in uren, als in minuten, als in seconden.
 * 
 * ANALYSE
 * =======
 * VRAAG    geboortedatum van de gebruiker
 * 
 * BEREKEN  de leeftijd van de persoon
 * 
 * TOON     leeftijd van de persoon
 * 
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leeftijdtweede
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaraties
            //inputvariabelen
            string naam, geboortedatuminvoer;
            //processingvariabelen
            DateTime geboortedatum, huidigedatum;
            ushort geboortejaar, huidigjaartal;
            byte leeftijd;
            //outputvariabelen
            string uitvoer;

            //input
            //vraag naam
            Console.Write("geef uw naam?: ");
            naam = Console.ReadLine();

            //vraag geboortedatum
            Console.Write("wat is uw geboortedatum");
            geboortedatuminvoer = Console.ReadLine();

            //pocessing 
            //parsen van input
            geboortedatum = DateTime.Parse(geboortedatuminvoer);
            //bereken huidig jaartal
            huidigedatum = DateTime.Today;
            huidigjaartal = (ushort)huidigedatum.Year;


            //bereken geboortejaar
            geboortejaar = (ushort)geboortedatum.Year;
            //bereken leeftijd
            leeftijd = (byte)((int)huidigjaartal - (int)geboortejaar);
            //bereken uitvoer
            uitvoer = $"{naam},u bent {leeftijd} jaar oud.";
            //output
            //toon uitvoer
            Console.WriteLine(uitvoer);

            //wachten
            Console.WriteLine();
            Console.WriteLine("druk op enter om af te sluiten");
            Console.ReadLine();
        }

    }
}

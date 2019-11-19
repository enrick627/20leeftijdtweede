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

            //DECLARATIES
            //inputvariabelen
            string naam, geboortedatumInvoer;

            //processingvariabelen
            DateTime geboortedatum, huidigeDatum;
            ushort geboortedatums, huidigdatums, geboortejaar, huidigjaartal;
            byte leeftijd1, leeftijd2, leeftijd3;

            //outputvariabelen
            string uitvoer;
            //INPUT
            // VRAAG naam
            Console.Write("Geef uw naam in, a.u.b.: ");
            naam = Console.ReadLine();

            // VRAAG geboortedatum
            Console.Write("Geef uw geboortedatum, a.u.b.: ");
            geboortedatumInvoer = Console.ReadLine();

            //PROCESSING
            // Parsen van input
            geboortedatum = DateTime.Parse(geboortedatumInvoer);

            // BEREKEN huidigJaartal (huidigeDatum.Year)
            huidigeDatum = DateTime.Today;
            huidigdatums = (ushort)huidigeDatum.Day;
            huidigjaartal = (ushort)huidigeDatum.Year;

            // BEREKEN geboortejaar (geboortedatum.Year)
            geboortedatums = (ushort)geboortedatum.Day;
            geboortejaar = (ushort)geboortedatum.Year;



            // BEREKEN leeftijd (huidigJaartal - geboortejaar)
            leeftijd1 = (byte)((int)huidigdatums - (int)geboortedatums);
            leeftijd2 = (byte)((int)huidigjaartal - (int)geboortejaar);

            if (huidigdatums < geboortedatums)
            {
                leeftijd2 = (byte)(leeftijd2 - 1);
            }


            // BEREKEN uitvoer (= "<naam>, u bent <leeftijd> jaar oud.")
            uitvoer = $"{naam}, u bent {leeftijd2}jaar en{leeftijd1} dagen oud.";


            //OUTPUT
            // TOON uitvoer
            Console.WriteLine(uitvoer);

            //Wachten...
            Console.WriteLine();
            Console.Write("Druk op Enter om af te sluiten... ");
            Console.ReadLine();
        }

    }
}

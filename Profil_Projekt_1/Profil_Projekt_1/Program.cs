using System;


namespace ExamplePrg
{
    class Program
    {

        static void Main(string[] args)
        { //Eingabe
          // Eingabe Länge 
            Console.WriteLine("Länger eingeben:");
            String eingabe = Console.ReadLine();
            double zahl = Convert.ToDouble(eingabe);


            // Eingabe Breite
            Console.WriteLine("Breite eingeben:");
            String eingabe2 = Console.ReadLine();
            double zahl2 = Convert.ToDouble(eingabe);


            // Eingabe Tiefe
            Console.WriteLine("Tiefe eingeben:");
            String eingabe3 = Console.ReadLine();
            double zahl3 = Convert.ToDouble(eingabe);


            //Querschnittfläche berechnung
            Querschnittfläche = zahl1 * zahl2 * zahl3



                // Initialisieren der Variablen
            double ergebnis;
            double divisor = 3;



            // Arithmetik
            ergebnis = zahl + zahl;
            ergebnis = zahl * 2;
            ergebnis = (zahl + zahl) * 2;
            ergebnis = Math.Pow(zahl, 2);
            ergebnis = zahl / divisor;

            // Ausgabe String generieren
            String ausgabetext1;
            ausgabetext1 = String.Format("AusgabeString = {0}", ergebnis);
            String ausgabetext2 = String.Format("AusgabeString = {0:0.00}", ergebnis);

            // Ausgabe
            Console.WriteLine("Ergebnis1: " + ergebnis);
            Console.WriteLine(ausgabetext1);
            Console.WriteLine("Ergebnis2: " + ausgabetext2);
            Console.WriteLine(String.Format("Ergebnis3: AusgabeString = {0:0.00}", ergebnis));
            Console.ReadKey();
        }

    }
}

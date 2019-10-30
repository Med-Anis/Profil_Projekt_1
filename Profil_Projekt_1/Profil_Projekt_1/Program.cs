using System;


namespace ExamplePrg
{
    class Program
    {

        static void Main(string[] args)
        { 
            
            
            //Eingabe

             
             
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


              //Eingabe Dicke 
              Console.WriteLine("Dicke eingeben:");
              String eingabe4 = Console.ReadLine();
              double zahl4 = Convert.ToDouble(eingabe);

        

            // Eingabe Dichte
            Console.WriteLine("Bitte geben sie die dichte des Profils");
            Console.ReadLine(D);



            //Querschnittfläche berechnung

            Console.WriteLine("Eigenschaften eingeben (L= 0 oder 1)");
            Console.ReadLine(L)


          


            while (L = 0) || (L = 1 );
            {
                
            
                if (L = 1) ;
                {
                    Querschnittfläche = (zahl1 * zahl2 * zahl3) - ((zahl1 - zahl4) * (zahl2 - zahl4));
                    Volume = (zahl1 * zahl2 * zahl3) - ((zahl1 - zahl4) * (zahl2 - zahl4) * zahl3);
                }




               else
               { 
                        Querschnittfläche2 = (zahl1 * zahl2 );
                        Volume2 = (zahl1 * zahl2 * zahl3);  
                }



                Gewuicht = Volume * Dichte;







            }

           //







            // Initialisieren der Variablen
            double ergebnis;
            double divisor = 3;
            double Querschnittfläche = 0;
            int L ;





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

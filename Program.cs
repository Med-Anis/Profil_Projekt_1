using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {

            // Eingabe von Hoehe
            Console.WriteLine("Eingabe H:");
            string eingabeH = Console.ReadLine();
            double zahlH = Convert.ToDouble(eingabeH);
            if (zahlH < 0)
            {
                Console.WriteLine("Eingabe muss größer als 0 sein!");

                eingabeH = Console.ReadLine(zahlH);
                double zahlH = Convert.ToDouble(eingabeH);
            }


            //Eingabe von Breite
            Console.WriteLine("Eingabe B:");
           string eingabeB = Console.ReadLine();
            double zahlB = Convert.ToDouble(eingabeB);
            if (zahlB < 0)
            {
                Console.WriteLine("Eingabe muss größer als 0 sein!");

                eingabeB = Console.ReadLine(zahlB);
                double zahlB = Convert.ToDouble(eingabeB);
            }



            //Eingabe Tiefe
            Console.WriteLine("Eingabe Tiefe:");
            string eingabeT = Console.ReadLine();
            double zahlT = Convert.ToDouble(eingabeT);
            if (zahlT < 0)
            {
                Console.WriteLine("Eingabe muss größer als 0 sein!");

                eingabeT = Console.ReadLine(zahlT);
                double zahlT = Convert.ToDouble(eingabeT);
            }



            //Eingabe von Dichte (Roh)
            Console.WriteLine("Eingabe Roh in kg/m³:");
            string eingabeR = Console.ReadLine();
            double zahlR = Convert.ToDouble(eingabeR);
            if (zahlR < 0)
            {
                Console.WriteLine("Eingabe muss größer als 0 sein!");

                eingabeR = Console.ReadLine(zahlR);
                double zahlR = Convert.ToDouble(eingabeR);
            }



            //Eingabe von Gravitation (g)
            Console.WriteLine("Eingabe Gravitation g in m/s²:");
            string eingabeG = Console.ReadLine();
            double zahlG = Convert.ToDouble(eingabeG);
            if (zahlG < 0)
            {
                Console.WriteLine("Eingabe muss größer als 0 sein!");

                eingabeG = Console.ReadLine(zahlG);
                double zahlG = Convert.ToDouble(eingabeG);
            }




            //Eingabe Dicke 
            Console.WriteLine("Dicke eingeben:");
            String eingabeD = Console.ReadLine();
            double zahlD = Convert.ToDouble(eingabe);
            if (zahlD < 0)
            {
                Console.WriteLine("Eingabe muss größer als 0 sein!");

                eingabeD = Console.ReadLine(zahlD);
                double zahlD = Convert.ToDouble(eingabDG);
            }



            //Berechnungen
            Console.WriteLine("Eigenschaften eingeben (L= 0 oder 1)");
            double L = Convert.ToDouble(L);
            Console.WriteLine(L)
            while (L = 0) || (L = 1);
            {
                if (L = 1) ;
                {

                    //Area
                    Console.WriteLine("Flächeninhalt in m²:");
                    double zahlA = Convert.ToDouble((zahlH * zahlB ) - ((zahlH - zahlD) * (zahlB - zahlD)););
                    Console.WriteLine(ZahlA);


                    // Volumen
                    Console.WriteLine("Volumen in m³:");
                    double zahlV = Convert.ToDouble((zahlH * zahlB * zahlT) - ((zahlH - zahlD) * (zahlB - zahlD) * zahlT););
                    Console.WriteLine(zahlV);

                }

             else
                //Area
                Console.WriteLine("Flächeninhalt in m²:");
                double zahlA = Convert.ToDouble(zahlH * zahlB);
                Console.WriteLine(ZahlA);
                // Volumen
                Console.WriteLine("Volumen in m³:");
                double zahlV = Convert.ToDouble(zahlH * zahlB * zahlT);
                Console.WriteLine(zahlV);
            }

            //Gewicht
            Console.WriteLine("Gewicht in kg:");
            double Zahlm = Convert.ToDouble( zahlV  * zahlR);
            Console.WriteLine(Zahlm);

            


        }
    }
}

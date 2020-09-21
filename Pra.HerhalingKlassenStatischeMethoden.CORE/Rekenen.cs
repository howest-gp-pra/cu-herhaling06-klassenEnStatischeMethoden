using System;
using System.Collections.Generic;
using System.Text;

namespace Pra.HerhalingKlassenStatischeMethoden.CORE
{
    public class Rekenen
    {
        // deze klasse bevat enkel STATISCHE methoden
        // van dergelijke klassen hoef je geen object te maken : m.a.w.
        // bij gebruik dien je het NEW keyword NIET te gebruiken
        // Dergelijke klassen houden geen gegevens bij maar bieden dus enkel functionaliteiten aan


        // de methoden bieden we (waar mogelijk) in meerdere versies aan
        // we gaan dus m.a.w. elke methode ook nog eens gaan over overladen

        // de methode Som wordt aangeboden in 6 verschillende versies
        public static int Som(int getal1, int getal2)
        {
            return (getal1 + getal2);
        }
        public static double Som(double getal1, double getal2)
        {
            return (getal1 + getal2);
        }
        public static int Som(int[] getallen)
        {
            int som = 0;
            foreach (int getal in getallen)
            {
                som += getal;
            }
            return som;
        }
        public static int Som(List<int> getallen)
        {
            int som = 0;
            foreach (int getal in getallen)
            {
                som += getal;
            }
            return som;
        }
        public static double Som(double[] getallen)
        {
            int som = 0;
            foreach (int getal in getallen)
            {
                som += getal;
            }
            return som;
        }
        public static double Som(List<double> getallen)
        {
            int som = 0;
            foreach (int getal in getallen)
            {
                som += getal;
            }
            return som;
        }

        // de methode verschil bieden we aan in 2 versies

        public static int Verschil(int aftrekgetal, int aftrekker)
        {
            return (aftrekgetal - aftrekker);
        }
        public static double Verschil(double aftrekgetal, double aftrekker)
        {
            return (aftrekgetal - aftrekker);
        }

        // de methode product bieden we aan in 4 verschillende formaten

        public static int Product(int getal1, int getal2)
        {
            return (getal1 + getal2);
        }
        public static double Product(double getal1, double getal2)
        {
            return (getal1 + getal2);
        }

        // IEnumerable hebben we in de cursus nog niet besproken
        // weet dat zowel de Array als de List IEnumerable "implementeren" (zie verder in de cursus PRA)
        // dit betekent dat we naar deze methode zowel een array als een list kunnen sturen : nog zo handig, niet?
        public static int Product(IEnumerable<int> getallen)
        {
            int som = 1;
            foreach (int getal in getallen)
            {
                som *= getal;
            }
            return som;
        }
        public static double Product(IEnumerable<double> getallen)
        {
            double som = 1.0;
            foreach (int getal in getallen)
            {
                som *= getal;
            }
            return som;
        }

        // de methode quotient bieden we slechts in 1 versie aan
        public static double Quotient(double teller, double noemer)
        {
            return (teller / noemer);
        }
    }
}

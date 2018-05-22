using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hundeschule
{
    public class Hund : StateContext
    {
        public string name;
        public string laut;
        public int groesseInCm;
        public string verhalten;
        public int schwierigkeitslevel;
        public string hundBeschreibung;
        public string aktuellerZustand;
        //public iHundStatus hundStatus { get; set; } 

        public Hund()
        {
            name = Name();
            groesseInCm = Groesse();
            laut = LautVonSichGeben();
            Gehorsam(out string verhalten, out int schwierigkeitslevel);
            {
                this.verhalten = verhalten;
                this.schwierigkeitslevel = schwierigkeitslevel;
            }         

        }
                
        public void SetAktuellerZustand(string Zustand)
        {
            this.aktuellerZustand = Zustand;
        }

        public string HundBeschreibung(Hund objekt)
        {
            string beschreibung = "Mein Hund heisst ***" + objekt.name + "*** und ist etwa " + objekt.groesseInCm + " cm gross. " +
                                  "Er " + objekt.verhalten + ", dies entspricht dem Schwierigkeitsgrad " + objekt.schwierigkeitslevel + "! " +
                                  "Sein Bellen hört sich so an: <<< " + objekt.LautVonSichGeben() + " >>>";
            return beschreibung;
        }

        private string LautVonSichGeben()
        {
            Random rnd = new Random();
            string[] laut = { "Wuff", "Wuff Wuff", "Wuff Wuff Wuff", "Grrrrrhhhhh",
                                        "Kläff Kläff", "Grummel Grummel", "Pfffttttt"};

            //Generate random indexes
            int mIndex = rnd.Next(0, laut.Length);

            return Convert.ToString(laut[mIndex]);
            
        }

        private int Groesse()
        {
            Random rnd = new Random();
            int[] groesse = { 20, 25, 30, 35, 45, 50, 55, 60, 65, 70 };

            //Generate random indexes
            int mIndex = rnd.Next(0, groesse.Length);
                        
            return groesse[mIndex];
        }

        private void Gehorsam(out string verhaltenBeschreibung, out int verhaltenLevel)
        {
            Random rnd = new Random();
            string[] GehorsamStufen = { "hört aufs Wort", "hört meistens", "hört oft", "hört wenn er möchte",
                                        "hört selten", "hört so gut wie gar nicht", "macht was er möchte"};

            //Generate random indexes
            int mIndex = rnd.Next(0, GehorsamStufen.Length);

            //Display the result.
            //Console.WriteLine("Der Hund entspricht Schwierigkeitslevel: {0}", mIndex);
            //Console.WriteLine("Der Hund ... {0}!", GehorsamStufen[mIndex]);

            verhaltenBeschreibung = Convert.ToString(GehorsamStufen[mIndex]);
            verhaltenLevel = mIndex;
        }

        private string Name()
        {
            Random rnd = new Random();
            string[] PetNames = { "Rufus", "Bear", "Dakota", "Fido",
                                "Vanya", "Samuel", "Koani", "Volodya",
                                "Prince", "Yiska" , "Maggie", "Penny", "Saya", "Princess",
                                  "Abby", "Laila", "Sadie", "Olivia",
                                  "Starlight", "Talla" };

            // Generate random indexes
            int mIndex = rnd.Next(0, PetNames.Length);

            //Display the result.            
            //Console.WriteLine("Der Name des Hundes lautet: {0}", PetNames[mIndex]);

            return Convert.ToString(PetNames[mIndex]);
        }
                
    }
}

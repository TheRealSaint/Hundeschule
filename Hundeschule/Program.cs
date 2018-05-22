using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hundeschule
{
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            Hund myDog = new Hund();
            //Console.WriteLine("Mein Hund heisst ***"+ myDog.name + "*** und ist etwa" + myDog.groesseInCm + "cm gross. \n" +
            //                    "Er "+ myDog.verhalten + ", dies entspricht dem Schwierigkeitsgrad " + myDog.schwierigkeitslevel + "!\n" +
            //                    "Sein Bellen hört sich so an: " + myDog.LautVonSichGeben()
            //                    );
            

        }
    }
}

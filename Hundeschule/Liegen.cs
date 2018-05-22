using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hundeschule
{
    class Liegen : iHundStatus
    {
        private Hund hund;

        //Konstruktor
        public Liegen(Hund einHund)
        {
            this.hund = einHund;
        }

        public void stehen()
        {
            //string status = "steht";
            //hund.setAktuellerZustand(status);
        }

        public void laufen()
        {
            //string status = "läuft";
            //hund.setAktuellerZustand(status);
        }

        public void liegen()
        {
            string status = "liegt";
            hund.setAktuellerZustand(status);
        }

        public void sitzen()
        {
            //string status = "sitzt";
            //hund.setAktuellerZustand(status);
        }
    }
}

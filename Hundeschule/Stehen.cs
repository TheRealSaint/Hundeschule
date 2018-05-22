using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hundeschule
{
    class Stehen : IHundStatus
    {
        //public void Stehen()
        //{
        //    string status = "steht";
        //    hund.setAktuellerZustand(status);
        //}
        
        public void Change(StateContext context)
        {
            context.State = new Laufen();
        }
    }    
}

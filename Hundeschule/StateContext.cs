using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hundeschule
{
    public class StateContext
    {
        //Variable zum halten des aktuellen Status
        public IHundStatus State { get; set; }

        //Wechseln des Status
        public void Change()
        {
            State.Change(this);
        }
    }
}

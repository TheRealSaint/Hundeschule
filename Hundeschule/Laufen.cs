using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hundeschule
{
    class Laufen : IHundStatus
    {
        public void Change(StateContext context)
        {
            context.State = new Liegen();
        }
    }
}

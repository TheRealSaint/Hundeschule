using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hundeschule
{
    class Sitzen : IHundStatus
    {
        public void Change(StateContext context)
        {
            context.State = new Stehen();
        }
    }
}

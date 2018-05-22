using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hundeschule
{
    public interface IHundStatus
    {
        void Change(StateContext context);        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hundeschule
{
    public interface iHundStatus
    {
        void stehen();
        void sitzen();
        void liegen();
        void laufen();
    }
}

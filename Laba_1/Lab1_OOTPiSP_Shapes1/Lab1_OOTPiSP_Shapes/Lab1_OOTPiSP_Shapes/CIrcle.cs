using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lab1_OOTPiSP_Shapes
{
    class Circle: Ellipse
    {
        public Circle (int x, int y, int diametr): base (x, y, diametr, diametr) { }
    }
}

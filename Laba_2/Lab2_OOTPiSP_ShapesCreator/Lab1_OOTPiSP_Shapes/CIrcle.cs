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
        public Circle (int x, int y, int diametr, Pen pen): base (x, y, diametr, diametr, pen) { }

        public override void setProperties(int endX, int endY)
        {
            int diametr = (int)(Math.Sqrt(Math.Pow(Math.Abs(endX - coordinate.X), 2) + Math.Pow(Math.Abs(endY - coordinate.Y), 2)));
            width = (int)(diametr / Math.Sqrt(2));
            height = (int)(diametr / Math.Sqrt(2));
        }
    }
}

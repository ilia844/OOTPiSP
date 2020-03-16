using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lab1_OOTPiSP_Shapes
{
    public abstract class Shape
    {
        Coordinate coordinate;

        public abstract void Draw(Graphics graphics );
    }
}

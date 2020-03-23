using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lab1_OOTPiSP_Shapes
{
    public class Sqare: Rectangle 
    {
        public Sqare(int x, int y, int length, Pen pen) : base(x, y, length, length, pen) { }

        public override void setProperties(int endX, int endY)
        {
            int diagonal = (int)(Math.Sqrt(Math.Pow(Math.Abs(endX - coordinate.X), 2) + Math.Pow(Math.Abs(endY - coordinate.Y), 2)));
            width = (int)(diagonal / Math.Sqrt(2));
            height = (int)(diagonal / Math.Sqrt(2));
        }

    }
}

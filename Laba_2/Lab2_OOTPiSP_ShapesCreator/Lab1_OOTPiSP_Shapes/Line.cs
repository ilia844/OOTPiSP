using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lab1_OOTPiSP_Shapes
{
    public class Line: Shape
    {
        private Point endPt;

        public Line(int x, int y, int width, int height): base (x, y) {
            this.endPt.X = x + width;
            this.endPt.Y = y + height;
        }

        public override void Draw(Graphics graphics) {
           graphics.DrawLine(pen, coordinate, endPt);
        }

    }
}

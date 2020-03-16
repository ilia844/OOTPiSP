using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lab1_OOTPiSP_Shapes
{
    public class Ellipse: Shape
    {
        private int width, height;

        public Ellipse(int x, int y, int width, int height) : base(x, y) {
            this.width = width;
            this.height = height;
        }

        public override void Draw(Graphics graphics) {
            graphics.DrawEllipse(pen, coordinate.X, coordinate.Y, width, height);
        }       
    }
}

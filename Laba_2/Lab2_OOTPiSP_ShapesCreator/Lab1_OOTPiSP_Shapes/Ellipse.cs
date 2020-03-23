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
        protected int width, height;

        public Ellipse(int x, int y, int width, int height, Pen pen) : base(x, y, pen) {
            this.width = width;
            this.height = height;
        }

        public override void setProperties(int endX, int endY)
        {
            width = endX - coordinate.X;
            height = endY - coordinate.Y;
        }

        public override void Draw(Graphics graphics) {
            graphics.DrawEllipse(pen, coordinate.X, coordinate.Y, width, height);
        }       
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lab1_OOTPiSP_Shapes
{
    public class Rectangle: Shape
    {
        protected int width, height;

        public Rectangle (int x, int y, int width, int height, Pen pen): base (x, y, pen) {
            this.width =  width;
            this.height = height;
        }

        public override void setProperties(int endX, int endY)
        {
            width = Math.Abs(endX - coordinate.X);
            height = Math.Abs(endY - coordinate.Y);
        }

        public override void Draw (Graphics graphics) {
            graphics.DrawRectangle(pen, coordinate.X, coordinate.Y, width, height);
        }    
    }
}

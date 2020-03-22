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
        private int width;
        private int height;

        public Rectangle (int x, int y, int width, int height): base (x, y) {
            this.width =  width;
            this.height = height;
        }

        public override void Draw (Graphics graphics) {
            graphics.DrawRectangle(pen, coordinate.X, coordinate.Y, width, height);
        }    
    }
}

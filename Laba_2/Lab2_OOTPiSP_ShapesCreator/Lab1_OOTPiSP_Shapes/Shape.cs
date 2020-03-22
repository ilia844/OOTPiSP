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
        protected Point coordinate;
        protected Pen pen;

        public Shape(int x, int y)

        {
            Random random = new Random();

            int penWidth = random.Next(1, 10);
            var color = Color.FromArgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255));

            pen = new Pen(color, penWidth);
            coordinate.X = x;
            coordinate.Y = y;
        }

        public abstract void Draw(Graphics graphics);
    }
}

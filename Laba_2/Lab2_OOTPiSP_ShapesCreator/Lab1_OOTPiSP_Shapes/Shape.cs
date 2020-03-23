using System;
using System.Drawing;

namespace Lab1_OOTPiSP_Shapes
{
    public abstract class Shape
    {
        protected Point coordinate;
        protected Pen pen;

        public Shape(int x, int y, Pen pen)

        {
            Random random = new Random();

//            int penWidth = random.Next(1, 10);
 //           var color = Color.FromArgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255));

            this.pen = pen;
            coordinate.X = x;
            coordinate.Y = y;
        }

        public void setStartPosition(int x, int y)
        {
            coordinate.X = x;
            coordinate.Y = y;
        }

        public void setPenWidth(int width)
        {
            pen.Width = width;
        }

        public void setPenColor(Color color)
        {
            pen.Color = color;
        }

        public abstract void setProperties(int endX, int endY);
        public abstract void Draw(Graphics graphics);
    }
}

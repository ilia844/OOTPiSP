using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Lab1_OOTPiSP_Shapes
{
    public class Triangle: Shape
    {
        private Point SecondPt, ThirdPt;
        private GraphicsPath graphPath = new GraphicsPath();

        public Triangle (int x1, int y1, int x2, int y2, int x3, int y3): base (x1, y1) {
            this.SecondPt.X = x2;
            this.SecondPt.Y = y2;
            this.ThirdPt.X = x3;
            this.ThirdPt.Y = y3;
            graphPath.AddLine(coordinate, SecondPt);
            graphPath.AddLine(SecondPt, ThirdPt);
            graphPath.AddLine(ThirdPt, coordinate);
        }

        public override void Draw (Graphics graphics) {
            graphics.DrawPath(pen, graphPath);
        }
    }
}

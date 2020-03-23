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
        private Point FirstPt, SecondPt, ThirdPt;
        private GraphicsPath graphPath = new GraphicsPath();

        public Triangle (int x1, int y1, int x2, int y2, int x3, int y3, Pen pen): base (x1, y1, pen) {
            this.SecondPt.X = x2;
            this.SecondPt.Y = y2;
            this.ThirdPt.X = x3;
            this.ThirdPt.Y = y3;
        }

        public override void setProperties(int endX, int endY)
        {
            int triangleBase = Math.Abs(endX - coordinate.X);
            FirstPt = new Point(coordinate.X + triangleBase / 2, coordinate.Y);
            SecondPt = new Point(endX - triangleBase, endY);
            ThirdPt = new Point(endX, endY);
        //    graphPath.ClearMarkers();
        //    graphPath.AddLine(FirstPt, SecondPt);
        //    graphPath.AddLine(SecondPt, ThirdPt);
        //    graphPath.AddLine(ThirdPt, FirstPt);
        }

        public override void Draw (Graphics graphics) {
        //    graphics.DrawPath(pen, graphPath);
            graphics.DrawLine(pen, FirstPt, SecondPt);
            graphics.DrawLine(pen, SecondPt, ThirdPt);
            graphics.DrawLine(pen, ThirdPt, FirstPt);
        }
    }
}

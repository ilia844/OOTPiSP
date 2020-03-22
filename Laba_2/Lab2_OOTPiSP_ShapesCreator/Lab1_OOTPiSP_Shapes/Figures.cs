using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1_OOTPiSP_Shapes
{
    public partial class Figures : Form
    {

        Graphics canvas;
        List<Shape> listOfShapes = new List<Shape>();
        Random random = new Random();

        public Figures()
        {
            InitializeComponent();
        }

        private void Figures_Load(object sender, EventArgs e)
        {
            canvas = pictureBox1.CreateGraphics();         
        }

        private void btLine_Click(object sender, EventArgs e)
        {
            var coordinate = getCoordinate();
//           int penWidth = random.Next(1, 10);
//           var color = Color.FromArgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255));

//          listOfShapes.Add(new Line(coordinate.X, coordinate.Y, 50, 50, new Pen(color, penWidth)));           
            listOfShapes.Add(new Line(coordinate.X, coordinate.Y, 50, 50)); 
        }

        private Point getCoordinate() 
        {
            const int SHAPE_SIZE = 50;
            const int BORDER = 20;
            var coordinate = new Point();

            coordinate.Y = (listOfShapes.Count / 9) * (SHAPE_SIZE + BORDER);
            coordinate.X = (listOfShapes.Count % 9) * (SHAPE_SIZE + BORDER);
            return coordinate;
        }

        private void btSqare_Click(object sender, EventArgs e)
        {
            var coordinate = getCoordinate();
//          int penWidth = random.Next(1, 10);
//          var color = Color.FromArgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255));

            listOfShapes.Add(new Sqare(coordinate.X, coordinate.Y, 50));
        }

        private void btRectangle_Click(object sender, EventArgs e)
        {
            var coordinate = getCoordinate();
//          int penWidth = random.Next(1, 10);
//          var color = Color.FromArgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255));

            listOfShapes.Add(new Rectangle(coordinate.X, coordinate.Y, 50, 30));
        }

        private void btTriangle_Click(object sender, EventArgs e)
        {
            var coordinate = getCoordinate();
//          int penWidth = random.Next(1, 10);
//            var color = Color.FromArgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255));

            listOfShapes.Add(new Triangle(coordinate.X, coordinate.Y, coordinate.X + 50, coordinate.Y + 50, coordinate.X, coordinate.Y + 50));
        }

        private void btCircle_Click(object sender, EventArgs e)
        {
            var coordinate = getCoordinate();
//            int penWidth = random.Next(1, 10);
//            var color = Color.FromArgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255));

            listOfShapes.Add(new Circle(coordinate.X, coordinate.Y, 50));
        }

        private void btEllipse_Click(object sender, EventArgs e)
        {
            var coordinate = getCoordinate();
//            int penWidth = random.Next(1, 10);
//            var color = Color.FromArgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255));

            listOfShapes.Add(new Ellipse(coordinate.X, coordinate.Y, 50, 30));
        }

        private void btDraw_Click(object secnder, EventArgs e)
        {
            foreach (Shape shape in listOfShapes)
            {
                shape.Draw(canvas);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}

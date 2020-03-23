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

//        Graphics mainCanvas;
        Graphics tempCanvas;
        Image image;
        Graphics mainImage;
        Shape model;

        bool isDrawing;

        public Figures()
        {
            InitializeComponent();
        }

        private void Figures_Load(object sender, EventArgs e)
        {
            tempCanvas = pbTemp.CreateGraphics();
//            mainCanvas = pbMain.CreateGraphics();
            image = new Bitmap(pbTemp.Width, pbTemp.Height);
            mainImage = Graphics.FromImage(image);

            pbViewPenColor.BackColor = cdPenColor.Color;
        }

        private void btLine_Click(object sender, EventArgs e)
        {
            model = new Line(0, 0, 0, 0, new Pen(cdPenColor.Color, tbPenWidth.Value));
        }

        private void btSqare_Click(object sender, EventArgs e)
        {
            model = new Sqare(0, 0, 0, new Pen(cdPenColor.Color, tbPenWidth.Value));
        }

        private void btRectangle_Click(object sender, EventArgs e)
        {
            model = new Rectangle(0, 0, 0, 0, new Pen(cdPenColor.Color, tbPenWidth.Value));
        }

        private void btTriangle_Click(object sender, EventArgs e)
        {
            model = new Triangle(0, 0, 0, 0, 0, 0, new Pen(cdPenColor.Color, tbPenWidth.Value));
        }

        private void btCircle_Click(object sender, EventArgs e)
        {
            model = new Circle(0, 0, 0, new Pen(cdPenColor.Color, tbPenWidth.Value));
        }

        private void btEllipse_Click(object sender, EventArgs e)
        {
            model = new Ellipse(0, 0, 0, 0, new Pen(cdPenColor.Color, tbPenWidth.Value));
        }

        private void pbTemp_MouseDown(object sender, MouseEventArgs e)
        {
            if (model != null)
            {
                model.setStartPosition(e.X, e.Y);
                isDrawing = true;
            }            
        }

        private void pbTemp_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                model.setProperties(e.X, e.Y);
                tempCanvas.Clear(pbTemp.BackColor);
                model.Draw(tempCanvas);
            }
        }

        private void pbTemp_MouseUp(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                model.Draw(mainImage);
                tempCanvas.DrawImage(image, 0, 0);
            }
            isDrawing = false;
        }

        private void btNUgolnik_Click(object sender, EventArgs e)
        {
            if (cdPenColor.ShowDialog() == DialogResult.Cancel)
                return;
            pbViewPenColor.BackColor = cdPenColor.Color;
        }

        private void pbViewPenColor_BackColorChanged(object sender, EventArgs e)
        {
            if (model != null)
            {
                model.setPenColor(cdPenColor.Color);
            }
        }

        private void tbPenWidth_ValueChanged(object sender, EventArgs e)
        {
            if (model != null)
            {
                model.setPenWidth(tbPenWidth.Value);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project2
{
    public partial class frmDrawing : Form
    {
        public frmDrawing()
        {
            InitializeComponent();
        }

        private void frmDrawing_Paint(object sender, PaintEventArgs e)
        {
            Color Black = Color.FromArgb(255, 0, 0, 0);

            Pen pen = new Pen(Black);

            pen.Width = 2;

            pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.DiamondAnchor;

            e.Graphics.DrawLine(pen, 100, 500, 100, 200);
            e.Graphics.DrawRectangle(pen, 100, 100, 300, 200);
            e.Graphics.DrawEllipse(pen, 200, 255, 100, 100); 
        }

    }
}

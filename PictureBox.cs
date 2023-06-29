using Project2.Properties;
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
    public partial class PictureBox : Form
    {
        public PictureBox()
        {
            InitializeComponent();
        }

        private void PictureBox_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image  = Resources.pic1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.pic2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(@"D:\\dowmloads\\Background\pic3.jpg");
        }
    }
}

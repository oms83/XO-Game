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
    public partial class Exercise : Form
    {
        public Exercise()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Exercise_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        void SetTitle()
        {
            if(rbGril.Checked)
            {
                label1.Text = rbGril.Text;
            }
            if(rbBook.Checked)
            {
                label1.Text = rbBook.Text;
            }
            if(rbBoy.Checked)
            {
                label1.Text = rbBoy.Text;
            }
            if(rbPen.Checked)
            {
                label1.Text = rbPen.Text;
            }
        }
        private void rbGril_CheckedChanged(object sender, EventArgs e)
        {
            //SetTitle();
            pictureBox1.Image = Resources.girl;            
            label1.Text = ((RadioButton) sender).Tag.ToString();
        }

        private void rbBoy_CheckedChanged(object sender, EventArgs e)
        {
            //SetTitle();
            pictureBox1.Image = Resources.boy;
            label1.Text = ((RadioButton) sender).Tag.ToString();
        }

        private void rbPen_CheckedChanged(object sender, EventArgs e)
        {
            //SetTitle();
            pictureBox1.Image = Resources.pen;
            label1.Text = ((RadioButton) sender).Tag.ToString();
        }

        private void rbBook_CheckedChanged(object sender, EventArgs e)
        {
            //SetTitle();
            pictureBox1.Image = Resources.book;
            label1.Text = ((RadioButton) sender).Tag.ToString();
        }

    }
}

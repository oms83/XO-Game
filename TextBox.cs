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
    public partial class TextBox : Form
    {
        public TextBox()
        {
            InitializeComponent();
        }

        private void btnFocus_Click(object sender, EventArgs e)
        {
            textBox7.Focus();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScrollBar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void HScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            label1.Text = Convert.ToString(hScrollBar1.Value);
            label1.BackColor = Color.FromArgb(hScrollBar1.Value, 0, 0);
        }
    }
}

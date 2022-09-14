using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button_decimal_Click(object sender, EventArgs e)
        {

            userControl11.BringToFront();
        }

        private void Button_binary_Click(object sender, EventArgs e)
        {
            userControl21.BringToFront();
        }

        private void Button_octal_Click(object sender, EventArgs e)
        {
            userControl31.BringToFront();
        }

        private void Button_hexa_Click(object sender, EventArgs e)
        {
            userControl41.BringToFront();
        }

        private void Button_decimal_MouseCaptureChanged(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }
        private void Plusbutton_Click(object sender, EventArgs e)
        {
            string input1 = Num1text.Text;
            string input2 = Num2text.Text;
            Anstext.Text = (double.Parse(input1) + double.Parse(input2)).ToString();
        }

        private void Minusbutton_Click(object sender, EventArgs e)
        {
            string input1 = Num1text.Text;
            string input2 = Num2text.Text;
            Anstext.Text = (double.Parse(input1) - double.Parse(input2)).ToString();
        }

        private void Timesbutton_Click(object sender, EventArgs e)
        {
            string input1 = Num1text.Text;
            string input2 = Num2text.Text;
            Anstext.Text = (double.Parse(input1) * double.Parse(input2)).ToString();
        }

        private void Dividedbutton_Click(object sender, EventArgs e)
        {
            string input1 = Num1text.Text;
            string input2 = Num2text.Text;
            Anstext.Text = (double.Parse(input1) / double.Parse(input2)).ToString();
        }
    }
}

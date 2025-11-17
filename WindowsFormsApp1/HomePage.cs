using StudentStructForm;
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
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Helloform hf = new Helloform();
            hf.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            POSform POS = new POSform();
            POS.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            StudentStruct Student = new StudentStruct();
            Student.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Calculator cla = new Calculator();
            cla.Show();
        }
    }
}

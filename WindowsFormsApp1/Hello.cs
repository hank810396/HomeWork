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
    public partial class Helloform : Form
    {
        public Helloform()
        {
            InitializeComponent();
        }

        private void Hibutton_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Hi!我是{Nametext.Text}\n"
            + $"英文名字是{Engtext.Text}\n"
            + $"性別是{Gendertext.Text}\n"
            + $"星座是{Startext.Text}\n"
            + $"很高興認識你!");
        }

        private void Hellobutton_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Hello!我是{Nametext.Text}\n"
            + $"英文名字是{Engtext.Text}\n"
            + $"性別是{Gendertext.Text}\n"
            + $"星座是{Startext.Text}\n"
            + $"很高興認識你!");
        }
    }
}

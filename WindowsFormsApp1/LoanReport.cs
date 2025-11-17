using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Report : Form
    {
        public Report(string LoanAmount, string LoanTerm, string Interest, string MonthlyPay, string TotalPay)
        {
            InitializeComponent();

            Moneytext2.Text = LoanAmount;
            Yeartext2.Text = LoanTerm;
            Ratetext2.Text = Interest;
            MonthPaytext.Text = MonthlyPay;
            TotalPaytext.Text = TotalPay;
        }
    }
}

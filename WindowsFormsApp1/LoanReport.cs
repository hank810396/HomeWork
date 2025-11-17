using System.Windows.Forms;

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

using System;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace LoanAmountForm
{
    public partial class Loan : Form
    {
        public string MonthlyPay { get; private set; }
        public string TotalPay { get; private set; }

        public Loan()
        {
            InitializeComponent();
        }

        public void PMTcalculation()
        {
            double LoanAmount = double.Parse(Moneytext.Text); //貸款金額
            int LoanTerm = int.Parse(Yeartext.Text); //貸款年限
            double InterestRate = double.Parse(Ratetext.Text); //年利率
            double DownPayment = double.Parse(DownPaytext.Text); //頭期款

            double MonthlyLoanTerm = LoanTerm * 12; //貸款月數
            double MonthlyRate = InterestRate / 12 / 100; //月利率=年利率/12

            double MonthlyPayValue = LoanAmount * (MonthlyRate * Math.Pow(1 + MonthlyRate, MonthlyLoanTerm)) / (Math.Pow(1 + MonthlyRate, MonthlyLoanTerm) - 1);
            //月還款金額=本金*[月利率*(1+月利率)^月數]/[(1+月利率)^(月數-1)]

            MonthlyPay = MonthlyPayValue.ToString("F2");
            MessageBox.Show("月付額: " + MonthlyPay + " 元");
        }

        public void Totalcalculation()
        {
            double LoanAmount = double.Parse(Moneytext.Text); //貸款金額
            int LoanTerm = int.Parse(Yeartext.Text); //貸款年限
            double InterestRate = double.Parse(Ratetext.Text); //年利率
            double DownPayment = double.Parse(DownPaytext.Text); //頭期款

            double MonthlyLoanTerm = LoanTerm * 12; //貸款月數
            double MonthlyRate = InterestRate / 12 / 100; //月利率=年利率/12

            double MonthlyPay = LoanAmount * (MonthlyRate * Math.Pow(1 + MonthlyRate, MonthlyLoanTerm)) / (Math.Pow(1 + MonthlyRate, MonthlyLoanTerm) - 1);
            //月還款金額=本金*[月利率*(1+月利率)^月數]/[(1+月利率)^(月數-1)]

            double TotalPayValue = MonthlyPay * MonthlyLoanTerm;
            //總還款金額 = 每月應付本息金額 × 總月數 

            TotalPay = TotalPayValue.ToString("F2");
            MessageBox.Show("總付款: " + TotalPay + " 元");
        }

        private void PMTbutton_Click(object sender, EventArgs e)
        {
            PMTcalculation();
        }

        private void Totalbutton_Click(object sender, EventArgs e)
        {
            Totalcalculation();
        }

        private void Reportbutton_Click(object sender, EventArgs e)
        {
            var Report = new Report 
            (
           Moneytext.Text,
           Yeartext.Text,
           Ratetext.Text,
           MonthlyPay,
           TotalPay
            );
            Report.Show(); //顯示Report視窗
        }
    }
}



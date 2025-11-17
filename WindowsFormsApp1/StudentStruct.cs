using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentStructForm
{
    public partial class StudentStruct : Form
    {
        string SName;
        string ChineseGrade;
        string EnglishGrade;
        string MathGrade;
        public StudentStruct()
        {
            InitializeComponent();
            Storagebutton.Click += Storagebutton_Click;
            Displaybutton.Click += Displaybutton_Click;
            Displaylabel.Visible = false;
            HighLowlabel.Visible = false;
        }

        private void Storagebutton_Click(object sender, EventArgs e)
        {
            SName = Nametext.Text;
            ChineseGrade = Chinesetext.Text;
            EnglishGrade = Englishtext.Text;
            MathGrade = Mathtext.Text;
            //Displaybutton_Click(sender,e);
        }
        private void Displaybutton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(SName) ||
                string.IsNullOrWhiteSpace(ChineseGrade) ||
                string.IsNullOrWhiteSpace(EnglishGrade) ||
                string.IsNullOrWhiteSpace(MathGrade))
            {
                Displaylabel.Visible = false;
                return;
            }

            Displaylabel.Visible = true;
            Displaylabel.Text = $"姓名: {SName} \n國文: {ChineseGrade} \n英文: {EnglishGrade} \n數學: {MathGrade}";
        }

        private void HighLowbutton_Click(object sender, EventArgs e)
        {
            int cn = int.Parse(ChineseGrade);
            int en = int.Parse(EnglishGrade);
            int ma = int.Parse(MathGrade);

            int max = Math.Max(cn, Math.Max(en, ma));
            int min = Math.Min(cn, Math.Min(en, ma));

            string maxSubject = "";

            List<int> ints = new List<int>();
            ints.Add(cn);
            ints.Add(en);
            ints.Add(ma);
            int Max = ints.Max();
            int Min = ints.Min();

            Dictionary<string, int> subjectDict = new Dictionary<string, int>()
            {
                { "國文", cn  },
                { "英文", en  },
                { "數學", ma  }
            };
            /*
            if (max == cn) maxSubject = "國文";
            else if (max == en) maxSubject = "英文";
            else if (max == ma) maxSubject = "數學";

            string minSubject = "";
            if (min == cn) minSubject = "國文";
            else if (min == en) minSubject = "英文";
            else if (min == ma) minSubject = "數學";
            */
            var maxItem = subjectDict.FirstOrDefault(x => x.Value == Max);
            var minItem = subjectDict.FirstOrDefault(x => x.Value == Min);

            HighLowlabel.Visible = true;
            HighLowlabel.Text = $"最高科目成績為: {maxItem.Key} {maxItem.Value}分\n" +
                                $"最低科目成績為: {minItem.Key} {minItem.Value}分";
        }
    }
}


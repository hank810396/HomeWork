using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class POSform : Form
    {
        public POSform()
        {
            InitializeComponent();
        }
        public class product
        {
            public string Name { get; set; }
            public int Price { get; set; }
            public int Count { get; set; }

            public int subtotal { get { return Price * Count; } }

            public product(string name, int price)
            {
                Name = name;
                Price = price;
                Count = 0;
            }
        }

        List<product> products = new List<product>() // 建立商品資料
        {
            new product("啤酒", 120),
            new product("龍舌蘭", 180),
            new product("威士忌", 350),
            new product("紅酒", 320)
        };

        int Total = 0;

        private void AddItem(string name, string English, int price)  // 新增商品至清單
        {
            foreach (var p in products)
            {
                if (p.Name == name)
                {
                    p.Count++;
                    Total += p.Price;
                    break;
                }
            }
            Totaltext.Text = $"NT$ {Total}";
            UpdateListBox();
        }

        private void UpdateListBox() //更新清單顯示
        {
            listBox1.Items.Clear();
            foreach (var p in products.Where(x => x.Count > 0))
            {
                listBox1.Items.Add($"{p.Name} × {p.Count} = 共{p.subtotal}元");
            }
        }

        private void Beerbutton_Click(object sender, EventArgs e)
        {
            AddItem("啤酒", "Beer", 120);
        }

        private void Tequilabutton_Click(object sender, EventArgs e)
        {
            AddItem("龍舌蘭", "Tequila", 180);
        }

        private void Whiskybutton_Click(object sender, EventArgs e)
        {
            AddItem("威士忌", "Whisky", 350);
        }
        private void Winebutton_Click(object sender, EventArgs e)
        {
            AddItem("紅酒", "Wine", 320);
        }

        private void Cashbutton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("總金額:" + Totaltext.Text);
        }

        private void Creditbutton_Click(object sender, EventArgs e)
        {
            double DiscountTotal = Total * 0.9;
            MessageBox.Show($"總金額:{Totaltext.Text}\n折扣後金額:NT${DiscountTotal}");
        }

        private void Cleanbutton_Click(object sender, EventArgs e) // 清空清單
        {
            listBox1.Items.Clear(); //清空ListBox

            Total = 0;
            Totaltext.Text = Total.ToString(); //重置總金額

            foreach (var item in products)
            {
                item.Count = 0; //重製商品數量
            }
        }
    }
}

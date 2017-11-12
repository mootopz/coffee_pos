using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace coffee_pos_603410071_9
{
    public partial class Form1 : Form
    {
        int i = 0 , j = 1;
        double total;
        string[] no = new string[50];
        string[] menu = new string[50];
        string[] price = new string[50];
        string w;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tb_total.Enabled = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            total += 35;
            tb_total.Text = total.ToString() + ".00 THB";
            no[i] = (i + 1).ToString()+".";
            menu[i] = "Esspresso (Hot)";
            price[i] = "35";
            w += menu[i] + "     " + price[i]+Environment.NewLine;
            list();
            i++;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            total += 45;
            tb_total.Text = total.ToString() + ".00 THB";
            no[i] = (i + 1).ToString() + ".";
            menu[i] = "Esspresso (Ice)";
            price[i] = "45";
            w += menu[i] + "     " + price[i] + Environment.NewLine;
            list();
            i++;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            total += 50;
            tb_total.Text = total.ToString() + ".00 THB";
            no[i] = (i + 1).ToString() + ".";
            menu[i] = "Esspresso (Frappe)";
            price[i] = "50";
            w += menu[i] + "     " + price[i] + Environment.NewLine;
            list();
            i++;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            total += 35;
            tb_total.Text = total.ToString() + ".00 THB";
            no[i] = (i + 1).ToString() + ".";
            menu[i] = "Americano (Hot)";
            price[i] = "35";
            w += menu[i] + "     " + price[i] + Environment.NewLine;
            list();
            i++;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            total += 45;
            tb_total.Text = total.ToString() + ".00 THB";
            no[i] = (i + 1).ToString() + ".";
            menu[i] = "Americano (Ice)";
            price[i] = "45";
            w += menu[i] + "     " + price[i] + Environment.NewLine;
            list();
            i++;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            total += 35;
            tb_total.Text = total.ToString() + ".00 THB";
            no[i] = (i + 1).ToString() + ".";
            menu[i] = "Latte (Hot)";
            price[i] = "35";
            w += menu[i] + "     " + price[i] + Environment.NewLine;
            list();
            i++;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            total += 45;
            tb_total.Text = total.ToString() + ".00 THB";
            no[i] = (i + 1).ToString() + ".";
            menu[i] = "Latte (Ice)";
            price[i] = "45";
            list();
            i++;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            total += 50;
            tb_total.Text = total.ToString() + ".00 THB";
            no[i] = (i + 1).ToString() + ".";
            menu[i] = "Latte (Frappe)";
            price[i] = "50";
            w += menu[i] + "     " + price[i] + Environment.NewLine;
            list();
            i++;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            total += 35;
            tb_total.Text = total.ToString() + ".00 THB";
            no[i] = (i + 1).ToString() + ".";
            menu[i] = "Mocha (Hot)";
            price[i] = "35";
            w += menu[i] + "     " + price[i] + Environment.NewLine;
            list();
            i++;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            total += 45;
            tb_total.Text = total.ToString() + ".00 THB";
            no[i] = (i + 1).ToString() + ".";
            menu[i] = "Mocha (Ice)";
            price[i] = "45";
            w += menu[i] + "     " + price[i] + Environment.NewLine;
            list();
            i++;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            total += 50;
            tb_total.Text = total.ToString() + ".00 THB";
            no[i] = (i + 1).ToString() + ".";
            menu[i] = "Mocha (Frappe)";
            price[i] = "50";
            w += menu[i] + "     " + price[i] + Environment.NewLine;
            list();
            i++;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            total += 35;
            tb_total.Text = total.ToString() + ".00 THB";
            no[i] = (i + 1).ToString() + ".";
            menu[i] = "Cappuccino (Hot)";
            price[i] = "35";
            w += menu[i] + "     " + price[i] + Environment.NewLine;
            list();
            i++;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            total += 45;
            tb_total.Text = total.ToString() + ".00 THB";
            no[i] = (i + 1).ToString() + ".";
            menu[i] = "Cappuccino (Ice)";
            price[i] = "45";
            w += menu[i] + "     " + price[i] + Environment.NewLine;
            list();
            i++;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            total += 50;
            tb_total.Text = total.ToString() + ".00 THB";
            no[i] = (i + 1).ToString() + ".";
            menu[i] = "Cappuccino (Frappe)";
            price[i] = "50";
            w += menu[i] + "     " + price[i] + Environment.NewLine;
            list();
            i++;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            total += 20;
            tb_total.Text = total.ToString() + ".00 THB";
            no[i] = (i + 1).ToString() + ".";
            menu[i] = "GreenTea (Hot)";
            price[i] = "20";
            w += menu[i] + "     " + price[i] + Environment.NewLine;
            list();
            i++;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            total += 25;
            tb_total.Text = total.ToString() + ".00 THB";
            no[i] = (i + 1).ToString() + ".";
            menu[i] = "GreenTae (Ice)";
            price[i] = "25";
            w += menu[i] + "     " + price[i] + Environment.NewLine;
            list();
            i++;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            total += 30;
            tb_total.Text = total.ToString() + ".00 THB";
            no[i] = (i + 1).ToString() + ".";
            menu[i] = "GreenTea (Frappe)";
            price[i] = "30";
            w += menu[i] + "     " + price[i] + Environment.NewLine;
            list();
            i++;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            total += 20;
            tb_total.Text = total.ToString() + ".00 THB";
            no[i] = (i + 1).ToString() + ".";
            menu[i] = "ThaiTea (Hot)";
            price[i] = "20";
            w += menu[i] + "     " + price[i] + Environment.NewLine;
            list();
            i++;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            total += 25;
            tb_total.Text = total.ToString() + ".00 THB";
            no[i] = (i + 1).ToString() + ".";
            menu[i] = "ThaiTea (Ice)";
            price[i] = "25";
            w += menu[i] + "     " + price[i] + Environment.NewLine;
            list();
            i++;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            total += 30;
            tb_total.Text = total.ToString() + ".00 THB";
            no[i] = (i + 1).ToString() + ".";
            menu[i] = "ThaiTea (Frappe)";
            price[i] = "30";
            w += menu[i] + "     " + price[i] + Environment.NewLine;
            list();
            i++;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            total += 20;
            tb_total.Text = total.ToString() + ".00 THB";
            no[i] = (i + 1).ToString() + ".";
            menu[i] = "CoCao (Hot)";
            price[i] = "20";
            w += menu[i] + "     " + price[i] + Environment.NewLine;
            list();
            i++;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            total += 25;
            tb_total.Text = total.ToString() + ".00 THB";
            no[i] = (i + 1).ToString() + ".";
            menu[i] = "CoCao (Ice)";
            price[i] = "25";
            w += menu[i] + "     " + price[i] + Environment.NewLine;
            list();
            i++;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            total += 30;
            tb_total.Text = total.ToString() + ".00 THB";
            no[i] = (i + 1).ToString() + ".";
            menu[i] = "CoCao (Frappe)";
            price[i] = "30";
            w += menu[i] + "     " + price[i] + Environment.NewLine;
            list();
            i++;
        }

        private void button25_Click(object sender, EventArgs e)
        {
            total += 20;
            tb_total.Text = total.ToString() + ".00 THB";
            no[i] = (i + 1).ToString() + ".";
            menu[i] = "Milk (Hot)";
            price[i] = "20";
            w += menu[i] + "     " + price[i] + Environment.NewLine;
            list();
            i++;
        }

        private void button26_Click(object sender, EventArgs e)
        {
            total += 25;
            tb_total.Text = total.ToString() + ".00 THB";
            no[i] = (i + 1).ToString() + ".";
            menu[i] = "Milk (Ice)";
            price[i] = "25";
            w += menu[i] + "     " + price[i] + Environment.NewLine;
            list();
            i++;
        }

        private void button27_Click(object sender, EventArgs e)
        {
            total += 30;
            tb_total.Text = total.ToString() + ".00 THB";
            no[i] = (i + 1).ToString() + ".";
            menu[i] = "Milk (Frappe)";
            price[i] = "30";
            w += menu[i] + "     " + price[i] + Environment.NewLine;
            list();
            i++;
        }

        private void button28_Click(object sender, EventArgs e)
        {
            total += 25;
            tb_total.Text = total.ToString() + ".00 THB";
            no[i] = (i + 1).ToString() + ".";
            menu[i] = "MilkTea (Ice)";
            price[i] = "25";
            w += menu[i] + "     " + price[i] + Environment.NewLine;
            list();
            i++;
        }

        private void button29_Click(object sender, EventArgs e)
        {
            total += 30;
            tb_total.Text = total.ToString() + ".00 THB";
            no[i] = (i + 1).ToString() + ".";
            menu[i] = "MilkTea (Frappe)";
            price[i] = "30";
            w += menu[i] + "     " + price[i] + Environment.NewLine;
            list();
            i++;
        }

        private void button30_Click(object sender, EventArgs e)
        {
            total += 25;
            tb_total.Text = total.ToString() + ".00 THB";
            no[i] = (i + 1).ToString() + ".";
            menu[i] = "LemonTea (Ice)";
            price[i] = "25";
            w += menu[i] + "     " + price[i] + Environment.NewLine;
            list();
            i++;
        }

        private void button31_Click(object sender, EventArgs e)
        {
            total += 30;
            tb_total.Text = total.ToString() + ".00 THB";
            no[i] = (i + 1).ToString() + ".";
            menu[i] = "LemonTea (Frappe)";
            price[i] = "30";
            w += menu[i] + "     " + price[i] + Environment.NewLine;
            list();
            i++;
        }

        private void button32_Click(object sender, EventArgs e)
        {
            total += 20;
            tb_total.Text = total.ToString() + ".00 THB";
            no[i] = (i + 1).ToString() + ".";
            menu[i] = "Milo (Hot)";
            price[i] = "20";
            w += menu[i] + "     " + price[i] + Environment.NewLine;
            list();
            i++;
        }

        private void button33_Click(object sender, EventArgs e)
        {
            total += 25;
            tb_total.Text = total.ToString() + ".00 THB";
            no[i] = (i + 1).ToString() + ".";
            menu[i] = "Milo (Ice)";
            price[i] = "25";
            w += menu[i] + "     " + price[i] + Environment.NewLine;
            list();
            i++;
        }

        private void button34_Click(object sender, EventArgs e)
        {
            total += 30;
            tb_total.Text = total.ToString() + ".00 THB";
            no[i] = (i + 1).ToString() + ".";
            menu[i] = "Milo (Frappe)";
            price[i] = "30";
            w += menu[i] + "     " + price[i] + Environment.NewLine;
            list();
            i++;
        }

        private void button35_Click(object sender, EventArgs e)
        {
            total += 20;
            tb_total.Text = total.ToString() + ".00 THB";
            no[i] = (i + 1).ToString() + ".";
            menu[i] = "NesCafe (Hot)";
            price[i] = "20";
            w += menu[i] + "     " + price[i] + Environment.NewLine;
            list();
            i++;
        }

        private void button36_Click(object sender, EventArgs e)
        {
            total += 25;
            tb_total.Text = total.ToString() + ".00 THB";
            no[i] = (i + 1).ToString() + ".";
            menu[i] = "NesCafe (Ice)";
            price[i] = "25";
            w += menu[i] + "     " + price[i] + Environment.NewLine;
            list();
            i++;
        }

        private void button37_Click(object sender, EventArgs e)
        {
            total += 30;
            tb_total.Text = total.ToString() + ".00 THB";
            no[i] = (i + 1).ToString() + ".";
            menu[i] = "NesCafe (Frappe)";
            price[i] = "30";
            w += menu[i] + "     " + price[i] + Environment.NewLine;
            list();
            i++;
        }

        private void button38_Click(object sender, EventArgs e)
        {
            total += 20;
            tb_total.Text = total.ToString() + ".00 THB";
            no[i] = (i + 1).ToString() + ".";
            menu[i] = "NesteaTae (Hot)";
            price[i] = "20";
            w += menu[i] + "     " + price[i] + Environment.NewLine;
            list();
            i++;
        }

        private void button40_Click(object sender, EventArgs e)
        {
            total += 25;
            tb_total.Text = total.ToString() + ".00 THB";
            no[i] = (i + 1).ToString() + ".";
            menu[i] = "NesteaTea (Ice)";
            price[i] = "25";
            w += menu[i] + "     " + price[i] + Environment.NewLine;
            list();
            i++;
        }

        private void button41_Click(object sender, EventArgs e)
        {
            total += 30;
            tb_total.Text = total.ToString() + ".00 THB";
            no[i] = (i + 1).ToString() + ".";
            menu[i] = "NesteaTea (Frappe)";
            price[i] = "30";
            w += menu[i] + "     " + price[i] + Environment.NewLine;
            list();
            i++;
        }

        private void button39_Click(object sender, EventArgs e)
        {
            total += 25;
            tb_total.Text = total.ToString() + ".00 THB";
            no[i] = (i + 1).ToString() + ".";
            menu[i] = "Italian Soda (Ice)";
            price[i] = "25";
            w += menu[i] + "     " + price[i] + Environment.NewLine;
            list();
            i++;
        }

        private void button42_Click(object sender, EventArgs e)
        {
            total += 25;
            tb_total.Text = total.ToString() + ".00 THB";
            no[i] = (i + 1).ToString() + ".";
            menu[i] = "Red lime Soda (Ice)";
            price[i] = "25";
            w += menu[i] + "     " + price[i] + Environment.NewLine;
            list();
            i++;
        }

        private void button43_Click(object sender, EventArgs e)
        {
            total += 25;
            tb_total.Text = total.ToString() + ".00 THB";
            no[i] = (i + 1).ToString() + ".";
            menu[i] = "Honey lime Soda (Ice)";
            price[i] = "25";
            w += menu[i] + "     " + price[i] + Environment.NewLine;
            list();
            i++;
        }

        private void button45_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button44_Click(object sender, EventArgs e)
        {
            i = 0;
            tb_total.Text = "0";
            total = 0;
            listView_top.Items.Clear();
        }

        public void list()
        {
            ListViewItem top = new ListViewItem();
            top.Text = no[i];
            top.SubItems.Add(menu[i]);
            top.SubItems.Add(price[i]);
            listView_top.Items.Add(top);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (tb_total.Text == ""){
                MessageBox.Show("กรุณาเลือกเมนูที่ต้องการ", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else {
                MessageBox.Show("ต้องการทำรายการใช่หรือไม่", "Confirm!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }
            i = 0;
            tb_total.Text = "0";
            listView_top.Items.Clear();
            total = 0;
            File.WriteAllText("Bill" + (j) + ".txt", w);
            j++;
        }
    }
}

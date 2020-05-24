using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pro
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            int salary = int.Parse(textBox1.Text);//รายรับ
            int other = int.Parse(textBox9.Text);
            int bonus = int.Parse(textBox10.Text);
            int total1;
            total1 = (salary * 12) + other + bonus;
            textBox11.Text = total1.ToString();


            int pay = int.Parse(textBox11.Text);//รายจ่าย
            int pay1;
            if(pay <= 200000)
            {
                pay1 = pay / 2;
                textBox7.Text = pay1.ToString();
            }
            else
            {
                textBox7.Text = "100000";
            }

            int a1 = int.Parse(numericUpDown1.Text);//บุตรเกิดก่อน61
            int a2 = int.Parse(numericUpDown2.Text);//บุตรเกิดหลัง61
            int a3 = int.Parse(textBox2.Text);//ค่าฝากครรภ์
            int a4 = int.Parse(textBox3.Text);//อุปการะคนพิการ
            int a5;
            int a6;
            int m = 0;
            int n = 0;
            int o = 0;
            int p = 0;
            int q = 0;
            int r = 0;
            int s = 0;
            int t = 0;
            int u = 0;
            int v = 0;
            int w = 0;
            int x = 60000;
            int total;
            if (checkBox9.Checked)
            {
                m = 0;
            }
            if (checkBox10.Checked)
            {
                n = 0;
            }
            if (checkBox11.Checked)
            {
                o = 60000;
            }
            if (checkBox1.Checked)
            {
                p = 0;
            }
            if (checkBox2.Checked)
            {
                q = 30000;
            }
            if (checkBox3.Checked)
            {
                r = 60000;
            }
            if (checkBox4.Checked)
            {
                s = 0;
            }
            if (checkBox5.Checked)
            {
                t = 30000;
            }
            if (checkBox6.Checked)
            {
                u = 30000;
            }
            if (checkBox7.Checked)
            {
                v = 30000;
            }
            if (checkBox8.Checked)
            {
                w = 30000;
            }
            a5 = a1 * 30000;
            a6 = a2 * 60000;

            total = a3 + a4 + a5 + +a6 + m + n + o + p + q + r + s + t + u + v + w + x;
            textBox4.Text = total.ToString();

            int b1 = int.Parse(textBox11.Text);//รายได้พึงประเมิน
            int b2 = int.Parse(textBox4.Text);//ภาษีลดหย่อน
            int b3 = int.Parse(textBox7.Text);//รายจ่าย
            int outcome;
            outcome = (b1 - b2) - b3;
            textBox5.Text = outcome.ToString();


            int tt = int.Parse(textBox5.Text);//ภาษีที่ต้องจ่าย
            int vat1;

            if (tt > 5000000)
            {
                vat1 = (tt * 35) / 100;
                textBox6.Text = vat1.ToString();

            }
            else if (tt >= 2000001)
            {
                vat1 = (tt * 30) / 100;
                textBox6.Text = vat1.ToString();
            }
            else if (tt >= 1000001)
            {
                vat1 = (tt * 25) / 100;
                textBox6.Text = vat1.ToString();
            }
            else if (tt >= 750001)
            {
                vat1 = (tt * 20) / 100;
                textBox6.Text = vat1.ToString();
            }
            else if (tt >= 500001)
            {
                vat1 = (tt * 15) / 100;
                textBox6.Text = vat1.ToString();
            }
            else if (tt >= 300001)
            {
                vat1 = (tt * 10) / 100;
                textBox6.Text = vat1.ToString();
            }
            else if (tt >= 150001)
            {
                vat1 = (tt * 5) / 100;
                textBox6.Text = vat1.ToString();
            }
            else
            {
                vat1 = 0;
                textBox6.Text = vat1.ToString();
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
          
        }
    }
}

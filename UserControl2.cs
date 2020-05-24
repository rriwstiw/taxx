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
    public partial class UserControl2 : UserControl
    {
        public UserControl2()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            int salary = int.Parse(x.Text);//รายได้
            int other = int.Parse(y.Text);
            int bonus = int.Parse(z.Text);
            int outcome;
            outcome = (salary * 12) + other + bonus;
            total.Text = outcome.ToString();

            int pay = int.Parse(total.Text);//รายจ่าย / ปี
            int pay1;
            if (pay <= 200000)
            {
                pay1 = pay / 2;
                textBox1.Text = pay1.ToString();
            }
            else
            {
                textBox1.Text = "100000";
            }
                if (checkBox1.Checked)
            {
                int a6 = int.Parse(textBox4.Text);
                if (a6 <= 9000)
                {
                    a.Text = a6.ToString();
                }
                else
                {
                    a.Text = "9000";
                }
            }
            if (checkBox2.Checked)
            {
                int bb = int.Parse(textBox5.Text);
                if (bb <= 100000)
                {
                    b.Text = bb.ToString();
                }
                else
                {
                    b.Text = "100000";
                }
            }
            if (checkBox3.Checked)
            {
                int cc = int.Parse(b.Text);
                int bb;
                if (cc <= 100000)
                {
                    bb = 100000 - cc;
                    c.Text = bb.ToString();

                    if (bb <= 15000)
                    {
                        c.Text = bb.ToString();
                    }
                    else
                    {
                        c.Text = "15000";
                    }
                }
                if (checkBox4.Checked)
                {
                    int dd = int.Parse(textBox7.Text);
                    if (dd <= 15000)
                    {
                        d.Text = dd.ToString();
                    }
                    else
                    {
                        d.Text = "15000";
                    }
                }
                if (checkBox5.Checked)
                {
                    int pe = int.Parse(textBox8.Text);
                    if (pe <= 10000)
                    {
                        e5.Text = pe.ToString();
                    }
                    else
                    {
                        e5.Text = "10000";
                    }
                }
                if (checkBox6.Checked)
                {
                    int ff = int.Parse(textBox9.Text);
                    if (ff <= 10000)
                    {
                        f.Text = ff.ToString();
                    }
                    else
                    {
                        f.Text = "10000";
                    }
                }
                if (checkBox7.Checked)
                {
                    int gg = int.Parse(textBox10.Text);
                    if (gg <= 500000)
                    {
                        g.Text = gg.ToString();
                    }
                    else
                    {
                        g.Text = "500000";
                    }
                }
                int p;
                int aa = int.Parse(a.Text);
                int ab = int.Parse(b.Text);
                int ac = int.Parse(c.Text);
                int ad = int.Parse(d.Text);
                int ae = int.Parse(e5.Text);
                int af = int.Parse(f.Text);
                int ag = int.Parse(g.Text);
                p = aa + ab + ac + ad + ae + af + ag;
                textBox11.Text = p.ToString();

                int b1 = int.Parse(total.Text);//รายได้พึงประเมิน
                int b2 = int.Parse(textBox11.Text);//ลดหย่อน
                int b3 = int.Parse(textBox1.Text);//รายจ่าย
                int outcome1;
                outcome1 = (b1 - b2) - b3;
                tot.Text = outcome1.ToString();//รายได้สุทธิ

                int tt = int.Parse(tot.Text);//ภาษีที่ต้องจ่าย
                int vat1;

                if (tt > 5000000)
                {
                    vat1 = (tt * 35) / 100;
                    textBox12.Text = vat1.ToString();

                }
                else if (tt >= 2000001)
                {
                    vat1 = (tt * 30) / 100;
                    textBox12.Text = vat1.ToString();
                }
                else if (tt >= 1000001)
                {
                    vat1 = (tt * 25) / 100;
                    textBox12.Text = vat1.ToString();
                }
                else if (tt >= 750001)
                {
                    vat1 = (tt * 20) / 100;
                    textBox12.Text = vat1.ToString();
                }
                else if (tt >= 500001)
                {
                    vat1 = (tt * 15) / 100;
                    textBox12.Text = vat1.ToString();
                }
                else if (tt >= 300001)
                {
                    vat1 = (tt * 10) / 100;
                    textBox12.Text = vat1.ToString();
                }
                else if (tt >= 150001)
                {
                    vat1 = (tt * 5) / 100;
                    textBox12.Text = vat1.ToString();
                }
                else
                {
                    vat1 = 0;
                    textBox12.Text = vat1.ToString();
                }
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                checkBox5.Enabled = false;
                textBox8.Enabled = false;
            }
            else
            {
                checkBox5.Enabled = true;
                textBox8.Enabled = true;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                checkBox5.Enabled = false;
                textBox8.Enabled = false;
            }
            else
            {
                checkBox5.Enabled = true;
                textBox8.Enabled = true;
            }
        }

        private void label21_Click(object sender, EventArgs e)
        {

        }
    }
}

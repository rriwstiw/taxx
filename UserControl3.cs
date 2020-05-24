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
    public partial class UserControl3 : UserControl
    {
        public UserControl3()
        {
            InitializeComponent();
        }

        private void y_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                groupBox2.Enabled = false;
            }
            else
            {
                groupBox2.Enabled = true;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                groupBox1.Enabled = false;
            }
            else
            {
                groupBox1.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int salary = int.Parse(textBox1.Text);
            int other = int.Parse(textBox2.Text);
            int bonus = int.Parse(textBox3.Text);
            int outcome;
            outcome = (salary * 12) + other + bonus;
            textBox4.Text = outcome.ToString();

            int pay = int.Parse(textBox4.Text);
            int pay1;
            if (pay <= 200000)
            {
                pay1 = pay / 2;
                textBox5.Text = pay1.ToString();
            }
            else
            {
                textBox5.Text = "100000";
            }

            int home58 = int.Parse(numericUpDown2.Text);//ราคาบ้าน
            int taxhome = int.Parse(home.Text);//ดอกเบี้ยบ้าน
            int total = int.Parse(textBox4.Text);//รายได้รวมต่อปี
            int payout1 = int.Parse(textBox5.Text);//รายจ่าย
            int tax20;// 20%ของอสังหาริมทรัพย์
            int tax5;//ภาษีที่เฉลี่ย 5 ปี
            int taxtotal;//รวมภาษี
            int total1;//รายได้สุทธิ

            tax20 = (home58 * 20) / 100;//ภาษีที่ลดหย่อนได้
            a.Text = tax20.ToString();
            tax5 = (tax20 / 5);//เฉลี่ย 5 ปี
            d.Text = tax5.ToString();
            taxtotal = (taxhome + tax5);//รวมลดหย่อนภาษี = ดอกเบี้ยบ้าน+ภาษีเฉลี่ย 5 ปี
            b.Text = taxtotal.ToString();

            total1 = (total - taxtotal) - payout1;//รายได้สุทธิ = รายได้รวม-รวมลดหย่อนสุทธิ
            c.Text = total1.ToString();

            int tt = int.Parse(c.Text);
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

        private void button5_Click(object sender, EventArgs e)
        {
            int salary1 = int.Parse(textBox1.Text);
            int other1 = int.Parse(textBox2.Text);
            int bonus1 = int.Parse(textBox3.Text);
            int outcome1;
            outcome1 = (salary1 * 12) + other1 + bonus1;
            textBox4.Text = outcome1.ToString();

            int pay1 = int.Parse(textBox4.Text);//รายจ่าย
            int pay12;
            if (pay1 <= 200000)
            {
                pay12 = pay1 / 2;
                textBox5.Text = pay12.ToString();
            }
            else
            {
                textBox5.Text = "100000";
            }


            int home62 = int.Parse(numericUpDown3.Text);//ราคาบ้าน
            int taxhome = int.Parse(home.Text);//ดอกเบี้ยบ้าน
            int total = int.Parse(textBox4.Text);//รายได้รวมต่อปี
            int payout = int.Parse(textBox5.Text);//รายจ่าย
            int tax;//ภาษีที่ลดหย่อน
            int taxtotal;//รวมภาษี
            int total2;//รายได้สุทธิ
            int a = 0;

            if (home62 < 200000)
            {
                a = home62;
            }
            else if (home62 < 5000001)
            {
                a = 200000;
            }

            tax = a;//ภาษีที่ลดหย่อนได้
            x.Text = tax.ToString();
            taxtotal = taxhome + a;//รวมภาษีที่ลดหย่อนได้ = ดอกเบี้ยบ้าน+ภาษีที่ลดหย่อน
            y.Text = taxtotal.ToString();

            total2 = (total - taxtotal) - payout;//รายได้รวม-รวมลดหย่อนสุทธิ-รายจ่าย
            z.Text = total2.ToString();

            int tt = int.Parse(z.Text);//ภาษีที่ต้องจ่าย
            int vat1;

            if (tt > 5000000)
            {
                vat1 = (tt * 35) / 100;
                textBox7.Text = vat1.ToString();

            }
            else if (tt >= 2000001)
            {
                vat1 = (tt * 30) / 100;
                textBox7.Text = vat1.ToString();
            }
            else if (tt >= 1000001)
            {
                vat1 = (tt * 25) / 100;
                textBox7.Text = vat1.ToString();
            }
            else if (tt >= 750001)
            {
                vat1 = (tt * 20) / 100;
                textBox7.Text = vat1.ToString();
            }
            else if (tt >= 500001)
            {
                vat1 = (tt * 15) / 100;
                textBox7.Text = vat1.ToString();
            }
            else if (tt >= 300001)
            {
                vat1 = (tt * 10) / 100;
                textBox7.Text = vat1.ToString();
            }
            else if (tt >= 150001)
            {
                vat1 = (tt * 5) / 100;
                textBox7.Text = vat1.ToString();
            }
            else
            {
                vat1 = 0;
                textBox7.Text = vat1.ToString();
            }
        }
    }
}

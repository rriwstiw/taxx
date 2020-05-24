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
    public partial class UserControl4 : UserControl
    {
        public UserControl4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            int salary = int.Parse(textBox1.Text);
            int other = int.Parse(textBox2.Text);
            int bonus = int.Parse(textBox3.Text);
            int total;

            total = (salary * 12) + other + bonus;
            textBox4.Text = total.ToString();

            int pay = int.Parse(textBox4.Text);//รายจ่าย
            int pay1;
            if (pay <= 200000)
            {
                pay1 = pay / 2;
                textBox20.Text = pay1.ToString();
            }
            else
            {
                textBox20.Text = "100000";
            }

            int study = int.Parse(textBox5.Text);
            int government = int.Parse(textBox6.Text);
            int sport = int.Parse(textBox7.Text);
            int public1 = int.Parse(textBox8.Text);
            int pabuk = int.Parse(textBox9.Text);
            int general = int.Parse(textBox10.Text);
            int politics = int.Parse(numericUpDown1.Text);
            int revenue = int.Parse(textBox4.Text);//รายได้พึงประะเมิน
            int payout = int.Parse(textBox20.Text);//รายจ่าย
            int a1;
            int a2;
            int a3;
            int a4;
            int a5;
            int a6;
            int a7;
            int x1;
            int total1;//รายได้สุทธิ
            int taxtotal;//สามารถลดหย่อนได้

            a1 = (study * 2);
            textBox11.Text = a1.ToString();
            a2 = (government * 2);
            textBox12.Text = a2.ToString();
            a3 = (sport * 2);
            textBox13.Text = a3.ToString();
            a4 = (public1 * 2);
            textBox14.Text = a4.ToString();
            a5 = pabuk;
            textBox15.Text = a5.ToString();
            a6 = general;
            textBox16.Text = a6.ToString();
            a7 = politics;
            textBox17.Text = a7.ToString();


            x1 = (a1 + a2 + a3 + a4 + a5 + a6 + a7);//บริจาค
            textBox18.Text = x1.ToString();

            total1 = (revenue - x1) - payout;//รายได้สุทธิ = รายได้พึงประเมิน-ภาษีที่ลดหย่อนได้-รายจ่าย
            textBox19.Text = total1.ToString();

            int tt = int.Parse(textBox19.Text);//ภาษีที่ต้องจ่าย
            int vat1;

            if (tt > 5000000)
            {
                vat1 = (tt * 35) / 100;
                textBox21.Text = vat1.ToString();

            }
            else if (tt >= 2000001)
            {
                vat1 = (tt * 30) / 100;
                textBox21.Text = vat1.ToString();
            }
            else if (tt >= 1000001)
            {
                vat1 = (tt * 25) / 100;
                textBox21.Text = vat1.ToString();
            }
            else if (tt >= 750001)
            {
                vat1 = (tt * 20) / 100;
                textBox21.Text = vat1.ToString();
            }
            else if (tt >= 500001)
            {
                vat1 = (tt * 15) / 100;
                textBox21.Text = vat1.ToString();
            }
            else if (tt >= 300001)
            {
                vat1 = (tt * 10) / 100;
                textBox21.Text = vat1.ToString();
            }
            else if (tt >= 150001)
            {
                vat1 = (tt * 5) / 100;
                textBox21.Text = vat1.ToString();
            }
            else
            {
                vat1 = 0;
                textBox21.Text = vat1.ToString();
            }
        }
    }
}

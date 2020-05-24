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
    public partial class UserControl5 : UserControl
    {
        public UserControl5()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown7_ValueChanged(object sender, EventArgs e)
        {

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
                textBox7.Text = pay1.ToString();
            }
            else
            {
                textBox7.Text = "100000";
            }


            int help = int.Parse(numericUpDown1.Text);//ช้อปช่วยชาติ
            int studysport = int.Parse(numericUpDown2.Text);//ซื้อสินค้าการศึกษาและกีฬา
            int book = int.Parse(numericUpDown3.Text);//ซื้อหนังสือ
            int otop = int.Parse(numericUpDown4.Text);//ซื้อสินค้าโอทอป
            int travel1 = int.Parse(numericUpDown5.Text);//เที่ยวเมืองหลัก
            int travel2 = int.Parse(numericUpDown6.Text);//เที่ยวเมืองรอง
            int home = int.Parse(numericUpDown7.Text);//ค่าซ่อมบ้าน
            int car = int.Parse(numericUpDown8.Text);//ค่าซ่อมรถ
            int revenue = int.Parse(textBox4.Text);//รายได้พึงประเมิน
            int payout = int.Parse(textBox7.Text);//รายจ่าย
            int total1;//รายได้สุทธิ
            int tax;//ภาษีที่ลดหย่อนได้
            int x = 0;
            int y = 0;

            if ((travel1 + travel2) < 20000)
            {
                x = (travel1 + travel2);
            }
            else if ((travel1 + travel2) > 20001)
            {
                x = 20000;
            }
            if ((home + car) < 100000)
            {
                y = (home + car);
            }
            else if ((home + car) > 100001)
            {
                y = 100000;
            }

            tax = help + studysport + book + otop + x + y;
            textBox5.Text = tax.ToString();

            total1 = (revenue - tax) - payout;
            textBox6.Text = total1.ToString();

            int tt = int.Parse(textBox6.Text);//ภาษีที่ต้องจ่าย
            int vat1;

            if (tt > 5000000)
            {
                vat1 = (tt * 35) / 100;
                textBox8.Text = vat1.ToString();

            }
            else if (tt >= 2000001)
            {
                vat1 = (tt * 30) / 100;
                textBox8.Text = vat1.ToString();
            }
            else if (tt >= 1000001)
            {
                vat1 = (tt * 25) / 100;
                textBox8.Text = vat1.ToString();
            }
            else if (tt >= 750001)
            {
                vat1 = (tt * 20) / 100;
                textBox8.Text = vat1.ToString();
            }
            else if (tt >= 500001)
            {
                vat1 = (tt * 15) / 100;
                textBox8.Text = vat1.ToString();
            }
            else if (tt >= 300001)
            {
                vat1 = (tt * 10) / 100;
                textBox8.Text = vat1.ToString();
            }
            else if (tt >= 150001)
            {
                vat1 = (tt * 5) / 100;
                textBox8.Text = vat1.ToString();
            }
            else
            {
                vat1 = 0;
                textBox8.Text = vat1.ToString();
            }
        }
    }
}

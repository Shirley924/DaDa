using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practice4_2
{
    public partial class Form1 : Form
    {
        static int money = 10000;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label6.Text = "[初始] 10000 NTD";
            password.PasswordChar = '*';
            label2.Hide();
            button2.Hide();
            button3.Hide();
            button4.Hide();
            button5.Hide();

            label3.Hide();
            button6.Hide();
            button7.Hide();
            button8.Hide();
            button9.Hide();
            button10.Hide();
            button11.Hide();

            label4.Hide();
            label5.Hide();
            textBox1.Hide();
            button12.Hide();

            label6.Hide();
            button13.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string passwd = password.Text;
            if (passwd == "000000")
            {
                //password.Text = "請輸入提領金額，按[確定]鈕";
                password.Enabled = true;
                password.Enabled = true;
                label1.Hide();
                password.Hide();
                button1.Hide();
                label2.Show();
                button2.Show();
                button3.Show();
                button4.Show();
                button5.Show();
                button13.Show();
                            }
            else
            {
                //lblShow.Text = "密碼錯誤! 請重新輸入";
                password.Clear();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Hide();
            button2.Hide();
            button3.Hide();
            button4.Hide();
            button5.Hide();

            label3.Show();
            button6.Show();
            button7.Show();
            button8.Show();
            button9.Show();
            button10.Show();
            button11.Show();


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            label4.Show();
            label6.Text = label6.Text + '\n' + "[提款] 1000 NTD";
            money = money - 1000;
            if (money >= 0)
                label4.Text = "餘額剩下:" + money;
            else
                label4.Text = "餘額不足" ;

            button13.Show();
            
            label3.Hide();
            button6.Hide();
            button7.Hide();
            button8.Hide();
            button9.Hide();
            button10.Hide();
            button11.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label4.Show();
            label6.Text = label6.Text + '\n' + "[提款] 3000 NTD";
            money = money - 3000;
            if (money >= 0)
                label4.Text = "餘額剩下:" + money;
            else
                label4.Text = "餘額不足";

            button13.Show();
            
            label3.Hide();
            button6.Hide();
            button7.Hide();
            button8.Hide();
            button9.Hide();
            button10.Hide();
            button11.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label4.Show();
            label6.Text = label6.Text + '\n' + "[提款] 5000 NTD";
            money = money - 5000;
            if (money >= 0)
                label4.Text = "餘額剩下:" + money;
            else
                label4.Text = "餘額不足";

            button13.Show();
            
            label3.Hide();
            button6.Hide();
            button7.Hide();
            button8.Hide();
            button9.Hide();
            button10.Hide();
            button11.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label4.Show();
            label6.Text = label6.Text + '\n' + "[提款] 10000 NTD";
            money = money - 10000;
            if (money >= 0)
                label4.Text = "餘額剩下:" + money;
            else
                label4.Text = "餘額不足";

            button13.Show();

            label3.Hide();
            button6.Hide();
            button7.Hide();
            button8.Hide();
            button9.Hide();
            button10.Hide();
            button11.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            label4.Show();
            label6.Text = label6.Text + '\n' + "[提款] 20000 NTD";
            money = money - 20000;
            if (money >= 0)
                label4.Text = "餘額剩下:" + money;
            else
                label4.Text = "餘額不足";

            button13.Show();

            label3.Hide();
            button6.Hide();
            button7.Hide();
            button8.Hide();
            button9.Hide();
            button10.Hide();
            button11.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            label4.Show();
            label6.Text = label6.Text + '\n' + "[提款] 30000 NTD";
            money = money - 30000;
            if (money >= 0)
                label4.Text = "餘額剩下:" + money;
            else
                label4.Text = "餘額不足";

            button13.Show();

            label3.Hide();
            button6.Hide();
            button7.Hide();
            button8.Hide();
            button9.Hide();
            button10.Hide();
            button11.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label5.Show();
            button12.Show();
            textBox1.Show();
            label2.Hide();
            button2.Hide();
            button3.Hide();
            button4.Hide();
            button5.Hide();
            button13.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //存款
            int deposit =int.Parse(textBox1.Text);
            money = money + deposit;
            label4.Text = "餘額剩下:" + money+"NTD";
            label4.Show();
            label5.Hide();
            button12.Hide();
            textBox1.Hide();
            label6.Text = label6.Text + '\n' + "[餘額]"+money;
            button13.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //balance
            label4.Text = "餘額剩下:" + money + "NTD";
            label4.Show();
            label2.Hide();
            button2.Hide();
            button3.Hide();
            button4.Hide();
            button5.Hide();
            button13.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //history
            label2.Hide();
            button2.Hide();
            button3.Hide();
            button4.Hide();
            button5.Hide();

            label6.Show();
            button13.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            button1.Show();
            label1.Show();
            password.Show();
            password.Clear();
            label3.Hide();
            label4.Hide();
            label6.Hide();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practice5_2
{
    public partial class Form1 : Form
    {
        int txb_count = 0;
        TextBox[] txb=new TextBox[30];

        int dec = 0;
        int uni = 0;
        int multi = 0;
        string toler = "±0%";
        public Form1()
        {
            InitializeComponent();            
        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txb[txb_count] = new TextBox();            
            txb[txb_count].Location = new Point(200, 65 + 30 * txb_count);
            txb[txb_count].Name = txb_count.ToString();
            Label lb = new Label();
            lb.Location = new Point(300, 70 + 30 * txb_count);
            lb.Text = "Ω";
            tabPage2.Controls.Add(txb[txb_count]);
            tabPage2.Controls.Add(lb);
            txb_count++;
            //tabControl1.SelectedTab = tabPage2;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double Serial = 0;
            double Parallel=0;
            
            for(int i = 0; i < txb_count; ++i)
            { 
                Serial += double.Parse(txb[i].Text);
                if (i == 0)
                    Parallel = double.Parse(txb[i].Text);
                else
                    Parallel = 1 / (1 / Parallel + 1 / double.Parse(txb[i].Text));
            }
            textBox1.Text = Serial.ToString("F2");
            textBox2.Text = Parallel.ToString("F2");
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            dec = 4;
            if (multi < 3)
                textBox3.Text = ((dec * 10 + uni) * Math.Pow(10, multi)).ToString() + toler;
            else if (multi < 6)
                textBox3.Text = ((dec * 10 + uni) * Math.Pow(10, multi - 3)).ToString() + "K" + toler;
            else if (multi < 9)
                textBox3.Text = ((dec * 10 + uni) * Math.Pow(10, multi - 6)).ToString() + "M" + toler;
            else
                textBox3.Text = ((dec * 10 + uni) * Math.Pow(10, multi - 9)).ToString() + "G" + toler;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            dec = 0;
            if (multi < 3)
                textBox3.Text = ((dec * 10 + uni) * Math.Pow(10, multi)).ToString() + toler;
            else if (multi < 6)
                textBox3.Text = ((dec * 10 + uni) * Math.Pow(10, multi - 3)).ToString() + "K" + toler;
            else if (multi < 9)
                textBox3.Text = ((dec * 10 + uni) * Math.Pow(10, multi - 6)).ToString() + "M" + toler;
            else
                textBox3.Text = ((dec * 10 + uni) * Math.Pow(10, multi - 9)).ToString() + "G" + toler;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            dec = 1;
            if (multi < 3)
                textBox3.Text = ((dec * 10 + uni) * Math.Pow(10, multi)).ToString() + toler;
            else if (multi < 6)
                textBox3.Text = ((dec * 10 + uni) * Math.Pow(10, multi - 3)).ToString() + "K" + toler;
            else if (multi < 9)
                textBox3.Text = ((dec * 10 + uni) * Math.Pow(10, multi - 6)).ToString() + "M" + toler;
            else
                textBox3.Text = ((dec * 10 + uni) * Math.Pow(10, multi - 9)).ToString() + "G" + toler;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            dec = 2;
            if (multi < 3)
                textBox3.Text = ((dec * 10 + uni) * Math.Pow(10, multi)).ToString() + toler;
            else if (multi < 6)
                textBox3.Text = ((dec * 10 + uni) * Math.Pow(10, multi - 3)).ToString() + "K" + toler;
            else if (multi < 9)
                textBox3.Text = ((dec * 10 + uni) * Math.Pow(10, multi - 6)).ToString() + "M" + toler;
            else
                textBox3.Text = ((dec * 10 + uni) * Math.Pow(10, multi - 9)).ToString() + "G" + toler;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            dec = 3;
            if (multi < 3)
                textBox3.Text = ((dec * 10 + uni) * Math.Pow(10, multi)).ToString() + toler;
            else if (multi < 6)
                textBox3.Text = ((dec * 10 + uni) * Math.Pow(10, multi - 3)).ToString() + "K" + toler;
            else if (multi < 9)
                textBox3.Text = ((dec * 10 + uni) * Math.Pow(10, multi - 6)).ToString() + "M" + toler;
            else
                textBox3.Text = ((dec * 10 + uni) * Math.Pow(10, multi - 9)).ToString() + "G" + toler;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            dec = 5;
            if (multi < 3)
                textBox3.Text = ((dec * 10 + uni) * Math.Pow(10, multi)).ToString() + toler;
            else if (multi < 6)
                textBox3.Text = ((dec * 10 + uni) * Math.Pow(10, multi - 3)).ToString() + "K" + toler;
            else if (multi < 9)
                textBox3.Text = ((dec * 10 + uni) * Math.Pow(10, multi - 6)).ToString() + "M" + toler;
            else
                textBox3.Text = ((dec * 10 + uni) * Math.Pow(10, multi - 9)).ToString() + "G" + toler;
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            dec = 6;
            if (multi < 3)
                textBox3.Text = ((dec * 10 + uni) * Math.Pow(10, multi)).ToString() + toler;
            else if (multi < 6)
                textBox3.Text = ((dec * 10 + uni) * Math.Pow(10, multi - 3)).ToString() + "K" + toler;
            else if (multi < 9)
                textBox3.Text = ((dec * 10 + uni) * Math.Pow(10, multi - 6)).ToString() + "M" + toler;
            else
                textBox3.Text = ((dec * 10 + uni) * Math.Pow(10, multi - 9)).ToString() + "G" + toler;
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            dec = 7;
            if (multi < 3)
                textBox3.Text = ((dec * 10 + uni) * Math.Pow(10, multi)).ToString() + toler;
            else if (multi < 6)
                textBox3.Text = ((dec * 10 + uni) * Math.Pow(10, multi - 3)).ToString() + "K" + toler;
            else if (multi < 9)
                textBox3.Text = ((dec * 10 + uni) * Math.Pow(10, multi - 6)).ToString() + "M" + toler;
            else
                textBox3.Text = ((dec * 10 + uni) * Math.Pow(10, multi - 9)).ToString() + "G" + toler;
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            dec = 8;
            if (multi < 3)
                textBox3.Text = ((dec * 10 + uni) * Math.Pow(10, multi)).ToString() + toler;
            else if (multi < 6)
                textBox3.Text = ((dec * 10 + uni) * Math.Pow(10, multi - 3)).ToString() + "K" + toler;
            else if (multi < 9)
                textBox3.Text = ((dec * 10 + uni) * Math.Pow(10, multi - 6)).ToString() + "M" + toler;
            else
                textBox3.Text = ((dec * 10 + uni) * Math.Pow(10, multi - 9)).ToString() + "G" + toler;
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            dec = 9;
            if (multi < 3)
                textBox3.Text = ((dec * 10 + uni) * Math.Pow(10, multi)).ToString() + toler;
            else if (multi < 6)
                textBox3.Text = ((dec * 10 + uni) * Math.Pow(10, multi - 3)).ToString() + "K" + toler;
            else if (multi < 9)
                textBox3.Text = ((dec * 10 + uni) * Math.Pow(10, multi - 6)).ToString() + "M" + toler;
            else
                textBox3.Text = ((dec * 10 + uni) * Math.Pow(10, multi - 9)).ToString() + "G" + toler;
        }

        private void radioButton20_CheckedChanged(object sender, EventArgs e)
        {
            uni = 0;
            if (multi < 3)
                textBox3.Text = ((dec * 10 + uni) * Math.Pow(10, multi)).ToString() + toler;
            else if (multi < 6)
                textBox3.Text = ((dec * 10 + uni) * Math.Pow(10, multi - 3)).ToString() + "K" + toler;
            else if (multi < 9)
                textBox3.Text = ((dec * 10 + uni) * Math.Pow(10, multi - 6)).ToString() + "M" + toler;
            else
                textBox3.Text = ((dec * 10 + uni) * Math.Pow(10, multi - 9)).ToString() + "G" + toler;
        }

        private void radioButton19_CheckedChanged(object sender, EventArgs e)
        {
            uni = 1;
            if (multi < 3)
                textBox3.Text = ((dec * 10 + uni) * Math.Pow(10, multi)).ToString() + toler;
            else if (multi < 6)
                textBox3.Text = ((dec * 10 + uni) * Math.Pow(10, multi - 3)).ToString() + "K" + toler;
            else if (multi < 9)
                textBox3.Text = ((dec * 10 + uni) * Math.Pow(10, multi - 6)).ToString() + "M" + toler;
            else
                textBox3.Text = ((dec * 10 + uni) * Math.Pow(10, multi - 9)).ToString() + "G" + toler;
        }

        private void radioButton18_CheckedChanged(object sender, EventArgs e)
        {
            uni = 2;
            if (multi < 3)
                textBox3.Text = ((dec * 10 + uni) * Math.Pow(10, multi)).ToString() + toler;
            else if (multi < 6)
                textBox3.Text = ((dec * 10 + uni) * Math.Pow(10, multi - 3)).ToString() + "K" + toler;
            else if (multi < 9)
                textBox3.Text = ((dec * 10 + uni) * Math.Pow(10, multi - 6)).ToString() + "M" + toler;
            else
                textBox3.Text = ((dec * 10 + uni) * Math.Pow(10, multi - 9)).ToString() + "G" + toler;
        }

        private void radioButton17_CheckedChanged(object sender, EventArgs e)
        {
            uni = 3;
            if (multi < 3)
                textBox3.Text = ((dec * 10 + uni) * Math.Pow(10, multi)).ToString() + toler;
            else if (multi < 6)
                textBox3.Text = ((dec * 10 + uni) * Math.Pow(10, multi - 3)).ToString() + "K" + toler;
            else if (multi < 9)
                textBox3.Text = ((dec * 10 + uni) * Math.Pow(10, multi - 6)).ToString() + "M" + toler;
            else
                textBox3.Text = ((dec * 10 + uni) * Math.Pow(10, multi - 9)).ToString() + "G" + toler;
        }

        private void radioButton16_CheckedChanged(object sender, EventArgs e)
        {
            uni = 4;
            if (multi < 3)
                textBox3.Text = ((dec * 10 + uni) * Math.Pow(10, multi)).ToString() + toler;
            else if (multi < 6)
                textBox3.Text = ((dec * 10 + uni) * Math.Pow(10, multi - 3)).ToString() + "K" + toler;
            else if (multi < 9)
                textBox3.Text = ((dec * 10 + uni) * Math.Pow(10, multi - 6)).ToString() + "M" + toler;
            else
                textBox3.Text = ((dec * 10 + uni) * Math.Pow(10, multi - 9)).ToString() + "G" + toler;
        }

        private void radioButton15_CheckedChanged(object sender, EventArgs e)
        {
            uni = 5;
            if (multi < 3)
                textBox3.Text = ((dec * 10 + uni) * Math.Pow(10, multi)).ToString() + toler;
            else if (multi < 6)
                textBox3.Text = ((dec * 10 + uni) * Math.Pow(10, multi - 3)).ToString() + "K" + toler;
            else if (multi < 9)
                textBox3.Text = ((dec * 10 + uni) * Math.Pow(10, multi - 6)).ToString() + "M" + toler;
            else
                textBox3.Text = ((dec * 10 + uni) * Math.Pow(10, multi - 9)).ToString() + "G" + toler;
        }

        private void radioButton14_CheckedChanged(object sender, EventArgs e)
        {
            uni = 6;
            if (multi < 3)
                textBox3.Text = ((dec * 10 + uni) * Math.Pow(10, multi)).ToString() + toler;
            else if (multi < 6)
                textBox3.Text = ((dec * 10 + uni) * Math.Pow(10, multi - 3)).ToString() + "K" + toler;
            else if (multi < 9)
                textBox3.Text = ((dec * 10 + uni) * Math.Pow(10, multi - 6)).ToString() + "M" + toler;
            else
                textBox3.Text = ((dec * 10 + uni) * Math.Pow(10, multi - 9)).ToString() + "G" + toler;
        }

        private void radioButton13_CheckedChanged(object sender, EventArgs e)
        {
            uni = 7;
            if (multi < 3)
                textBox3.Text = ((dec * 10 + uni) * Math.Pow(10, multi)).ToString() + toler;
            else if (multi < 6)
                textBox3.Text = ((dec * 10 + uni) * Math.Pow(10, multi - 3)).ToString() + "K" + toler;
            else if (multi < 9)
                textBox3.Text = ((dec * 10 + uni) * Math.Pow(10, multi - 6)).ToString() + "M" + toler;
            else
                textBox3.Text = ((dec * 10 + uni) * Math.Pow(10, multi - 9)).ToString() + "G" + toler;
        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {
            uni = 8;
            if (multi < 3)
                textBox3.Text = ((dec * 10 + uni) * Math.Pow(10, multi)).ToString() + toler;
            else if (multi < 6)
                textBox3.Text = ((dec * 10 + uni) * Math.Pow(10, multi - 3)).ToString() + "K" + toler;
            else if (multi < 9)
                textBox3.Text = ((dec * 10 + uni) * Math.Pow(10, multi - 6)).ToString() + "M" + toler;
            else
                textBox3.Text = ((dec * 10 + uni) * Math.Pow(10, multi - 9)).ToString() + "G" + toler;
        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            uni = 9;
            if (multi < 3)
                textBox3.Text = ((dec * 10 + uni) * Math.Pow(10, multi)).ToString() + toler;
            else if (multi < 6)
                textBox3.Text = ((dec * 10 + uni) * Math.Pow(10, multi - 3)).ToString() + "K" + toler;
            else if (multi < 9)
                textBox3.Text = ((dec * 10 + uni) * Math.Pow(10, multi - 6)).ToString() + "M" + toler;
            else
                textBox3.Text = ((dec * 10 + uni) * Math.Pow(10, multi - 9)).ToString() + "G" + toler;
        }

        private void radioButton30_CheckedChanged(object sender, EventArgs e)
        {
            multi = 0;
            if (multi < 3)
                textBox3.Text = ((dec * 10 + uni) * Math.Pow(10, multi)).ToString() + toler;
            else if (multi < 6)
                textBox3.Text = ((dec * 10 + uni) * Math.Pow(10, multi - 3)).ToString() + "K" + toler;
            else if (multi < 9)
                textBox3.Text = ((dec * 10 + uni) * Math.Pow(10, multi - 6)).ToString() + "M" + toler;
            else
                textBox3.Text = ((dec * 10 + uni) * Math.Pow(10, multi - 9)).ToString() + "G" + toler;
        }

        private void radioButton29_CheckedChanged(object sender, EventArgs e)
        {
            multi = 1;
            if (multi < 3)
                textBox3.Text = ((dec * 10 + uni) * Math.Pow(10, multi)).ToString() + toler;
            else if (multi < 6)
                textBox3.Text = ((dec * 10 + uni) * Math.Pow(10, multi - 3)).ToString() + "K" + toler;
            else if (multi < 9)
                textBox3.Text = ((dec * 10 + uni) * Math.Pow(10, multi - 6)).ToString() + "M" + toler;
            else
                textBox3.Text = ((dec * 10 + uni) * Math.Pow(10, multi - 9)).ToString() + "G" + toler;
        }

        private void radioButton28_CheckedChanged(object sender, EventArgs e)
        {
            multi = 2;
                if (multi < 3)
                    textBox3.Text = ((dec * 10 + uni) * Math.Pow(10, multi)).ToString()+toler;
                else if (multi < 6)
                    textBox3.Text = ((dec * 10 + uni) * Math.Pow(10, multi - 3)).ToString() + "K"+toler;
                else if (multi < 9)
                    textBox3.Text = ((dec * 10 + uni) * Math.Pow(10, multi - 6)).ToString() + "M"+toler;
                else
                    textBox3.Text = ((dec * 10 + uni) * Math.Pow(10, multi - 9)).ToString() + "G"+toler;
        }

        private void radioButton27_CheckedChanged(object sender, EventArgs e)
        {
            multi = 3;
            if (multi < 3)
                textBox3.Text = ((dec * 10 + uni) * Math.Pow(10, multi)).ToString() + toler;
            else if (multi < 6)
                textBox3.Text = ((dec * 10 + uni) * Math.Pow(10, multi - 3)).ToString() + "K" + toler;
            else if (multi < 9)
                textBox3.Text = ((dec * 10 + uni) * Math.Pow(10, multi - 6)).ToString() + "M" + toler;
            else
                textBox3.Text = ((dec * 10 + uni) * Math.Pow(10, multi - 9)).ToString() + "G" + toler;
        }

        private void radioButton26_CheckedChanged(object sender, EventArgs e)
        {
            multi = 4;
            if (multi < 3)
                textBox3.Text = ((dec * 10 + uni) * Math.Pow(10, multi)).ToString() + toler;
            else if (multi < 6)
                textBox3.Text = ((dec * 10 + uni) * Math.Pow(10, multi - 3)).ToString() + "K" + toler;
            else if (multi < 9)
                textBox3.Text = ((dec * 10 + uni) * Math.Pow(10, multi - 6)).ToString() + "M" + toler;
            else
                textBox3.Text = ((dec * 10 + uni) * Math.Pow(10, multi - 9)).ToString() + "G" + toler;
        }

        private void radioButton25_CheckedChanged(object sender, EventArgs e)
        {
            multi = 5;
            if (multi < 3)
                textBox3.Text = ((dec * 10 + uni) * Math.Pow(10, multi)).ToString() + toler;
            else if (multi < 6)
                textBox3.Text = ((dec * 10 + uni) * Math.Pow(10, multi - 3)).ToString() + "K" + toler;
            else if (multi < 9)
                textBox3.Text = ((dec * 10 + uni) * Math.Pow(10, multi - 6)).ToString() + "M" + toler;
            else
                textBox3.Text = ((dec * 10 + uni) * Math.Pow(10, multi - 9)).ToString() + "G" + toler;
        }

        private void radioButton24_CheckedChanged(object sender, EventArgs e)
        {
            multi = 6;
            if (multi < 3)
                textBox3.Text = ((dec * 10 + uni) * Math.Pow(10, multi)).ToString() + toler;
            else if (multi < 6)
                textBox3.Text = ((dec * 10 + uni) * Math.Pow(10, multi - 3)).ToString() + "K" + toler;
            else if (multi < 9)
                textBox3.Text = ((dec * 10 + uni) * Math.Pow(10, multi - 6)).ToString() + "M" + toler;
            else
                textBox3.Text = ((dec * 10 + uni) * Math.Pow(10, multi - 9)).ToString() + "G" + toler;
        }

        private void radioButton23_CheckedChanged(object sender, EventArgs e)
        {
            multi = 7;
            if (multi < 3)
                textBox3.Text = ((dec * 10 + uni) * Math.Pow(10, multi)).ToString() + toler;
            else if (multi < 6)
                textBox3.Text = ((dec * 10 + uni) * Math.Pow(10, multi - 3)).ToString() + "K" + toler;
            else if (multi < 9)
                textBox3.Text = ((dec * 10 + uni) * Math.Pow(10, multi - 6)).ToString() + "M" + toler;
            else
                textBox3.Text = ((dec * 10 + uni) * Math.Pow(10, multi - 9)).ToString() + "G" + toler;
        }

        private void radioButton22_CheckedChanged(object sender, EventArgs e)
        {
            multi = 8;
            if (multi < 3)
                textBox3.Text = ((dec * 10 + uni) * Math.Pow(10, multi)).ToString() + toler;
            else if (multi < 6)
                textBox3.Text = ((dec * 10 + uni) * Math.Pow(10, multi - 3)).ToString() + "K" + toler;
            else if (multi < 9)
                textBox3.Text = ((dec * 10 + uni) * Math.Pow(10, multi - 6)).ToString() + "M" + toler;
            else
                textBox3.Text = ((dec * 10 + uni) * Math.Pow(10, multi - 9)).ToString() + "G" + toler;
        }

        private void radioButton21_CheckedChanged(object sender, EventArgs e)
        {
            multi = 9;
            if (multi < 3)
                textBox3.Text = ((dec * 10 + uni) * Math.Pow(10, multi)).ToString() + toler;
            else if (multi < 6)
                textBox3.Text = ((dec * 10 + uni) * Math.Pow(10, multi - 3)).ToString() + "K" + toler;
            else if (multi < 9)
                textBox3.Text = ((dec * 10 + uni) * Math.Pow(10, multi - 6)).ToString() + "M" + toler;
            else
                textBox3.Text = ((dec * 10 + uni) * Math.Pow(10, multi - 9)).ToString() + "G" + toler;
        }

        private void radioButton31_CheckedChanged(object sender, EventArgs e)
        {
            multi = -1;
            if (multi < 3)
                textBox3.Text = ((dec * 10 + uni) * Math.Pow(10, multi)).ToString() + toler;
            else if (multi < 6)
                textBox3.Text = ((dec * 10 + uni) * Math.Pow(10, multi - 3)).ToString() + "K" + toler;
            else if (multi < 9)
                textBox3.Text = ((dec * 10 + uni) * Math.Pow(10, multi - 6)).ToString() + "M" + toler;
            else
                textBox3.Text = ((dec * 10 + uni) * Math.Pow(10, multi - 9)).ToString() + "G" + toler;
        }

        private void radioButton32_CheckedChanged(object sender, EventArgs e)
        {
            multi = -2;
            if (multi < 3)
                textBox3.Text = ((dec * 10 + uni) * Math.Pow(10, multi)).ToString() + toler;
            else if (multi < 6)
                textBox3.Text = ((dec * 10 + uni) * Math.Pow(10, multi - 3)).ToString() + "K" + toler;
            else if (multi < 9)
                textBox3.Text = ((dec * 10 + uni) * Math.Pow(10, multi - 6)).ToString() + "M" + toler;
            else
                textBox3.Text = ((dec * 10 + uni) * Math.Pow(10, multi - 9)).ToString() + "G" + toler;
        }

        private void radioButton43_CheckedChanged(object sender, EventArgs e)
        {
            toler = "±1%";
            if (multi < 3)
                textBox3.Text = ((dec * 10 + uni) * Math.Pow(10, multi)).ToString() + toler;
            else if (multi < 6)
                textBox3.Text = ((dec * 10 + uni) * Math.Pow(10, multi - 3)).ToString() + "K" + toler;
            else if (multi < 9)
                textBox3.Text = ((dec * 10 + uni) * Math.Pow(10, multi - 6)).ToString() + "M" + toler;
            else
                textBox3.Text = ((dec * 10 + uni) * Math.Pow(10, multi - 9)).ToString() + "G" + toler;
        }

        private void radioButton42_CheckedChanged(object sender, EventArgs e)
        {
            toler = "±2%";
            if (multi < 3)
                textBox3.Text = ((dec * 10 + uni) * Math.Pow(10, multi)).ToString() + toler;
            else if (multi < 6)
                textBox3.Text = ((dec * 10 + uni) * Math.Pow(10, multi - 3)).ToString() + "K" + toler;
            else if (multi < 9)
                textBox3.Text = ((dec * 10 + uni) * Math.Pow(10, multi - 6)).ToString() + "M" + toler;
            else
                textBox3.Text = ((dec * 10 + uni) * Math.Pow(10, multi - 9)).ToString() + "G" + toler;
        }

        private void radioButton39_CheckedChanged(object sender, EventArgs e)
        {
            toler = "±0.5%";
            if (multi < 3)
                textBox3.Text = ((dec * 10 + uni) * Math.Pow(10, multi)).ToString() + toler;
            else if (multi < 6)
                textBox3.Text = ((dec * 10 + uni) * Math.Pow(10, multi - 3)).ToString() + "K" + toler;
            else if (multi < 9)
                textBox3.Text = ((dec * 10 + uni) * Math.Pow(10, multi - 6)).ToString() + "M" + toler;
            else
                textBox3.Text = ((dec * 10 + uni) * Math.Pow(10, multi - 9)).ToString() + "G" + toler;
        }

        private void radioButton38_CheckedChanged(object sender, EventArgs e)
        {
            toler = "±0.25%";
            if (multi < 3)
                textBox3.Text = ((dec * 10 + uni) * Math.Pow(10, multi)).ToString() + toler;
            else if (multi < 6)
                textBox3.Text = ((dec * 10 + uni) * Math.Pow(10, multi - 3)).ToString() + "K" + toler;
            else if (multi < 9)
                textBox3.Text = ((dec * 10 + uni) * Math.Pow(10, multi - 6)).ToString() + "M" + toler;
            else
                textBox3.Text = ((dec * 10 + uni) * Math.Pow(10, multi - 9)).ToString() + "G" + toler;
        }

        private void radioButton37_CheckedChanged(object sender, EventArgs e)
        {
            toler = "±0.10%";
            if (multi < 3)
                textBox3.Text = ((dec * 10 + uni) * Math.Pow(10, multi)).ToString() + toler;
            else if (multi < 6)
                textBox3.Text = ((dec * 10 + uni) * Math.Pow(10, multi - 3)).ToString() + "K" + toler;
            else if (multi < 9)
                textBox3.Text = ((dec * 10 + uni) * Math.Pow(10, multi - 6)).ToString() + "M" + toler;
            else
                textBox3.Text = ((dec * 10 + uni) * Math.Pow(10, multi - 9)).ToString() + "G" + toler;
        }

        private void radioButton36_CheckedChanged(object sender, EventArgs e)
        {
            toler = "±0.05%";
            if (multi < 3)
                textBox3.Text = ((dec * 10 + uni) * Math.Pow(10, multi)).ToString() + toler;
            else if (multi < 6)
                textBox3.Text = ((dec * 10 + uni) * Math.Pow(10, multi - 3)).ToString() + "K" + toler;
            else if (multi < 9)
                textBox3.Text = ((dec * 10 + uni) * Math.Pow(10, multi - 6)).ToString() + "M" + toler;
            else
                textBox3.Text = ((dec * 10 + uni) * Math.Pow(10, multi - 9)).ToString() + "G" + toler;
        }

        private void radioButton34_CheckedChanged(object sender, EventArgs e)
        {
            toler = "±5%";
            if (multi < 3)
                textBox3.Text = ((dec * 10 + uni) * Math.Pow(10, multi)).ToString() + toler;
            else if (multi < 6)
                textBox3.Text = ((dec * 10 + uni) * Math.Pow(10, multi - 3)).ToString() + "K" + toler;
            else if (multi < 9)
                textBox3.Text = ((dec * 10 + uni) * Math.Pow(10, multi - 6)).ToString() + "M" + toler;
            else
                textBox3.Text = ((dec * 10 + uni) * Math.Pow(10, multi - 9)).ToString() + "G" + toler;
        }

        private void radioButton33_CheckedChanged(object sender, EventArgs e)
        {
            toler = "±10%";
            if (multi < 3)
                textBox3.Text = ((dec * 10 + uni) * Math.Pow(10, multi)).ToString() + toler;
            else if (multi < 6)
                textBox3.Text = ((dec * 10 + uni) * Math.Pow(10, multi - 3)).ToString() + "K" + toler;
            else if (multi < 9)
                textBox3.Text = ((dec * 10 + uni) * Math.Pow(10, multi - 6)).ToString() + "M" + toler;
            else
                textBox3.Text = ((dec * 10 + uni) * Math.Pow(10, multi - 9)).ToString() + "G" + toler;
        }
    }
}

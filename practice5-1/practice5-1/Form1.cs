using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practice5_1
{
    public partial class Form1 : Form
    {
        //Object Background=new Bitmap("..\\..\\IMG\\BREAD.png");
        int sauce=0;
        int pin = 0;
        int h = 0;
        public Form1()
        {
            InitializeComponent();
            pictureBox2.Hide();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            sauce = 1;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            sauce = 2;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            sauce = 3;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            sauce = 0;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //sauce
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Show();
            switch (sauce)
            {
                case 1:
                    pictureBox2.Image = Properties.Resources.SAUCE_BLUE;
                    break;
                case 2:
                    pictureBox2.Image = Properties.Resources.SAUCE_GREEN;
                    break;
                case 3:
                    pictureBox2.Image = Properties.Resources.SAUCE_RED;
                    break;
                case 0:
                    pictureBox2.Image = Properties.Resources.SAUCE_NONE;
                    break;
            }
            pictureBox1.Controls.Add(pictureBox2);

            Random ranObj = new Random();
            if (pin%2 == 1)
            {
                PictureBox[] pineapple = new PictureBox[int.Parse(textBox1.Text)];
                for (int i = 0; i < int.Parse(textBox1.Text); i++)
                {
                    int rnd_x, rnd_y;
                    while (true)
                    {
                        Screen now = Screen.FromHandle(this.Handle);
                        rnd_x = ranObj.Next(now.Bounds.Width);
                        rnd_y = ranObj.Next(now.Bounds.Height);
                        double length = Math.Sqrt(Math.Pow((rnd_x - 74), 2) + Math.Pow((rnd_y - 78), 2));
                        if (length < 80)
                            break;
                    }
                    pineapple[i] = new System.Windows.Forms.PictureBox();
                    pineapple[i].BorderStyle = BorderStyle.None;
                    pineapple[i].Size = new Size(17, 17);
                    pineapple[i].Location = new Point(rnd_x, rnd_y);
                    pineapple[i].SizeMode = PictureBoxSizeMode.Zoom;
                    pineapple[i].Image = Properties.Resources.PINEAPPLE;
                    pineapple[i].BackColor = Color.Transparent;

                    pictureBox2.Controls.Add(pineapple[i]);
                }
            }

            if (h%2 == 1)
            {
                PictureBox[] ham = new PictureBox[int.Parse(textBox2.Text)];
                for (int i = 0; i < int.Parse(textBox2.Text); i++)
                {
                    int rnd_x, rnd_y;
                    while (true)
                    {
                        Screen now = Screen.FromHandle(this.Handle);
                        rnd_x = ranObj.Next(now.Bounds.Width);
                        rnd_y = ranObj.Next(now.Bounds.Height);
                        double length = Math.Sqrt(Math.Pow((rnd_x - 74), 2) + Math.Pow((rnd_y - 78), 2));
                        if (length < 80)
                            break;
                    }
                    ham[i] = new System.Windows.Forms.PictureBox();
                    ham[i].BorderStyle = BorderStyle.None;
                    ham[i].Size = new Size(17, 17);
                    ham[i].Location = new Point(rnd_x, rnd_y);
                    //ham[i].Location = new Point(31 + i * 20, 39 + i * 20);
                    ham[i].SizeMode = PictureBoxSizeMode.Zoom;
                    ham[i].Image = Properties.Resources.HAM;
                    ham[i].BackColor = Color.Transparent;

                    pictureBox2.Controls.Add(ham[i]);
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            pin++;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            h++;
        }
    }
}

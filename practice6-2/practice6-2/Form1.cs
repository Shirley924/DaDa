using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practice6_2
{
    public partial class Form1 : Form
    {
        bool Fail = false;
        int score = 0;
        int num = 0;
        int tik = 0;
        int shone = 0;
        int[] position = new int[60];
        int[] fall = new int[60];
        PictureBox[] enemy = new PictureBox[60];
        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 1000; //one second
            for (int i = 0; i < 50; i++)
                enemy[i] = null;
            pictureBox1.Location = new Point(155, 350);
            pictureBox1.Size = new Size(40, 40);
        }

        private void invader(int num) //create the enemies
        {
            Random ranObj = new Random();
            position[num] = ranObj.Next(5);
            enemy[num] = new PictureBox();
            for (int i = 0; i <= num; i++)
            {
                enemy[i].Name = "invader" + i.ToString();
                enemy[i].Image = Properties.Resources.Invader;
                enemy[i].SizeMode = PictureBoxSizeMode.Zoom;
                enemy[i].Size = new Size(50, 50);
                enemy[i].Location = new Point(50 * position[i], 50 * fall[i]);
                this.Controls.Add(enemy[i]);
                fall[i]++;
            }
        }

        private void gone()
        {
            foreach (Control c in this.Controls)
                if (c is PictureBox)
                    if (c.Name.Substring(0, 7) == "invader")  //except for the ship
                        this.Controls.Remove(c);
        }

        private void Crash(int i)
        {            
            if (pictureBox1.Left == enemy[i].Left + 50 && pictureBox1.Top + 25 >= enemy[i].Top - 20 && pictureBox1.Top + 25 <= enemy[i].Top + 70)
                Fail = true;
            else if (pictureBox1.Left + 40 == enemy[i].Left && pictureBox1.Top + 25 >= enemy[i].Top - 20 && pictureBox1.Top + 25 <= enemy[i].Top + 70)
                Fail = true;
            else if (pictureBox1.Top == enemy[i].Top + 50 && pictureBox1.Left + 25 >= enemy[i].Left - 10 && pictureBox1.Left + 25 <= enemy[i].Left + 70)
                Fail = true;
            else if (pictureBox1.Top == enemy[i].Top && pictureBox1.Left + 25 >= enemy[i].Left - 10 && pictureBox1.Left + 25 <= enemy[i].Left + 70)
                Fail = true;
        }

        private void ship_go(object sender, KeyEventArgs e)
        {
            int x = pictureBox1.Location.X, y = pictureBox1.Location.Y;
            if (e.KeyCode == Keys.Up && (y > 0 && y < 310))
                pictureBox1.Location = new Point(x, y - 50);
            else if (e.KeyCode == Keys.Down && (y > 0 && y < 310))
                pictureBox1.Location = new Point(x, y + 50);
            else if (e.KeyCode == Keys.Left && (x > 5 && x < 170))
                pictureBox1.Location = new Point(x - 50, y);
            else if (e.KeyCode == Keys.Right && (x > 5 && x < 170))
                pictureBox1.Location = new Point(x + 50, y);

            if (e.KeyCode == Keys.Up && y >= 310)
                pictureBox1.Location = new Point(x, y - 50);
            else if (e.KeyCode == Keys.Down && y <= 0)
                pictureBox1.Location = new Point(x, y + 50);
            else if (e.KeyCode == Keys.Left && x >= 170)
                pictureBox1.Location = new Point(x - 50, y);
            else if (e.KeyCode == Keys.Right && x <= 5)
                pictureBox1.Location = new Point(x + 50, y);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Fail = false;
            button1.Enabled = false;
            timer1.Enabled = true;
            timer2.Enabled = true;
            score = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = "score:" + score.ToString();
            score += 100;
            gone();
            if (num < 60)
            {
                invader(num);
                num++;
            }
            else
            {
                num = 0;
                for (int i = 0; i < 60; i++)
                    fall[i] = 0;
            }
            
            tik++;
            if (tik > 59 && (tik % 65 == 0 || tik % 65 >= 60)) 
            {
                timer3.Enabled = true;               
            }
            else if (tik > 59 && tik % 65 == 1)
            {
                timer3.Enabled = false;
                for (int m = 0; m < 10; m++)
                    enemy[m].Show();
            }
        }

        private void check(object sender, EventArgs e)
        {
            for (int count = 0; count < num; count++)
                Crash(count);

            if (Fail == true)
            {                
                timer1.Enabled = false;
                timer2.Enabled = false;
                button1.Enabled = true;
            }
        }

        private void shine(object sender, EventArgs e)
        {
            shone++;
            if (shone % 2 == 0)
                for (int m = 0; m < 10; m++)
                {
                    enemy[m].Show();
                }
            else
                for (int m = 0; m < 10; m++)
                {
                    enemy[m].Hide();
                }
        }
    }
}

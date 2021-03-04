using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practice8_2
{
    public partial class Form2 : Form
    {
        public Form1 fm1 = null;
        Random ranObj = new Random();
        int ran;
        int time = 3;
        public Form2()
        {
            InitializeComponent();
        }

        public void start()
        {
            timer1.Enabled = true;
        }

        public void stop()
        {
            timer1.Enabled = false;
        }

        public void restart()
        {
            pictureBox1.Image = null;
            timer1.Enabled = false;
        }

        public int Get_Pic()
        {
            return ran;
        }

        private void Chang_pic(object sender, EventArgs e)
        {
            ran = ranObj.Next(4);
            switch (ran)
            {
                case 0:
                    pictureBox1.Image = Properties.Resources.eyechart_1;
                    break;
                case 1:
                    pictureBox1.Image = Properties.Resources.eyechart_2;
                    break;
                case 2:
                    pictureBox1.Image = Properties.Resources.eyechart_3;
                    break;
                case 3:
                    pictureBox1.Image = Properties.Resources.eyechart_4;
                    break;
            }
            timer1.Enabled = false;
            timer1.Enabled = true;

            fm1.Change = false;

        }

        public void changePic()
        {
            ran = ranObj.Next(4);
            switch (ran)
            {
                case 0:
                    pictureBox1.Image = Properties.Resources.eyechart_1;
                    break;
                case 1:
                    pictureBox1.Image = Properties.Resources.eyechart_2;
                    break;
                case 2:
                    pictureBox1.Image = Properties.Resources.eyechart_3;
                    break;
                case 3:
                    pictureBox1.Image = Properties.Resources.eyechart_4;
                    break;
            }
            timer1.Enabled = false;
            timer1.Enabled = true;
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            start();
            fm1.State = true;
            Application.OpenForms[fm1.Name].Focus();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            stop();
            fm1.State = false;
            Application.OpenForms[fm1.Name].Focus();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            restart();
            fm1.State = false;
            fm1.score = 0;
            Application.OpenForms[fm1.Name].Focus();
        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.Z)
            {
                start();
                fm1.State = true;
                Application.OpenForms[fm1.Name].Focus();
            }
            else if (e.Control && e.KeyCode == Keys.X)
            {
                stop();
                fm1.State = false;
                Application.OpenForms[fm1.Name].Focus();
            }
            else if (e.Control && e.KeyCode == Keys.C)
            {
                restart();
                fm1.State = false;
                fm1.score = 0;
                Application.OpenForms[fm1.Name].Focus();
            }
        }
    }
}

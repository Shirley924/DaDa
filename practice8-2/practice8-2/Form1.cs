using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practice8_2
{
    public partial class Form1 : Form
    {
        public Form2 fm2 = new Form2();
        public int score = 0;
        public bool State = false;
        public bool Change = false;
        int Pic;
        public Form1()
        {
            InitializeComponent();
            fm2.fm1 = this;
            fm2.Show();
        }

        private void Guess(object sender, KeyEventArgs e)
        {
            //Change = false;
            if (e.Control && e.KeyCode == Keys.Z)
            {
                fm2.start();
                State = true;
                //Debug.Write("start");
            }
            else if(e.Control && e.KeyCode == Keys.X)
            {
                fm2.stop();
                State = false;
            }
            else if(e.Control && e.KeyCode == Keys.C)
            {
                fm2.restart();
                State = false;
                score = 0;
                label1.Text = score.ToString();
            }
            
            if (State == true)
            {
                //Debug.Write(Pic);
                switch (fm2.Get_Pic())
                {
                    case 0:
                        if (e.KeyCode == Keys.Right)
                        {
                            score += 10;
                            fm2.changePic();
                        }
                        break;
                    case 1:
                        if (e.KeyCode == Keys.Left)
                        {
                            score += 10;
                            fm2.changePic();

                        }
                        break;
                    case 2:
                        if (e.KeyCode == Keys.Up)
                        {
                            score += 10;
                            fm2.changePic();
                        }
                        break;
                    case 3:
                        if (e.KeyCode == Keys.Down)
                        {
                            score += 10;
                            fm2.changePic();
                        }
                        break;
                }
            }
            label1.Text = score.ToString();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            //Start
            fm2.start();
            State = true;
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            //Pause
            fm2.stop();
            State = false;
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            fm2.restart();
            State = false;
            score = 0;
            label1.Text = score.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
                   
        }
    }
}

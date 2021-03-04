using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;
using System.Security;
using System.Diagnostics;

namespace practice7_1
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        System.Media.SoundPlayer music = new System.Media.SoundPlayer();
        string filePath= "awaken.wav";
        TrackBar[] trcb = new TrackBar[10];
        PictureBox[,] lab = new PictureBox[10, 10];
        int[] judge = new int[3];

        private void background(object sender, EventArgs e)
        {
            //調音量
            for(int i = 0; i < 10; i++)
            {
                trcb[i] = new TrackBar();
                trcb[i].Orientation = Orientation.Vertical;
                trcb[i].Minimum = 0;
                trcb[i].Maximum = 9;
                trcb[i].TickFrequency = 1;
                trcb[i].Location = new Point(10+55*i, 250);
                trcb[i].Size = new Size(10,150);
                tabPage1.Controls.Add(trcb[i]);
            }

            //volumn
            for(int i = 0; i < 10; i++)
            {
                for(int j = 0; j < 10; j++)
                {
                    lab[i, j] = new PictureBox();
                    lab[i, j].BackColor = Color.LightGray;
                    lab[i, j].Size = new Size(45, 15);
                    lab[i, j].Location = new Point(10 + 55 * i, 50 + 20 * j);
                    tabPage1.Controls.Add(lab[i, j]);
                }
            }

            hScrollBar1.Minimum = 0;
            hScrollBar1.Maximum = 255;
            hScrollBar2.Minimum = 0;
            hScrollBar2.Maximum = 255;
            hScrollBar3.Minimum = 0;
            hScrollBar3.Maximum = 255;

            
            
        }

        private void Start(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer2.Enabled = true;
            timer3.Enabled = true;
            
            music.SoundLocation = @filePath;
            music.PlayLooping();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {            
            judge[0]++;
            int[] value = new int[3];
            value[0] = 9-trcb[0].Value;
            value[1] = 9-trcb[3].Value;
            value[2] = 9-trcb[8].Value;

            for(int i = 0; i < value[0]; i++)
                lab[0, i].BackColor = pictureBox1.BackColor;
            for (int i = 9; i > value[0]; i--)
                lab[0, i].BackColor = Color.White;

            for (int i = 0; i < value[1]; i++)
                lab[3, i].BackColor = pictureBox1.BackColor;
            for (int i = 9; i > value[1]; i--)
                lab[3, i].BackColor = Color.White;

            for (int i = 0; i < value[2]; i++)
                lab[8, i].BackColor = pictureBox1.BackColor;
            for (int i = 9; i > value[2]; i--)
                lab[8, i].BackColor = Color.White;

            if (judge[0] % 2 == 0)
            {
                if (value[0] > 0)
                    lab[0, value[0] - 1].BackColor = Color.White;
                if (value[1] > 0)
                    lab[3, value[1] - 1].BackColor = pictureBox1.BackColor;
                if (value[2] > 0)
                    lab[8, value[2] - 1].BackColor = Color.White;

                lab[0, value[0]].BackColor = pictureBox1.BackColor;
                lab[3, value[1]].BackColor = Color.White;
                lab[8, value[2]].BackColor = pictureBox1.BackColor;

                if (value[0] < 9)
                    lab[0, value[0] + 1].BackColor = Color.White;
                if (value[1] < 9)
                    lab[3, value[1] + 1].BackColor = pictureBox1.BackColor;
                if (value[2] < 9)
                    lab[8, value[2] + 1].BackColor = Color.White;
            }
            else
            {
                if (value[0] > 0)
                    lab[0, value[0] - 1].BackColor = pictureBox1.BackColor;
                if (value[1] > 0)
                    lab[3, value[1] - 1].BackColor = Color.White;
                if (value[2] > 0)
                    lab[8, value[2] - 1].BackColor = pictureBox1.BackColor;

                lab[0, value[0]].BackColor = Color.White;
                lab[3, value[1]].BackColor = pictureBox1.BackColor;
                lab[8, value[2]].BackColor = Color.White;

                if (value[0] < 9)
                    lab[0, value[0] + 1].BackColor = pictureBox1.BackColor;
                if (value[1] < 9)
                    lab[3, value[1] + 1].BackColor = Color.White;
                if (value[2] < 9)
                    lab[8, value[2] + 1].BackColor = pictureBox1.BackColor;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            judge[1]++;
            int[] value = new int[3];
            value[0] = 9-trcb[1].Value;
            value[1] = 9-trcb[5].Value;
            value[2] = 9-trcb[7].Value;

            for (int i = 0; i < value[0]; i++)
                lab[1, i].BackColor = pictureBox1.BackColor;
            for (int i = 9; i > value[0]; i--)
                lab[1, i].BackColor = Color.White;

            for (int i = 0; i < value[1]; i++)
                lab[5, i].BackColor = pictureBox1.BackColor;
            for (int i = 9; i > value[1]; i--)
                lab[5, i].BackColor = Color.White;

            for (int i = 0; i < value[2]; i++)
                lab[7, i].BackColor = pictureBox1.BackColor;
            for (int i = 9; i > value[2]; i--)
                lab[7, i].BackColor = Color.White;

            if (judge[1] % 2 == 0)
            {
                if (value[0] > 0)
                    lab[1, value[0] - 1].BackColor = Color.White;
                if (value[1] > 0)
                    lab[5, value[1] - 1].BackColor = pictureBox1.BackColor;
                if (value[2] > 0)
                    lab[7, value[2] - 1].BackColor = Color.White;

                lab[1, value[0]].BackColor = pictureBox1.BackColor;
                lab[5, value[1]].BackColor = Color.White;
                lab[7, value[2]].BackColor = pictureBox1.BackColor;

                if (value[0] < 9)
                    lab[1, value[0] + 1].BackColor = Color.White;
                if (value[1] < 9)
                    lab[5, value[1] + 1].BackColor = pictureBox1.BackColor;
                if (value[2] < 9)
                    lab[7, value[2] + 1].BackColor = Color.White;
            }
            else
            {
                if (value[0] > 0)
                    lab[1, value[0] - 1].BackColor = pictureBox1.BackColor;
                if (value[1] > 0)
                    lab[5, value[1] - 1].BackColor = Color.White;
                if (value[2] > 0)
                    lab[7, value[2] - 1].BackColor = pictureBox1.BackColor;

                lab[1, value[0]].BackColor = Color.White;
                lab[5, value[1]].BackColor = pictureBox1.BackColor;
                lab[7, value[2]].BackColor = Color.White;

                if (value[0] < 9)
                    lab[1, value[0] + 1].BackColor = pictureBox1.BackColor;
                if (value[1] < 9)
                    lab[5, value[1] + 1].BackColor = Color.White;
                if (value[2] < 9)
                    lab[7, value[2] + 1].BackColor = pictureBox1.BackColor;
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            judge[2]++;
            int[] value = new int[4];
            value[0] = 9-trcb[2].Value;
            value[1] = 9-trcb[4].Value;
            value[2] = 9-trcb[6].Value;
            value[3] = 9-trcb[9].Value;

            for (int i = 0; i < value[0]-1; i++)
                lab[2, i].BackColor = pictureBox1.BackColor;
            for (int i = 9; i > value[0]-1; i--)
                lab[2, i].BackColor = Color.White;

            for (int i = 0; i < value[1]-1; i++)
                lab[4, i].BackColor = pictureBox1.BackColor;
            for (int i = 9; i > value[1]-1; i--)
                lab[4, i].BackColor = Color.White;

            for (int i = 0; i < value[2]-1; i++)
                lab[6, i].BackColor = pictureBox1.BackColor;
            for (int i = 9; i > value[2]-1; i--)
                lab[6, i].BackColor = Color.White;

            for (int i = 0; i < value[3]-1; i++)
                lab[9, i].BackColor = pictureBox1.BackColor;
            for (int i = 9; i > value[3]-1; i--)
                lab[9, i].BackColor = Color.White;

            if (judge[2] % 2 == 0)
            {
                if (value[0] > 0) 
                    lab[2, value[0]-1].BackColor = Color.White;
                if (value[1] > 0) 
                    lab[4, value[1]-1].BackColor = pictureBox1.BackColor;
                if (value[2] > 0) 
                    lab[6, value[2]-1].BackColor = Color.White;
                if (value[3] > 0) 
                    lab[9, value[3]-1].BackColor = pictureBox1.BackColor;

                lab[2, value[0]].BackColor = pictureBox1.BackColor;
                lab[4, value[1]].BackColor = Color.White;
                lab[6, value[2]].BackColor = pictureBox1.BackColor;
                lab[9, value[3]].BackColor = Color.White;

                if (value[0] < 9) 
                    lab[2, value[0]+1].BackColor = Color.White;
                if (value[1] < 9) 
                    lab[4, value[1]+1].BackColor = pictureBox1.BackColor;
                if (value[2] < 9) 
                    lab[6, value[2]+1].BackColor = Color.White;
                if (value[3] < 9) 
                    lab[9, value[3]+1].BackColor = pictureBox1.BackColor;
            }
            else
            {
                if (value[0] > 0) 
                    lab[2, value[0]-1].BackColor = pictureBox1.BackColor;
                if (value[1] > 0) 
                    lab[4, value[1]-1].BackColor = Color.White;
                if (value[2] > 0) 
                    lab[6, value[2]-1].BackColor = pictureBox1.BackColor;
                if (value[3] > 0) 
                    lab[9, value[3]-1].BackColor = Color.White;

                lab[2, value[0]].BackColor = Color.White;
                lab[4, value[1]].BackColor = pictureBox1.BackColor;
                lab[6, value[2]].BackColor = Color.White;
                lab[9, value[3]].BackColor = pictureBox1.BackColor;

                if (value[0] < 9) 
                    lab[2, value[0]+1].BackColor = pictureBox1.BackColor;
                if (value[1] < 9)
                    lab[4, value[1]+1].BackColor = Color.White;
                if (value[2] < 9)
                    lab[6, value[2]+1].BackColor = pictureBox1.BackColor;
                if (value[3] < 9)
                    lab[9, value[3]+1].BackColor = Color.White;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            timer2.Enabled = false;
            timer3.Enabled = false;
            
            music.Stop();
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.FromArgb(hScrollBar1.Value, hScrollBar2.Value, hScrollBar3.Value);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //選擇檔案路徑
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Media Files|*.wav*";
            //file.ShowDialog();
            //this.txtFile.Text = file.SafeFileName;
            if (file.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    filePath = file.FileName;
                }
                catch (SecurityException ex)
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                    $"Details:\n\n{ex.StackTrace}");
                }
            }
        }
    
    }
}

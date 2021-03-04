using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practice6_1
{
    public partial class Form1 : Form
    {
        int num = 20;
        Label[] brick = new Label[20];
        Label block = new Label();
        PictureBox ball = new PictureBox();
        int x = 0;
        bool result=false;
        bool b_der = true;
        bool X_direction = false, Y_direction = false;  //false為負,true為正
        public Form1()
        {
            InitializeComponent();
            
            int index = 0;
            for(int i = 0; i < 4; i++)
            {
                for(int j = 0; j < 5; j++)
                {
                    brick[index] = new Label();
                    brick[index].Location = new Point(100 * j, 30 * i);
                    brick[index].Size = new Size(100,30);
                    brick[index].BackColor = Color.Brown;
                    brick[index].BorderStyle = BorderStyle.FixedSingle;
                    
                    this.Controls.Add(brick[index]);
                    index++;
                }
            }

            block.Location = new Point(200, 200);
            block.Size = new Size(100, 30);
            block.BackColor = Color.Gray;
            this.Controls.Add(block);
            
            ball.Image = Properties.Resources.ball;
            ball.Size = new Size(20, 20);
            ball.SizeMode = PictureBoxSizeMode.Zoom;
            ball.Location = new Point(238, 440);
            this.Controls.Add(ball);
            label1.Size = new Size(150, 30);
        }

        private void GameStart()
        {
            for (int i = 0; i < num; i++)
                brick[i].Dispose();

            b_der = true; X_direction = false; Y_direction = false; num = 20 ;

            int index = 0;
            for(int i = 0; i < 4; i++)
            {
                for(int j = 0; j < 5; j++)
                {
                    brick[index] = new Label();
                    brick[index].Location = new Point(100 * j, 30 * i);
                    brick[index].Size = new Size(100,30);
                    brick[index].BackColor = Color.Brown;
                    brick[index].BorderStyle = BorderStyle.FixedSingle;
                    
                    this.Controls.Add(brick[index]);
                    index++;
                }
            }

            block.Location = new Point(200, 200);
            block.Size = new Size(100, 30);
            block.BackColor = Color.Gray;
            this.Controls.Add(block);
            
            label1.Location = new Point(180, 463);
            ball.Location = new Point(238, 440);
        }

        private void GameOver()
        {
            timer1.Enabled = false;
            timer2.Enabled = false;
            timer3.Enabled = false;

            if (result == false)
            {
                Form2 f = new Form2();
                f.ShowDialog(this);
                if (f.DialogResult == System.Windows.Forms.DialogResult.OK)
                {
                    GameStart();
                    f.Close();
                }
            }
            else
            {
                Form3 F = new Form3();
                F.ShowDialog(this);
                if (F.DialogResult == System.Windows.Forms.DialogResult.OK)
                {
                    GameStart();
                    F.Close();
                }
            }
        }

        private void start(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer2.Enabled = true;
            timer3.Enabled = true;
        }

        private void block_move(object sender, EventArgs e)
        {            
            int b_x = block.Location.X;            
            if (b_x == 70)
                b_der = true;
            else if (b_x == 330)
                b_der = false;

            switch (b_der) {
                case true:
                    block.Location = new Point(b_x + 5, 200);
                    break;
                case false:
                        block.Location = new Point(b_x - 5, 200);
                    break;
            }
            //block.Location = new Point(x - 20, 200);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            x = e.Location.X;
            //this.Invalidate(); //Q
        }

        private void player(object sender, EventArgs e)
        {            
            if (x >= 0 && x <= 495) 
            label1.Location = new Point(x-75, 463);
        }

        private void ball_go(object sender, EventArgs e)
        {
            int b_down = ball.Top + 20, b_right = ball.Left + 20;
            int ball_x = ball.Location.X, ball_y = ball.Location.Y;
            
            if (b_down == label1.Top && (ball.Left > label1.Left && ball.Left < label1.Left + 150))
                Y_direction = false;
            else if (ball.Left <= 0)
                X_direction = true;
            else if (ball.Top < 0)
                Y_direction = true;
            else if (b_right > 505)
                X_direction = false;
            else if (ball.Top == block.Top + 30 && (ball.Left +10 > block.Left -3 && ball.Left < block.Left + 103))
                Y_direction = true;
            else if (ball.Top + 20 == block.Top && (ball.Left +10 > block.Left -3 && ball.Left < block.Left + 103))
                Y_direction = false;
            else if (ball.Left == block.Left + 100 && ball.Top +10 > block.Top && ball.Top +3 < block.Top + 28)
                X_direction = true;
            else if (ball.Left + 20 == block.Left && ball.Top +10 > block.Top && ball.Top +3 < block.Top + 28)
                X_direction = false;

            for(int i = 0; i < num; i++)
            {
                if (ball.Top == brick[i].Top + 30 && ball.Left > brick[i].Left -3 && ball.Left < brick[i].Left + 103)
                {
                    Y_direction = true;
                    brick[i].Dispose();
                    for (int j = i; j < num - 1; j++)
                        brick[j] = brick[j + 1];
                    num--;
                }
                else if (ball.Left == brick[i].Left + 100 && ball.Top > brick[i].Top + 3 && ball.Top < brick[i].Top + 28)
                {
                    X_direction = true;
                    brick[i].Dispose();
                    for (int j = i; j < num - 1; j++)
                        brick[j] = brick[j + 1];
                    num--;
                }
                else if (ball.Left +20 == brick[i].Left && ball.Top > brick[i].Top && ball.Top < brick[i].Top + 28)
                {
                    X_direction = false;
                    brick[i].Dispose();
                    for (int j = i; j < num - 1; j++)
                        brick[j] = brick[j + 1];
                    num--;
                }
            }

            if (X_direction == true && Y_direction == true)
                ball.Location = new Point(ball_x + 1, ball_y + 1);
            else if (X_direction == true && Y_direction == false)
                ball.Location = new Point(ball_x + 1, ball_y - 1);
            else if (X_direction == false && Y_direction == true)
                ball.Location = new Point(ball_x - 1, ball_y + 1);
            else if (X_direction == false && Y_direction == false)
                ball.Location = new Point(ball_x - 1, ball_y - 1);

            //GameOver
            if (ball_y>500)
            {
                result = false;
                GameOver();
            }
            else if (num == 0)
            {
                result = true;
                GameOver();
            }
        }

        private void ball_Click(object sender, EventArgs e)
        {
            
        }
    }
}

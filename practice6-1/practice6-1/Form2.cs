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

namespace practice6_1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            System.Media.SoundPlayer music = new System.Media.SoundPlayer();
            
            label1.Text = "Game Over";
            music.SoundLocation = @"可惜音效.wav";
            music.Play();
        }
    }
}

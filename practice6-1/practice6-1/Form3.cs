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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();

            button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            System.Media.SoundPlayer music = new System.Media.SoundPlayer();
            label1.Text = "You win";
            music.SoundLocation = @"歡呼音效.wav";
            music.Play();
        }
    }
}

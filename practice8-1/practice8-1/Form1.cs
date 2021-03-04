using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practice8_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() != System.Windows.Forms.DialogResult.Cancel)
                BackColor = colorDialog1.Color;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] files = System.IO.Directory.GetDirectories(@"pic\");
            this.comboBox1.Items.AddRange(files);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string[] files = System.IO.Directory.GetFiles(comboBox1.SelectedItem.ToString());
            this.listBox1.Items.AddRange(files);
        }

        private void listBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(listBox1.SelectedItem.ToString());
        }
    }
}

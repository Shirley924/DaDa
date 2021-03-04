using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace practice7_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int month, day;
        bool[,] exist =new bool[12,31];
        
        private void Form1_Load(object sender, EventArgs e)
        {
            numericUpDown1.Minimum = 1;
            numericUpDown1.Maximum = 12;
            numericUpDown3.Minimum = 1;
                                    
            numericUpDown2.Minimum = 0;
            numericUpDown2.Maximum = 23;
            numericUpDown4.Minimum = 0;
            numericUpDown4.Maximum = 59;

            textBox1.ScrollBars = ScrollBars.Vertical;
            textBox1.ScrollToCaret();
        }
        private void input(object sender, EventArgs e)
        {
            string[] product = new string[20];
            int k = 0;

            foreach (string item in textBox1.Lines)  // 將輸入資料置入陣列
            {
                product[k] = item;
                k++;
            }

            month = int.Parse(numericUpDown1.Value.ToString());
            day = int.Parse(numericUpDown3.Value.ToString());

            string filename = @"schedule\"+month+"_"+day+".txt";   // 指定存入的文字檔檔名
            
            FileInfo finfo = new FileInfo(filename);

            if (!Directory.Exists(finfo.DirectoryName))  // 檢查路徑和檔名是否存在
                Directory.CreateDirectory(finfo.DirectoryName); // 不存在則建立

            string data=null;
            if (exist[month,day] == true)
            {
                StreamReader sr = new StreamReader(filename);
                data = sr.ReadToEnd();
                sr.Close();
            }
            
            int hour = int.Parse(numericUpDown2.Value.ToString());
            int min = int.Parse(numericUpDown4.Value.ToString());

            StreamWriter sw = finfo.CreateText();
            sw.WriteLine(data+hour+" 時 "+min+" 分");
            sw.WriteLine(textBox1.Text);
            sw.WriteLine("-----------------------------");
            sw.Flush();
            sw.Close();

            exist[month,day] = true;

            data = null;
            textBox1.Clear();
        }

        private void output(object sender, EventArgs e)
        {
            month = int.Parse(numericUpDown1.Value.ToString());
            day = int.Parse(numericUpDown3.Value.ToString());
            string filename = @"schedule\" + month + "_" + day + ".txt";
            
            if (exist[month,day]==false)
            {
                textBox1.Text = "no schedule";

                Form2 f = new Form2();
                f.ShowDialog(this);
                if (f.DialogResult == System.Windows.Forms.DialogResult.OK)
                    f.Close();
                
                return;
            }
            else
            {
                StreamReader sr = new StreamReader(filename);
                Dictionary<int, string> map = new Dictionary<int, string>();

                //textBox1.Text = sr.ReadToEnd();

                do {
                    string data = sr.ReadLine();
                    if (data == null)
                        break;

                    char[] delete = { '時',' ','分' };
                    string[] tmp = data.Split(delete);
                    //textBox1.Text += tmp[3];
                    
                    var com = tmp[0];
                    com += tmp[3];
                    //sr.ReadLine();
                    int time = int.Parse(com);
                    if (time == 0) { }
                    else if (time < 10)
                        time += 10000;
                    else if (time < 100)
                    {
                        if (tmp[0] == "0")
                            time += 20000;
                        else
                            time += 30000;
                    }
                    else if (time < 1000)
                    {
                        if (int.Parse(tmp[0]) < 10)
                            time += 40000;
                        else
                            time += 50000;
                    }
                    else
                        time += 60000;
                    textBox1.Text += time+"\r\n";
                    map.Add(time, sr.ReadLine());
                    data = sr.ReadLine();  //delete"------"
                } while (true);

                Dictionary<int, string> dic1Asc = map.OrderBy(o => o.Key).ToDictionary(o => o.Key, p => p.Value);

                foreach (KeyValuePair<int,string> k in dic1Asc)
                {
                    if (k.Key == 0)
                        textBox1.Text += ("0 時 0 分");
                    else
                    {
                        string tmp = k.Key.ToString();
                        string judge = tmp.Substring(0, 1);
                        switch (judge)
                        {
                            case "1":
                                textBox1.Text += "0 時 " + tmp.Substring(tmp.Length - 1) + " 分";
                                break;
                            case "2":
                                textBox1.Text += "0 時 " + tmp.Substring(tmp.Length - 2) + " 分";
                                break;
                            case "3":
                                textBox1.Text += tmp.Substring(3, 1) + " 時 " + tmp.Substring(tmp.Length - 1) + " 分";
                                break;
                            case "4":
                                textBox1.Text += tmp.Substring(2, 1) + " 時 " + tmp.Substring(tmp.Length - 2) + " 分";
                                break;
                            case "5":
                                textBox1.Text += tmp.Substring(2, 2) + " 時 " + tmp.Substring(tmp.Length - 1) + " 分";
                                break;
                            case "6":
                                textBox1.Text += tmp.Substring(1, 2) + " 時 " + tmp.Substring(tmp.Length - 2) + " 分";
                                break;
                        }
                    }
                    
                    textBox1.Text += "\r\n" + k.Value + "\r\n";
                    textBox1.Text += "---------------------------";
                    textBox1.Text += "\r\n";
                }            
                sr.Close();
            }
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void bound(object sender, EventArgs e)
        {
            if (textBox2.Text != string.Empty)
            {
                int year = int.Parse(textBox2.Text);
                bool y = false;

                if (year % 400 == 0)
                    y = true;
                else
                {
                    if (year % 100 == 0)
                        y = false;
                    else
                    {
                        if (year % 4 == 0)
                            y = true;
                        else
                            y = false;
                    }
                }

                month = int.Parse(numericUpDown1.Value.ToString());
                if (y == false)
                {
                    switch (month)
                    {
                        case 1:
                            numericUpDown3.Maximum = 31;
                            break;
                        case 2:
                            numericUpDown3.Maximum = 28;
                            break;
                        case 3:
                            numericUpDown3.Maximum = 31;
                            break;
                        case 4:
                            numericUpDown3.Maximum = 30;
                            break;
                        case 5:
                            numericUpDown3.Maximum = 31;
                            break;
                        case 6:
                            numericUpDown3.Maximum = 30;
                            break;
                        case 7:
                            numericUpDown3.Maximum = 31;
                            break;
                        case 8:
                            numericUpDown3.Maximum = 31;
                            break;
                        case 9:
                            numericUpDown3.Maximum = 30;
                            break;
                        case 10:
                            numericUpDown3.Maximum = 31;
                            break;
                        case 11:
                            numericUpDown3.Maximum = 30;
                            break;
                        case 12:
                            numericUpDown3.Maximum = 31;
                            break;
                    }
                }
                else
                    switch (month)
                    {
                        case 1:
                            numericUpDown3.Maximum = 31;
                            break;
                        case 2:
                            numericUpDown3.Maximum = 29;
                            break;
                        case 3:
                            numericUpDown3.Maximum = 31;
                            break;
                        case 4:
                            numericUpDown3.Maximum = 30;
                            break;
                        case 5:
                            numericUpDown3.Maximum = 31;
                            break;
                        case 6:
                            numericUpDown3.Maximum = 30;
                            break;
                        case 7:
                            numericUpDown3.Maximum = 31;
                            break;
                        case 8:
                            numericUpDown3.Maximum = 31;
                            break;
                        case 9:
                            numericUpDown3.Maximum = 30;
                            break;
                        case 10:
                            numericUpDown3.Maximum = 31;
                            break;
                        case 11:
                            numericUpDown3.Maximum = 30;
                            break;
                        case 12:
                            numericUpDown3.Maximum = 31;
                            break;
                    }
            }
            else
            {
                Form3 f = new Form3();
                f.ShowDialog(this);
                if (f.DialogResult == System.Windows.Forms.DialogResult.OK)
                    f.Close();
            }
        }

        private void clear(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        
    }
}

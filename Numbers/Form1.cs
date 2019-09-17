using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Numbers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            double pi = 3.14159265;
            double c = 299792458;
            richTextBox1.AppendText(pi.ToString() + "\n");
            richTextBox1.AppendText(pi.ToString("N3") + "\n");
            richTextBox1.AppendText(pi.ToString("N5") + "\n");
            richTextBox1.AppendText(pi.ToString("N15") + "\n");
            richTextBox1.AppendText("\n");
            richTextBox1.AppendText(c.ToString("0") + "\n");
            richTextBox1.AppendText(c.ToString("N0") + "\n");
            richTextBox1.AppendText(c.ToString("0.000000E0") + "\n");
            richTextBox1.AppendText(c.ToString("0.000E0") + "\n");

            string st = "three";
            try
            {
                int it = int.Parse(st);
            }
            catch
            {
                MessageBox.Show(st + " is not an intiger");
            }
            string s2 = "3.2";
            try
            {
                int i2 = int.Parse(s2);
            }
            catch
            {
                MessageBox.Show(s2 + "is not an interger");
                int i2 = 0;
            }
            string s3 = "pi";
            try
            {
                double d2 = double.Parse(s3);
            }
            catch
            {
                double d2 = 0;
            }
        }
        private void RichTextBox1_TextChanged(object sender, EventArgs e)
        { 

    }   }



    

}
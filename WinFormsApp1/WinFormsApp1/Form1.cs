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


namespace WinFormsApp1
{   

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("HH:mm:ss:ff");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "Leyendo...";
            StreamReader sr = new StreamReader(@"C:\Users\alexd\Desktop\lorem.txt");
            var txt =  sr.ReadToEnd();
             richTextBox1.Lines = txt.Split("");
        }
    
       
        private async Task button2_Click(object sender, EventArgs e)
        {

            richTextBox1.Text = "Leyendo...";
            StreamReader sr = new StreamReader(@"C:\Users\alexd\Desktop\lorem.txt");
            string text = await sr.ReadToEndAsync();
            richTextBox1.Lines = text.Split("");
        }

       
    }
}

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

//https://stackoverflow.com/questions/71787845/timer-stopping-on-async-button-click
namespace WinFormsApp1
{   

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("HH:mm:ss:ff");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            StreamReader sr = new StreamReader(@"C:\Users\alexd\Desktop\lorem.txt");
            var txt =  sr.ReadToEnd();
            textBox1.Text = txt;
        }
        private async void button2_Click(object sender, EventArgs e)
        {

            textBox1.Text = " ";
            StreamReader sr = new StreamReader(@"C:\Users\alexd\Desktop\lorem.txt");
            var txt = await sr.ReadToEndAsync();
            textBox1.Text = txt;


        }

        //private async void button2_Click(object sender, EventArgs e)
        //{ 

        //      Task.Run(async () =>
        //    {

        //        StreamReader sr = new StreamReader(@"C:\Users\alexd\Desktop\lorem.txt");
        //        var txt =  sr.ReadToEndAsync().Result; 

        //         Task.Run(async () =>
        //        {

        //            textBox1.Invoke(new Action(() => { textBox1.Text = txt; }));
        //        });
        //    });


        //}
    }
}

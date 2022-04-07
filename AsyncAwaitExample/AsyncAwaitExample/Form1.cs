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
using MongoDB.Driver;

namespace AsyncAwaitExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }
     
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("HH:mm:ss");
        }
         private void bSync_Click(object sender, EventArgs e)
        {

            tb.Text = " ";
            StreamReader sr = new StreamReader(@"C:\Users\alexd\Desktop\lorem.txt");
            var txt = sr.ReadToEnd();
            tb.Text = txt;

        }

        private async void bAsync_Click(object sender, EventArgs e)
        {
            
            tb.Text = " ";
            StreamReader sr = new StreamReader(@"C:\Users\alexd\Desktop\lorem.txt");
            var txt =  await sr.ReadToEndAsync();
            tb.Text = txt;
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tb.Text = " ";
        }

        //    private void bSync_Click(object sender, EventArgs e)
        //    {
        //        tb.Text = " ";
        //        MongoClient dbClient = new MongoClient("mongodb://localhost:27017");

        //    var dbList = dbClient.ListDatabases().ToList();


        //    foreach (var db in dbList)
        //    {
        //            tb.Text += db;
        //    }

        //}

        //    private async void bAsync_Click(object sender, EventArgs e)
        //    {
        //        tb.Text = " ";

        //        MongoClient dbClient = new MongoClient("mongodb://localhost:27017");

        //        var dbList = await dbClient.ListDatabasesAsync();



        //        foreach (var db in dbList.ToList())
        //        {
        //            tb.Text += db;
        //        }

        //    }

        //    private void button1_Click(object sender, EventArgs e)
        //    {
        //        tb.Text = " ";
        //    }
    }
}

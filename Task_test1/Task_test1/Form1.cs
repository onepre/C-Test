using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_test1
{
    public partial class Form1 : Form
    {
        string str1 = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (str1 == "Begin"||str1=="Finish")
            {
                listView1.Items.Add(str1+"\n");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var task1 = new Task(() =>
            {
                str1 = "Begin";
                //listView1.BeginInvoke(new Action(() =>
                //{

                //    listView1.Items.Add(str1 + "\r\n");

                //}));
                System.Threading.Thread.Sleep(1000);
                str1 = "Finish";
                //listView1.BeginInvoke(new Action(() =>
                //{
                //    listView1.Items.Add(str1 + "\r\n");

                //}));
            });
            str1 = "Before Start:" + task1.Status.ToString();
            listView1.Items.Add(str1 + "\r\n");
            task1.Start();
            str1 = "After Start:" + task1.Status.ToString();
            listView1.Items.Add(str1 + "\r\n");
            str1 = "Before Wait:" + task1.Status.ToString();
            listView1.Items.Add(str1 + "\r\n");
            task1.Wait();
            str1 = "After Wait:" + task1.Status.ToString();
            listView1.Items.Add(str1 + "\r\n");
        }
    }
}

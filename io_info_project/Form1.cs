using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace io_info_project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fn;
            fn = "E:\\tuts\\info_" + this.id_textBox1.Text + ".txt";
            if (this.id_textBox1.Text=="")
            {
                MessageBox.Show("Please enter your ID!");
                return;
            }
            if (this.full_name_textBox2.Text == "")
            {
                MessageBox.Show("Please enter your Full Name!");
                return;
            }
            System.IO.File.WriteAllText(fn, this.full_name_textBox2.Text, Encoding.UTF8);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string fn;
            fn = "E:\\tuts\\info_" + this.id_textBox1.Text + ".txt";
            if (this.id_textBox1.Text == "")
            {
                MessageBox.Show("Please enter your ID!");
                return;
            }
            if (System.IO.File.Exists( fn )==false )
            {
                MessageBox.Show ("I can't find your info.Please try again!");
                return;
            }
            //////////if (this.full_name_textBox2.Text == "")
            //////////{
            //////////    MessageBox.Show("Please enter your Full Name!");
            //////////    return;
            //////////}
            // System.IO.File.WriteAllText(fn, this.full_name_textBox2.Text, Encoding.UTF8);
            string r;
            r = System.IO.File.ReadAllText(fn, Encoding.UTF8);
            this.full_name_textBox2.Text = r;
        }
    }
}

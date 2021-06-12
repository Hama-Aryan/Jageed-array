using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Football
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer5.Enabled = true;
            timer6.Enabled = false;
            timer7.Enabled = false;
            timer8.Enabled = false;


        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 fm = new Form1();
            fm.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox2.Top -= 10;
            pictureBox2.Left -= 10;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            timer2.Enabled = true;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            pictureBox2.Top -= 20;
            pictureBox2.Left += 20;
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            pictureBox1.Left += 10;
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            pictureBox1.Left -= 10;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer6.Enabled = true;
            timer5.Enabled = false;
            timer7.Enabled = false;
            timer8.Enabled = false;

        }

        private void timer7_Tick(object sender, EventArgs e)
        {
            pictureBox1.Top -= 10;
        }

        private void timer8_Tick(object sender, EventArgs e)
        {
            pictureBox1.Top += 10;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            timer7.Enabled = false;
            timer5.Enabled = false;
            timer6.Enabled = false;
            timer8.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer7.Enabled = true;
            timer5.Enabled = false;
            timer6.Enabled = false;
            timer8.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer8.Enabled = true;
            timer5.Enabled = false;
            timer6.Enabled = false;
            timer7.Enabled = false;
        }
    }
}

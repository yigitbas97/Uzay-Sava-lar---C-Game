using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GorselProgramlama_UzaySavaslari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            label2.Visible = false;
            label3.Visible = false;
            button1.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Visible = true;
            if (label2.Left>150)
            {
                label2.Left -= 10;
            }
            else
            {
                timer1.Stop();
                timer2.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            label3.Visible = true;
            if (label3.Left > 150)
            {
                label3.Left -= 10;
            }
            else
            {
                timer2.Stop();
                button1.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 kurallar = new Form5();
            kurallar.Show();
            this.Hide();
        }
    }
}

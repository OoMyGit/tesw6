using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tesw6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Button tombol1 = new Button();
        Button tombol2 = new Button();
        Timer timer1 = new Timer();
        Timer timer2 = new Timer();
        public void Form1_Load(object sender, EventArgs e)
        {
            tombol1.Text = "Tombol 1";
            tombol1.Visible = true;
            tombol1.Location = new Point(100, 100);
            this.Controls.Add(tombol1);
            

            tombol2.Text = "Tombol 2";
            tombol2.Visible = true;
            tombol2.Location = new Point(500, 100);
            this.Controls.Add(tombol2);

            tombol2.Click += hilang_Click;
            tombol1.Click += hijau_Click;

        }

        public void hijau_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn = tombol2;
            btn.BackColor = Color.Green;

            timer1.Interval = 10000;
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            timer1.Start();
        }
        public void hilang_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn = tombol1;
            btn.Visible = false;

            timer2.Interval = 10000;
            timer2.Enabled = true;
            timer2.Tick += timer2_Tick;
            timer2.Start();
        }
        public void timer1_Tick(object sender, EventArgs e)
        {
            tombol2.BackColor = Color.White;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            tombol1.Visible = true;
        }
    }
}

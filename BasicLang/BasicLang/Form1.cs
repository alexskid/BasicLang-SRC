using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicLang
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void siticoneCircleButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void siticoneCircleButton2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        Point lastPoint;

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void siticoneButton3_Click(object sender, EventArgs e)
        {
            Form f3 = new Construct();

            f3.Show();
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            Form f2 = new Creators();

            f2.Show();
        }

        private void siticoneButton2_Click(object sender, EventArgs e)
        {
            Form f = new Functions();

            f.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://blixer.eu.org");
        }
    }
}

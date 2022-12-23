using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace BasicLang
{
    public partial class Functions : Form
    {
        public Functions()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void siticoneCircleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void siticoneCircleButton2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
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

        private void siticoneButton12_Click(object sender, EventArgs e)
        {
            Process.Start(".\\bat/m.bat");
        }

        private void siticoneButton28_Click(object sender, EventArgs e)
        {
            Process.Start(".\\bat/reg1.bat");
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("!! Запускать от имени администратора !! ", "Предуприждение");
            Process.Start(".\\bat/a.bat");
        }

        private void siticoneButton2_Click(object sender, EventArgs e)
        {
            Process.Start(".\\bat/b.bat");
        }

        private void siticoneButton3_Click(object sender, EventArgs e)
        {
            Process.Start(".\\bat/c.bat");
        }

        private void siticoneButton4_Click(object sender, EventArgs e)
        {
            Process.Start(".\\bat/d.bat");
        }

        private void siticoneButton5_Click(object sender, EventArgs e)
        {
            Process.Start(".\\bat/e.bat");
        }

        private void siticoneButton6_Click(object sender, EventArgs e)
        {
            Process.Start(".\\bat/f.bat");
        }

        private void siticoneButton7_Click(object sender, EventArgs e)
        {
            Process.Start(".\\bat/g.bat");
        }

        private void siticoneButton8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("!!! ОБЯЗАТЕЛЬНО ЗАПУСКАТЬ ОТ ИМЕНИ АДМИНИСТРАТОРА ДЛЯ СТАБИЛЬНОЙ РАБОТЫ !!!", "!! ВНИМАНИЕ !!");
            Process.Start(".\\bat/h.bat");
        }

        private void siticoneButton16_Click(object sender, EventArgs e)
        {
            Process.Start(".\\bat/i.bat");
        }

        private void siticoneButton15_Click(object sender, EventArgs e)
        {
            Process.Start(".\\bat/j.bat");
        }

        private void siticoneButton14_Click(object sender, EventArgs e)
        {
            Process.Start(".\\bat/k.bat");
        }

        private void siticoneButton13_Click(object sender, EventArgs e)
        {
            Process.Start(".\\bat/l.bat");
        }

        private void siticoneButton21_Click(object sender, EventArgs e)
        {
            Process.Start(".\\bat/n.bat");
        }

        private void siticoneButton20_Click(object sender, EventArgs e)
        {
            Process.Start(".\\bat/p.bat");
        }

        private void siticoneButton19_Click(object sender, EventArgs e)
        {
            Process.Start(".\\bat/q.bat");
        }

        private void siticoneButton18_Click(object sender, EventArgs e)
        {
            Process.Start(".\\bat/r.bat");
        }

        private void siticoneButton17_Click(object sender, EventArgs e)
        {
            Process.Start(".\\bat/s.bat");
        }

        private void siticoneButton11_Click(object sender, EventArgs e)
        {
            Process.Start(".\\bat/t.bat");
        }

        private void siticoneButton10_Click(object sender, EventArgs e)
        {
            Process.Start(".\\bat/v.bat");
        }

        private void siticoneButton9_Click(object sender, EventArgs e)
        {
            Process.Start(".\\bat/w.bat");
        }

        private void siticoneButton22_Click(object sender, EventArgs e)
        {
            Process.Start(".\\bat/x.bat");
        }

        private void siticoneButton23_Click(object sender, EventArgs e)
        {
            Process.Start(".\\bat/y.bat");
        }

        private void siticoneButton24_Click(object sender, EventArgs e)
        {
            Process.Start(".\\bat/z.bat");
        }
        

        private void siticoneButton26_Click(object sender, EventArgs e)
        {
            Process.Start(".\\bat/reg2.bat");
        }

        private void siticoneButton29_Click(object sender, EventArgs e)
        {
            Process.Start(".\\bat/reg3.bat");
        }

        private void siticoneButton25_Click(object sender, EventArgs e)
        {
            Process.Start(".\\bat/reg4.bat");
        }

        private void siticoneButton30_Click(object sender, EventArgs e)
        {
            Process.Start(".\\bat/reg5.bat");
        }

        private void siticoneButton31_Click(object sender, EventArgs e)
        {
            Process.Start(".\\bat/w.bat");
        }
    }
}

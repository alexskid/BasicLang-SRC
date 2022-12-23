namespace BasicLang
{
    partial class Construct
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Construct));
            this.text = new FastColoredTextBoxNS.FastColoredTextBox();
            this.siticoneButton1 = new Siticone.UI.WinForms.SiticoneButton();
            this.siticoneButton2 = new Siticone.UI.WinForms.SiticoneButton();
            this.siticoneButton3 = new Siticone.UI.WinForms.SiticoneButton();
            this.siticoneButton4 = new Siticone.UI.WinForms.SiticoneButton();
            this.siticoneButton5 = new Siticone.UI.WinForms.SiticoneButton();
            this.siticoneButton6 = new Siticone.UI.WinForms.SiticoneButton();
            this.siticoneButton7 = new Siticone.UI.WinForms.SiticoneButton();
            this.siticoneButton8 = new Siticone.UI.WinForms.SiticoneButton();
            this.siticoneButton9 = new Siticone.UI.WinForms.SiticoneButton();
            this.siticoneButton10 = new Siticone.UI.WinForms.SiticoneButton();
            this.siticoneButton11 = new Siticone.UI.WinForms.SiticoneButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.siticoneCircleButton2 = new Siticone.UI.WinForms.SiticoneCircleButton();
            this.siticoneCircleButton1 = new Siticone.UI.WinForms.SiticoneCircleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.text)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // text
            // 
            this.text.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.text.AutoIndentCharsPatterns = "^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>[^;=]+);\r\n^\\s*(case|default)\\s*[^:]*" +
    "(?<range>:)\\s*(?<range>[^;]+);";
            this.text.AutoScrollMinSize = new System.Drawing.Size(27, 14);
            this.text.BackBrush = null;
            this.text.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.text.CharHeight = 14;
            this.text.CharWidth = 8;
            this.text.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.text.ForeColor = System.Drawing.Color.SeaGreen;
            this.text.IndentBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.text.IsReplaceMode = false;
            this.text.Location = new System.Drawing.Point(426, 52);
            this.text.Name = "text";
            this.text.Paddings = new System.Windows.Forms.Padding(0);
            this.text.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.text.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("text.ServiceColors")));
            this.text.ServiceLinesColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.text.Size = new System.Drawing.Size(452, 577);
            this.text.TabIndex = 0;
            this.text.Zoom = 100;
            // 
            // siticoneButton1
            // 
            this.siticoneButton1.CheckedState.Parent = this.siticoneButton1;
            this.siticoneButton1.CustomImages.Parent = this.siticoneButton1;
            this.siticoneButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneButton1.ForeColor = System.Drawing.Color.White;
            this.siticoneButton1.HoveredState.Parent = this.siticoneButton1;
            this.siticoneButton1.Location = new System.Drawing.Point(5, 82);
            this.siticoneButton1.Name = "siticoneButton1";
            this.siticoneButton1.ShadowDecoration.Parent = this.siticoneButton1;
            this.siticoneButton1.Size = new System.Drawing.Size(415, 45);
            this.siticoneButton1.TabIndex = 1;
            this.siticoneButton1.Text = "Сделать консоль чистой";
            this.siticoneButton1.Click += new System.EventHandler(this.siticoneButton1_Click);
            // 
            // siticoneButton2
            // 
            this.siticoneButton2.CheckedState.Parent = this.siticoneButton2;
            this.siticoneButton2.CustomImages.Parent = this.siticoneButton2;
            this.siticoneButton2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneButton2.ForeColor = System.Drawing.Color.White;
            this.siticoneButton2.HoveredState.Parent = this.siticoneButton2;
            this.siticoneButton2.Location = new System.Drawing.Point(5, 133);
            this.siticoneButton2.Name = "siticoneButton2";
            this.siticoneButton2.ShadowDecoration.Parent = this.siticoneButton2;
            this.siticoneButton2.Size = new System.Drawing.Size(415, 45);
            this.siticoneButton2.TabIndex = 2;
            this.siticoneButton2.Text = "Создание пользователей";
            this.siticoneButton2.Click += new System.EventHandler(this.siticoneButton2_Click);
            // 
            // siticoneButton3
            // 
            this.siticoneButton3.CheckedState.Parent = this.siticoneButton3;
            this.siticoneButton3.CustomImages.Parent = this.siticoneButton3;
            this.siticoneButton3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneButton3.ForeColor = System.Drawing.Color.White;
            this.siticoneButton3.HoveredState.Parent = this.siticoneButton3;
            this.siticoneButton3.Location = new System.Drawing.Point(5, 184);
            this.siticoneButton3.Name = "siticoneButton3";
            this.siticoneButton3.ShadowDecoration.Parent = this.siticoneButton3;
            this.siticoneButton3.Size = new System.Drawing.Size(415, 45);
            this.siticoneButton3.TabIndex = 3;
            this.siticoneButton3.Text = "Цикл";
            this.siticoneButton3.Click += new System.EventHandler(this.siticoneButton3_Click);
            // 
            // siticoneButton4
            // 
            this.siticoneButton4.CheckedState.Parent = this.siticoneButton4;
            this.siticoneButton4.CustomImages.Parent = this.siticoneButton4;
            this.siticoneButton4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneButton4.ForeColor = System.Drawing.Color.White;
            this.siticoneButton4.HoveredState.Parent = this.siticoneButton4;
            this.siticoneButton4.Location = new System.Drawing.Point(5, 235);
            this.siticoneButton4.Name = "siticoneButton4";
            this.siticoneButton4.ShadowDecoration.Parent = this.siticoneButton4;
            this.siticoneButton4.Size = new System.Drawing.Size(415, 45);
            this.siticoneButton4.TabIndex = 4;
            this.siticoneButton4.Text = "Запрет диспечера задач";
            this.siticoneButton4.Click += new System.EventHandler(this.siticoneButton4_Click);
            // 
            // siticoneButton5
            // 
            this.siticoneButton5.CheckedState.Parent = this.siticoneButton5;
            this.siticoneButton5.CustomImages.Parent = this.siticoneButton5;
            this.siticoneButton5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneButton5.ForeColor = System.Drawing.Color.White;
            this.siticoneButton5.HoveredState.Parent = this.siticoneButton5;
            this.siticoneButton5.Location = new System.Drawing.Point(5, 286);
            this.siticoneButton5.Name = "siticoneButton5";
            this.siticoneButton5.ShadowDecoration.Parent = this.siticoneButton5;
            this.siticoneButton5.Size = new System.Drawing.Size(415, 45);
            this.siticoneButton5.TabIndex = 5;
            this.siticoneButton5.Text = "Открытие чего-то";
            this.siticoneButton5.Click += new System.EventHandler(this.siticoneButton5_Click);
            // 
            // siticoneButton6
            // 
            this.siticoneButton6.CheckedState.Parent = this.siticoneButton6;
            this.siticoneButton6.CustomImages.Parent = this.siticoneButton6;
            this.siticoneButton6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneButton6.ForeColor = System.Drawing.Color.White;
            this.siticoneButton6.HoveredState.Parent = this.siticoneButton6;
            this.siticoneButton6.Location = new System.Drawing.Point(5, 337);
            this.siticoneButton6.Name = "siticoneButton6";
            this.siticoneButton6.ShadowDecoration.Parent = this.siticoneButton6;
            this.siticoneButton6.Size = new System.Drawing.Size(415, 45);
            this.siticoneButton6.TabIndex = 6;
            this.siticoneButton6.Text = "Сообщение";
            this.siticoneButton6.Click += new System.EventHandler(this.siticoneButton6_Click);
            // 
            // siticoneButton7
            // 
            this.siticoneButton7.CheckedState.Parent = this.siticoneButton7;
            this.siticoneButton7.CustomImages.Parent = this.siticoneButton7;
            this.siticoneButton7.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneButton7.ForeColor = System.Drawing.Color.White;
            this.siticoneButton7.HoveredState.Parent = this.siticoneButton7;
            this.siticoneButton7.Location = new System.Drawing.Point(5, 388);
            this.siticoneButton7.Name = "siticoneButton7";
            this.siticoneButton7.ShadowDecoration.Parent = this.siticoneButton7;
            this.siticoneButton7.Size = new System.Drawing.Size(415, 45);
            this.siticoneButton7.TabIndex = 7;
            this.siticoneButton7.Text = "Название";
            this.siticoneButton7.Click += new System.EventHandler(this.siticoneButton7_Click);
            // 
            // siticoneButton8
            // 
            this.siticoneButton8.CheckedState.Parent = this.siticoneButton8;
            this.siticoneButton8.Cursor = System.Windows.Forms.Cursors.Help;
            this.siticoneButton8.CustomImages.Parent = this.siticoneButton8;
            this.siticoneButton8.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneButton8.ForeColor = System.Drawing.Color.White;
            this.siticoneButton8.HoveredState.Parent = this.siticoneButton8;
            this.siticoneButton8.Location = new System.Drawing.Point(5, 584);
            this.siticoneButton8.Name = "siticoneButton8";
            this.siticoneButton8.ShadowDecoration.Parent = this.siticoneButton8;
            this.siticoneButton8.Size = new System.Drawing.Size(415, 45);
            this.siticoneButton8.TabIndex = 10;
            this.siticoneButton8.Text = "Куда и где я могу менять текст?";
            this.siticoneButton8.Click += new System.EventHandler(this.siticoneButton8_Click);
            // 
            // siticoneButton9
            // 
            this.siticoneButton9.CheckedState.Parent = this.siticoneButton9;
            this.siticoneButton9.Cursor = System.Windows.Forms.Cursors.Help;
            this.siticoneButton9.CustomImages.Parent = this.siticoneButton9;
            this.siticoneButton9.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneButton9.ForeColor = System.Drawing.Color.White;
            this.siticoneButton9.HoveredState.Parent = this.siticoneButton9;
            this.siticoneButton9.Location = new System.Drawing.Point(5, 533);
            this.siticoneButton9.Name = "siticoneButton9";
            this.siticoneButton9.ShadowDecoration.Parent = this.siticoneButton9;
            this.siticoneButton9.Size = new System.Drawing.Size(415, 45);
            this.siticoneButton9.TabIndex = 9;
            this.siticoneButton9.Text = "Как пользоваться переменной?";
            this.siticoneButton9.Click += new System.EventHandler(this.siticoneButton9_Click);
            // 
            // siticoneButton10
            // 
            this.siticoneButton10.CheckedState.Parent = this.siticoneButton10;
            this.siticoneButton10.Cursor = System.Windows.Forms.Cursors.Help;
            this.siticoneButton10.CustomImages.Parent = this.siticoneButton10;
            this.siticoneButton10.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneButton10.ForeColor = System.Drawing.Color.White;
            this.siticoneButton10.HoveredState.Parent = this.siticoneButton10;
            this.siticoneButton10.Location = new System.Drawing.Point(5, 482);
            this.siticoneButton10.Name = "siticoneButton10";
            this.siticoneButton10.ShadowDecoration.Parent = this.siticoneButton10;
            this.siticoneButton10.Size = new System.Drawing.Size(415, 45);
            this.siticoneButton10.TabIndex = 8;
            this.siticoneButton10.Text = "Комманда диспечера задач не работает(";
            this.siticoneButton10.Click += new System.EventHandler(this.siticoneButton10_Click);
            // 
            // siticoneButton11
            // 
            this.siticoneButton11.CheckedState.Parent = this.siticoneButton11;
            this.siticoneButton11.CustomImages.Parent = this.siticoneButton11;
            this.siticoneButton11.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneButton11.ForeColor = System.Drawing.Color.White;
            this.siticoneButton11.HoveredState.Parent = this.siticoneButton11;
            this.siticoneButton11.Location = new System.Drawing.Point(426, 636);
            this.siticoneButton11.Name = "siticoneButton11";
            this.siticoneButton11.ShadowDecoration.Parent = this.siticoneButton11;
            this.siticoneButton11.Size = new System.Drawing.Size(452, 19);
            this.siticoneButton11.TabIndex = 11;
            this.siticoneButton11.Text = "Сохранить";
            this.siticoneButton11.Click += new System.EventHandler(this.siticoneButton11_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.siticoneCircleButton2);
            this.panel1.Controls.Add(this.siticoneCircleButton1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-2, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(893, 35);
            this.panel1.TabIndex = 12;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(284, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "ALPHA";
            // 
            // siticoneCircleButton2
            // 
            this.siticoneCircleButton2.CheckedState.Parent = this.siticoneCircleButton2;
            this.siticoneCircleButton2.CustomImages.Parent = this.siticoneCircleButton2;
            this.siticoneCircleButton2.FillColor = System.Drawing.Color.Transparent;
            this.siticoneCircleButton2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneCircleButton2.ForeColor = System.Drawing.Color.White;
            this.siticoneCircleButton2.HoveredState.Parent = this.siticoneCircleButton2;
            this.siticoneCircleButton2.Location = new System.Drawing.Point(818, 2);
            this.siticoneCircleButton2.Name = "siticoneCircleButton2";
            this.siticoneCircleButton2.ShadowDecoration.Mode = Siticone.UI.WinForms.Enums.ShadowMode.Circle;
            this.siticoneCircleButton2.ShadowDecoration.Parent = this.siticoneCircleButton2;
            this.siticoneCircleButton2.Size = new System.Drawing.Size(33, 32);
            this.siticoneCircleButton2.TabIndex = 2;
            this.siticoneCircleButton2.Text = "-";
            this.siticoneCircleButton2.Click += new System.EventHandler(this.siticoneCircleButton2_Click);
            // 
            // siticoneCircleButton1
            // 
            this.siticoneCircleButton1.CheckedState.Parent = this.siticoneCircleButton1;
            this.siticoneCircleButton1.CustomImages.Parent = this.siticoneCircleButton1;
            this.siticoneCircleButton1.FillColor = System.Drawing.Color.Transparent;
            this.siticoneCircleButton1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneCircleButton1.ForeColor = System.Drawing.Color.White;
            this.siticoneCircleButton1.HoveredState.Parent = this.siticoneCircleButton1;
            this.siticoneCircleButton1.Location = new System.Drawing.Point(857, 2);
            this.siticoneCircleButton1.Name = "siticoneCircleButton1";
            this.siticoneCircleButton1.ShadowDecoration.Mode = Siticone.UI.WinForms.Enums.ShadowMode.Circle;
            this.siticoneCircleButton1.ShadowDecoration.Parent = this.siticoneCircleButton1;
            this.siticoneCircleButton1.Size = new System.Drawing.Size(33, 32);
            this.siticoneCircleButton1.TabIndex = 1;
            this.siticoneCircleButton1.Text = "X";
            this.siticoneCircleButton1.Click += new System.EventHandler(this.siticoneCircleButton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(9, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "BasicLang (BatLang) | Конструктор";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(160, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 24);
            this.label3.TabIndex = 13;
            this.label3.Text = "Функции";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(169, 453);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 24);
            this.label4.TabIndex = 14;
            this.label4.Text = "Помощь";
            // 
            // Construct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(890, 682);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.siticoneButton11);
            this.Controls.Add(this.siticoneButton8);
            this.Controls.Add(this.siticoneButton9);
            this.Controls.Add(this.siticoneButton10);
            this.Controls.Add(this.siticoneButton7);
            this.Controls.Add(this.siticoneButton6);
            this.Controls.Add(this.siticoneButton5);
            this.Controls.Add(this.siticoneButton4);
            this.Controls.Add(this.siticoneButton3);
            this.Controls.Add(this.siticoneButton2);
            this.Controls.Add(this.siticoneButton1);
            this.Controls.Add(this.text);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Construct";
            this.Text = "Construct";
            ((System.ComponentModel.ISupportInitialize)(this.text)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FastColoredTextBoxNS.FastColoredTextBox text;
        private Siticone.UI.WinForms.SiticoneButton siticoneButton1;
        private Siticone.UI.WinForms.SiticoneButton siticoneButton2;
        private Siticone.UI.WinForms.SiticoneButton siticoneButton3;
        private Siticone.UI.WinForms.SiticoneButton siticoneButton4;
        private Siticone.UI.WinForms.SiticoneButton siticoneButton5;
        private Siticone.UI.WinForms.SiticoneButton siticoneButton6;
        private Siticone.UI.WinForms.SiticoneButton siticoneButton7;
        private Siticone.UI.WinForms.SiticoneButton siticoneButton8;
        private Siticone.UI.WinForms.SiticoneButton siticoneButton9;
        private Siticone.UI.WinForms.SiticoneButton siticoneButton10;
        private Siticone.UI.WinForms.SiticoneButton siticoneButton11;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private Siticone.UI.WinForms.SiticoneCircleButton siticoneCircleButton2;
        private Siticone.UI.WinForms.SiticoneCircleButton siticoneCircleButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}
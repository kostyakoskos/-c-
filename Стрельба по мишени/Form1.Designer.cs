namespace Стрельба_по_мишени
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.textCentre = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textCount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.numer_up_down = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.стрелToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.стрелятьВводомКоординатToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelx = new System.Windows.Forms.Label();
            this.label_y = new System.Windows.Forms.Label();
            this.textBox_x = new System.Windows.Forms.TextBox();
            this.textBox_y = new System.Windows.Forms.TextBox();
            this.button_strike = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numer_up_down)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 206);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(213, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите радиус мишени(1- 220)";
            this.label1.Visible = false;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textCentre
            // 
            this.textCentre.Location = new System.Drawing.Point(7, 263);
            this.textCentre.Name = "textCentre";
            this.textCentre.Size = new System.Drawing.Size(100, 22);
            this.textCentre.TabIndex = 1;
            this.textCentre.Visible = false;
            this.textCentre.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(7, 125);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(213, 78);
            this.button1.TabIndex = 2;
            this.button1.Text = "Нарисовать мишень";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(3, 288);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 52);
            this.label2.TabIndex = 3;
            this.label2.Text = "Введите число выстрелов(3-9)";
            this.label2.Visible = false;
            // 
            // textCount
            // 
            this.textCount.Location = new System.Drawing.Point(7, 343);
            this.textCount.Name = "textCount";
            this.textCount.Size = new System.Drawing.Size(100, 22);
            this.textCount.TabIndex = 4;
            this.textCount.Visible = false;
            this.textCount.TextChanged += new System.EventHandler(this.textCount_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(3, 368);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Число попаданий";
            this.label3.Visible = false;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(7, 394);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 6;
            this.textBox1.Visible = false;
            this.textBox1.WordWrap = false;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(-1, 419);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "Число промахов";
            this.label4.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(7, 454);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 8;
            this.textBox2.Visible = false;
            // 
            // numer_up_down
            // 
            this.numer_up_down.Location = new System.Drawing.Point(7, 558);
            this.numer_up_down.Name = "numer_up_down";
            this.numer_up_down.Size = new System.Drawing.Size(120, 22);
            this.numer_up_down.TabIndex = 9;
            this.numer_up_down.Visible = false;
            this.numer_up_down.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(3, 479);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 76);
            this.label5.TabIndex = 10;
            this.label5.Text = "Введите координаты смещения";
            this.label5.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.стрелToolStripMenuItem,
            this.стрелятьВводомКоординатToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1624, 31);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // стрелToolStripMenuItem
            // 
            this.стрелToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.стрелToolStripMenuItem.Name = "стрелToolStripMenuItem";
            this.стрелToolStripMenuItem.Size = new System.Drawing.Size(192, 27);
            this.стрелToolStripMenuItem.Text = "Стрелять мышкой";
            this.стрелToolStripMenuItem.Click += new System.EventHandler(this.стрелToolStripMenuItem_Click);
            // 
            // стрелятьВводомКоординатToolStripMenuItem
            // 
            this.стрелятьВводомКоординатToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.стрелятьВводомКоординатToolStripMenuItem.Name = "стрелятьВводомКоординатToolStripMenuItem";
            this.стрелятьВводомКоординатToolStripMenuItem.Size = new System.Drawing.Size(275, 27);
            this.стрелятьВводомКоординатToolStripMenuItem.Text = "Стрелять вводом координат";
            this.стрелятьВводомКоординатToolStripMenuItem.Click += new System.EventHandler(this.стрелятьВводомКоординатToolStripMenuItem_Click);
            // 
            // labelx
            // 
            this.labelx.AutoSize = true;
            this.labelx.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelx.Location = new System.Drawing.Point(1419, 36);
            this.labelx.Name = "labelx";
            this.labelx.Size = new System.Drawing.Size(100, 23);
            this.labelx.TabIndex = 12;
            this.labelx.Text = "Введите х";
            this.labelx.Visible = false;
            // 
            // label_y
            // 
            this.label_y.AutoSize = true;
            this.label_y.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_y.Location = new System.Drawing.Point(1423, 125);
            this.label_y.Name = "label_y";
            this.label_y.Size = new System.Drawing.Size(100, 23);
            this.label_y.TabIndex = 13;
            this.label_y.Text = "Введите у";
            this.label_y.Visible = false;
            // 
            // textBox_x
            // 
            this.textBox_x.Location = new System.Drawing.Point(1423, 85);
            this.textBox_x.Name = "textBox_x";
            this.textBox_x.Size = new System.Drawing.Size(100, 22);
            this.textBox_x.TabIndex = 14;
            this.textBox_x.Visible = false;
            this.textBox_x.TextChanged += new System.EventHandler(this.textBox_x_TextChanged);
            // 
            // textBox_y
            // 
            this.textBox_y.Location = new System.Drawing.Point(1423, 168);
            this.textBox_y.Name = "textBox_y";
            this.textBox_y.Size = new System.Drawing.Size(100, 22);
            this.textBox_y.TabIndex = 15;
            this.textBox_y.Visible = false;
            this.textBox_y.TextChanged += new System.EventHandler(this.textBox_y_TextChanged);
            // 
            // button_strike
            // 
            this.button_strike.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_strike.Location = new System.Drawing.Point(1423, 221);
            this.button_strike.Name = "button_strike";
            this.button_strike.Size = new System.Drawing.Size(122, 39);
            this.button_strike.TabIndex = 16;
            this.button_strike.Text = "Стрелять";
            this.button_strike.UseVisualStyleBackColor = false;
            this.button_strike.Visible = false;
            this.button_strike.Click += new System.EventHandler(this.button_strike_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1624, 609);
            this.Controls.Add(this.button_strike);
            this.Controls.Add(this.textBox_y);
            this.Controls.Add(this.textBox_x);
            this.Controls.Add(this.label_y);
            this.Controls.Add(this.labelx);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numer_up_down);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textCentre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "ТИР";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.numer_up_down)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textCentre;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.NumericUpDown numer_up_down;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem стрелToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem стрелятьВводомКоординатToolStripMenuItem;
        private System.Windows.Forms.Label labelx;
        private System.Windows.Forms.Label label_y;
        private System.Windows.Forms.TextBox textBox_x;
        private System.Windows.Forms.TextBox textBox_y;
        protected System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button_strike;
    }
}


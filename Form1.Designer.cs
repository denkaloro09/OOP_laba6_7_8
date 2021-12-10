namespace VectorCreater
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.lb1 = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbColorBlue = new System.Windows.Forms.RadioButton();
            this.rbColorGreen = new System.Windows.Forms.RadioButton();
            this.rbColorYellow = new System.Windows.Forms.RadioButton();
            this.rbColorRed = new System.Windows.Forms.RadioButton();
            this.rbColorBlack = new System.Windows.Forms.RadioButton();
            this.rbColorViolet = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButton3);
            this.panel1.Controls.Add(this.lb1);
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Location = new System.Drawing.Point(461, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(100, 102);
            this.panel1.TabIndex = 1;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(4, 75);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(88, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "треугольник";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Location = new System.Drawing.Point(3, 13);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(66, 13);
            this.lb1.TabIndex = 2;
            this.lb1.Text = "Количество";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(4, 52);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(66, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "квадрат";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(4, 29);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(47, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "круг";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(453, 436);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.rbColorViolet);
            this.panel2.Controls.Add(this.rbColorBlue);
            this.panel2.Controls.Add(this.rbColorGreen);
            this.panel2.Controls.Add(this.rbColorYellow);
            this.panel2.Controls.Add(this.rbColorRed);
            this.panel2.Controls.Add(this.rbColorBlack);
            this.panel2.Location = new System.Drawing.Point(461, 110);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(100, 179);
            this.panel2.TabIndex = 5;
            // 
            // rbColorBlue
            // 
            this.rbColorBlue.AutoSize = true;
            this.rbColorBlue.ForeColor = System.Drawing.Color.Blue;
            this.rbColorBlue.Location = new System.Drawing.Point(4, 102);
            this.rbColorBlue.Name = "rbColorBlue";
            this.rbColorBlue.Size = new System.Drawing.Size(56, 17);
            this.rbColorBlue.TabIndex = 4;
            this.rbColorBlue.TabStop = true;
            this.rbColorBlue.Text = "Синий";
            this.rbColorBlue.UseVisualStyleBackColor = true;
            this.rbColorBlue.CheckedChanged += new System.EventHandler(this.rbColorBlue_CheckedChanged);
            // 
            // rbColorGreen
            // 
            this.rbColorGreen.AutoSize = true;
            this.rbColorGreen.ForeColor = System.Drawing.Color.Green;
            this.rbColorGreen.Location = new System.Drawing.Point(4, 79);
            this.rbColorGreen.Name = "rbColorGreen";
            this.rbColorGreen.Size = new System.Drawing.Size(70, 17);
            this.rbColorGreen.TabIndex = 3;
            this.rbColorGreen.TabStop = true;
            this.rbColorGreen.Text = "Зеленый";
            this.rbColorGreen.UseVisualStyleBackColor = true;
            this.rbColorGreen.CheckedChanged += new System.EventHandler(this.rbColorGreen_CheckedChanged);
            // 
            // rbColorYellow
            // 
            this.rbColorYellow.AutoSize = true;
            this.rbColorYellow.ForeColor = System.Drawing.Color.Yellow;
            this.rbColorYellow.Location = new System.Drawing.Point(4, 56);
            this.rbColorYellow.Name = "rbColorYellow";
            this.rbColorYellow.Size = new System.Drawing.Size(67, 17);
            this.rbColorYellow.TabIndex = 2;
            this.rbColorYellow.TabStop = true;
            this.rbColorYellow.Text = "Желтый";
            this.rbColorYellow.UseVisualStyleBackColor = true;
            this.rbColorYellow.CheckedChanged += new System.EventHandler(this.rbColorYellow_CheckedChanged);
            // 
            // rbColorRed
            // 
            this.rbColorRed.AutoSize = true;
            this.rbColorRed.ForeColor = System.Drawing.Color.Red;
            this.rbColorRed.Location = new System.Drawing.Point(4, 33);
            this.rbColorRed.Name = "rbColorRed";
            this.rbColorRed.Size = new System.Drawing.Size(70, 17);
            this.rbColorRed.TabIndex = 1;
            this.rbColorRed.TabStop = true;
            this.rbColorRed.Text = "Красный";
            this.rbColorRed.UseVisualStyleBackColor = true;
            this.rbColorRed.CheckedChanged += new System.EventHandler(this.rbColorRed_CheckedChanged);
            // 
            // rbColorBlack
            // 
            this.rbColorBlack.AutoSize = true;
            this.rbColorBlack.BackColor = System.Drawing.Color.Gainsboro;
            this.rbColorBlack.ForeColor = System.Drawing.Color.Black;
            this.rbColorBlack.Location = new System.Drawing.Point(4, 10);
            this.rbColorBlack.Name = "rbColorBlack";
            this.rbColorBlack.Size = new System.Drawing.Size(65, 17);
            this.rbColorBlack.TabIndex = 0;
            this.rbColorBlack.TabStop = true;
            this.rbColorBlack.Text = "Черный";
            this.rbColorBlack.UseVisualStyleBackColor = false;
            this.rbColorBlack.CheckedChanged += new System.EventHandler(this.rbColorBlack_CheckedChanged);
            // 
            // rbColorViolet
            // 
            this.rbColorViolet.AutoSize = true;
            this.rbColorViolet.ForeColor = System.Drawing.Color.Violet;
            this.rbColorViolet.Location = new System.Drawing.Point(4, 125);
            this.rbColorViolet.Name = "rbColorViolet";
            this.rbColorViolet.Size = new System.Drawing.Size(85, 17);
            this.rbColorViolet.TabIndex = 5;
            this.rbColorViolet.TabStop = true;
            this.rbColorViolet.Text = "Филетовый";
            this.rbColorViolet.UseVisualStyleBackColor = true;
            this.rbColorViolet.CheckedChanged += new System.EventHandler(this.rbColorViolet_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(591, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rbColorBlue;
        private System.Windows.Forms.RadioButton rbColorGreen;
        private System.Windows.Forms.RadioButton rbColorYellow;
        private System.Windows.Forms.RadioButton rbColorRed;
        private System.Windows.Forms.RadioButton rbColorBlack;
        private System.Windows.Forms.RadioButton rbColorViolet;
    }
}


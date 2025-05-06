namespace WindowsFormsApp13
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox_size = new System.Windows.Forms.PictureBox();
            this.textBox_size = new System.Windows.Forms.TextBox();
            this.trackBar_size = new System.Windows.Forms.TrackBar();
            this.textBox_B = new System.Windows.Forms.TextBox();
            this.textBox_G = new System.Windows.Forms.TextBox();
            this.textBox_R = new System.Windows.Forms.TextBox();
            this.pictureBox_tempColor = new System.Windows.Forms.PictureBox();
            this.trackBar_B = new System.Windows.Forms.TrackBar();
            this.trackBar_G = new System.Windows.Forms.TrackBar();
            this.trackBar_R = new System.Windows.Forms.TrackBar();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.radioButton_swapColor = new System.Windows.Forms.RadioButton();
            this.button_ToBW = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button_ToL = new System.Windows.Forms.Button();
            this.button_ToSep = new System.Windows.Forms.Button();
            this.button_ToD = new System.Windows.Forms.Button();
            this.button_ToRand = new System.Windows.Forms.Button();
            this.myToolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_size)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_size)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_tempColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_B)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_G)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_R)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox.Location = new System.Drawing.Point(286, 71);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(502, 367);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseClick);
            this.pictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseDown);
            this.pictureBox.MouseHover += new System.EventHandler(this.pictureBox_MouseHover);
            this.pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseMove);
            this.pictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseUp);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pictureBox_size);
            this.groupBox1.Controls.Add(this.textBox_size);
            this.groupBox1.Controls.Add(this.trackBar_size);
            this.groupBox1.Controls.Add(this.textBox_B);
            this.groupBox1.Controls.Add(this.textBox_G);
            this.groupBox1.Controls.Add(this.textBox_R);
            this.groupBox1.Controls.Add(this.pictureBox_tempColor);
            this.groupBox1.Controls.Add(this.trackBar_B);
            this.groupBox1.Controls.Add(this.trackBar_G);
            this.groupBox1.Controls.Add(this.trackBar_R);
            this.groupBox1.Location = new System.Drawing.Point(3, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(277, 367);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Настройки";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Размер";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Цвет";
            // 
            // pictureBox_size
            // 
            this.pictureBox_size.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_size.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox_size.Location = new System.Drawing.Point(217, 39);
            this.pictureBox_size.Name = "pictureBox_size";
            this.pictureBox_size.Size = new System.Drawing.Size(52, 48);
            this.pictureBox_size.TabIndex = 9;
            this.pictureBox_size.TabStop = false;
            this.pictureBox_size.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox_size_Paint);
            // 
            // textBox_size
            // 
            this.textBox_size.Enabled = false;
            this.textBox_size.Location = new System.Drawing.Point(163, 51);
            this.textBox_size.Name = "textBox_size";
            this.textBox_size.Size = new System.Drawing.Size(51, 20);
            this.textBox_size.TabIndex = 8;
            this.textBox_size.Text = "10";
            this.textBox_size.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // trackBar_size
            // 
            this.trackBar_size.Location = new System.Drawing.Point(9, 51);
            this.trackBar_size.Maximum = 40;
            this.trackBar_size.Name = "trackBar_size";
            this.trackBar_size.Size = new System.Drawing.Size(160, 45);
            this.trackBar_size.TabIndex = 7;
            this.trackBar_size.Value = 10;
            this.trackBar_size.Scroll += new System.EventHandler(this.trackBar_size_Scroll);
            // 
            // textBox_B
            // 
            this.textBox_B.Location = new System.Drawing.Point(163, 300);
            this.textBox_B.Name = "textBox_B";
            this.textBox_B.Size = new System.Drawing.Size(51, 20);
            this.textBox_B.TabIndex = 6;
            this.textBox_B.Text = "0";
            this.textBox_B.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_B.TextChanged += new System.EventHandler(this.textBox_B_TextChanged);
            // 
            // textBox_G
            // 
            this.textBox_G.Location = new System.Drawing.Point(163, 265);
            this.textBox_G.Name = "textBox_G";
            this.textBox_G.Size = new System.Drawing.Size(51, 20);
            this.textBox_G.TabIndex = 5;
            this.textBox_G.Text = "0";
            this.textBox_G.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_G.TextChanged += new System.EventHandler(this.textBox_G_TextChanged);
            // 
            // textBox_R
            // 
            this.textBox_R.Location = new System.Drawing.Point(163, 230);
            this.textBox_R.Name = "textBox_R";
            this.textBox_R.Size = new System.Drawing.Size(51, 20);
            this.textBox_R.TabIndex = 4;
            this.textBox_R.Text = "0";
            this.textBox_R.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_R.TextChanged += new System.EventHandler(this.textBox_R_TextChanged);
            // 
            // pictureBox_tempColor
            // 
            this.pictureBox_tempColor.BackColor = System.Drawing.Color.Black;
            this.pictureBox_tempColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox_tempColor.Location = new System.Drawing.Point(217, 251);
            this.pictureBox_tempColor.Name = "pictureBox_tempColor";
            this.pictureBox_tempColor.Size = new System.Drawing.Size(52, 48);
            this.pictureBox_tempColor.TabIndex = 3;
            this.pictureBox_tempColor.TabStop = false;
            // 
            // trackBar_B
            // 
            this.trackBar_B.Location = new System.Drawing.Point(6, 300);
            this.trackBar_B.Maximum = 255;
            this.trackBar_B.Name = "trackBar_B";
            this.trackBar_B.Size = new System.Drawing.Size(160, 45);
            this.trackBar_B.TabIndex = 2;
            this.trackBar_B.Scroll += new System.EventHandler(this.trackBar_B_Scroll);
            // 
            // trackBar_G
            // 
            this.trackBar_G.Location = new System.Drawing.Point(6, 265);
            this.trackBar_G.Maximum = 255;
            this.trackBar_G.Name = "trackBar_G";
            this.trackBar_G.Size = new System.Drawing.Size(160, 45);
            this.trackBar_G.TabIndex = 1;
            this.trackBar_G.Scroll += new System.EventHandler(this.trackBar_G_Scroll);
            // 
            // trackBar_R
            // 
            this.trackBar_R.Location = new System.Drawing.Point(6, 230);
            this.trackBar_R.Maximum = 255;
            this.trackBar_R.Name = "trackBar_R";
            this.trackBar_R.Size = new System.Drawing.Size(160, 45);
            this.trackBar_R.TabIndex = 0;
            this.trackBar_R.Scroll += new System.EventHandler(this.trackBar_R_Scroll);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.button_save);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Location = new System.Drawing.Point(3, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(329, 53);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Меню";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Очистить";
            this.myToolTip.SetToolTip(this.button1, "Очистить холс");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(244, 19);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(75, 23);
            this.button_save.TabIndex = 1;
            this.button_save.Text = "Сохранить";
            this.myToolTip.SetToolTip(this.button_save, "Сохранить проект с заданным названием");
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox1.Location = new System.Drawing.Point(94, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(144, 22);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Название файла";
            this.textBox1.Click += new System.EventHandler(this.textBox1_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 31);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(55, 17);
            this.radioButton1.TabIndex = 12;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Кисть";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 54);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(68, 17);
            this.radioButton2.TabIndex = 13;
            this.radioButton2.Text = "Пипетка";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(6, 77);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(68, 17);
            this.radioButton3.TabIndex = 14;
            this.radioButton3.Text = "Заливка";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton_swapColor);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.radioButton6);
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Controls.Add(this.radioButton3);
            this.groupBox2.Location = new System.Drawing.Point(9, 93);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(260, 118);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Инструменты";
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Enabled = false;
            this.radioButton4.Location = new System.Drawing.Point(6, 43);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(105, 17);
            this.radioButton4.TabIndex = 15;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Прямоугольник";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Enabled = false;
            this.radioButton5.Location = new System.Drawing.Point(6, 20);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(48, 17);
            this.radioButton5.TabIndex = 16;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Круг";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Enabled = false;
            this.radioButton6.Location = new System.Drawing.Point(75, 20);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(82, 17);
            this.radioButton6.TabIndex = 17;
            this.radioButton6.Text = "Выделение";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.radioButton5);
            this.groupBox4.Controls.Add(this.radioButton4);
            this.groupBox4.Location = new System.Drawing.Point(75, 43);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(174, 69);
            this.groupBox4.TabIndex = 18;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Фигуры";
            // 
            // radioButton_swapColor
            // 
            this.radioButton_swapColor.AutoSize = true;
            this.radioButton_swapColor.Location = new System.Drawing.Point(154, 20);
            this.radioButton_swapColor.Name = "radioButton_swapColor";
            this.radioButton_swapColor.Size = new System.Drawing.Size(96, 17);
            this.radioButton_swapColor.TabIndex = 19;
            this.radioButton_swapColor.Text = "Замена цвета";
            this.radioButton_swapColor.UseVisualStyleBackColor = true;
            this.radioButton_swapColor.CheckedChanged += new System.EventHandler(this.radioButton_swapColor_CheckedChanged);
            // 
            // button_ToBW
            // 
            this.button_ToBW.Location = new System.Drawing.Point(6, 19);
            this.button_ToBW.Name = "button_ToBW";
            this.button_ToBW.Size = new System.Drawing.Size(75, 23);
            this.button_ToBW.TabIndex = 3;
            this.button_ToBW.Text = "Ч/Б";
            this.button_ToBW.UseVisualStyleBackColor = true;
            this.button_ToBW.Click += new System.EventHandler(this.button_ToBW_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.button_ToRand);
            this.groupBox5.Controls.Add(this.button_ToD);
            this.groupBox5.Controls.Add(this.button_ToSep);
            this.groupBox5.Controls.Add(this.button_ToL);
            this.groupBox5.Controls.Add(this.button_ToBW);
            this.groupBox5.Location = new System.Drawing.Point(338, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(450, 53);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Изменить";
            // 
            // button_ToL
            // 
            this.button_ToL.Location = new System.Drawing.Point(168, 19);
            this.button_ToL.Name = "button_ToL";
            this.button_ToL.Size = new System.Drawing.Size(75, 23);
            this.button_ToL.TabIndex = 4;
            this.button_ToL.Text = "Ярче";
            this.button_ToL.UseVisualStyleBackColor = true;
            this.button_ToL.Click += new System.EventHandler(this.button_ToL_Click);
            // 
            // button_ToSep
            // 
            this.button_ToSep.Location = new System.Drawing.Point(87, 19);
            this.button_ToSep.Name = "button_ToSep";
            this.button_ToSep.Size = new System.Drawing.Size(75, 23);
            this.button_ToSep.TabIndex = 5;
            this.button_ToSep.Text = "Сепия";
            this.button_ToSep.UseVisualStyleBackColor = true;
            this.button_ToSep.Click += new System.EventHandler(this.button_ToSep_Click);
            // 
            // button_ToD
            // 
            this.button_ToD.Location = new System.Drawing.Point(249, 19);
            this.button_ToD.Name = "button_ToD";
            this.button_ToD.Size = new System.Drawing.Size(75, 23);
            this.button_ToD.TabIndex = 6;
            this.button_ToD.Text = "Темнее";
            this.button_ToD.UseVisualStyleBackColor = true;
            this.button_ToD.Click += new System.EventHandler(this.button_ToD_Click);
            // 
            // button_ToRand
            // 
            this.button_ToRand.Location = new System.Drawing.Point(354, 19);
            this.button_ToRand.Name = "button_ToRand";
            this.button_ToRand.Size = new System.Drawing.Size(75, 23);
            this.button_ToRand.TabIndex = 7;
            this.button_ToRand.Text = "Шум";
            this.button_ToRand.UseVisualStyleBackColor = true;
            this.button_ToRand.Click += new System.EventHandler(this.button_ToRand_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Типо Paint";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_size)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_size)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_tempColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_B)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_G)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_R)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox pictureBox_tempColor;
        private System.Windows.Forms.TrackBar trackBar_B;
        private System.Windows.Forms.TrackBar trackBar_G;
        private System.Windows.Forms.TrackBar trackBar_R;
        private System.Windows.Forms.TextBox textBox_B;
        private System.Windows.Forms.TextBox textBox_G;
        private System.Windows.Forms.TextBox textBox_R;
        private System.Windows.Forms.PictureBox pictureBox_size;
        private System.Windows.Forms.TextBox textBox_size;
        private System.Windows.Forms.TrackBar trackBar_size;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton_swapColor;
        private System.Windows.Forms.Button button_ToBW;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button button_ToRand;
        private System.Windows.Forms.Button button_ToD;
        private System.Windows.Forms.Button button_ToSep;
        private System.Windows.Forms.Button button_ToL;
        private System.Windows.Forms.ToolTip myToolTip;
    }
}


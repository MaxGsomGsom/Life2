namespace Life_2
{
    partial class Setting
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
            this.textBox1_x = new System.Windows.Forms.TextBox();
            this.textBox2_y = new System.Windows.Forms.TextBox();
            this.button1_start = new System.Windows.Forms.Button();
            this.button1_pause = new System.Windows.Forms.Button();
            this.textBox1_green_num = new System.Windows.Forms.TextBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1_zoom = new System.Windows.Forms.TextBox();
            this.button1_help = new System.Windows.Forms.Button();
            this.textBox1_blue = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.radioButton1_1 = new System.Windows.Forms.RadioButton();
            this.radioButton2_2 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.checkBox1_lines = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1_x
            // 
            this.textBox1_x.Location = new System.Drawing.Point(186, 21);
            this.textBox1_x.Name = "textBox1_x";
            this.textBox1_x.Size = new System.Drawing.Size(67, 22);
            this.textBox1_x.TabIndex = 0;
            this.textBox1_x.Text = "50";
            this.textBox1_x.TextChanged += new System.EventHandler(this.textBox1_x_TextChanged);
            // 
            // textBox2_y
            // 
            this.textBox2_y.Location = new System.Drawing.Point(186, 58);
            this.textBox2_y.Name = "textBox2_y";
            this.textBox2_y.Size = new System.Drawing.Size(67, 22);
            this.textBox2_y.TabIndex = 1;
            this.textBox2_y.Text = "50";
            this.textBox2_y.TextChanged += new System.EventHandler(this.textBox2_y_TextChanged);
            // 
            // button1_start
            // 
            this.button1_start.Location = new System.Drawing.Point(45, 436);
            this.button1_start.Name = "button1_start";
            this.button1_start.Size = new System.Drawing.Size(100, 23);
            this.button1_start.TabIndex = 2;
            this.button1_start.Text = "Start New";
            this.button1_start.UseVisualStyleBackColor = true;
            this.button1_start.Click += new System.EventHandler(this.button1_start_Click);
            // 
            // button1_pause
            // 
            this.button1_pause.Location = new System.Drawing.Point(186, 436);
            this.button1_pause.Name = "button1_pause";
            this.button1_pause.Size = new System.Drawing.Size(100, 23);
            this.button1_pause.TabIndex = 3;
            this.button1_pause.Text = "Pause";
            this.button1_pause.UseVisualStyleBackColor = true;
            this.button1_pause.Click += new System.EventHandler(this.button1_pause_Click);
            // 
            // textBox1_green_num
            // 
            this.textBox1_green_num.Location = new System.Drawing.Point(186, 98);
            this.textBox1_green_num.Name = "textBox1_green_num";
            this.textBox1_green_num.Size = new System.Drawing.Size(67, 22);
            this.textBox1_green_num.TabIndex = 4;
            this.textBox1_green_num.Text = "250";
            this.textBox1_green_num.TextChanged += new System.EventHandler(this.textBox1_green_num_TextChanged);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(150, 178);
            this.trackBar1.Maximum = 1000;
            this.trackBar1.Minimum = 10;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(152, 56);
            this.trackBar1.TabIndex = 5;
            this.trackBar1.TickFrequency = 50;
            this.trackBar1.Value = 500;
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Size X:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Size Y:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Start green №:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Speed:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Zoom:";
            // 
            // textBox1_zoom
            // 
            this.textBox1_zoom.Location = new System.Drawing.Point(185, 225);
            this.textBox1_zoom.Name = "textBox1_zoom";
            this.textBox1_zoom.Size = new System.Drawing.Size(67, 22);
            this.textBox1_zoom.TabIndex = 11;
            this.textBox1_zoom.Text = "10";
            this.textBox1_zoom.TextChanged += new System.EventHandler(this.textBox1_zoom_TextChanged);
            // 
            // button1_help
            // 
            this.button1_help.Location = new System.Drawing.Point(119, 487);
            this.button1_help.Name = "button1_help";
            this.button1_help.Size = new System.Drawing.Size(100, 23);
            this.button1_help.TabIndex = 12;
            this.button1_help.Text = "Help";
            this.button1_help.UseVisualStyleBackColor = true;
            this.button1_help.Click += new System.EventHandler(this.button1_help_Click);
            // 
            // textBox1_blue
            // 
            this.textBox1_blue.Location = new System.Drawing.Point(185, 134);
            this.textBox1_blue.Name = "textBox1_blue";
            this.textBox1_blue.Size = new System.Drawing.Size(68, 22);
            this.textBox1_blue.TabIndex = 13;
            this.textBox1_blue.Text = "10";
            this.textBox1_blue.TextChanged += new System.EventHandler(this.textBox1_blue_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Start blue №:";
            // 
            // radioButton1_1
            // 
            this.radioButton1_1.AutoSize = true;
            this.radioButton1_1.Location = new System.Drawing.Point(172, 283);
            this.radioButton1_1.Name = "radioButton1_1";
            this.radioButton1_1.Size = new System.Drawing.Size(93, 21);
            this.radioButton1_1.TabIndex = 15;
            this.radioButton1_1.TabStop = true;
            this.radioButton1_1.Text = "Simple life";
            this.radioButton1_1.UseVisualStyleBackColor = true;
            // 
            // radioButton2_2
            // 
            this.radioButton2_2.AutoSize = true;
            this.radioButton2_2.Location = new System.Drawing.Point(172, 310);
            this.radioButton2_2.Name = "radioButton2_2";
            this.radioButton2_2.Size = new System.Drawing.Size(96, 21);
            this.radioButton2_2.TabIndex = 16;
            this.radioButton2_2.TabStop = true;
            this.radioButton2_2.Text = "Double life";
            this.radioButton2_2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(150, 268);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(152, 74);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(47, 283);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 17);
            this.label7.TabIndex = 18;
            this.label7.Text = "Type of game:";
            // 
            // checkBox1_lines
            // 
            this.checkBox1_lines.AutoSize = true;
            this.checkBox1_lines.Location = new System.Drawing.Point(48, 367);
            this.checkBox1_lines.Name = "checkBox1_lines";
            this.checkBox1_lines.Size = new System.Drawing.Size(97, 21);
            this.checkBox1_lines.TabIndex = 19;
            this.checkBox1_lines.Text = "Black lines";
            this.checkBox1_lines.UseVisualStyleBackColor = true;
            this.checkBox1_lines.CheckedChanged += new System.EventHandler(this.checkBox1_lines_CheckedChanged);
            // 
            // Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 545);
            this.Controls.Add(this.checkBox1_lines);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.radioButton1_1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.radioButton2_2);
            this.Controls.Add(this.textBox1_blue);
            this.Controls.Add(this.button1_help);
            this.Controls.Add(this.textBox1_zoom);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.textBox1_green_num);
            this.Controls.Add(this.button1_pause);
            this.Controls.Add(this.button1_start);
            this.Controls.Add(this.textBox2_y);
            this.Controls.Add(this.textBox1_x);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Setting";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Setting";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Setting_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox textBox1_x;
        public System.Windows.Forms.TextBox textBox2_y;
        private System.Windows.Forms.Button button1_start;
        private System.Windows.Forms.Button button1_pause;
        public System.Windows.Forms.TextBox textBox1_green_num;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox textBox1_zoom;
        private System.Windows.Forms.Button button1_help;
        public System.Windows.Forms.TextBox textBox1_blue;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.RadioButton radioButton1_1;
        public System.Windows.Forms.RadioButton radioButton2_2;
        private System.Windows.Forms.CheckBox checkBox1_lines;

    }
}
namespace Life_2
{
    partial class Game
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1_main = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1_main)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1_main
            // 
            this.pictureBox1_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1_main.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1_main.Name = "pictureBox1_main";
            this.pictureBox1_main.Size = new System.Drawing.Size(420, 396);
            this.pictureBox1_main.TabIndex = 0;
            this.pictureBox1_main.TabStop = false;
            this.pictureBox1_main.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_main_MouseClick);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 396);
            this.Controls.Add(this.pictureBox1_main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Life 2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1_main)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox pictureBox1_main;

    }
}


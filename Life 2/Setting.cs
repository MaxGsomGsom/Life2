using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Life_2
{
    public partial class Setting : Form
    {
        Game game_form;
        public Setting(Game that)
        {
            InitializeComponent();
            game_form = that;
            button1_pause.Enabled = false;
            radioButton1_1.Checked = true;
            game_form.WindowState = FormWindowState.Minimized;

        }

        private void Setting_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_x_TextChanged(object sender, EventArgs e)
        {
            NoLetters(textBox1_x);
            
        }

        private void NoLetters(TextBox box)
        {
            try
            {
                int s = Convert.ToInt32(box.Text);
            }
            catch (System.FormatException)
            {
                box.Clear();
            }
        }

        private void textBox2_y_TextChanged(object sender, EventArgs e)
        {
            NoLetters(textBox2_y);
        }

        private void button1_start_Click(object sender, EventArgs e)
        {
            game_form.WindowState = FormWindowState.Normal;
            game_form.Init_game();
            button1_pause.Enabled = true;
            button1_pause.Text = "Pause";
        }

        private void button1_pause_Click(object sender, EventArgs e)
        {
            if (game_form.t.Enabled == true)
            {
                game_form.t.Stop();
                button1_pause.Text = "Resume";
            }
            else
            {
                game_form.t.Start();
                button1_pause.Text = "Pause";
            }
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            game_form.t.Interval = trackBar1.Value;
        }

        private void textBox1_green_num_TextChanged(object sender, EventArgs e)
        {
            NoLetters(textBox1_green_num);
        }

        private void textBox1_zoom_TextChanged(object sender, EventArgs e)
        {
            NoLetters(textBox1_zoom);
        }

        private void button1_help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Simple life - обычная игра Жизнь\nПравила:\n1.Клетка жива пока рядом с ней есть 2 или 3 живые клетки\n2.Клетка размножается если рядом есть 3 живые клетки\n\nDouble life - игра Жизнь с двумя формами жизни\nПравила:\n1.Зеленые клетки - трава - действуют так же как и в простой игре, но выживают еще и при 4 соседях\n2.Синие клетки - животные - могут двигаться, размножаться и есть траву\n3.Синие живут 50 ходов, при этом размножаясь на 20 и 40 ходах\n4.Синим нужно есть траву, иначе они умирают после 10 голодных ходов\n\n\nМожно вручную добавлятьзеленые клетки, если во время паузы нажать ЛКМ на поле, и синие - если нажать ПКМ\n\n\nCopyright © Maxim Kuzmin, 2014");
        }

        private void textBox1_blue_TextChanged(object sender, EventArgs e)
        {
            NoLetters(textBox1_blue);
        }

        
    }
}

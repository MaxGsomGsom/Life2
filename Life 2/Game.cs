using System;
using System.Collections;
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
    public partial class Game : Form
    {
        Setting setting_form;
        int[,] field_green;
        int[,] next_field_green;

        int[,,] field_blue;
        int[,,] next_field_blue;

        public bool blackLines = false;
        int stepShow = 0;
        int blueNumShow = 0;
        int greenNumShow = 0;

        Graphics g;
        Random rand;
        int xx, yy;
        public Timer t;
        BufferedGraphics gBuf;
        int zoom = 16;
        bool doubleLife = false;

        int greenMaxLife = 3;

        public Game()
        {
            InitializeComponent();
            setting_form = new Setting(this);
            setting_form.Show();

            rand = new Random();
            t = new Timer();
            t.Tick += Step;
            t.Interval = 500;
            

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        public void Init_game()
        {
            stepShow = 0;

            doubleLife = setting_form.radioButton2_2.Checked;
            if (doubleLife) greenMaxLife = 4;
            else greenMaxLife = 3;

            if (setting_form.textBox1_zoom.Text == "")
            {
                setting_form.textBox1_zoom.Text = "10";
            }
            zoom = Convert.ToInt32(setting_form.textBox1_zoom.Text);

            //============
            if (setting_form.textBox1_x.Text == "" || setting_form.textBox2_y.Text == "")
            {
                setting_form.textBox1_x.Text = "50";
                setting_form.textBox2_y.Text = "50";
            }

            xx = Convert.ToInt32(setting_form.textBox1_x.Text);
            yy = Convert.ToInt32(setting_form.textBox2_y.Text);

            field_green = new int[xx, yy];
            next_field_green = new int[xx, yy];

            field_blue = new int[xx, yy, 3];
            next_field_blue = new int[xx, yy, 3];


            //============
            if (setting_form.textBox1_green_num.Text == "")
            {
                setting_form.textBox1_green_num.Text = "250";
            }

            int green_num = Convert.ToInt32(setting_form.textBox1_green_num.Text);

            for (int y = 0; y < yy; y++)
            {
                for (int x = 0; x < xx; x++)
                {
                    field_green[x, y] = 0;
                    field_blue[x, y, 0] = 0;
                    field_blue[x, y, 1] = 10;
                    field_blue[x, y, 2] = 50;
                }
            }

            for (int i = 0; i < green_num; i++)
            {
                field_green[rand.Next(xx), rand.Next(yy)] = 1;
            }
            //============

            if (setting_form.textBox1_blue.Text == "")
            {
                setting_form.textBox1_blue.Text = "10";
            }

            int blue_num = Convert.ToInt32(setting_form.textBox1_blue.Text);

            for (int i = 0; i < blue_num; i++)
            {
                field_blue[rand.Next(xx), rand.Next(yy), 0] = 1;
            }

            //============
            this.Width = xx * zoom + 40;
            this.Height = yy * zoom + 70;

            g = pictureBox1_main.CreateGraphics();

            t.Start();

            BufferedGraphicsContext context = new BufferedGraphicsContext();
            gBuf = context.Allocate(g, new Rectangle(0, 0, pictureBox1_main.Width, pictureBox1_main.Height));

            g.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighSpeed;
            g.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighSpeed;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            gBuf.Graphics.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighSpeed;
            gBuf.Graphics.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighSpeed;
            gBuf.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;

            StepDraw();

        }

        public void Step(object sender, EventArgs e)
        {
            next_field_green = (int[,])field_green.Clone();

            Text = "Life 2  |  step - "+stepShow+", green - "+greenNumShow+", blue - "+blueNumShow;

            blueNumShow = 0;
            greenNumShow = 0;
            stepShow++;

            for (int y = 0; y < yy; y++)
            {
                for (int x = 0; x < xx; x++)
                {
                    if (field_green[x, y] == 1)
                    {
                        greenNumShow++;
                        int around = Around(x, y, 1);
                        if (around > greenMaxLife || around < 2) next_field_green[x, y] = 0;
                    }
                    else if (field_green[x, y] == 0)
                    {
                        int around = Around(x, y, 1);
                        if (around == 3) next_field_green[x, y] = 1;
                    }
                }
            }

            field_green = (int[,])next_field_green.Clone();

            //============
            if (doubleLife)
            {
                next_field_blue = (int[, ,])field_blue.Clone();

                for (int y = 0; y < yy; y++)
                {
                    for (int x = 0; x < xx; x++)
                    {
                        if (next_field_blue[x, y, 0] == 1)
                        {
                            next_field_blue[x, y, 1]--;
                            next_field_blue[x, y, 2]--;



                            if (next_field_blue[x, y, 1] <= 0 || next_field_blue[x, y, 2] <= 0)
                            {
                                next_field_blue[x, y, 0] = 0;
                            }
                            else
                            {
                                Point[] waysArr = { new Point(-1, -1), new Point(-1, 0), new Point(-1, 1), new Point(0, -1), new Point(0, 0), new Point(0, 1), new Point(1, -1), new Point(1, 0), new Point(1, 1) };
                                ArrayList ways = new ArrayList();
                                ways.AddRange(waysArr);

                                if (next_field_blue[x, y, 2] == 30 || next_field_blue[x, y, 2] == 10)
                                {
                                    ArrayList ways2 = new ArrayList();
                                    ways2.AddRange(waysArr);

                                    while (ways2.Count != 0)
                                    {
                                        Point p = (Point)ways2[rand.Next(ways2.Count)];
                                        ways2.Remove(p);

                                        if ((x + p.X) < xx && (x + p.X) >= 0 && (y + p.Y) < yy && (y + p.Y) >= 0 && next_field_blue[x + p.X, y + p.Y, 0] != 1)
                                        {
                                            next_field_blue[x + p.X, y + p.Y, 0] = 1;
                                            next_field_blue[x + p.X, y + p.Y, 1] = 10;
                                            next_field_blue[x + p.X, y + p.Y, 2] = 50;
                                            break;
                                        }
                                    }

                                }

                                //field_green[x, y] = 0;
                                while (ways.Count != 0)
                                {
                                    Point p = (Point)ways[rand.Next(ways.Count)];
                                    ways.Remove(p);

                                    if ((x + p.X) < xx && (x + p.X) >= 0 && (y + p.Y) < yy && (y + p.Y) >= 0 && next_field_blue[x + p.X, y + p.Y, 0] == 0 && (field_green[x + p.X, y + p.Y] == 1 || rand.Next(100) > 90))
                                    {
                                        next_field_blue[x + p.X, y + p.Y, 0] = 1;
                                        next_field_blue[x + p.X, y + p.Y, 1] = next_field_blue[x, y, 1];
                                        next_field_blue[x + p.X, y + p.Y, 2] = next_field_blue[x, y, 2];
                                        next_field_blue[x, y, 0] = 0;
                                        if (field_green[x + p.X, y + p.Y] == 1)
                                        {
                                            next_field_blue[x + p.X, y + p.Y, 1] = 10;
                                            field_green[x + p.X, y + p.Y] = 0;
                                        }
                                        //else next_field_blue[x + p.X, y + p.Y, 1]--;
                                        break;
                                    }
                                }
                            }
                            blueNumShow++;
                        }
                    }
                }
                field_blue = (int[, ,])next_field_blue.Clone();
            }

            //===========

            StepDraw();
        }

        private int Around(int x, int y, int type)
        {
            int around = 0;
            for (int i = -1; i <= 1; i++)
            {
                    for (int k = -1; k <= 1; k++)
                    {
                        if ((k!= 0 || i!= 0) && (x + k) < xx && (x + k) >= 0 && (y + i) < yy && (y + i) >= 0)
                        {
                            if (type == 1 && field_green[x+k, y+i] == 1) around++;
                            else if (type == 2 && field_blue[x + k, y + i, 0] == 1) around++;

                        }
                    }
            }
            return around;
        }


        public void StepDraw()
        {
            gBuf.Graphics.Clear(Color.White);
            for (int y = 0; y < yy; y++)
            {
                for (int x = 0; x < xx; x++)
                {
                    if (field_green[x, y] == 1 && field_blue[x, y, 0] == 0)
                    {
                        FillDot(x, y, 1);
                    }
                    else if (doubleLife && field_blue[x, y, 0] == 1)
                    {
                        FillDot(x, y, 2);
                    }
                    FillDot(x, y, 0);
                }
            }
            gBuf.Render(g);
        }

        private void FillDot(int x, int y, int d, bool now = false)
        {
            int d2 = 1;
            if (d == 0) d2 = 0;

                Point[] p = new Point[4];
                p[0].X = x * zoom + 10 + d2;
                p[0].Y = y * zoom + 10 + d2;
                p[1].X = x * zoom + zoom + 10;
                p[1].Y = y * zoom + 10 + d2;
                p[2].X = x * zoom + zoom + 10;
                p[2].Y = y * zoom + zoom + 10;
                p[3].X = x * zoom + 10 + d2;
                p[3].Y = y * zoom + zoom + 10;

                if (d == 1) 
                {
                    if (now) g.FillPolygon(Brushes.LawnGreen, p);
                    else gBuf.Graphics.FillPolygon(Brushes.LawnGreen, p);
                }
                else if (d == 0 && blackLines) gBuf.Graphics.DrawPolygon(Pens.Black, p);
                else if (d == 2)
                {
                    if (now) g.FillPolygon(Brushes.Blue, p);
                    else
                    {
                        int colorInt = field_blue[x, y, 1] * field_blue[x, y, 2] * 255 / 500;
                        Color color = Color.FromArgb(255, 255 - colorInt, 0, colorInt);
                        gBuf.Graphics.FillPolygon(new SolidBrush(color), p);
                    }
                }

        }

        private void pictureBox1_main_MouseClick(object sender, MouseEventArgs e)
        {
            if (t.Enabled == false) {
                int dot_x = (e.X - 10) / zoom;
                int dot_y = (e.Y - 10) / zoom;
                if (dot_x < xx && dot_y < yy)
                {
                    if (e.Button == System.Windows.Forms.MouseButtons.Left)
                    {
                        field_green[dot_x, dot_y] = 1;
                        FillDot(dot_x, dot_y, 1, true);
                        if (field_blue[dot_x, dot_y, 0] == 1) FillDot(dot_x, dot_y, 2, true);
                    }
                    else
                    {
                        field_blue[dot_x, dot_y, 0] = 1;
                        FillDot(dot_x, dot_y, 2, true);
                    }
                }
            }
        }


    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Collections;
// 1. пользователь вводит координаты(чтобы пользователь указывал где будет координаты ввводить кнопка или мышь)
// 2. генерируем исключение
// 3. кнопка стрелять появляется аосле ввода x0 у
// сделать отдельныый массив л=для выстелов по координатам
namespace Стрельба_по_мишени
{
    public partial class Form1 : Form
    {
        bool flag_strike_by_mouse = false;
        bool flag_coordinates = false;
        bool flag_strike = false;
        bool flag_mouse_first_click = false;
        bool flag_text_changed = false;// рисует выстрелы
        bool drawflag = false;// рисует мишень
        bool flag_score = false;
        int count_right = 0;
        int k;
        int W1, H1;
        int counter = 0;// переменная, для хранения количества выстрелов
        int count = 0;
        Point[] MP1 = new Point[20];
        Point[] MP2 = new Point[20];

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
        }
        public struct point// структура для хранения координат
        {
            int x;
            int y;
            private int v1;
            private int v2;

            public point(int v1, int v2) : this()
            {
                this.v1 = v1;
                this.v2 = v2;
            }

            public void SetXY(int nx, int ny)
            {
                x = nx;
                y = ny;
            }
            public int X1
            {
                get { return x; }
                set { x = value; }
            }
            public int Y1
            {
                get { return y; }
                set { y = value; }
            }
        }



        public Form1()
        {
            InitializeComponent();
        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {
            // try catch  
            try
            {
                if (Convert.ToInt16(textCentre.Text) < 0 ||
                    Convert.ToInt16(textCentre.Text) >= 221)
                    throw new FormatException();
            }
            catch (FormatException)
            {
                MessageBox.Show("Wrong input parametr!");
                Close();
            }
        }
        private void button1_Click(object sender, EventArgs e) { }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            DrawFlag(ClientRectangle, e.Graphics);
        }
        public void DrawFlag(Rectangle r, Graphics g)
        {
            int H = r.Height, W = r.Width;
            H1 = H;
            W1 = W;
            Point WN = new Point(0, 0);
            int count_shooting1 = count_right;
            int count_shooting2 = 0;
            if (drawflag)
            {
                const int PROPX = 2, PROPY = 3;
                g.Clear(Color.Gray);

                if (PROPX * r.Width > PROPY * r.Height) // широкое поле
                {
                    W = H * PROPY / PROPX;
                    WN.X = (r.Width - W) / 2;
                }
                else if (PROPX * r.Width < PROPY * r.Height) // высокое поле
                {
                    H = W * PROPX / PROPY;
                    WN.Y = (r.Height - H) / 2;
                }

                Point A = new Point(WN.X, WN.Y + H / 2);
                Point B = new Point(WN.X + W / 2, WN.Y);
                Point C = new Point(WN.X + W, WN.Y + H / 2);
                Point D = new Point(WN.X + W / 2, WN.Y + H);
                Point O = new Point(WN.X + W / 2, WN.Y + H / 2);
                Point I = new Point(WN.X + W / 2 - H / 30, WN.Y + H / 20);
                Point G = new Point(WN.X + W / 2 + H / 30, WN.Y + H / 20);
                Point K = new Point(WN.X + W - H / 20, WN.Y + H / 2 - H / 30);
                Point F = new Point(WN.X + W - H / 20, WN.Y + H / 2 + H / 30);
                Point M = new Point(WN.X - Convert.ToInt16(textCentre.Text) + W / 2, WN.Y + H / 2);
                Point N = new Point(WN.X + W / 2, WN.Y + H / 2 + Convert.ToInt16(textCentre.Text));

                Point F1 = new Point(WN.X, WN.Y);
                Point F2 = new Point(WN.X, WN.Y + H);
                Point F3 = new Point(WN.X + W, WN.Y + H);
                Point F4 = new Point(WN.X + W, WN.Y + H / 2);
                Point F5 = new Point(WN.X + W / 2, WN.Y + H / 2);
                Point F6 = new Point(WN.X + W / 2, WN.Y);


                Point[] white_field = new Point[6];
                Point[] y_black_part = new Point[3];
                Point[] x_black_part = new Point[3];
                Point[] triangle = new Point[3];

                y_black_part[0] = I; y_black_part[1] = G; y_black_part[2] = B;
                x_black_part[0] = K; x_black_part[1] = C; x_black_part[2] = F;
                triangle[0] = M; triangle[1] = N; triangle[2] = O;
                white_field[0] = F1; white_field[1] = F2; white_field[2] = F3; white_field[3] = F4;
                white_field[4] = F5; white_field[5] = F6;

                SolidBrush brush = new SolidBrush(Color.White);// берем белую краску
                Pen pen = new Pen(brush);// берем кисть
                g.FillRectangle(brush, WN.X, WN.Y, W, H);// зарисовываем беым

                brush.Color = Color.Black;
                g.FillEllipse(brush, WN.X - Convert.ToInt16(textCentre.Text) + W / 2,
                    WN.Y + H / 2 - Convert.ToInt16(textCentre.Text),
                    2 * Convert.ToInt16(textCentre.Text),
                    2 * Convert.ToInt16(textCentre.Text));

                brush.Color = Color.White;
                g.FillPolygon(brush, white_field);

                pen.Color = Color.Black;
                g.DrawLine(pen, A, C);
                g.DrawLine(pen, B, D);

                brush.Color = Color.Black;
                g.FillPolygon(brush, y_black_part);
                g.FillPolygon(brush, x_black_part);

                g.FillPolygon(brush, triangle);

                brush.Color = Color.Black;
                Font font = new Font("Courier New", 20, FontStyle.Bold | FontStyle.Italic);
                StringFormat drawFormat = new System.Drawing.StringFormat();
                g.DrawString("X", font, brush, WN.X + W * 91 / 100, WN.Y + H / 2, drawFormat);
                g.DrawString("Y", font, brush, WN.X + W * 43 / 100, WN.Y + 20, drawFormat);
                g.DrawString("-R", font, brush, WN.X + W * 425 / 1000 - Convert.ToInt16(textCentre.Text),
                    WN.Y + H * 425 / 1000, drawFormat);
                g.DrawString("-R", font, brush, WN.X + W * 500 / 1000,
                    WN.Y + H / 2 + Convert.ToInt16(textCentre.Text), drawFormat);

                brush.Dispose();
                pen.Dispose();
                //font.Dispose();
                if (flag_text_changed)// когда ввели правильное число выстрелов и стреляем мышкой
                {
                    SolidBrush brush1 = new SolidBrush(Color.Red);
                    for (int i = 0; i < count; i++)
                    {
                        g.FillEllipse(brush1, Convert.ToInt16(MP1[i].X) + k,
                        // 3 четверть
                            Convert.ToInt16(MP1[i].Y) + k, 10, 10);// рисуем точку, по координатам
                        if (Convert.ToInt16(MP1[i].X) + k < WN.X + W / 2 &&
     Convert.ToInt16(MP1[i].Y) + k > WN.Y + H / 2)
                        {// обрабатываем ситуцию попадание в треугольник(координата клика
                            if (Convert.ToInt16(MP1[i].X) + k >
                         WN.X + W / 2 - Convert.ToInt16(textCentre.Text) &&
                        Convert.ToInt16(MP1[i].X) + k <
                         WN.X + W / 2 &&
                        Convert.ToInt16(MP1[i].Y) + k <
                        H / 2 + Convert.ToInt16(textCentre.Text) &&
                        Convert.ToInt16(MP1[i].Y) + k >
                        H / 2 &&
                        (Convert.ToInt16(MP1[i].Y) - WN.Y - H / 2 <=
                        Convert.ToInt16(MP1[i].X) - WN.X - W / 2 + Convert.ToInt16(textCentre.Text) + 7))
                            {
                                count_shooting1++;
                                textBox1.Text = Convert.ToString(count_shooting1);
                            }
                            else
                            {
                                count_shooting2++;
                                textBox2.Text = Convert.ToString(count_shooting2);
                            }
                        }
                        // 1 четверть
                        if (Convert.ToInt16(MP1[i].X) + k > WN.X + W / 2 &&
 Convert.ToInt16(MP1[i].Y) + k < WN.Y + H / 2)
                        {
                            // для круга
                            if ((Convert.ToInt16(MP1[i].X) - WN.X - W / 2) *
                                (Convert.ToInt16(MP1[i].X) - WN.X - W / 2) +
                                (Convert.ToInt16(MP1[i].Y) + 7 - WN.Y - H / 2) *
                                (Convert.ToInt16(MP1[i].Y) + 7 - WN.Y - H / 2) <
                                Convert.ToInt16(textCentre.Text) *
                                Convert.ToInt16(textCentre.Text))
                            {
                                count_shooting1++;
                                textBox1.Text = Convert.ToString(count_shooting1);
                            }
                            else
                            {
                                count_shooting2++;
                                textBox2.Text = Convert.ToString(count_shooting2);
                            }
                        }
                        //2 четверть(неполная)
                        if (Convert.ToInt16(MP1[i].X) + k < WN.X + W / 2 - 10 &&
 Convert.ToInt16(MP1[i].Y) + k < WN.Y + H / 2 - 10)
                        {
                            count_shooting2++;
                            textBox2.Text = Convert.ToString(count_shooting2);
                        }
                        // 2 четверть, особая область для треугольник
                        if (Convert.ToInt16(MP1[i].X) + k < WN.X + W / 2 - 10 &&
                            Convert.ToInt16(MP1[i].X) + k > WN.X + W / 2 - Convert.ToInt16(textCentre.Text) - 10
                            &&
                            Convert.ToInt16(MP1[i].Y) + k < WN.Y + H / 2 &&
                            Convert.ToInt16(MP1[i].Y) + k > WN.Y + H / 2 - 10)
                        {
                            count_shooting1++;
                            textBox1.Text = Convert.ToString(count_shooting1);
                        }
                        // 2 четверть особая область для круга
                        if (Convert.ToInt16(MP1[i].X) + k < WN.X + W / 2 &&
                            Convert.ToInt16(MP1[i].X) + k > WN.X + W / 2 - 10 &&
                            Convert.ToInt16(MP1[i].Y) + k < WN.Y + H / 2 &&
                            Convert.ToInt16(MP1[i].Y) + k > WN.Y + H / 2 - 10 - Convert.ToInt16(textCentre.Text)
                            )
                        {
                            count_shooting1++;
                            textBox1.Text = Convert.ToString(count_shooting1);
                        }
                        // 4 четверть
                        if (Convert.ToInt16(MP1[i].X) + k > WN.X + W / 2 &&// 4 четверть
Convert.ToInt16(MP1[i].Y + k) > WN.Y + H / 2)
                        {
                            count_shooting2++;
                            textBox2.Text = Convert.ToString(count_shooting2);
                        }
                    }
                    flag_text_changed = false;
                    brush1.Dispose();
                }
                if (flag_strike)// когда стреляем координатами
                {
                    SolidBrush brush1 = new SolidBrush(Color.Green);
                    for (int i = 0; i < count; i++)
                    {
                        g.FillEllipse(brush1, Convert.ToInt16(MP2[i].X) + WN.X, Convert.ToInt16(MP2[i].Y) + WN.Y,
                            10, 10);
                        if (Convert.ToInt16(MP1[i].X) + k < WN.X + W / 2 &&
     Convert.ToInt16(MP1[i].Y) + k > WN.Y + H / 2)
                        {// обрабатываем ситуцию попадание в треугольник(координата клика
                            if (Convert.ToInt16(MP2[i].X) + k >
                         WN.X + W / 2 - Convert.ToInt16(textCentre.Text) &&
                        Convert.ToInt16(MP2[i].X) + k <
                         WN.X + W / 2 &&
                        Convert.ToInt16(MP2[i].Y) + k <
                        H / 2 + Convert.ToInt16(textCentre.Text) &&
                        Convert.ToInt16(MP2[i].Y) + k >
                        H / 2 &&
                        (Convert.ToInt16(MP2[i].Y) - WN.Y - H / 2 <=
                        Convert.ToInt16(MP2[i].X) - WN.X - W / 2 + Convert.ToInt16(textCentre.Text) + 7))
                            {
                                count_shooting1++;
                                textBox1.Text = Convert.ToString(count_shooting1);
                            }
                            else
                            {
                                count_shooting2++;
                                textBox2.Text = Convert.ToString(count_shooting2);
                            }
                        }
                        // 1 четверть
                        if (Convert.ToInt16(MP2[i].X) + k > WN.X + W / 2 &&
 Convert.ToInt16(MP2[i].Y) + k < WN.Y + H / 2)
                        {
                            // для круга
                            if ((Convert.ToInt16(MP2[i].X) - WN.X - W / 2) *
                                (Convert.ToInt16(MP2[i].X) - WN.X - W / 2) +
                                (Convert.ToInt16(MP2[i].Y) + 7 - WN.Y - H / 2) *
                                (Convert.ToInt16(MP2[i].Y) + 7 - WN.Y - H / 2) <
                                Convert.ToInt16(textCentre.Text) *
                                Convert.ToInt16(textCentre.Text))
                            {
                                count_shooting1++;
                                textBox1.Text = Convert.ToString(count_shooting1);
                            }
                            else
                            {
                                count_shooting2++;
                                textBox2.Text = Convert.ToString(count_shooting2);
                            }
                        }
                        //2 четверть(неполная)
                        if (Convert.ToInt16(MP2[i].X) + k < WN.X + W / 2 - 10 &&
 Convert.ToInt16(MP2[i].Y) + k < WN.Y + H / 2 - 10)
                        {
                            count_shooting2++;
                            textBox2.Text = Convert.ToString(count_shooting2);
                        }
                        // 2 четверть, особая область для треугольник
                        if (Convert.ToInt16(MP2[i].X) + k < WN.X + W / 2 - 10 &&
                            Convert.ToInt16(MP2[i].X) + k > WN.X + W / 2 - Convert.ToInt16(textCentre.Text) - 10
                            &&
                            Convert.ToInt16(MP2[i].Y) + k < WN.Y + H / 2 &&
                            Convert.ToInt16(MP2[i].Y) + k > WN.Y + H / 2 - 10)
                        {
                            count_shooting1++;
                            textBox1.Text = Convert.ToString(count_shooting1);
                        }
                        // 2 четверть особая область для круга
                        if (Convert.ToInt16(MP2[i].X) + k < WN.X + W / 2 &&
                            Convert.ToInt16(MP2[i].X) + k > WN.X + W / 2 - 10 &&
                            Convert.ToInt16(MP2[i].Y) + k < WN.Y + H / 2 &&
                            Convert.ToInt16(MP2[i].Y) + k > WN.Y + H / 2 - 10 - Convert.ToInt16(textCentre.Text)
                            )
                        {
                            count_shooting1++;
                            textBox1.Text = Convert.ToString(count_shooting1);
                        }
                        // 4 четверть
                        if (Convert.ToInt16(MP2[i].X) + k > WN.X + W / 2 &&// 4 четверть
Convert.ToInt16(MP2[i].Y + k) > WN.Y + H / 2)
                        {
                            count_shooting2++;
                            textBox2.Text = Convert.ToString(count_shooting2);
                        }
                    }
                }
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            Invalidate();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void DrawTriangle(Rectangle r, Graphics g)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            flag_mouse_first_click = true;
            try
            {
                if (Convert.ToInt16(textCount.Text) >= 3 && Convert.ToInt16(textCount.Text) <= 9 &&
                                    Convert.ToInt16(textCentre.Text) > 0 &&
                             Convert.ToInt16(textCentre.Text) <= 220)
                {
                    drawflag = true;
                    Invalidate();
                }
                else
                    throw new FormatException();
            }
            catch (FormatException)
            {
                MessageBox.Show("Wrong input parametr");
                Close();
            }
        }
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {

        }
        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textCount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt16(textCount.Text) < 3 ||
                    Convert.ToInt16(textCount.Text) > 9)
                    throw new FormatException();
            }
            catch (FormatException)
            {
                MessageBox.Show("Wrong input parametr!");
                Close();
            }
        }

        public void Form1_MouseClick(object sender, MouseEventArgs e)// когда кликаем на форму
        {
            try
            {
                if (flag_strike_by_mouse)
                {
                    try
                    {
                        if (flag_mouse_first_click)
                        {
                            counter++;// количество кликов.
                            count++;
                            for (int i = count - 1; i < count; i++)
                            {
                                MP1[count - 1].X = e.X;
                                MP1[count - 1].Y = e.Y;
                            }
                            flag_text_changed = true;
                            Invalidate();
                            if (counter == Convert.ToInt16(textCount.Text))
                            {
                                if (flag_score)
                                {
                                    flag_text_changed = true;
                                    MessageBox.Show("Your score: " + (100 * Convert.ToInt16(textBox1.Text) / counter) + "%");
                                    Close();
                                }
                                else
                                {
                                    MessageBox.Show("Your score: 0%");
                                    Close();
                                }
                            }

                        }
                        else
                            throw new FormatException();
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("In first, you must click on menustrip!");
                        Close();
                    }

                }
                else
                    throw new FormatException();
            }
            catch (FormatException)
            {
                MessageBox.Show("You click not not strike by mouse!");
                Close();
            }
        }
        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            if (Convert.ToInt16(textBox1.Text) > 0)
                flag_score = true;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            k = Convert.ToInt16(numer_up_down.Value);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void стрелToolStripMenuItem_Click(object sender, EventArgs e)
        {
            flag_strike_by_mouse = true;
            Show_Visuable();
        }

        public void Show_Visuable()
        {

            button1.Visible = true;
            label1.Visible = true;
            textCentre.Visible = true;
            label2.Visible = true;
            textCount.Visible = true;
            label3.Visible = true;
            textBox1.Visible = true;
            label4.Visible = true;
            textBox2.Visible = true;
            label5.Visible = true;
            numer_up_down.Visible = true;
        }

        private void стрелятьВводомКоординатToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //flag_srtike_by_mouse = false;
            button_strike.Visible = true;
            flag_coordinates = true;
            labelx.Visible = true;
            textBox_x.Visible = true;
            label_y.Visible = true;
            textBox_y.Visible = true;
            Show_Visuable();
        }

        private void textBox_x_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt16(textBox_x.Text) < 0 ||
                    Convert.ToInt16(textBox_x.Text) > 1000)
                    throw new FormatException();
            }
            catch (FormatException)
            {
                MessageBox.Show("Wrong input!");
                Close();
            }
        }

        private void textBox_y_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt16(textBox_y.Text) < 0 ||
                    Convert.ToInt16(textBox_y.Text) > 1000)
                    throw new FormatException();
            }
            catch (FormatException)
            {
                MessageBox.Show("Wrong input!");
                Close();
            }
        }

        private void button_strike_Click(object sender, EventArgs e)
        {
            counter++;// количество кликов.
            count++;
            for (int i = count - 1; i < count; i++)
            {
                MP2[count - 1].X = Convert.ToInt16(textBox_x.Text);
                MP2[count - 1].Y = Convert.ToInt16(textBox_y.Text);
            }
            //Invalidate();
            try
            {
                if (Convert.ToInt16(textCount.Text) >= 3 && Convert.ToInt16(textCount.Text) <= 9 &&
                                    Convert.ToInt16(textCentre.Text) > 0 &&
                             Convert.ToInt16(textCentre.Text) <= 220 &&
                             Convert.ToInt16(textBox_x.Text) > 0 &&
                             Convert.ToInt16(textBox_x.Text) < 1000 &&
                             Convert.ToInt16(textBox_y.Text) > 0 &&
                             Convert.ToInt16(textBox_y.Text) < 1000)
                {
                    drawflag = true;
                    flag_strike = true;
                    Invalidate();
                }
                else
                    throw new FormatException();
            }
            catch (FormatException)
            {
                MessageBox.Show("Wrong input parametr");
                Close();
            }
        }
        private void count_shooting()
        {
        }
    }
}

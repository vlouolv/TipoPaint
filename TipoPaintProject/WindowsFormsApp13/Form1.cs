using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp13
{
    public partial class Form1 : Form
    {

        Bitmap canvas = new Bitmap(502, 367);
        public Form1()
        {
            InitializeComponent();

            // Изменение размера изображения по колёсику мыши
            //pictureBox.MouseWheel += pictureBox_MouseWheel;

            using (Graphics g = Graphics.FromImage(canvas))
            {
                g.Clear(Color.White);
            }
        }


        int wheelOffset = 0;
        private void pictureBox_MouseWheel(object sender, MouseEventArgs e)
        {
            wheelOffset = e.Delta / 20;
            using (Bitmap sourceBitmap = new Bitmap(pictureBox.Image,
                 pictureBox.ClientSize.Width, pictureBox.ClientSize.Height))
            {
                using (Graphics g = Graphics.FromImage(canvas))
                {
                    g.Clear(Color.White);
                    g.DrawImage(sourceBitmap, new Rectangle(wheelOffset, wheelOffset, pictureBox.Width - wheelOffset * 2, pictureBox.Height - wheelOffset * 2));
                };
                
            }
        }

        // Набор цветов
        Pen BlackPen = new Pen(Color.Black, 3);
        Pen RedPen = new Pen(Color.Red, 3);
        Pen MainPen = new Pen(Color.Black, 1);

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {

            using (Graphics g = Graphics.FromImage(canvas))
            {
                g.DrawRectangle(BlackPen, 20, 20, pictureBox.Width - 40, pictureBox.Height - 40);
            }

            pictureBox.Image = canvas;
        }

        bool isPaint = false;
        bool isFirst = true;

        bool isFilling = false;
        bool isPipette = false;
        bool isSwap = false;


        int last_x;
        int last_y;
        int next_x;
        int next_y;

        int brushSize = 10;
        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (isPaint && !isFilling && !isPipette && !isSwap)
            {
                next_x = e.X;
                next_y = e.Y;
                
                if (isFirst)
                {
                    last_x = next_x;
                    last_y = next_y;
                    isFirst = false;
                }


                int step_x = (last_x - next_x) / 5;
                int step_y = (last_y - next_y) / 5;

                for (int i = 0; i < 5; i++)
                {
                    using (Graphics g = Graphics.FromImage(canvas))
                    {
                        g.FillEllipse(MainPen.Brush, last_x - brushSize / 2, last_y - brushSize / 2, brushSize, brushSize);
                    }
                    last_x += step_x;
                    last_y += step_y;
                }

                //pictureBox.CreateGraphics().DrawLine(MainPen, last_x, last_y, next_x, next_y);

                last_x = next_x; 
                last_y = next_y;
            }
        }

        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            isPaint = true;
        }

        private void pictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            isPaint = false;
            isFirst = true;
        }


        int R = 0;
        int G = 0;
        int B = 0;
        private void trackBar_R_Scroll(object sender, EventArgs e)
        {
            R = trackBar_R.Value;
            textBox_R.Text = R.ToString();
            UpdateBrushColor();
        }

        private void trackBar_G_Scroll(object sender, EventArgs e)
        {
            G = trackBar_G.Value;
            textBox_G.Text = G.ToString();
            UpdateBrushColor();
        }

        private void trackBar_B_Scroll(object sender, EventArgs e)
        {
            B = trackBar_B.Value;
            textBox_B.Text = B.ToString();
            UpdateBrushColor();
        }

        private bool ValidateContact(string T)
        {
            int val;
            if (int.TryParse(T, out val))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void textBox_R_TextChanged(object sender, EventArgs e)
        {
            if (ValidateContact(textBox_R.Text))
            {
                R = Convert.ToInt32(textBox_R.Text);
                if (R > 255) { R = 255; }
                else if (R < 0) { R = 0; }

                textBox_R.Text = R.ToString();
                trackBar_R.Value = R;
                UpdateBrushColor();
            }
        }

        private void textBox_G_TextChanged(object sender, EventArgs e)
        {
            if (ValidateContact(textBox_G.Text))
            {
                G = Convert.ToInt32(textBox_G.Text);
                if (G > 255) { G = 255; }
                else if (G < 0) { G = 0; }

                textBox_G.Text = G.ToString();
                trackBar_G.Value = G;
                UpdateBrushColor();
            }
        }

        private void textBox_B_TextChanged(object sender, EventArgs e)
        {
            if (ValidateContact(textBox_B.Text))
            {
                B = Convert.ToInt32(textBox_B.Text);
                if (B > 255) { B = 255;}
                else if (B < 0) { B = 0; }

                textBox_B.Text = B.ToString();
                trackBar_B.Value = B;
                UpdateBrushColor();
            }
        }
        private void UpdateBrushColor()
        {
            pictureBox_tempColor.BackColor = Color.FromArgb(R, G, B);
            MainPen.Color = Color.FromArgb(R, G, B);
        }

        private void trackBar_size_Scroll(object sender, EventArgs e)
        {
            int D = trackBar_size.Value;
            pictureBox_size.CreateGraphics().Clear(SystemColors.Control);
            pictureBox_size.CreateGraphics().DrawEllipse(BlackPen, pictureBox_size.Width / 2 - D / 2 - 2, pictureBox_size.Height / 2 - D / 2 - 2, D, D);

            textBox_size.Text = D.ToString();
            MainPen.Width = D;
            brushSize = D;
        }

        private void pictureBox_size_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawEllipse(BlackPen, pictureBox_size.Width / 2 - 10 / 2 - 2, pictureBox_size.Height / 2 - 10 / 2 - 2, 10, 10);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (Graphics g = Graphics.FromImage(canvas))
            {
                g.Clear(Color.White);
            }
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            using (Bitmap sourceBitmap = new Bitmap(
                 pictureBox.Width - 43, pictureBox.Height - 43))
            {
                using (Graphics g = Graphics.FromImage(sourceBitmap))
                {
                    g.DrawImage(canvas, -22, -22);
                }

                if (textBox1.Text == string.Empty) { textBox1.Text = "DefultName"; }

                sourceBitmap.Save(textBox1.Text + ".png", System.Drawing.Imaging.ImageFormat.Png);
            }
            
        }

        private void pictureBox_MouseHover(object sender, EventArgs e)
        {
            pictureBox.Focus();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Black;
            textBox1.Text = "";
            textBox1.Click -= textBox1_Click;

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                pictureBox.Cursor = Cursors.Cross;
                isPipette = false;
                isSwap    = false;
                isFilling = true;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                pictureBox.Cursor = Cursors.Cross;
                isFilling = false;
                isSwap    = false;
                isPipette = true;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                pictureBox.Cursor = Cursors.Hand;
                isPipette = false;
                isFilling = false;
                isSwap    = false;
            }
        }

        private void pictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (canvas == null) return;
            if (isPipette)
            {
                Color pixelColor = canvas.GetPixel(e.X, e.Y);

                textBox_R.Text = pixelColor.R.ToString();
                textBox_G.Text = pixelColor.G.ToString();
                textBox_B.Text = pixelColor.B.ToString();
            }
            if (isFilling)
            {
                Point startPixel = new Point(e.X, e.Y);
                Color targetPixelColor = canvas.GetPixel(startPixel.X, startPixel.Y);

                if (targetPixelColor == MainPen.Color) return;

                Queue<Point> queue = new Queue<Point>();
                queue.Enqueue(startPixel);

                while (queue.Count > 0)
                {
                    Point p = queue.Dequeue();
                    if (p.X < 0 || p.X >= canvas.Width || p.Y < 0 || p.Y >= canvas.Height) continue;

                    if (canvas.GetPixel(p.X, p.Y) != targetPixelColor) continue;

                    canvas.SetPixel(p.X, p.Y, MainPen.Color);

                    queue.Enqueue(new Point(p.X - 1, p.Y));
                    queue.Enqueue(new Point(p.X + 1, p.Y));
                    queue.Enqueue(new Point(p.X, p.Y - 1));
                    queue.Enqueue(new Point(p.X, p.Y + 1));
                }
            }
            if (isSwap)
            {
                Point startPixel = new Point(e.X, e.Y);
                Color targetPixelColor = canvas.GetPixel(startPixel.X, startPixel.Y);

                for (int x = 0; x < canvas.Width; x++)
                {
                    for (int y = 0; y < canvas.Height; y++)
                    {
                        if (canvas.GetPixel(x, y) == targetPixelColor)
                            canvas.SetPixel(x, y, MainPen.Color);
                    }
                }
            }
        }

        private void radioButton_swapColor_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_swapColor.Checked)
            {
                pictureBox.Cursor = Cursors.Cross;
                isPipette = false;
                isFilling = false;
                isSwap = true;
            }
        }

        private void button_ToBW_Click(object sender, EventArgs e)
        {
            for (int x = 0; x < canvas.Width; x++)
            {
                for (int y = 0; y < canvas.Height; y++)
                {
                    int color = (canvas.GetPixel(x, y).R + canvas.GetPixel(x, y).G + canvas.GetPixel(x, y).B) / 3;
                    canvas.SetPixel(x, y, Color.FromArgb(color, color, color));
                }
            }
        }

        private void button_ToSep_Click(object sender, EventArgs e)
        {
            for (int x = 0; x < canvas.Width; x++)
            {
                for (int y = 0; y < canvas.Height; y++)
                {
                    int color = (canvas.GetPixel(x, y).R + canvas.GetPixel(x, y).G + canvas.GetPixel(x, y).B) / 3;
                    int colorB = color - 20;
                    if (colorB < 0) { colorB = 0; }
                    canvas.SetPixel(x, y, Color.FromArgb(color, color, colorB));
                }
            }
        }

        Random rand = new Random();

        private void button_ToRand_Click(object sender, EventArgs e)
        {
            for (int x = 0; x < canvas.Width; x++)
            {
                for (int y = 0; y < canvas.Height; y++)
                {
                    canvas.SetPixel(x, y, Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255)));
                }
            }
        }

        private void button_ToL_Click(object sender, EventArgs e)
        {
            for (int x = 0; x < canvas.Width; x++)
            {
                for (int y = 0; y < canvas.Height; y++)
                {
                    int colorR = Convert.ToInt32(canvas.GetPixel(x, y).R);
                    colorR += (255 - colorR + 1) / 10;
                    if (colorR > 255) { colorR = 255; }

                    int colorG = Convert.ToInt32(canvas.GetPixel(x, y).G);
                    colorG += (255 - colorG + 1) / 10;
                    if (colorG > 255) { colorG = 255; }

                    int colorB = Convert.ToInt32(canvas.GetPixel(x, y).B);
                    colorB += (255 - colorB + 1) / 10;
                    if (colorB > 255) { colorB = 255; }
                    
                    canvas.SetPixel(x, y, Color.FromArgb(colorR, colorG, colorB));
                }
            }
        }

        private void button_ToD_Click(object sender, EventArgs e)
        {
            for (int x = 0; x < canvas.Width; x++)
            {
                for (int y = 0; y < canvas.Height; y++)
                {
                    int colorR = Convert.ToInt32(canvas.GetPixel(x, y).R);
                    colorR -= (colorR) / 10;
                    if (colorR < 0) { colorR = 0; }

                    int colorG = Convert.ToInt32(canvas.GetPixel(x, y).G);
                    colorG -= (colorG) / 10;
                    if (colorG < 0) { colorG = 0; }

                    int colorB = Convert.ToInt32(canvas.GetPixel(x, y).B);
                    colorB -= (colorB) / 10;
                    if (colorB < 0) { colorB = 0; }

                    canvas.SetPixel(x, y, Color.FromArgb(colorR, colorG, colorB));
                }
            }
        }
    }
}

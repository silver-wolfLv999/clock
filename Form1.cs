namespace clock
{
    public partial class Form1 : Form
    {
        float x2, y2, x3, y3, x4, y4;
        int second = DateTime.Now.Second, minute = DateTime.Now.Minute, hour = DateTime.Now.Hour;
        int s, m, h;
        string Input_h, Input_m, Input_s;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            this.ClientSize = new System.Drawing.Size(600, 600);
            paint();
        }

        void time(float center_x, float center_y, int sec, int min, int hr)
        {
            Graphics g = this.CreateGraphics();
            g.DrawEllipse(new Pen(Color.Black), center_x - 70, center_y - 70, 140, 140);
            g.FillEllipse(new SolidBrush(Color.Black), center_x - 5, center_y - 5, 10, 10);
            float secRad = (float)(sec * Math.PI / 180);
            float minRad = (float)(min * Math.PI / 180);
            float hrRad = (float)((hr * 30 + min * 0.5) * Math.PI / 180);

            x2 = center_x + 55 * (float)Math.Sin(6 * secRad);
            y2 = center_y - 55 * (float)Math.Cos(6 * secRad);

            x3 = center_x + 50 * (float)Math.Sin(6 * minRad);
            y3 = center_y - 50 * (float)Math.Cos(6 * minRad);

            x4 = center_x + 30 * (float)Math.Sin(hrRad);
            y4 = center_y - 30 * (float)Math.Cos(hrRad);

            using (var secondArrow = new System.Drawing.Drawing2D.AdjustableArrowCap(8, 10, true))
            using (var minuteArrow = new System.Drawing.Drawing2D.AdjustableArrowCap(2.4F, 3, true))
            using (var hourArrow = new System.Drawing.Drawing2D.AdjustableArrowCap(1.6F, 2, true))
            using (var secondPen = new Pen(Color.Red, 1))
            using (var minutePen = new Pen(Color.Blue, 5))
            using (var hourPen = new Pen(Color.Green, 10))
            {
                secondPen.CustomEndCap = secondArrow;
                minutePen.CustomEndCap = minuteArrow;
                hourPen.CustomEndCap = hourArrow;

                g.DrawLine(secondPen, center_x, center_y, x2, y2);
                g.DrawLine(minutePen, center_x, center_y, x3, y3);
                g.DrawLine(hourPen, center_x, center_y, x4, y4);
            }
            for (int i = 1; i <= 60; i++)
            {
                if (i % 5 == 0)
                {
                    g.DrawLine(new Pen(Color.Black, 2), center_x + 62 * (float)Math.Sin((float)(i * Math.PI / 30)), center_y - 62 * (float)Math.Cos((float)(i * Math.PI / 30)), center_x + 70 * (float)Math.Sin((float)(i * Math.PI / 30)), center_y - 70 * (float)Math.Cos((float)(i * Math.PI / 30)));
                }
                else
                    g.DrawLine(new Pen(Color.Black, 1), center_x + 65 * (float)Math.Sin((float)(i * Math.PI / 30)), center_y - 65 * (float)Math.Cos((float)(i * Math.PI / 30)), center_x + 70 * (float)Math.Sin((float)(i * Math.PI / 30)), center_y - 70 * (float)Math.Cos((float)(i * Math.PI / 30)));
            }

            g.DrawString("12", new Font("Times New Roman", 10, FontStyle.Bold | FontStyle.Italic), new SolidBrush(Color.Green), new Point((int)(center_x - 11), (int)(center_y - 66)));
            g.DrawString("6", new Font("Times New Roman", 10, FontStyle.Bold | FontStyle.Italic), new SolidBrush(Color.Green), new Point((int)(center_x - 6), (int)(center_y + 47)));
            g.DrawString("3", new Font("Times New Roman", 10, FontStyle.Bold | FontStyle.Italic), new SolidBrush(Color.Green), new Point((int)(center_x + 52), (int)(center_y - 10)));
            g.DrawString("9", new Font("Times New Roman", 10, FontStyle.Bold | FontStyle.Italic), new SolidBrush(Color.Green), new Point((int)(center_x - 67), (int)(center_y - 10)));
        }

        void paint()
        {
            Graphics g = this.CreateGraphics();
            g.Clear(Color.White);
            time(460.0F, 120.0F, second, minute, hour);
            time(290.0F, 120.0F, s, m, h);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (second == 59)
            {
                second = 0;
                minute++;
                if (minute == 60)
                {
                    minute = 0;
                    hour++;
                    if (hour == 13)
                        hour = 1;
                }
            }
            else
                second++;
            if (s == 0)
            {
                s = 59;
                m--;
                if (m == -1)
                {
                    m = 59;
                    h--;
                    if (h == -1)
                        MessageBox.Show("Time's up!", "Countdown Timer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            else
                s--;
            paint();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.Enter:
                    Input_h = textBox1.Text;
                    Input_m = textBox2.Text;
                    Input_s = textBox3.Text;
                    if (int.TryParse(Input_h, out h) == true)
                        h = int.Parse(Input_h);
                    else
                        h = 0;
                    if (int.TryParse(Input_m, out m) == true)
                        m = int.Parse(Input_m);
                    else
                        m = 0;
                    if (int.TryParse(Input_s, out s) == true)
                        s = int.Parse(Input_s);
                    else
                        s = 0;
                    paint();
                    break;
                case Keys.R:
                    paint();
                    break;
                case Keys.S:
                    timer1.Stop();
                    break;

            }
        }
        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Focus();
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Focus();
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            textBox3.Focus();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            this.ActiveControl = null;
        }
    }
}

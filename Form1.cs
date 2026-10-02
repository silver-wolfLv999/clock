namespace clock
{
    public partial class Form1 : Form
    {
        float x1 = 460.0F, y1 = 120.0F, x2, y2, x3, y3, x4, y4;
        int second = DateTime.Now.Second, minute = DateTime.Now.Minute, hour = DateTime.Now.Hour;
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

        void paint()
        {
            Graphics g = this.CreateGraphics();
            g.Clear(Color.White);

            g.DrawEllipse(new Pen(Color.Black), 390, 50, 140,140);
            g.FillEllipse(new SolidBrush(Color.Black), 455, 115, 10, 10);

            //g.DrawEllipse(new Pen(Color.Black), 220, 50, 140, 140);
            //g.FillEllipse(new SolidBrush(Color.Black), 285, 115, 10, 10);

            float secRad = (float)(second * Math.PI / 180);
            float minRad = (float)(minute * Math.PI / 180);
            float hourRad = (float)((hour * 30 + minute * 0.5) * Math.PI / 180);

            x2 = x1 + 55 * (float)Math.Sin(6 * secRad);
            y2 = y1 - 55 * (float)Math.Cos(6 * secRad);

            x3 = x1 + 50 * (float)Math.Sin(6 * minRad);
            y3 = y1 - 50 * (float)Math.Cos(6 * minRad);

            x4 = x1 + 30 * (float)Math.Sin(hourRad);
            y4 = y1 - 30 * (float)Math.Cos(hourRad);

            g.DrawLine(new Pen(Color.Red, 1), x1, y1, x2, y2);
            g.DrawLine(new Pen(Color.Blue, 5), x1, y1, x3, y3);
            g.DrawLine(new Pen(Color.Green, 10), x1, y1, x4, y4);

            g.DrawString("12", new Font("Times New Roman", 10, FontStyle.Bold | FontStyle.Italic), new SolidBrush(Color.Green), new Point(449,54));
            g.DrawString("6", new Font("Times New Roman", 10, FontStyle.Bold | FontStyle.Italic), new SolidBrush(Color.Green), new Point(454, 167));
            g.DrawString("3", new Font("Times New Roman", 10, FontStyle.Bold | FontStyle.Italic), new SolidBrush(Color.Green), new Point(512, 110));
            g.DrawString("9", new Font("Times New Roman", 10, FontStyle.Bold | FontStyle.Italic), new SolidBrush(Color.Green), new Point(393, 110));

            for (int i = 1; i <= 60; i++)
            {
                if (i % 5 == 0)
                {
                    g.DrawLine(new Pen(Color.Black, 2), x1 + 62 * (float)Math.Sin((float)(i * Math.PI / 30)), y1 - 62 * (float)Math.Cos((float)(i * Math.PI / 30)), x1 + 70 * (float)Math.Sin((float)(i * Math.PI / 30)), y1 - 70 * (float)Math.Cos((float)(i * Math.PI / 30)));
                }
                else
                    g.DrawLine(new Pen(Color.Black, 1), x1 + 65 * (float)Math.Sin((float)(i * Math.PI / 30)), y1 - 65 * (float)Math.Cos((float)(i * Math.PI / 30)), x1 + 70 * (float)Math.Sin((float)(i * Math.PI / 30)), y1 - 70 * (float)Math.Cos((float)(i * Math.PI / 30)));
            }
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
            paint();
        }
    }
}

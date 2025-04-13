using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BBDemo
{
    public partial class Form1 : Form
    {
        private SimulationBox sb;
        private BBox bb;

        private Bitmap buffer;
        public int ballnumber = 0;

        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            buffer = new Bitmap(ClientRectangle.Width, ClientRectangle.Height);

            bb = new BBox(50, 50, 600, 500);

            bb.Balls.Add(new Ball(25, new Vec2D(200, 300), new Vec2D(4, 6)));
            bb.Balls.Add(new Ball(25, new Vec2D(150, 300), new Vec2D(3, 8)));

            //            sb = new SimulationBox(bb, new NaiveAlgo());
            sb = new SimulationBox(bb, new Naive2Algo());
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timMain.Enabled = !timMain.Enabled;

            btnStart.Text = (timMain.Enabled) ? "Stop" : "Start";

        }

        //rysowac scene na podstawie


        protected override void OnPaint(PaintEventArgs e)
        {
            trackBar1.Minimum = 10;
            trackBar1.Maximum = 50;
            trackBar1.Value = bb.Balls[ballnumber].Radius;

            base.OnPaint(e);
            using (var g = Graphics.FromImage(buffer))
            {
                g.Clear(Color.White);
                using (Brush brush = new SolidBrush(Color.FromArgb(200, 200, 200)))
                {
                    int frame = 2;
                    g.FillRectangle(brush, new Rectangle(bb.X - frame, bb.Y - frame, bb.Width + 2 * frame, bb.Height + 2 * frame));
                }
                using (Brush brush = new SolidBrush(Color.FromArgb(230, 230, 230)))
                {
                    g.FillRectangle(brush, new Rectangle(bb.X, bb.Y, bb.Width, bb.Height));
                }
                foreach (var ball in bb.Balls)
                {
                    using Brush ballBrush = new SolidBrush(ball.Ballcolor);
                    g.FillEllipse(ballBrush,
                        ball.Position.X - ball.Radius,
                        ball.Position.Y - ball.Radius,
                        2 * ball.Radius,
                        2 * ball.Radius
                    );
                }
            }
            e.Graphics.DrawImage(buffer, 0, 0);
        }

        private void timMain_Tick(object sender, EventArgs e)
        {
            sb.NextStep();

            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            bb.Balls.Add(new Ball(25, new Vec2D(rnd.Next(50, 650), rnd.Next(50, 550)), new Vec2D(0, 0)));
        }


        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            bb.Balls[ballnumber].Radius = trackBar1.Value;
            bb.Balls[ballnumber].Mass = (int)(32 * Math.Pow(trackBar1.Value, 3));
            bb.Balls[ballnumber].Velocity.X = 1 - (bb.Balls[ballnumber].Velocity.X * trackBar1.Value) / 100;
            bb.Balls[ballnumber].Velocity.Y = 1 - (bb.Balls[ballnumber].Velocity.Y * trackBar1.Value) / 100;
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (ballnumber > 0)
            {
                ballnumber -= 1;
            }
            label3.Text = ballnumber.ToString();
        }
        private void button2_Click(object sender, EventArgs e)
        {

            
            if (ballnumber < bb.Balls.Count - 1)
            {
                ballnumber++;
            }
            label3.Text = ballnumber.ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (bb.Balls[ballnumber].Velocity.X > 0)
            {
                bb.Balls[ballnumber].Velocity.X -= 1;
            }
            else if (bb.Balls[ballnumber].Velocity.X < 0)
            {
                bb.Balls[ballnumber].Velocity.X += 1;
            }

            if (bb.Balls[ballnumber].Velocity.Y > 0)
            {
                bb.Balls[ballnumber].Velocity.Y -= 1;
            }
            else if (bb.Balls[ballnumber].Velocity.Y < 0)
            {
                bb.Balls[ballnumber].Velocity.Y += 1;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (bb.Balls[ballnumber].Velocity.X > 0)
            {
                bb.Balls[ballnumber].Velocity.X += 1;
            }
            else if (bb.Balls[ballnumber].Velocity.X < 0)
            {
                bb.Balls[ballnumber].Velocity.X -= 1;
            }

            if (bb.Balls[ballnumber].Velocity.Y > 0)
            {
                bb.Balls[ballnumber].Velocity.Y += 1;
            }
            else if (bb.Balls[ballnumber].Velocity.Y < 0)
            {
                bb.Balls[ballnumber].Velocity.Y -= 1;
            }
        }
    }
}

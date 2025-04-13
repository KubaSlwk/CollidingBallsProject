using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Diagnostics;
namespace BBDemo
{
    public class Ball
    {

        public int Radius { get; set; }
        public int Mass { get; set; }
        public Vec2D Velocity { get; set; }
        public Vec2D Position { get; set; }

        public Color Ballcolor { get; set; }
        public Color Color { get; internal set; }

        public Ball()
        {
            Radius = 1;
            Mass = (int)(32 * Math.Pow(Radius, 3));
            this.Position = new Vec2D();
            this.Velocity = new Vec2D();

            Random rnd = new Random();
            this.Ballcolor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
        }

        public Ball(int radius, Vec2D Position ,Vec2D Velocity)
        {
            Radius = radius;
            Mass = (int)(32 * Math.Pow(radius, 3));
            this.Position = Position;
            this.Velocity = Velocity;

            Random rnd = new Random();
            this.Ballcolor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
        }

        public double Distance(Ball ball)
        {
            return Math.Sqrt(Math.Pow(this.Position.X - ball.Position.X, 2) + Math.Pow(this.Position.Y - ball.Position.Y, 2));
        }

        public bool Colliding(Ball b)
        {
            if (this.Distance(b) <= this.Radius + b.Radius)
            {
                Debug.WriteLine("Collision detected1");
                return true;
            }
            return false;
        }

    }
}

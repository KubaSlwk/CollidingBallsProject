using System;
using System.Collections.Generic;
using System.Media;
using System.Text;

namespace CollidingBalls
{
    class Naive2Algo : IAlgo
    {
        public void NextStep(BBox box)
        {
            foreach (var ball in box.Balls)
            {

                if (ball.Position.X >= box.Width + box.X - ball.Radius)
                {
                    ball.Position.X = box.X + box.Width - ball.Radius;
                    ball.Velocity.X = -ball.Velocity.X;
                }
                else if (ball.Position.X <= box.X + ball.Radius)
                {
                    ball.Position.X = box.X + ball.Radius;
                    ball.Velocity.X = -ball.Velocity.X;
                }
                if (ball.Position.Y >= box.Y + box.Height - ball.Radius)
                {
                    ball.Position.Y = box.Y + box.Height - ball.Radius;
                    ball.Velocity.Y = -ball.Velocity.Y;
                }
                else if (ball.Position.Y <= box.Y + ball.Radius)
                {
                    ball.Position.Y = box.Y + ball.Radius;
                    ball.Velocity.Y = -ball.Velocity.Y;
                }

                ball.Position.X += ball.Velocity.X;
                ball.Position.Y += ball.Velocity.Y;

                for (int i = 0; i < box.Balls.Count; i++)
                {
                    for (int j = i + 1; j < box.Balls.Count; j++)
                    {
                        Ball b = box.Balls[i];
                        Ball c = box.Balls[j];

                        float dx = c.Position.X - b.Position.X;
                        float dy = c.Position.Y - b.Position.Y;

                        float distance = (float)Math.Sqrt(dx * dx + dy * dy);

                        // 🔴 Zabezpieczenie przed dzieleniem przez zero
                        if (distance == 0) continue;

                        if (b.Colliding(c))
                        {   
                            float nx = dx / distance;
                            float ny = dy / distance;

                            float gx = (float)0.5 * nx * (b.Radius + c.Radius - distance);
                            float gy = (float)0.5 * ny * (b.Radius + c.Radius - distance);

                            b.Position.X -= gx;
                            b.Position.Y -= gy;
                            c.Position.X += gx;
                            c.Position.Y += gy;


                            float v1n = b.Velocity.X * nx + b.Velocity.Y * ny;
                            float v2n = c.Velocity.X * nx + c.Velocity.Y * ny;

                            float m1 = b.Mass;
                            float m2 = c.Mass;
                            float newV1n = (v1n * (m1 - m2) + 2 * m2 * v2n) / (m1 + m2);
                            float newV2n = (v2n * (m2 - m1) + 2 * m1 * v1n) / (m1 + m2);

                            float dv1n = newV1n - v1n;
                            float dv2n = newV2n - v2n;

                            b.Velocity.X += dv1n * nx;
                            b.Velocity.Y += dv1n * ny;
                            c.Velocity.X += dv2n * nx;
                            c.Velocity.Y += dv2n * ny;
                        }
                    }
                }

            }
        }
    }
}

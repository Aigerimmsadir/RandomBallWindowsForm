using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace randomball
{
    class ball
    {
        public Point location;
        public List<Point> neighbours= new List<Point>();
        public GraphicsPath gp = new GraphicsPath();
        public ball()
        {
            location = new Point(new Random().Next(0,200), new Random().Next(0,200));
            Randomlocation();
        }

        public void Randomlocation()
        {
            if (location.X >= 1 && location.Y >= 1)
            {
                neighbours.Add(new Point(location.X + 5, location.Y));
                neighbours.Add(new Point(location.X - 5, location.Y));
                neighbours.Add(new Point(location.X, location.Y + 5));
                neighbours.Add(new Point(location.X, location.Y - 5));
                neighbours.Add(new Point(location.X + 5, location.Y - 5));
                neighbours.Add(new Point(location.X + 5, location.Y - 5));
                neighbours.Add(new Point(location.X + 5, location.Y + 5));
                neighbours.Add(new Point(location.X - 5, location.Y - 5));
            }
            else location = new Point(new Random().Next(0,200) , new Random().Next(0,200) );
        }

        public void Move()
        {
            gp.Reset();
          
            location = neighbours[new Random().Next(0, 7)];
            gp.AddEllipse(location.X, location.Y, 10, 10);
            Thread.Sleep(new Random().Next(0, 500));
            neighbours.Clear();
            Randomlocation();
         
        }
    }
}

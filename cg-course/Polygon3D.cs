using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cg_course
{
    class Polygon3D
    {
        private Point3D[] points3D;
        private Color color;

        public Polygon3D(IEnumerable<Point3D> points3D, Color color)
        {
            this.points3D = points3D.ToArray();
            this.color = color;
        }

        private static Point getPointOnScreen(Point3D point3D, int width, int height)
        {
            Point pointOnScreen = new Point(width / 2, height / 2);
            pointOnScreen.X += (int)point3D.X;
            pointOnScreen.Y -= (int)point3D.Y;
            return pointOnScreen;
        }

        private Point[] getPointsOnScreen(int width, int height)
        {
            Point[] points = new Point[points3D.Length];
            for (int i = 0; i < points3D.Length; i++)
                points[i] = getPointOnScreen(points3D[i], width, height);
            return points;
        }

        public void Draw(Graphics gr, int width, int height)
        {
            Brush brush = new SolidBrush(color);
            Point[] points = getPointsOnScreen(width, height);
            gr.FillPolygon(brush, points);
        }
    }
}

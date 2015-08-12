using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cg_course
{
    class Diagram
    {
        private double[] values;
        private Polygon3D[] sections;

        private Color[] palette;
        private Random random;

        public Diagram(IEnumerable<double> values, IEnumerable<Color> palette)
        {
            this.values = values.ToArray();
            this.palette = new Color[0];
            this.random = new Random();
            this.palette = palette.ToArray();
            generateSections();
        }

        private void generateSections()
        {
            sections = new Polygon3D[values.Length];
            double sum = values.Sum();
            if (sum == 0)
                sum = 1;
            double initialAngle = 0;
            for (int i = 0; i < values.Length; i++)
            {
                double portion = values[i] / sum;
                double angle = 2 * Math.PI * portion;
                Color color = getColor(i);
                sections[i] = generateSection(color, initialAngle, angle);
                initialAngle += angle;
            }
        }

        private static double degToRad(double angle)
        {
            return angle * Math.PI / 180;
        }

        private static double radToDeg(double angle)
        {
            return angle * 180 / Math.PI;
        }

        private Color getColor(int index)
        {
            if (index >= 0 && index < palette.Length)
                return palette[index];
            else
            {
                int r = random.Next(256);
                int g = random.Next(256);
                int b = random.Next(256);
                return Color.FromArgb(r, g, b);
            }
        }

        private Polygon3D generateSection(Color color, double initialAngle, double angle)
        {
            List<Point3D> upperVertices = new List<Point3D>();
            List<Point3D> lowerVertices = new List<Point3D>();
            int upperRadius = 200;
            int lowerRadius = 150;
            Point3D initialUpperPoint = new Point3D(0, upperRadius, 0);
            Point3D initialLowerPoint = new Point3D(0, lowerRadius, 0);
            initialUpperPoint.Rotate(Axes.Z, initialAngle);
            initialLowerPoint.Rotate(Axes.Z, initialAngle);
            int steps = (int)radToDeg(angle);
            for (int i = 0; i <= steps; i++)
            {
                Point3D upperPoint = initialUpperPoint.Clone();
                Point3D lowerPoint = initialLowerPoint.Clone();
                double rotationAngle = angle / steps * i;
                upperPoint.Rotate(Axes.Z, rotationAngle);
                lowerPoint.Rotate(Axes.Z, rotationAngle);
                upperVertices.Add(upperPoint);
                lowerVertices.Add(lowerPoint);
            }
            lowerVertices.Reverse();
            upperVertices.AddRange(lowerVertices);
            return new Polygon3D(upperVertices, color);
        }

        public void Draw(Graphics gr, int width, int height)
        {
            foreach (Polygon3D section in sections)
                section.Draw(gr, width, height);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cg_course
{
    class Point3D : ICloneable
    {
        private double x, y, z, h;

        public double X { get { return x / h; } }
        public double Y { get { return y / h; } }
        public double Z { get { return z / h; } }

        public override string ToString()
        {
            return String.Format("{0:0.0} {1:0.0} {2:0.0}", X, Y, Z);
        }

        public Point3D(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.h = 1;
        }

        private void Transform(double[,] matrix)
        {
            if (matrix.GetLength(0) != 4 || matrix.GetLength(1) != 4)
                throw new ArgumentException();
            double x = this.x;
            double y = this.y;
            double z = this.z;
            double h = this.h;
            this.x = matrix[0, 0] * x + matrix[0, 1] * y + 
                matrix[0, 2] * z + matrix[0, 3] * h;
            this.y = matrix[1, 0] * x + matrix[1, 1] * y + 
                matrix[1, 2] * z + matrix[1, 3] * h;
            this.z = matrix[2, 0] * x + matrix[2, 1] * y + 
                matrix[2, 2] * z + matrix[2, 3] * h;
            this.h = matrix[3, 0] * x + matrix[3, 1] * y + 
                matrix[3, 2] * z + matrix[3, 3] * h;
        }

        private void RotateX(double angle)
        {
            double sin = Math.Sin(angle);
            double cos = Math.Cos(angle);
            double[,] matrix = { {1, 0, 0, 0}, 
                               {0, cos, sin, 0}, 
                               {0, -sin, cos, 0}, 
                               {0, 0, 0, 1} };
            Transform(matrix);
        }

        private void RotateY(double angle)
        {
            double sin = Math.Sin(angle);
            double cos = Math.Cos(angle);
            double[,] matrix = { {cos, 0, -sin, 0}, 
                               {0, 1, 0, 0}, 
                               {sin, 0, cos, 0}, 
                               {0, 0, 0, 1} };
            Transform(matrix);
        }

        private void RotateZ(double angle)
        {
            double sin = Math.Sin(angle);
            double cos = Math.Cos(angle);
            double[,] matrix = { {cos, sin, 0, 0}, 
                               {-sin, cos, 0, 0}, 
                               {0, 0, 1, 0}, 
                               {0, 0, 0, 1} };
            Transform(matrix);
        }

        public void Rotate(Axes axis, double angle)
        {
            switch (axis)
            {
                case Axes.X:
                    RotateX(angle);
                    break;
                case Axes.Y:
                    RotateY(angle);
                    break;
                case Axes.Z:
                    RotateZ(angle);
                    break;
            }
        }

        public void Scale(double ax, double ay, double az)
        {
            double[,] matrix = { {ax, 0, 0, 0}, 
                               {0, ay, 0, 0}, 
                               {0, 0, az, 0}, 
                               {0, 0, 0, 1} };
            Transform(matrix);
        }

        public void Scale(double ratio)
        {
            Scale(ratio, ratio, ratio);
        }

        private void ReflectX()
        {
            double[,] matrix = { {-1, 0, 0, 0}, 
                               {0, 1, 0, 0}, 
                               {0, 0, 1, 0}, 
                               {0, 0, 0, 1} };
            Transform(matrix);
        }

        private void ReflectY()
        {
            double[,] matrix = { {1, 0, 0, 0}, 
                               {0, -1, 0, 0}, 
                               {0, 0, 1, 0}, 
                               {0, 0, 0, 1} };
            Transform(matrix);
        }

        private void ReflectZ()
        {
            double[,] matrix = { {1, 0, 0, 0}, 
                               {0, 1, 0, 0}, 
                               {0, 0, -1, 0}, 
                               {0, 0, 0, 1} };
            Transform(matrix);
        }

        public void Reflect(Axes axis)
        {
            switch (axis)
            {
                case Axes.X:
                    ReflectX();
                    break;
                case Axes.Y:
                    ReflectY();
                    break;
                case Axes.Z:
                    ReflectZ();
                    break;
            }
        }

        public void Shift(double ax, double ay, double az)
        {
            double[,] matrix = { {1, 0, 0, ax}, 
                               {0, 1, 0, ay}, 
                               {0, 0, 1, az}, 
                               {0, 0, 0, 1} };
            Transform(matrix);
        }

        public void Shift(Axes axis, double step)
        {
            switch (axis)
            {
                case Axes.X:
                    Shift(step, 0, 0);
                    break;
                case Axes.Y:
                    Shift(0, step, 0);
                    break;
                case Axes.Z:
                    Shift(0, 0, step);
                    break;
            }
        }

        private void ProjectCabinet()
        {
            double a = 0.5 * Math.Cos(Math.PI / 4);
            double[,] matrix = { {1, 0, a, 0}, 
                               {0, 1, a, 0}, 
                               {0, 0, 1, 0}, 
                               {0, 0, 0, 1} };
            Transform(matrix);
        }

        private void ProjectPerspective()
        {
            double r = 0.001;
            double[,] matrix = { {1, 0, 0, 0}, 
                               {0, 1, 0, 0}, 
                               {0, 0, 0, 0}, 
                               {0, 0, r, 1} };
            Transform(matrix);
        }

        public void Project(Projections type)
        {
            switch (type)
            {
                case Projections.Cabinet:
                    ProjectCabinet();
                    break;
                case Projections.Perspective:
                    ProjectPerspective();
                    break;
            }
        }

        object ICloneable.Clone()
        {
            return Clone();
        }

        public Point3D Clone()
        {
            return new Point3D(X, Y, Z);
        }
    }
}

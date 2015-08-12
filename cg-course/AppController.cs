using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cg_course
{
    class AppController
    {
        private int value1;
        public int Value1 {
            get { return value1; }
            set { oldValue1 = value1; value1 = value; }
        }

        private int value2;
        public int Value2
        {
            get { return value2; }
            set { oldValue2 = value2; value2 = value; }
        }

        private int value3;
        public int Value3
        {
            get { return value3; }
            set { oldValue3 = value3; value3 = value; }
        }

        private int value4;
        public int Value4
        {
            get { return value4; }
            set { oldValue4 = value4; value4 = value; }
        }

        private int value5;
        public int Value5
        {
            get { return value5; }
            set { oldValue5 = value5; value5 = value; }
        }

        private int value6;
        public int Value6
        {
            get { return value6; }
            set { oldValue6 = value6; value6 = value; }
        }

        private int value7;
        public int Value7
        {
            get { return value7; }
            set { oldValue7 = value7; value7 = value; }
        }

        private int value8;
        public int Value8
        {
            get { return value8; }
            set { oldValue8 = value8; value8 = value; }
        }

        private int oldValue1, oldValue2, oldValue3, oldValue4, 
            oldValue5, oldValue6, oldValue7, oldValue8;

        public double NewValuesPortion { get; set; }

        private int width, height;

        private Color[] palette;
        
        private Random random;

        public AppController(int width, int height)
        {
            this.width = width;
            this.height = height;
            this.random = new Random();
            this.Value1 = 0;
            this.Value2 = 0;
            this.Value3 = 0;
            this.Value4 = 0;
            this.Value5 = 0;
            this.Value6 = 0;
            this.Value7 = 0;
            this.Value8 = 0;
            this.NewValuesPortion = 1;
            GeneratePalette();
            GenerateValues();
        }

        public void GenerateValues()
        {
            this.Value1 = random.Next(100);
            this.Value2 = random.Next(100);
            this.Value3 = random.Next(100);
            this.Value4 = random.Next(100);
            this.Value5 = random.Next(100);
            this.Value6 = random.Next(100);
            this.Value7 = random.Next(100);
            this.Value8 = random.Next(100);
        }

        private double[] getDiagramValues()
        {
            double oldValuesPortion = 1 - NewValuesPortion;
            double value1 = this.Value1 * NewValuesPortion + 
                this.oldValue1 * oldValuesPortion;
            double value2 = this.Value2 * NewValuesPortion +
                this.oldValue2 * oldValuesPortion;
            double value3 = this.Value3 * NewValuesPortion +
                this.oldValue3 * oldValuesPortion;
            double value4 = this.Value4 * NewValuesPortion +
                this.oldValue4 * oldValuesPortion;
            double value5 = this.Value5 * NewValuesPortion +
                this.oldValue5 * oldValuesPortion;
            double value6 = this.Value6 * NewValuesPortion +
                this.oldValue6 * oldValuesPortion;
            double value7 = this.Value7 * NewValuesPortion +
                this.oldValue7 * oldValuesPortion;
            double value8 = this.Value8 * NewValuesPortion +
                this.oldValue8 * oldValuesPortion;
            double[] result = { value1, value2, value3, value4, 
                                  value5, value6, value7, value8 };
            return result;
        }

        public void GeneratePalette()
        {
            int size = 8;
            palette = new Color[size];
            for (int i = 0; i < size; i++)
            {
                int r = random.Next(256);
                int g = random.Next(256);
                int b = random.Next(256);
                Color color = Color.FromArgb(r, g, b);
                palette[i] = color;
            }
        }

        public void Draw(Graphics gr)
        {
            Diagram diagram = new Diagram(getDiagramValues(), palette);
            diagram.Draw(gr, width, height);
        }
    }
}

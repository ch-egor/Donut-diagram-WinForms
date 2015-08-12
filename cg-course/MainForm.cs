using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cg_course
{
    public partial class MainForm : Form
    {
        private AppController appController;

        public MainForm()
        {
            InitializeComponent();
            appController = new AppController(canvas.Width, canvas.Height);
            updateElements();
        }

        private void updateElements()
        {
            diagramValue1.Value = appController.Value1;
            diagramValue2.Value = appController.Value2;
            diagramValue3.Value = appController.Value3;
            diagramValue4.Value = appController.Value4;
            diagramValue5.Value = appController.Value5;
            diagramValue6.Value = appController.Value6;
            diagramValue7.Value = appController.Value7;
            diagramValue8.Value = appController.Value8;
        }

        private void canvas_Paint(object sender, PaintEventArgs e)
        {
            appController.Draw(e.Graphics);
        }

        private void newValuesTimer_Tick(object sender, EventArgs e)
        {
            appController.GenerateValues();
            appController.NewValuesPortion = 0;
            updateElements();
            animationTimer.Start();
        }

        private void animationTimer_Tick(object sender, EventArgs e)
        {
            appController.NewValuesPortion += animationTimer.Interval / 1000d;
            canvas.Invalidate();
            if (appController.NewValuesPortion >= 1)
                animationTimer.Stop();
        }

        private void updateValues_Click(object sender, EventArgs e)
        {
            appController.Value1 = (int)diagramValue1.Value;
            appController.Value2 = (int)diagramValue2.Value;
            appController.Value3 = (int)diagramValue3.Value;
            appController.Value4 = (int)diagramValue4.Value;
            appController.Value5 = (int)diagramValue5.Value;
            appController.Value6 = (int)diagramValue6.Value;
            appController.Value7 = (int)diagramValue7.Value;
            appController.Value8 = (int)diagramValue8.Value;
            appController.NewValuesPortion = 0;
            animationTimer.Start();
        }

        private void startTimer_Click(object sender, EventArgs e)
        {
            startTimer.Enabled = false;
            stopTimer.Enabled = true;
            newValuesTimer.Start();
        }

        private void stopTimer_Click(object sender, EventArgs e)
        {
            startTimer.Enabled = true;
            stopTimer.Enabled = false;
            newValuesTimer.Stop();
        }

        private void changePalette_Click(object sender, EventArgs e)
        {
            appController.GeneratePalette();
            canvas.Invalidate();
        }
    }
}

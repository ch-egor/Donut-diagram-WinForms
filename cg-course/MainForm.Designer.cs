namespace cg_course
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.canvas = new System.Windows.Forms.PictureBox();
            this.diagramValue1 = new System.Windows.Forms.NumericUpDown();
            this.diagramValue2 = new System.Windows.Forms.NumericUpDown();
            this.diagramValue3 = new System.Windows.Forms.NumericUpDown();
            this.diagramValue4 = new System.Windows.Forms.NumericUpDown();
            this.diagramValue5 = new System.Windows.Forms.NumericUpDown();
            this.diagramValue6 = new System.Windows.Forms.NumericUpDown();
            this.diagramValue7 = new System.Windows.Forms.NumericUpDown();
            this.diagramValue8 = new System.Windows.Forms.NumericUpDown();
            this.newValuesTimer = new System.Windows.Forms.Timer(this.components);
            this.animationTimer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.updateValues = new System.Windows.Forms.Button();
            this.startTimer = new System.Windows.Forms.Button();
            this.stopTimer = new System.Windows.Forms.Button();
            this.changePalette = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagramValue1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagramValue2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagramValue3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagramValue4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagramValue5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagramValue6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagramValue7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagramValue8)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // canvas
            // 
            this.canvas.Location = new System.Drawing.Point(12, 12);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(600, 600);
            this.canvas.TabIndex = 0;
            this.canvas.TabStop = false;
            this.canvas.Paint += new System.Windows.Forms.PaintEventHandler(this.canvas_Paint);
            // 
            // diagramValue1
            // 
            this.diagramValue1.Location = new System.Drawing.Point(116, 26);
            this.diagramValue1.Name = "diagramValue1";
            this.diagramValue1.Size = new System.Drawing.Size(120, 22);
            this.diagramValue1.TabIndex = 1;
            // 
            // diagramValue2
            // 
            this.diagramValue2.Location = new System.Drawing.Point(116, 54);
            this.diagramValue2.Name = "diagramValue2";
            this.diagramValue2.Size = new System.Drawing.Size(120, 22);
            this.diagramValue2.TabIndex = 2;
            // 
            // diagramValue3
            // 
            this.diagramValue3.Location = new System.Drawing.Point(116, 82);
            this.diagramValue3.Name = "diagramValue3";
            this.diagramValue3.Size = new System.Drawing.Size(120, 22);
            this.diagramValue3.TabIndex = 3;
            // 
            // diagramValue4
            // 
            this.diagramValue4.Location = new System.Drawing.Point(116, 110);
            this.diagramValue4.Name = "diagramValue4";
            this.diagramValue4.Size = new System.Drawing.Size(120, 22);
            this.diagramValue4.TabIndex = 4;
            // 
            // diagramValue5
            // 
            this.diagramValue5.Location = new System.Drawing.Point(116, 138);
            this.diagramValue5.Name = "diagramValue5";
            this.diagramValue5.Size = new System.Drawing.Size(120, 22);
            this.diagramValue5.TabIndex = 5;
            // 
            // diagramValue6
            // 
            this.diagramValue6.Location = new System.Drawing.Point(116, 166);
            this.diagramValue6.Name = "diagramValue6";
            this.diagramValue6.Size = new System.Drawing.Size(120, 22);
            this.diagramValue6.TabIndex = 6;
            // 
            // diagramValue7
            // 
            this.diagramValue7.Location = new System.Drawing.Point(116, 194);
            this.diagramValue7.Name = "diagramValue7";
            this.diagramValue7.Size = new System.Drawing.Size(120, 22);
            this.diagramValue7.TabIndex = 7;
            // 
            // diagramValue8
            // 
            this.diagramValue8.Location = new System.Drawing.Point(116, 222);
            this.diagramValue8.Name = "diagramValue8";
            this.diagramValue8.Size = new System.Drawing.Size(120, 22);
            this.diagramValue8.TabIndex = 8;
            // 
            // newValuesTimer
            // 
            this.newValuesTimer.Interval = 5000;
            this.newValuesTimer.Tick += new System.EventHandler(this.newValuesTimer_Tick);
            // 
            // animationTimer
            // 
            this.animationTimer.Interval = 25;
            this.animationTimer.Tick += new System.EventHandler(this.animationTimer_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Значение 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Значение 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Значение 3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Значение 4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Значение 5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Значение 6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 196);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Значение 7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 224);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "Значение 8";
            // 
            // updateValues
            // 
            this.updateValues.Location = new System.Drawing.Point(78, 259);
            this.updateValues.Name = "updateValues";
            this.updateValues.Size = new System.Drawing.Size(100, 25);
            this.updateValues.TabIndex = 17;
            this.updateValues.Text = "Обновить";
            this.updateValues.UseVisualStyleBackColor = true;
            this.updateValues.Click += new System.EventHandler(this.updateValues_Click);
            // 
            // startTimer
            // 
            this.startTimer.Location = new System.Drawing.Point(674, 400);
            this.startTimer.Name = "startTimer";
            this.startTimer.Size = new System.Drawing.Size(100, 25);
            this.startTimer.TabIndex = 18;
            this.startTimer.Text = "Начать";
            this.startTimer.UseVisualStyleBackColor = true;
            this.startTimer.Click += new System.EventHandler(this.startTimer_Click);
            // 
            // stopTimer
            // 
            this.stopTimer.Enabled = false;
            this.stopTimer.Location = new System.Drawing.Point(791, 400);
            this.stopTimer.Name = "stopTimer";
            this.stopTimer.Size = new System.Drawing.Size(100, 25);
            this.stopTimer.TabIndex = 19;
            this.stopTimer.Text = "Завершить";
            this.stopTimer.UseVisualStyleBackColor = true;
            this.stopTimer.Click += new System.EventHandler(this.stopTimer_Click);
            // 
            // changePalette
            // 
            this.changePalette.Location = new System.Drawing.Point(730, 369);
            this.changePalette.Name = "changePalette";
            this.changePalette.Size = new System.Drawing.Size(100, 25);
            this.changePalette.TabIndex = 20;
            this.changePalette.Text = "Цвета";
            this.changePalette.UseVisualStyleBackColor = true;
            this.changePalette.Click += new System.EventHandler(this.changePalette_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.diagramValue1);
            this.groupBox1.Controls.Add(this.diagramValue2);
            this.groupBox1.Controls.Add(this.diagramValue3);
            this.groupBox1.Controls.Add(this.updateValues);
            this.groupBox1.Controls.Add(this.diagramValue4);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.diagramValue5);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.diagramValue6);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.diagramValue7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.diagramValue8);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(652, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 302);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Значения";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 633);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.changePalette);
            this.Controls.Add(this.stopTimer);
            this.Controls.Add(this.startTimer);
            this.Controls.Add(this.canvas);
            this.Name = "MainForm";
            this.Text = "Визуализация количественных данных";
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagramValue1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagramValue2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagramValue3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagramValue4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagramValue5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagramValue6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagramValue7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagramValue8)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox canvas;
        private System.Windows.Forms.NumericUpDown diagramValue1;
        private System.Windows.Forms.NumericUpDown diagramValue2;
        private System.Windows.Forms.NumericUpDown diagramValue3;
        private System.Windows.Forms.NumericUpDown diagramValue4;
        private System.Windows.Forms.NumericUpDown diagramValue5;
        private System.Windows.Forms.NumericUpDown diagramValue6;
        private System.Windows.Forms.NumericUpDown diagramValue7;
        private System.Windows.Forms.NumericUpDown diagramValue8;
        private System.Windows.Forms.Timer newValuesTimer;
        private System.Windows.Forms.Timer animationTimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button updateValues;
        private System.Windows.Forms.Button startTimer;
        private System.Windows.Forms.Button stopTimer;
        private System.Windows.Forms.Button changePalette;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}


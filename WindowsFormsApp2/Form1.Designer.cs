﻿namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series31 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint6 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(3.14D, "0,0,0,0");
            System.Windows.Forms.DataVisualization.Charting.Series series32 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series33 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series34 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series35 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series36 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title6 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.DashDotDot;
            chartArea6.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea6);
            this.chart1.Cursor = System.Windows.Forms.Cursors.Default;
            legend6.Name = "Legend1";
            this.chart1.Legends.Add(legend6);
            this.chart1.Location = new System.Drawing.Point(-1, -2);
            this.chart1.Name = "chart1";
            series31.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Top;
            series31.BorderWidth = 2;
            series31.ChartArea = "ChartArea1";
            series31.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series31.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            series31.LabelForeColor = System.Drawing.Color.BlanchedAlmond;
            series31.Legend = "Legend1";
            series31.LegendText = "f(x)";
            series31.MarkerBorderWidth = 3;
            series31.MarkerColor = System.Drawing.Color.Black;
            series31.MarkerStep = 34;
            series31.Name = "Series1";
            series31.Points.Add(dataPoint6);
            series31.YValuesPerPoint = 4;
            series32.BorderWidth = 2;
            series32.ChartArea = "ChartArea1";
            series32.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series32.Color = System.Drawing.Color.Black;
            series32.Legend = "Legend1";
            series32.MarkerBorderWidth = 3;
            series32.MarkerColor = System.Drawing.Color.Red;
            series32.MarkerStep = 34;
            series32.Name = "Series2";
            series33.ChartArea = "ChartArea1";
            series33.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series33.Color = System.Drawing.Color.Blue;
            series33.Legend = "Legend1";
            series33.MarkerSize = 7;
            series33.MarkerStep = 3;
            series33.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series33.Name = "Series3";
            series34.ChartArea = "ChartArea1";
            series34.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series34.Color = System.Drawing.Color.Blue;
            series34.Legend = "Legend1";
            series34.MarkerSize = 7;
            series34.MarkerStep = 3;
            series34.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series34.Name = "Series4";
            series35.ChartArea = "ChartArea1";
            series35.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series35.Color = System.Drawing.Color.Blue;
            series35.Legend = "Legend1";
            series35.MarkerSize = 7;
            series35.MarkerStep = 3;
            series35.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series35.Name = "Series5";
            series36.ChartArea = "ChartArea1";
            series36.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series36.Color = System.Drawing.Color.Blue;
            series36.Legend = "Legend1";
            series36.MarkerSize = 7;
            series36.MarkerStep = 3;
            series36.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series36.Name = "Series6";
            this.chart1.Series.Add(series31);
            this.chart1.Series.Add(series32);
            this.chart1.Series.Add(series33);
            this.chart1.Series.Add(series34);
            this.chart1.Series.Add(series35);
            this.chart1.Series.Add(series36);
            this.chart1.Size = new System.Drawing.Size(924, 378);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            title6.Name = "Title1";
            title6.Text = "График функции f(x)";
            this.chart1.Titles.Add(title6);
            this.chart1.Click += new System.EventHandler(this.Chart1_Click);
            this.chart1.Layout += new System.Windows.Forms.LayoutEventHandler(this.Chart1_Layout);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(586, 406);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 55);
            this.button1.TabIndex = 1;
            this.button1.Text = "Нарисовать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "sin(x)",
            "cos(x)",
            "tan(x)",
            "ctan(x)",
            "sin(kx)",
            "cos(kx)",
            "tan(kx)",
            "ctan(kx)",
            "sin(x)+a",
            "cos(x)+a",
            "tan(x)+a",
            "ctan(x)+a",
            "sin(x+a)",
            "cos(x+a)",
            "tan(x+a)",
            "ctan(x+a)",
            "sin(|x|)",
            "cos(|x|)",
            "tan(|x|)",
            "ctan(|x|)"});
            this.comboBox1.Location = new System.Drawing.Point(115, 414);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(146, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.Text = "sin(x)";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "sin(x)",
            "cos(x)",
            "tan(x)",
            "ctan(x)",
            "sin(kx)",
            "cos(kx)",
            "tan(kx)",
            "ctan(kx)",
            "sin(x)+a",
            "cos(x)+a",
            "tan(x)+a",
            "ctan(x)+a",
            "sin(x+a)",
            "cos(x+a)",
            "tan(x+a)",
            "ctan(x+a)",
            "sin(|x|)",
            "cos(|x|)",
            "tan(|x|)",
            "ctan(|x|)"});
            this.comboBox2.Location = new System.Drawing.Point(361, 414);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(146, 21);
            this.comboBox2.TabIndex = 3;
            this.comboBox2.Text = "sin(x)";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(139, 441);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(32, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "0";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(389, 441);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(34, 20);
            this.textBox2.TabIndex = 5;
            this.textBox2.Text = "0";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(232, 441);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(29, 20);
            this.textBox3.TabIndex = 6;
            this.textBox3.Text = "0";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(469, 441);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(38, 20);
            this.textBox4.TabIndex = 7;
            this.textBox4.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(360, 444);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "K = ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(440, 444);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "A = ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(200, 444);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "A = ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(112, 444);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "K = ";
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.Timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 511);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.Text = "Trigonometrick Functions ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer2;
    }
}


﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Chart1_Click(object sender, EventArgs e)
        {

        }
        Double k;
        Double a;
        Double k2, a2;
        private void Button1_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
            chart1.Series[2].Points.Clear();
            chart1.Series[3].Points.Clear();
            chart1.Series[1].Points.Clear();
            chart1.Series[4].Points.Clear();
    
            
            k = Convert.ToDouble(textBox1.Text);
            a = Convert.ToDouble(textBox3.Text);
            switch (comboBox1.Text)
            {
                case "cos(x)":
                    for (double i = -4; i < 10;)
                    {
                        i += 0.1;
                        chart1.Series[0].Points.AddXY(i, Math.Cos(i));
                        chart1.Series[2].Points.AddXY(0, Math.Cos(0));
                    }
                    break;
                case "sin(x)":
                    for (double i = -4; i < 10;)
                    {
                        i += 0.1;
                        chart1.Series[0].Points.AddXY(i, Math.Sin(i));
                        chart1.Series[2].Points.AddXY(-1.57, Math.Sin(-1.57));
                        chart1.Series[3].Points.AddXY(1.65, Math.Sin(1.65));
                    }
                    break;
                case "tan(x)":
                    for (double i = -4; i < 10;)
                    {
                        i += 0.1;
                        chart1.Series[0].Points.AddXY(i, Math.Tan(i));
                        chart1.Series[2].Points.AddXY(3.14, Math.Tan(3.14));
                    }
                    break;
                case "ctan(x)":
                    for (double i = -4; i < 10;)
                    {
                        i += 0.1;
                        chart1.Series[0].Points.AddXY(i, -Math.Tan(i));
                        chart1.Series[2].Points.AddXY(3.14, -Math.Tan(3.14));
                    }
                    break;
                case "cos(kx)":
                    for (double i = -4; i < 10;)
                    {
                        i += 0.1;
                        chart1.Series[0].Points.AddXY(i, Math.Cos(i * k));
                        chart1.Series[2].Points.AddXY(3.14, k * Math.Cos(3.14*k));
                    }
                    break;
                case "sin(kx)":

                    for (double i = -4; i < 10;)
                    {
                        i += 0.1;
                        chart1.Series[0].Points.AddXY(i, Math.Sin(i*k));
                        chart1.Series[2].Points.AddXY(3.14, Math.Sin(k*3.14));
                    }
                    break;
                case "tan(kx)":
                    for (double i = -4; i < 10;)
                    {
                        i += 0.1;
                        chart1.Series[0].Points.AddXY(i, k*Math.Tan(i * k));
                        chart1.Series[2].Points.AddXY(3.14, Math.Tan(3.14*k));
                    }
                    break;
                case "ctan(kx)":
                    for (double i = -4; i < 10;)
                    {
                        i += 0.1;
                        chart1.Series[0].Points.AddXY(i,-k*Math.Tan(i * k));
                        chart1.Series[2].Points.AddXY(3.14, -k*Math.Tan(3.14));
                    }
                    break;
                case "sin(x)+a":
                    for (double i = -4; i < 10;)
                    {
                        i += 0.1;
                        chart1.Series[0].Points.AddXY(i, Math.Sin(i)+a);
                        chart1.Series[2].Points.AddXY(-1.57, Math.Sin(-1.57));
                    }
                    break;
                case "cos(x)+a":
                    for (double i = -4; i < 10;)
                    {
                        i += 0.1;
                        chart1.Series[0].Points.AddXY(i, Math.Cos(i)+a);
                        chart1.Series[2].Points.AddXY(3.14, Math.Cos(3.14) + a);
                    }
                    break;
                case "tan(x)+a":
                    for (double i = -4; i < 10;)
                    {
                        i += 0.1;
                        chart1.Series[0].Points.AddXY(i, Math.Tan(i)+a);
                        chart1.Series[2].Points.AddXY(3.14, Math.Tan(3.14) + a);
                    }
                    break;
                case "ctan(x)+a":
                    for (double i = -4; i < 10;)
                    {
                        i += 0.1;
                        chart1.Series[0].Points.AddXY(i, -Math.Tan(i) + a);
                        chart1.Series[2].Points.AddXY(3.14, -Math.Tan(3.14) + a);
                    }
                    break;
                case "cos(|x|)":
                    for (double i = -4; i < 10;)
                    {
                        i += 0.1;
                        chart1.Series[0].Points.AddXY(i, Math.Abs(Math.Cos(i)));
                        chart1.Series[2].Points.AddXY(3.14, Math.Abs(Math.Cos(3.14)));
                    }
                    break;
                case "sin(|x|)":
                    for (double i = -4; i < 10;)
                    {
                        i += 0.1;
                        chart1.Series[0].Points.AddXY(i, Math.Abs(Math.Sin(i)));
                        chart1.Series[2].Points.AddXY(3.14, Math.Abs(Math.Sin(3.14)));
                    }
                    break;
                case "tan(|x|)":
                    for (double i = -4; i < 10;)
                    {
                        i += 0.1;
                        chart1.Series[0].Points.AddXY(i, Math.Abs(Math.Tan(i)));
                        chart1.Series[2].Points.AddXY(3.14, Math.Abs(Math.Tan(3.14)));
                    }
                    break;
                case "ctan(|x|)":
                    for (double i = -4; i < 10;)
                    {
                        i += 0.1;
                        chart1.Series[0].Points.AddXY(i, -Math.Abs(Math.Tan(i)));
                        chart1.Series[2].Points.AddXY(3.14, -Math.Abs(Math.Cos(3.14)));
                    }
                    break;
                default:
                    
                    break;
            }


            k2 = Convert.ToDouble(textBox2.Text);
            a2 = Convert.ToDouble(textBox4.Text);
            timer1.Enabled = true;
           
            
        }

        double N = -4.1;


        private void Timer1_Tick(object sender, EventArgs e)
        {

            N += 0.1;   
            switch (comboBox2.Text)
            {
                case "cos(x)":
                        chart1.Series[1].Points.AddXY(N, Math.Cos(N));
                    chart1.Series[2].Points.AddXY(0, Math.Cos(0));
                    break;
                case "sin(x)":
                    chart1.Series[1].Points.AddXY(N, Math.Sin(N));
                    chart1.Series[2].Points.AddXY(-1.57, Math.Sin(-1.57));
                    chart1.Series[3].Points.AddXY(1.8, Math.Sin(1.8));

                    break;
                case "tan(x)":
                    chart1.Series[1].Points.AddXY(N, Math.Tan(N));
                    chart1.Series[2].Points.AddXY(3.14, Math.Tan(3.14));
                    break;
                case "Ctan(x)":
                    chart1.Series[1].Points.AddXY(N, -Math.Tan(N));
                    chart1.Series[2].Points.AddXY(3.14, -Math.Tan(3.14));
                    break;
                case "cos(kx)":
                    chart1.Series[1].Points.AddXY(N, Math.Cos(k2*N));
                    chart1.Series[2].Points.AddXY(3.14, Math.Cos(k2*3.14));
                    break;  
                case "sin(kx)":

                    chart1.Series[1].Points.AddXY(N, Math.Sin(k2*N));
                    chart1.Series[2].Points.AddXY(1.57, Math.Sin(k2*1.57));
                    break;
                case "tan(kx)":

                    chart1.Series[1].Points.AddXY(N, Math.Tan(N*k2));
                    chart1.Series[2].Points.AddXY(3.14, Math.Tan(k2*3.14));

                    break;
                case "ctan(kx)":

                    chart1.Series[1].Points.AddXY(N, -Math.Tan(N*k2));
                    chart1.Series[2].Points.AddXY(3.14, Math.Tan(k2*3.14));

                    break;
                case "sin(x)+a":
                    chart1.Series[1].Points.AddXY(N, Math.Sin(N)+a2);
                    chart1.Series[2].Points.AddXY(-1.57, Math.Sin(-1.57)+a2);
                    chart1.Series[3].Points.AddXY(1.65, Math.Sin(1.65)+a2);
                    break;
                case "cos(x)+a":
                    chart1.Series[1].Points.AddXY(N, Math.Cos(N)+a2);
                    chart1.Series[2].Points.AddXY(-1.57, Math.Sin(-1.57));

                    break;
                case "tan(x)+a":

                    chart1.Series[1].Points.AddXY(N, Math.Tan(N)+a2);
                    chart1.Series[2].Points.AddXY(3.14, Math.Tan(3.14) + a2);

                    break;
                case "ctan(x)+a":

                    chart1.Series[1].Points.AddXY(N, -Math.Tan(N)+a2);
                    chart1.Series[2].Points.AddXY(3.14,-Math.Tan(3.14) + a2);

                    break;
                case "cos(|x|)":

                    chart1.Series[1].Points.AddXY(N, Math.Abs(Math.Cos(N)));
                    chart1.Series[2].Points.AddXY(3.14, Math.Abs(Math.Cos(3.14)));

                    break;
                case "sin(|x|)":

                    chart1.Series[1].Points.AddXY(N, Math.Abs(Math.Sin(N)));
                    chart1.Series[2].Points.AddXY(3.14, Math.Abs(Math.Sin(3.14)));

                    break;
                case "tan(|x|)":

                    chart1.Series[1].Points.AddXY(N, Math.Abs(Math.Tan(N)));
                    chart1.Series[2].Points.AddXY(3.14, Math.Abs(Math.Tan(3.14)));
                    break;
                case "ctan(|x|)":

                    chart1.Series[1].Points.AddXY(N, -Math.Abs(Math.Tan(N)));
                    chart1.Series[2].Points.AddXY(3.14, Math.Abs(Math.Cos(3.14)));
                    break;
                default:

                    break;
            }
            if (N >= 10)
            {
                timer1.Enabled = false;
                N = -4.1;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
            chart1.Series[2].Points.Clear();
            chart1.Series[3].Points.Clear();
            chart1.Series[1].Points.Clear();
            chart1.Series[4].Points.Clear();
            chart1.ChartAreas[0].AxisY.ScaleView.Zoom(-1.5, 1.5);
            chart1.ChartAreas[0].CursorX.IsUserEnabled = true;
            chart1.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
            chart1.ChartAreas[0].AxisX.ScaleView.Zoomable = true;


            chart1.ChartAreas[0].CursorY.IsUserEnabled = true;
            chart1.ChartAreas[0].CursorY.IsUserSelectionEnabled = true;
            chart1.ChartAreas[0].AxisY.ScaleView.Zoomable = true;
            //  chart1.ChartAreas[0].AxisX.ScrollBar.IsPositionedInside = true;
            for (double i = -4; i < 10;)
            {
                i += 0.1;

                chart1.Series[0].Points.AddXY(i, Math.Sin(i));
                chart1.Series[1].Points.AddXY(i, Math.Sin(0.5*i));

                chart1.Series[2].Points.AddXY(-3.9, Math.Sin(-3.9));
                chart1.Series[2].Points.AddXY(-3.9, Math.Sin(-3.9*0.5));

                chart1.Series[3].Points.AddXY(1.6, 1);
                chart1.Series[3].Points.AddXY(3.1 , 1);

                chart1.Series[4].Points.AddXY(9.35 , -1);
                chart1.Series[4].Points.AddXY(4.82, -1);
            }
        }

        private void Chart1_Layout(object sender, LayoutEventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

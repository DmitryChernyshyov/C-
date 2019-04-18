using System;
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

        Double[] extrX = new double[4];
        private void Button1_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
            chart1.Series[2].Points.Clear();
            chart1.Series[3].Points.Clear();
            chart1.Series[1].Points.Clear();
            chart1.Series[4].Points.Clear();
            chart1.Series[5].Points.Clear();

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
                        chart1.Series[3].Points.AddXY(3.14, Math.Cos(3.14));
                        chart1.Series[4].Points.AddXY(3.14 * 2, Math.Cos(3.14 * 2));
                        chart1.Series[5].Points.AddXY(-3.14, Math.Cos(-3.14));
                    }

                    break;
                case "sin(x)":
                    for (double i = -4; i < 10;)
                    {
                        i += 0.1;
                        chart1.Series[0].Points.AddXY(i, Math.Sin(i));
                        chart1.Series[2].Points.AddXY(3.14/2, Math.Sin(3.14 / 2));
                        chart1.Series[3].Points.AddXY(3*3.14/2, Math.Sin(3 * 3.14/2 ));
                        chart1.Series[4].Points.AddXY(5 * 3.14 / 2, Math.Sin(5 * 3.14 / 2));
                        chart1.Series[5].Points.AddXY(-3.14/2, Math.Sin(-3.14/2));
                    }
                    break;
                case "tan(x)":
                    for (double i = -4; i < 10;)
                    {
                        i += 0.1;
                        chart1.Series[0].Points.AddXY(i, Math.Tan(i));
                       
                    }
                    break;
                case "ctan(x)":
                    for (double i = -4; i < 10;)
                    {
                        i += 0.1;
                        chart1.Series[0].Points.AddXY(i, -Math.Tan(i));
                       
                    }
                    break;
                case "cos(kx)":
                    for (double i = -4; i < 10;)
                    {
                        i += 0.1;
                        chart1.Series[0].Points.AddXY(i, Math.Cos(i * k));
                       
                    }
                    break;
                case "sin(kx)":

                    for (double i = -4; i < 10;)
                    {
                        i += 0.1;
                        chart1.Series[0].Points.AddXY(i, Math.Sin(i*k));

                    }
                    break;
                case "tan(kx)":
                    for (double i = -4; i < 10;)
                    {
                        i += 0.1;
                        chart1.Series[0].Points.AddXY(i, k*Math.Tan(i * k));

                    }
                    break;
                case "ctan(kx)":
                    for (double i = -4; i < 10;)
                    {
                        i += 0.1;
                        chart1.Series[0].Points.AddXY(i,-k*Math.Tan(i * k));

                    }
                    break;
                case "sin(x)+a":
                    for (double i = -4; i < 10;)
                    {
                        i += 0.1;
                        chart1.Series[0].Points.AddXY(i, Math.Sin(i)+a);

                    }
                    break;
                case "cos(x)+a":
                    for (double i = -4; i < 10;)
                    {
                        i += 0.1;
                        chart1.Series[0].Points.AddXY(i, Math.Cos(i)+a);
  
                    }
                    break;
                case "tan(x)+a":
                    for (double i = -4; i < 10;)
                    {
                        i += 0.1;
                        chart1.Series[0].Points.AddXY(i, Math.Tan(i)+a);

                    }
                    break;
                case "ctan(x)+a":
                    for (double i = -4; i < 10;)
                    {
                        i += 0.1;
                        chart1.Series[0].Points.AddXY(i, -Math.Tan(i) + a);

                    }
                    break;
                case "sin(x+a)":
                    for (double i = -4; i < 10;)
                    {
                        i += 0.1;
                        chart1.Series[0].Points.AddXY(i, Math.Sin(i + a) );

                    }
                    break;
                case "cos(x+a)":
                    for (double i = -4; i < 10;)
                    {
                        i += 0.1;
                        chart1.Series[0].Points.AddXY(i, Math.Cos(i + a) );

                    }
                    break;
                case "tan(+ax)":
                    for (double i = -4; i < 10;)
                    {
                        i += 0.1;
                        chart1.Series[0].Points.AddXY(i, Math.Tan(i + a));

                    }
                    break;
                case "ctan(x+a)":
                    for (double i = -4; i < 10;)
                    {
                        i += 0.1;
                        chart1.Series[0].Points.AddXY(i, -Math.Tan(i + a)) ;

                    }
                    break;
                case "cos(|x|)":
                    for (double i = -4; i < 10;)
                    {
                        i += 0.1;
                        chart1.Series[0].Points.AddXY(i, Math.Abs(Math.Cos(i)));

                    }
                    break;
                case "sin(|x|)":
                    for (double i = -4; i < 10;)
                    {
                        i += 0.1;
                        chart1.Series[0].Points.AddXY(i, Math.Abs(Math.Sin(i)));
                      
                    }
                    break;
                case "tan(|x|)":
                    for (double i = -4; i < 10;)
                    {
                        i += 0.1;
                        chart1.Series[0].Points.AddXY(i, Math.Abs(Math.Tan(i)));
                    }
                    break;
                case "ctan(|x|)":
                    for (double i = -4; i < 10;)
                    {
                        i += 0.1;
                        chart1.Series[0].Points.AddXY(i, -Math.Abs(Math.Tan(i)));

                    }
                    break;
                default:
                    
                    break;
            }


            k2 = Convert.ToDouble(textBox2.Text);
            a2 = Convert.ToDouble(textBox4.Text);

           
            
        }

        double N = -4.1;


        private void Timer1_Tick(object sender, EventArgs e)
        {

            N += 0.1;   
            switch (comboBox2.Text)
            {
                case "cos(x+a)":
                    chart1.Series[1].Points.AddXY(N, Math.Cos(N+a2));

                    break;
                case "sin(x+a)":
                    chart1.Series[1].Points.AddXY(N, Math.Sin(N+a2));


                    break;
                case "tan(x+a)":
                    chart1.Series[1].Points.AddXY(N, Math.Tan(N + a2));

                    break;
                case "Ctan(x+a)":
                    chart1.Series[1].Points.AddXY(N, -Math.Tan(N + a2));

                    break;


                case "cos(x)":
                        chart1.Series[1].Points.AddXY(N, Math.Cos(N));

                    break;
                case "sin(x)":
                    chart1.Series[1].Points.AddXY(N, Math.Sin(N));


                    break;
                case "tan(x)":
                    chart1.Series[1].Points.AddXY(N, Math.Tan(N));

                    break;
                case "Ctan(x)":
                    chart1.Series[1].Points.AddXY(N, -Math.Tan(N));
                    
                    break;
                case "cos(kx)":
                    chart1.Series[1].Points.AddXY(N, Math.Cos(k2*N));

                   
                    break;  
                case "sin(kx)":

                    chart1.Series[1].Points.AddXY(N, Math.Sin(k2*N));
                    
                    break;
                case "tan(kx)":

                    chart1.Series[1].Points.AddXY(N, Math.Tan(N*k2));
                   

                    break;
                case "ctan(kx)":

                    chart1.Series[1].Points.AddXY(N, -Math.Tan(N*k2));
                   

                    break;
                case "sin(x)+a":
                    chart1.Series[1].Points.AddXY(N, Math.Sin(N)+a2);

                    break;
                case "cos(x)+a":
                    chart1.Series[1].Points.AddXY(N, Math.Cos(N)+a2);


                    break;
                case "tan(x)+a":

                    chart1.Series[1].Points.AddXY(N, Math.Tan(N)+a2);

                    break;
                case "ctan(x)+a":

                    chart1.Series[1].Points.AddXY(N, -Math.Tan(N)+a2);


                    break;
                case "cos(|x|)":

                    chart1.Series[1].Points.AddXY(N, Math.Abs(Math.Cos(N)));

                    break;
                case "sin(|x|)":

                    chart1.Series[1].Points.AddXY(N, Math.Abs(Math.Sin(N)));
                    break;
                case "tan(|x|)":

                    chart1.Series[1].Points.AddXY(N, Math.Abs(Math.Tan(N)));
                    break;
                case "ctan(|x|)":

                    chart1.Series[1].Points.AddXY(N, -Math.Abs(Math.Tan(N)));
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
            chart1.Series[5].Points.Clear();
            chart1.ChartAreas[0].AxisY.ScaleView.Zoom(-3, 5);
            chart1.ChartAreas[0].CursorX.IsUserEnabled = true;
            chart1.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
            chart1.ChartAreas[0].AxisX.ScaleView.Zoomable = true;

            chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            chart1.ChartAreas[0].AxisX.Crossing = 0;
            chart1.ChartAreas[0].AxisY.Crossing = 0;

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
       
        private void Timer2_Tick(object sender, EventArgs e)
        {
            if (N < 0)
            {
                N = 0;
            }
            N += 0.1;
            switch (comboBox2.Text)
            {
                case "cos(x)":

                    break;
                case "sin(x)":
                    chart1.Series[2].Points.AddXY(N, Math.Sin(N));


                    break;
                case "tan(x)":
                    chart1.Series[2].Points.AddXY(N, Math.Tan(N));

                    break;
                case "Ctan(x)":
                    chart1.Series[2].Points.AddXY(N, -Math.Tan(N));

                    break;
                case "cos(kx)":

               

                    break;
                case "sin(kx)":
                   
                    if ((N >= 0) & (N <= k2))
                    {
                        chart1.Series[2].Points.AddXY(3.14 / 2 - N, Math.Sin(3.14 / 2) );
                        chart1.Series[3].Points.AddXY(3 * 3.14 / 2 - N, Math.Sin(3 * 3.14 / 2));
                        chart1.Series[4].Points.AddXY(5 * 3.14 / 2 - N, Math.Sin(5 * 3.14 / 2));
                        chart1.Series[5].Points.AddXY(-3.14 / 2 - N, Math.Sin(-3.14 / 2) );
                    }


                    break;
                case "tan(kx)":

                    chart1.Series[2].Points.AddXY(N, Math.Tan(N * k2));


                    break;
                case "ctan(kx)":

                    chart1.Series[2].Points.AddXY(N, -Math.Tan(N * k2));


                    break;
                case "sin(x)+a":
                    if ((N >= 0) & (N <= a2))
                    {
                        chart1.Series[2].Points.AddXY(3.14 / 2, Math.Sin(3.14 / 2) + N);
                        chart1.Series[3].Points.AddXY(3 * 3.14 / 2, Math.Sin(3 * 3.14 / 2) + N);
                        chart1.Series[4].Points.AddXY(5 * 3.14 / 2, Math.Sin(5 * 3.14 / 2) + N);
                        chart1.Series[5].Points.AddXY(-3.14/2, Math.Sin(-3.14/2) + N);
                    }

                    break;
                case "cos(x)+a":
                    if ((N >= 0) & (N <= a2))
                    {
                        chart1.Series[2].Points.AddXY(0, Math.Cos(0) + N);
                        chart1.Series[3].Points.AddXY(3.14, Math.Cos(3.14) + N);
                        chart1.Series[4].Points.AddXY(3.14 * 2, Math.Cos(3.14 * 2) + N);
                        chart1.Series[5].Points.AddXY(-3.14, Math.Cos(-3.14) + N);

                    }


                    break;
                case "tan(x)+a":

                    chart1.Series[2].Points.AddXY(N, Math.Tan(N) + a2);

                    break;
                case "ctan(x)+a":

                    chart1.Series[2].Points.AddXY(N, -Math.Tan(N) + a2);

                    break;
                case "cos(|x|)":
                    a2 = 2;
                    if ((N >= 0) & (N <= 2))
                    {
                        chart1.Series[2].Points.AddXY(0, Math.Abs(Math.Cos(0)));              
                        chart1.Series[4].Points.AddXY(3.14 * 2, Math.Abs(Math.Cos(3.14 * 2)));
                        chart1.Series[3].Points.AddXY(3.14, -1 + N);
                        chart1.Series[5].Points.AddXY(-3.14, -1 + N);
                    }


                    break;
                case "sin(|x|)":
                    a2 = 2;
                    if ((N >= 0) & (N <= 2))
                    {
                        chart1.Series[2].Points.AddXY(3.14 / 2, Math.Abs(Math.Sin(3.14 / 2)));
                        chart1.Series[3].Points.AddXY(3 * 3.14 / 2, -1 + N);
                        chart1.Series[4].Points.AddXY(5 * 3.14 / 2, Math.Abs(Math.Sin(5 * 3.14 / 2)));
                        chart1.Series[5].Points.AddXY(-3.14 / 2,-1 + N);
                    }
                    break;
                case "tan(|x|)":

                    chart1.Series[2].Points.AddXY(N, Math.Abs(Math.Tan(N)));
                    break;
                case "ctan(|x|)":

                    chart1.Series[2].Points.AddXY(N, -Math.Abs(Math.Tan(N)));
                    break;
                case "cos(x+a)":
                    if ((N >= 0) & (N <= a2))
                    {
                        chart1.Series[2].Points.AddXY(0 - N, 1);
                        chart1.Series[3].Points.AddXY(3.14 -N, -1);
                        chart1.Series[4].Points.AddXY(3.14*2-N ,1);
                        chart1.Series[5].Points.AddXY(-3.14 -N ,-1);
                    }
                    break;
                case "sin(x+a)":
                    if ((N >= 0) & (N <= a2))
                    {
                        chart1.Series[2].Points.AddXY(3.14 / 2-N, Math.Sin(3.14 / 2));
                        chart1.Series[3].Points.AddXY(3 * 3.14 / 2-N, Math.Sin(3 * 3.14 / 2));
                        chart1.Series[4].Points.AddXY(5 * 3.14 / 2-N, Math.Sin(5 * 3.14 / 2));
                        chart1.Series[5].Points.AddXY(-3.14 / 2-N, Math.Sin(-3.14 / 2));
                    }


                    break;
                case "tan(x+a)":
                    chart1.Series[1].Points.AddXY(N, Math.Tan(N + a2));

                    break;
                case "Ctan(x+a)":
                    chart1.Series[1].Points.AddXY(N, -Math.Tan(N + a2));

                    break;

                default:

                    break;
            }
            
            if (N >= a2)
            {
                timer1.Enabled = true;
                timer2.Enabled = false;
                N = -4.1;

            }

        }

        private void Button2_Click(object sender, EventArgs e)
        {

            timer2.Enabled = true;
        }

        private void MenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Удалить_Click(object sender, EventArgs e)
        {

        }

        private void ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
            chart1.Series[2].Points.Clear();
            chart1.Series[3].Points.Clear();
            chart1.Series[1].Points.Clear();
            chart1.Series[4].Points.Clear();
            chart1.Series[5].Points.Clear();
        }

        private void Удалить1ГрафикToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
        }

        private void Удалить2ГрафикToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chart1.Series[1].Points.Clear();
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

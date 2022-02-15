using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Configuration;
using System.Windows.Forms.DataVisualization.Charting;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimMod_1
{
    public partial class Form1 : Form
    {
        const decimal g = 9.81M;
        const decimal C = 0.15M;
        const decimal rho = 1.29M;


        decimal t, x, y, v0, cosa, sina, S, m, k, vx, vy;
        decimal dt = 0.01M;
        decimal maxHeight, distanceTravelled, speedAtEndPoint;

        Series curSeries;
        int seriesCount = 0;

        public Form1()
        {
            InitializeComponent();
            chart1.ChartAreas[0].AxisX.Minimum = 0;
            chart1.ChartAreas[0].AxisY.Minimum = 0;
            chart1.Series[0].Points.Clear();

            inputTimeStep.Value = 0.01M;
            inputTimeStep.Increment = 0.001M;

            calculatedDataGrid.Columns[0].Name = "Time step";
            calculatedDataGrid.Columns[1].Name = "Distance";
            calculatedDataGrid.Columns[2].Name = "Max height";
            calculatedDataGrid.Columns[3].Name = "Speed at the end point";
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            if (!timer1.Enabled)
            {
                curSeries = new Series();
                curSeries.ChartType = SeriesChartType.Line;
                curSeries.BorderWidth = 3;
                seriesCount++;
                chart1.Series.Add(curSeries);

                maxHeight = 0;
                distanceTravelled = 0;
                speedAtEndPoint = 0;

                t = 0;
                dt = inputTimeStep.Value;
                x = 0;
                y = inputHeight.Value;
                v0 = inputVelocity.Value;
                double a = (double)inputAngle.Value * Math.PI / 180;
                cosa = (decimal)Math.Cos(a);
                sina = (decimal)Math.Sin(a);
                S = inputSize.Value;
                m = inputWeight.Value;
                k = 0.5M * C * rho * S / m;
                vx = v0 * cosa;
                vy = v0 * sina;

                chart1.Series[seriesCount - 1].Points.AddXY(x, y);

                timer1.Start();
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            decimal v = (decimal)Math.Sqrt((double)(vx * vx + vy * vy));
            if (y >= maxHeight)
            {
                maxHeight = y;
            }
            speedAtEndPoint = v;
            distanceTravelled = x;
            t += dt;
            vx = vx - k * vx * v * dt;
            vy = vy - (g + k * vy * v) * dt;
            x = x + vx * dt;
            y = y + vy * dt;
            chart1.Series[seriesCount - 1].Points.AddXY(x, y);
            if (y <= 0)
            {
                timer1.Stop();
                AddDataToTable(dt, maxHeight, distanceTravelled, speedAtEndPoint);
            }

        }

        private void AddDataToTable(decimal timeStep, decimal distance, decimal height, decimal speed)
        {
            string[] newRow = { timeStep.ToString(), distance.ToString(), height.ToString(), speed.ToString() };
            calculatedDataGrid.Rows.Add(newRow);
        }
    }
}

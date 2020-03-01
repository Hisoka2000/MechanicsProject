using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing;

namespace ProjectMechanics
{

    public partial class Entry : Form
    {
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;

        public Entry()
        {
            InitializeComponent();
            ChartLoad();
        }

        void ChartLoad()
        {
            float speed;
            float positiveAcc;
            float negativeAcc;
            float distanceToIntersection;
            float width;
            float duration;
            bool shouldStop;

            Car car = new Car();
            Intersection intersection = new Intersection();

            Console.Write("Input the cars speed in km/h: ");
            speed = float.Parse(Console.ReadLine());
            car.Speed = speed;
            Console.Write("Input the cars constant positive acceleration in m/s^2: ");
            positiveAcc = float.Parse(Console.ReadLine());
            car.PositiveAcc = positiveAcc;
            Console.Write("Input the cars constant negative acceleration in m/s^2: ");
            negativeAcc = float.Parse(Console.ReadLine());
            car.NegativeAcc = negativeAcc;
            Console.Write("Input the cars distance to the intersection in meters: ");
            distanceToIntersection = float.Parse(Console.ReadLine());
            car.DistanceToIntersection = distanceToIntersection;

            Console.Write("Input the width of the intersection in meters: ");
            width = float.Parse(Console.ReadLine());
            intersection.Width = width;
            Console.Write("Input the duration of the yellow light in seconds: ");
            duration = float.Parse(Console.ReadLine());
            intersection.Duration = duration;

            if (car.shouldCarStop(intersection.Width, intersection.Duration))
            {
                Console.WriteLine("The car should start decelerating to stop");
                shouldStop = true;
            }
            else
            {
                Console.WriteLine("The car should accelerate to pass the intersection");
                shouldStop = false;
            }


            var dtChart = chart1.ChartAreas[0];
            var sdChart = chart2.ChartAreas[0];

            dtChart.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            dtChart.AxisX.LabelStyle.Format = "";
            dtChart.AxisY.LabelStyle.Format = "";
            dtChart.AxisX.LabelStyle.IsEndLabelVisible = true;

            dtChart.AxisX.Minimum = 0;
            dtChart.AxisY.Minimum = 0;

            dtChart.AxisX.Name = "Time";
            dtChart.AxisY.Name = "Distance";

            sdChart.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            sdChart.AxisX.LabelStyle.Format = "";
            sdChart.AxisY.LabelStyle.Format = "";
            sdChart.AxisX.LabelStyle.IsEndLabelVisible = true;

            sdChart.AxisX.Minimum = 0;
            sdChart.AxisY.Minimum = 0;

            sdChart.AxisX.Name = "Speed";
            sdChart.AxisY.Name = "Distance";

            chart1.Series[0].IsVisibleInLegend = false;
            chart2.Series[0].IsVisibleInLegend = false;

            chart1.Series.Add("Distance-Time");
            chart1.Series["Distance-Time"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chart1.Series["Distance-Time"].Color = Color.Green;

            chart2.Series.Add("Speed-Distance");
            chart2.Series["Speed-Distance"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chart2.Series["Speed-Distance"].Color = Color.Blue;

            for (float i = 0; i <= duration; i = (float)(i + 0.1))
            {
                if (shouldStop)
                {
                    chart1.Series["Distance-Time"].Points.AddXY(i, car.positiveDistance(i, -negativeAcc));
                    chart2.Series["Speed-Distance"].Points.AddXY(car.currentSpeed(speed, i, -negativeAcc), car.positiveDistance(i, -negativeAcc));
                }
                else
                {
                    chart1.Series["Distance-Time"].Points.AddXY(i, car.positiveDistance(i, positiveAcc));
                    chart2.Series["Speed-Distance"].Points.AddXY(car.currentSpeed(speed, i, positiveAcc), car.positiveDistance(i, positiveAcc));
                }
            }
        }
        public static void Main(string[] args)
        {
            displayGraph();

            #if DEBUG
                Console.WriteLine("Press enter to close...");
                Console.ReadLine();
            #endif
        }

        public static void displayGraph()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Entry());
        }
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(44, 12);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(411, 431);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // chart2
            // 
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(470, 12);
            this.chart2.Name = "chart2";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart2.Series.Add(series2);
            this.chart2.Size = new System.Drawing.Size(446, 431);
            this.chart2.TabIndex = 1;
            this.chart2.Text = "chart2";
            // 
            // Entry
            // 
            this.ClientSize = new System.Drawing.Size(937, 474);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.chart1);
            this.Name = "Entry";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);

        }
    }
}

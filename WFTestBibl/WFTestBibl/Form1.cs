using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MathNet.Numerics.LinearAlgebra;


namespace MasterThesisApp
{
    public partial class Form1 : Form
    {
        public ClrLib.Obl obl;

        public Mgr.MA ma;
        public Mgr.MED med;
        public Mgr.SG sg;
        public Mgr.KF kf;

        public Form1()
        {
            InitializeComponent();

            obl = new ClrLib.Obl();
            ma = new Mgr.MA();
            med = new Mgr.MED();
            sg = new Mgr.SG();
            kf = new Mgr.KF();

            chart1.Legends.Clear();
            chart1.Series.Clear();
        }

        public static string filePath;
        public static string Axis;
        public static int frame;
        public static int l;
        public static string chartNameRaw = "Raw data";
        public static string chartNameFiltered = "Filtered data";
        public static List<double> Actual = new List<double>();

        private void Open_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Title = "Browse Text Files";
            open.InitialDirectory = @"C:\";
            open.DefaultExt = "txt";
            open.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

            if (open.ShowDialog() == DialogResult.OK)
            {
                StreamReader reader = new StreamReader(File.OpenRead(open.FileName));

                textBox1.Text = reader.ReadToEnd();
                reader.Dispose();
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Title = "Save Text Files";
            save.InitialDirectory = @"C:\Users\ola\source\repos\Data\";
            save.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            if (save.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                StreamWriter writer = new StreamWriter(File.Create(save.FileName));
                filePath = Path.GetFullPath(save.FileName);
                writer.Write(textBox1.Text);
                writer.Dispose();
            }
            textBox1.ResetText();
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            textBox1.ResetText();
        }

        private void ConvertStringToList(List<double> L)
        {
            if (filePath.Length > 0)
            {
                string allData = File.ReadAllText(filePath);
                string[] stringSplit = allData.Split(' ', '=', '\n');
                double[] doubleSplit = new double[stringSplit.Length];

                for (int i = 0; i < stringSplit.Length; i++)
                {
                    doubleSplit[i] = Double.Parse(stringSplit[i]);
                    L.Add(doubleSplit[i]);
                }

                Actual.Clear();
                L.TrimExcess();
                FrameSize();
                WhichAxis(out int l);

                for (int j = 0, k = 0; j < L.Count / 3; j++)
                {
                    Actual.Add(L[k + l]);
                    k += 3;
                }
            }
        }

        private void Graph(string chartName, List<double> L)
        {
            chart1.Legends.Clear();
            chart1.Series.Clear();
            chart1.Titles.Clear();
            chart1.ChartAreas.Clear();

            chart1.Series.Add(chartNameFiltered);
            chart1.Series[chartNameFiltered].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chart1.Series[chartNameFiltered].BorderWidth = 8;

            chart1.Series.Add(chartNameRaw);
            chart1.Series[chartNameRaw].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chart1.Series[chartNameRaw].BorderWidth = 4;

            chart1.Titles.Add(new System.Windows.Forms.DataVisualization.Charting.Title(chartName + " Axis: " + Axis + " Window frame = " + frame));
            chart1.ChartAreas.Add(new System.Windows.Forms.DataVisualization.Charting.ChartArea("chartArea"));
            chart1.ChartAreas["chartArea"].AxisX.Title = "Probe number [-]";
            chart1.ChartAreas["chartArea"].AxisY.Title = "Amplitude [-]";
            chart1.ChartAreas["chartArea"].AxisX.Minimum = 0;
            chart1.ChartAreas["chartArea"].AxisX.Maximum = L.Count - 1;
            chart1.ChartAreas["chartArea"].AxisY.Minimum = Actual.Min();
            chart1.ChartAreas["chartArea"].AxisY.Maximum = Actual.Max();
            chart1.ChartAreas["chartArea"].AxisX.Interval = 1;
            chart1.ChartAreas["chartArea"].AxisY.Interval = 50;

            chart1.Legends.Add(new System.Windows.Forms.DataVisualization.Charting.Legend("Legend"));
            chart1.Series[chartNameFiltered].Legend = "Legend";
            chart1.Series[chartNameRaw].Legend = "Legend";

            for (int i = 0; i < L.Count; i++)
            {
                chart1.Series[chartNameRaw].Points.AddXY(i, Actual[i]);
                chart1.Series[chartNameFiltered].Points.AddXY(i, L[i]);
                chart1.ChartAreas["chartArea"].RecalculateAxesScale();
            }
        }

        private string EL(List<double> L)
        {
            string s = "";
            foreach (var i in L)
            {
                string t = i.ToString();
                s += (t + " ");
            }
            return s;
        }

        void graphAdjustment(List<double> L)
        {
            var L5 = new List<double>(frame);
            for (int i = 0; i < frame; i++)
            {
                L5.Add(Actual[i]);
            }
            L.InsertRange(0, L5);
            L.RemoveRange(Actual.Count, frame);
        }

        private void WhichAxis(out int l)
        {
            if (xButton.Checked)
            {
                l = 0;
                Axis = "X";
            }
            else if (yButton.Checked)
            {
                l = 1;
                Axis = "Y";
            }
            else if (zButton.Checked)
            {
                l = 2;
                Axis = "Z";
            }
            else
            {
                Application.ExitThread();
                l = -1;
            }
        }

        private void FrameSize()
        {
            if (fiveButton.Checked)
            {
                frame = 5;
            }
            else if (sevenButton.Checked)
            {
                frame = 7;
            }
            else if (nineButton.Checked)
            {
                frame = 9;
            }
            else
            {
                Application.ExitThread();
                frame = -1;
            }
        }

        private void MovAv_Click(object sender, EventArgs e)
        {
            var L = new List<double>();
            ConvertStringToList(L);
           
            
            var L1 = new List<double>(Actual);
            textBox1.Text += "\r\n" + "Moving Average filter" + "\r\n";
            ma.MovingAverage(L1, L1.Count, frame);

            textBox1.Text += EL(L1) + "\r\n";
            textBox1.Text += "\r\n";

            graphAdjustment(L1);
            
            Graph("Moving Average filtering", L1);
        }

        private void MedF_Click(object sender, EventArgs e)
        {
            var L = new List<double>();
            ConvertStringToList(L);

            var L1 = new List<double>(Actual);
            textBox1.Text += "\r\n" + "Median filter" + "\r\n";
            med.Median(L1, L1.Count, frame);

            textBox1.Text += EL(L1) + "\r\n";
            textBox1.Text += "\r\n";

            graphAdjustment(L1);

            Graph("Median filtering", L1);
        }

        private void SavGol_Click(object sender, EventArgs e)
        {
            var L = new List<double>();
            ConvertStringToList(L);

            var L1 = new List<double>(Actual);
            textBox1.Text += "\r\n" + "Savitzky-Golay filter" + "\r\n";
            sg.Savitzky(L1, L1.Count, frame);
            
            textBox1.Text += EL(L1) + "\r\n";
            textBox1.Text += "\r\n";

            graphAdjustment(L1);

            Graph("Savitzky-Golay", L1);
        }

        private void Kal_Click(object sender, EventArgs e)
        {
            var L = new List<double>();
            ConvertStringToList(L);

            var L1 = new List<double>(Actual);
            textBox1.Text += "\r\n" + "Kalman filter" + "\r\n";
            kf.Kalman(L1, L1.Count, frame);

            textBox1.Text += EL(L1) + "\r\n";
            textBox1.Text += "\r\n";

            Graph("Kalman filtering", L1);
        }  
    }
}

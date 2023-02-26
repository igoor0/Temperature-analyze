using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Windows.Forms.DataVisualization.Charting;

namespace ProjektPP
{
    public partial class Wykres : Form
    {
        public static Legend legend;
        public static Series s1, s2;
        List<double> probki = new List<double>();
        public static string tytul;
        public static ChartArea chartArea;
        public Wykres(List<double> data, string text)
        {
            InitializeComponent();
            tytul = text;
            probki = data;
            panel_left.Height = Seria.Height;
            panel_left.Top = Seria.Top;

            chart1.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
            chart1.ChartAreas[0].AxisY.ScaleView.Zoomable = true;
            
        }    
        private void Wykres_Load(object sender, EventArgs e)
        {
            legend = chart1.Legends["Legend1"];
            s1 = chart1.Series["Odczyt Temperatur"];
            s2 = chart1.Series["Różnica Temperatur"];
            Title mainTitle = chart1.Titles["Wykres Pomiarów"];
            mainTitle.Text = tytul;
            chartArea = chart1.ChartAreas["ChartArea1"];
            for (int x = 0; x < probki.Count; x++)
                s1.Points.AddXY(x + 1, probki[x]);
            for (int x2 = 1; x2 < probki.Count; x2++)
                s2.Points.AddXY(x2, probki[x2] - probki[x2 - 1]);
        }
                                            //---Po kliknieciu---//
        private void Legenda_CheckedChanged(object sender, EventArgs e)
        {
            if (Legenda.Checked == true)
            {
                chart1.Legends["Legend1"].Enabled = true;
                //s1.Enabled
            }
            else
            {
                chart1.Legends["Legend1"].Enabled = false;
            }
        }
        private void Seria_CheckedChanged(object sender, EventArgs e)
        {
            if (Seria.Checked == true)
            {
                chart1.Series["Odczyt Temperatur"].Enabled = true;              
            }
            else
            {
                chart1.Series["Odczyt Temperatur"].Enabled = false;               
            }
        }
        private void Seria2_CheckedChanged(object sender, EventArgs e)
        {
            if (Seria2.Checked == true)
            {               
                chart1.Series["Różnica Temperatur"].Enabled = true;
            }
            else
            {    
                chart1.Series["Różnica Temperatur"].Enabled = false;
            }
        }
        private void WykresCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (WykresCheck.Checked == true)
            {
                s1.ChartType = SeriesChartType.Column; 
            }
            else
            {
                s1.ChartType = SeriesChartType.Spline;  
            }
        }
        private void Siatka_CheckedChanged(object sender, EventArgs e)
        {
            if (Siatka.Checked == true)
            {
                chartArea.AxisX.MinorGrid.Enabled = true;
                chartArea.AxisY.MinorGrid.Enabled = true;
            }
            else
            {
                chartArea.AxisX.MinorGrid.Enabled = false;
                chartArea.AxisY.MinorGrid.Enabled = false;
            }
        }
        private void kolorSerii_CheckedChanged(object sender, EventArgs e)
        {
            if (kolorSerii.Checked == true)
            {
                s1.Color = Color.Red;
            }
            else
            {
                s1.Color = Color.Black;
            }
        }
        private void kolorTemperatury_CheckedChanged(object sender, EventArgs e)
        {
            if (kolorTemperatury.Checked == true)
            {
                s2.Color = Color.Black;
            }
            else
            {
                s2.Color = Color.Red;
            }
        }
        private void WykresRoznicaCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (WykresRoznicaCheck.Checked == true)
            {
                s2.ChartType = SeriesChartType.Column;
            }
            else
            {
                s2.ChartType = SeriesChartType.Spline;
            }
        }
                            //---Po najechaniu---//
        private void Legenda_MouseMove(object sender, MouseEventArgs e)
        {
            panel_left.Height = Legenda.Height;
            panel_left.Top = Legenda.Top;
        }
        private void Seria_MouseMove(object sender, MouseEventArgs e)
        {
            panel_left.Height = Seria.Height;
            panel_left.Top = Seria.Top;
        }
        private void Siatka_MouseMove(object sender, MouseEventArgs e)
        {
            panel_left.Height = Siatka.Height;
            panel_left.Top = Siatka.Top;
        }
        private void WykresCheck_MouseMove(object sender, MouseEventArgs e)
        {
            panel_left.Height = WykresCheck.Height;
            panel_left.Top = WykresCheck.Top;
        }
        private void kolorSerii_MouseMove(object sender, MouseEventArgs e)
        {
            panel_left.Height = kolorSerii.Height;
            panel_left.Top = kolorSerii.Top;
        }
        private void Seria2_MouseMove(object sender, MouseEventArgs e)
        {
            panel_left.Height = Seria2.Height;
            panel_left.Top = Seria2.Top;
        }
        private void WykresRoznicaCheck_MouseMove(object sender, MouseEventArgs e)
        {
            panel_left.Height = WykresRoznicaCheck.Height;
            panel_left.Top = WykresRoznicaCheck.Top;
        }
        private void kolorTemperatury_MouseMove(object sender, MouseEventArgs e)
        {
            panel_left.Height = kolorTemperatury.Height;
            panel_left.Top = kolorTemperatury.Top;
        }
        private void chart1_MouseWheel(object sender, MouseEventArgs e)
        {
            var chart = (Chart)sender;
            var xAxis = chart.ChartAreas[0].AxisX;
            var yAxis = chart.ChartAreas[0].AxisY;

            try
            {
                if (e.Delta < 0) // Scrolled down.
                {
                    xAxis.ScaleView.ZoomReset();
                    yAxis.ScaleView.ZoomReset();
                }
                else if (e.Delta > 0) // Scrolled up.
                {
                    var xMin = xAxis.ScaleView.ViewMinimum;
                    var xMax = xAxis.ScaleView.ViewMaximum;
                    var yMin = yAxis.ScaleView.ViewMinimum;
                    var yMax = yAxis.ScaleView.ViewMaximum;

                    var posXStart = xAxis.PixelPositionToValue(e.Location.X) - (xMax - xMin) / 4;
                    var posXFinish = xAxis.PixelPositionToValue(e.Location.X) + (xMax - xMin) / 4;
                    var posYStart = yAxis.PixelPositionToValue(e.Location.Y) - (yMax - yMin) / 4;
                    var posYFinish = yAxis.PixelPositionToValue(e.Location.Y) + (yMax - yMin) / 4;

                    xAxis.ScaleView.Zoom(posXStart, posXFinish);
                    yAxis.ScaleView.Zoom(posYStart, posYFinish);
                }
            }
            catch { }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.Database;
using System.Windows.Forms.DataVisualization.Charting;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;


namespace WpfApp1.Statistics
{

    class Stats
    { 
        enum warriant { win = 1, lose, draw, unfair };
    
        DataToApp controller;
        public Stats()
        {
            controller = DataToApp.Instance;
        }


        public void MakeStatistics()
        {
            Document doc = new Document() ;
            PdfWriter.GetInstance(doc, new FileStream("stats.pdf", FileMode.OpenOrCreate));
            doc = GetChart((int)warriant.win,doc);
            doc = GetChart((int)warriant.lose,doc);
            doc = GetChart((int)warriant.draw,doc);
            doc = GetChart((int)warriant.unfair,doc);
            doc.Close();
        }

        private Document MakeSpecificChart(string title,  List<int> datalist, bool type, Document doc)
        {

            doc.Open();
           
            
            string path = "charts/";
            Chart chart = new Chart();
            chart.Titles.Add("Title1");
            chart.Titles["Title1"].Text = title;
            ChartArea chartArea = new ChartArea();
            Axis yAxis = new Axis(chartArea, AxisName.Y);
           if(!type)
            chartArea.AxisY.Title = "średni ból";
           else
                chartArea.AxisY.Title = "średnia przyejmność";
            chart.Palette = ChartColorPalette.SeaGreen;
            Legend legend = new Legend(); ;
            Series series = chart.Series.Add("Mężczyzna vs Mężczyzna");
            series.ChartType = SeriesChartType.Column;
            series.Points.Add(datalist[0]);
            Series series1 = chart.Series.Add("Mężczyzna vs Kobieta");
            series1.ChartType = SeriesChartType.Column;
            series1.Points.Add(datalist[1]);
            Series series2 = chart.Series.Add("Kobieta vs Kobieta");
            series2.ChartType = SeriesChartType.Column;
            series2.Points.Add(datalist[2]);
            Series series3 = chart.Series.Add("Kobieta vs Mężczyzna");
            series3.ChartType = SeriesChartType.Column;
            series3.Points.Add(datalist[3]);
            series3.LegendText = "Kobieta vs Mężczyzna";
            chart.Legends.Add(series3.Legend);
            chart.Series[0].LegendText = "Mężczyzna vs Mężczyzna";
            chart.Height = 500;
            chart.Width = 500;
            chart.ChartAreas.Add(chartArea);   
            DateTime data = DateTime.UtcNow.ToLocalTime();
            chart.SaveImage(path + title  + ".png", ChartImageFormat.Png);
            using (MemoryStream memoryStream = new MemoryStream())
            {
                chart.SaveImage(memoryStream, ChartImageFormat.Png);
                iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(memoryStream.GetBuffer());
                img.ScalePercent(100f);
                doc.Add(new Paragraph(title));
                doc.Add(img);
                doc.NewPage();
                return doc;
            }


        }

        private Document GetChart(int warriant,Document doc)
        {
            List<int> infoPain = new List<int>();
            List<int> infoPleasure = new List<int>();
            infoPain.Add (controller.GetAvaragePainMvM(warriant));
            infoPain.Add (controller.GetAvaragePainMvF(warriant));
            infoPain.Add (controller.GetAvaragePainFvF(warriant));
            infoPain.Add (controller.GerAvaragePainFvM(warriant));
            MakeSpecificChart("Średni ból dla wariantu " + warriant, infoPain, false, doc);
            infoPleasure.Add ( controller.GetAvaragePleasureMvM(warriant));
            infoPleasure.Add ( controller.GetAvaragePleasureMvF(warriant));
            infoPleasure.Add ( controller.GetAvaragePleasureFvF(warriant));
           infoPleasure.Add ( controller.GetAvaragePleasureFvM(warriant));
            MakeSpecificChart("Średnia przyjemność dla wariantu " + warriant, infoPleasure, true, doc);
            return doc;
        }
    }
}

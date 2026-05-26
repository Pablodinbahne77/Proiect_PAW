using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Proiect_PAW_Livrari_La_Domiciliu
{
    public partial class FormGrafic : Form
    {
        private AccesBD bd = new AccesBD();

        public FormGrafic()
        {
            InitializeComponent();
            this.Load += FormGrafic_Load;
        }

        private void FormGrafic_Load(object sender, EventArgs e)
        {
            Dictionary<string, int> date = new Dictionary<string, int>();

            try
            {
                date = bd.GetTopProduseVandute();
            }
            catch
            {
                MessageBox.Show("Nu s-a putut conecta la baza de date.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (date.Count == 0)
            {
                MessageBox.Show("Nu exista date de afisat. Adaugati comenzi cu produse.", "Informatii", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            chart.Series.Clear();
            chart.ChartAreas.Clear();
            chart.Titles.Clear();
            chart.Legends.Clear();

            chart.Titles.Add("Top produse vandute (dupa cantitate)");
            chart.Titles[0].Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Bold);

            ChartArea area = new ChartArea("area1");
            area.AxisX.Title = "Produs";
            area.AxisX.TitleFont = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            area.AxisY.Title = "Cantitate totala";
            area.AxisY.TitleFont = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            area.AxisX.LabelStyle.Angle = -30;
            area.AxisY.Interval = 1;
            chart.ChartAreas.Add(area);

            Series serie = new Series("Cantitate");
            serie.ChartType = SeriesChartType.Bar;
            serie.ChartArea = "area1";
            serie.IsValueShownAsLabel = true;
            serie.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            serie.Color = Color.SteelBlue;

            foreach (KeyValuePair<string, int> entry in date)
            {
                serie.Points.AddXY(entry.Key, entry.Value);
            }

            chart.Series.Add(serie);
        }

        private void btnPrinteaza_Click(object sender, EventArgs e)
        {
            PrintDocument doc = new PrintDocument();
            doc.PrintPage += Doc_PrintPage;

            PrintPreviewDialog preview = new PrintPreviewDialog();
            preview.Document = doc;
            preview.Width = 900;
            preview.Height = 650;
            preview.Text = "Previzualizare printare - Top produse vandute";
            preview.ShowDialog();
        }

        private void Doc_PrintPage(object sender, PrintPageEventArgs e)
        {
            Bitmap imagine = new Bitmap(chart.Width, chart.Height);
            chart.DrawToBitmap(imagine, new Rectangle(0, 0, chart.Width, chart.Height));

            string titlu = "Top produse vandute - Livrari La Domiciliu";
            Font fontTitlu = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);

            float latimePagina = e.MarginBounds.Width;
            float inaltimePagina = e.MarginBounds.Height;

            SizeF dimTitlu = e.Graphics.MeasureString(titlu, fontTitlu);
            float xTitlu = e.MarginBounds.Left + (latimePagina - dimTitlu.Width) / 2;
            float yTitlu = e.MarginBounds.Top;

            e.Graphics.DrawString(titlu, fontTitlu, Brushes.Black, xTitlu, yTitlu);

            float yGrafic = yTitlu + dimTitlu.Height + 10;
            float inaltimeGrafic = inaltimePagina - dimTitlu.Height - 10;

            float scalaX = latimePagina / imagine.Width;
            float scalaY = inaltimeGrafic / imagine.Height;
            float scala = Math.Min(scalaX, scalaY);

            float latimeFinala = imagine.Width * scala;
            float inaltimeFinala = imagine.Height * scala;
            float xGrafic = e.MarginBounds.Left + (latimePagina - latimeFinala) / 2;

            e.Graphics.DrawImage(imagine, xGrafic, yGrafic, latimeFinala, inaltimeFinala);

            imagine.Dispose();
            fontTitlu.Dispose();
        }
    }
}

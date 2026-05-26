namespace Proiect_PAW_Livrari_La_Domiciliu
{
    partial class FormGrafic
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnPrinteaza = new System.Windows.Forms.Button();
            this.panelButoane = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.panelButoane.SuspendLayout();
            this.SuspendLayout();

            this.panelButoane.Controls.Add(this.btnPrinteaza);
            this.panelButoane.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelButoane.Height = 45;
            this.panelButoane.Name = "panelButoane";

            this.btnPrinteaza.Text = "Printeaza";
            this.btnPrinteaza.Width = 110;
            this.btnPrinteaza.Height = 30;
            this.btnPrinteaza.Location = new System.Drawing.Point(10, 8);
            this.btnPrinteaza.Name = "btnPrinteaza";
            this.btnPrinteaza.Click += new System.EventHandler(this.btnPrinteaza_Click);

            this.chart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart.Name = "chart";
            this.chart.TabIndex = 0;

            this.Controls.Add(this.chart);
            this.Controls.Add(this.panelButoane);

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 550);
            this.Name = "FormGrafic";
            this.Text = "Grafic - Top produse vandute";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;

            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.panelButoane.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.Button btnPrinteaza;
        private System.Windows.Forms.Panel panelButoane;
    }
}

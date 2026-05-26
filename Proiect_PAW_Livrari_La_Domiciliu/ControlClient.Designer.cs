namespace Proiect_PAW_Livrari_La_Domiciliu
{
    partial class ControlClient
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
            this.lblNumePrenume = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.lblAdresa = new System.Windows.Forms.Label();
            this.SuspendLayout();
            //
            // lblNumePrenume
            //
            this.lblNumePrenume.AutoSize = false;
            this.lblNumePrenume.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblNumePrenume.Location = new System.Drawing.Point(8, 8);
            this.lblNumePrenume.Name = "lblNumePrenume";
            this.lblNumePrenume.Size = new System.Drawing.Size(204, 20);
            this.lblNumePrenume.Text = "";
            //
            // lblEmail
            //
            this.lblEmail.AutoSize = false;
            this.lblEmail.Location = new System.Drawing.Point(8, 34);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(204, 18);
            this.lblEmail.Text = "";
            //
            // lblTelefon
            //
            this.lblTelefon.AutoSize = false;
            this.lblTelefon.Location = new System.Drawing.Point(8, 56);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(204, 18);
            this.lblTelefon.Text = "";
            //
            // lblAdresa
            //
            this.lblAdresa.AutoSize = false;
            this.lblAdresa.Location = new System.Drawing.Point(8, 78);
            this.lblAdresa.Name = "lblAdresa";
            this.lblAdresa.Size = new System.Drawing.Size(204, 18);
            this.lblAdresa.Text = "";
            //
            // ControlClient
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lblAdresa);
            this.Controls.Add(this.lblTelefon);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblNumePrenume);
            this.Name = "ControlClient";
            this.Size = new System.Drawing.Size(220, 104);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label lblNumePrenume;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.Label lblAdresa;
    }
}

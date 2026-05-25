namespace Proiect_PAW_Livrari_La_Domiciliu
{
    partial class FormClienti
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelDateClient = new System.Windows.Forms.Label();
            this.labelNume = new System.Windows.Forms.Label();
            this.tbNume = new System.Windows.Forms.TextBox();
            this.labelPrenume = new System.Windows.Forms.Label();
            this.tbPrenume = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.labelTelefon = new System.Windows.Forms.Label();
            this.tbTelefon = new System.Windows.Forms.TextBox();
            this.labelAdresa = new System.Windows.Forms.Label();
            this.tbAdresa = new System.Windows.Forms.TextBox();
            this.btnSalveaza = new System.Windows.Forms.Button();
            this.btnAnuleaza = new System.Windows.Forms.Button();
            this.labelListaClienti = new System.Windows.Forms.Label();
            this.btnAdauga = new System.Windows.Forms.Button();
            this.btnModifica = new System.Windows.Forms.Button();
            this.btnSterge = new System.Windows.Forms.Button();
            this.dgvClienti = new System.Windows.Forms.DataGridView();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClienti)).BeginInit();
            this.SuspendLayout();
            //
            // labelDateClient
            //
            this.labelDateClient.AutoSize = true;
            this.labelDateClient.Location = new System.Drawing.Point(46, 9);
            this.labelDateClient.Name = "labelDateClient";
            this.labelDateClient.TabIndex = 0;
            this.labelDateClient.Text = "DATE CLIENT";
            //
            // labelNume
            //
            this.labelNume.AutoSize = true;
            this.labelNume.Location = new System.Drawing.Point(46, 36);
            this.labelNume.Name = "labelNume";
            this.labelNume.TabIndex = 1;
            this.labelNume.Text = "&Nume";
            //
            // tbNume
            //
            this.tbNume.Location = new System.Drawing.Point(49, 52);
            this.tbNume.Name = "tbNume";
            this.tbNume.Size = new System.Drawing.Size(262, 20);
            this.tbNume.TabIndex = 2;
            //
            // labelPrenume
            //
            this.labelPrenume.AutoSize = true;
            this.labelPrenume.Location = new System.Drawing.Point(422, 36);
            this.labelPrenume.Name = "labelPrenume";
            this.labelPrenume.TabIndex = 3;
            this.labelPrenume.Text = "&Prenume";
            //
            // tbPrenume
            //
            this.tbPrenume.Location = new System.Drawing.Point(425, 52);
            this.tbPrenume.Name = "tbPrenume";
            this.tbPrenume.Size = new System.Drawing.Size(262, 20);
            this.tbPrenume.TabIndex = 4;
            //
            // labelEmail
            //
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(46, 75);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.TabIndex = 5;
            this.labelEmail.Text = "&Email";
            //
            // tbEmail
            //
            this.tbEmail.Location = new System.Drawing.Point(49, 91);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(262, 20);
            this.tbEmail.TabIndex = 6;
            //
            // labelTelefon
            //
            this.labelTelefon.AutoSize = true;
            this.labelTelefon.Location = new System.Drawing.Point(422, 75);
            this.labelTelefon.Name = "labelTelefon";
            this.labelTelefon.TabIndex = 7;
            this.labelTelefon.Text = "&Telefon";
            //
            // tbTelefon
            //
            this.tbTelefon.Location = new System.Drawing.Point(425, 91);
            this.tbTelefon.Name = "tbTelefon";
            this.tbTelefon.Size = new System.Drawing.Size(262, 20);
            this.tbTelefon.TabIndex = 8;
            //
            // labelAdresa
            //
            this.labelAdresa.AutoSize = true;
            this.labelAdresa.Location = new System.Drawing.Point(46, 114);
            this.labelAdresa.Name = "labelAdresa";
            this.labelAdresa.TabIndex = 9;
            this.labelAdresa.Text = "&Adresa";
            //
            // tbAdresa
            //
            this.tbAdresa.Location = new System.Drawing.Point(49, 130);
            this.tbAdresa.Name = "tbAdresa";
            this.tbAdresa.Size = new System.Drawing.Size(638, 20);
            this.tbAdresa.TabIndex = 10;
            //
            // btnSalveaza
            //
            this.btnSalveaza.Location = new System.Drawing.Point(49, 157);
            this.btnSalveaza.Name = "btnSalveaza";
            this.btnSalveaza.Size = new System.Drawing.Size(94, 31);
            this.btnSalveaza.TabIndex = 11;
            this.btnSalveaza.Text = "&Salveaza";
            this.btnSalveaza.UseVisualStyleBackColor = true;
            //
            // btnAnuleaza
            //
            this.btnAnuleaza.Location = new System.Drawing.Point(149, 157);
            this.btnAnuleaza.Name = "btnAnuleaza";
            this.btnAnuleaza.Size = new System.Drawing.Size(94, 31);
            this.btnAnuleaza.TabIndex = 12;
            this.btnAnuleaza.Text = "An&uleaza";
            this.btnAnuleaza.UseVisualStyleBackColor = true;
            //
            // labelListaClienti
            //
            this.labelListaClienti.AutoSize = true;
            this.labelListaClienti.Location = new System.Drawing.Point(46, 268);
            this.labelListaClienti.Name = "labelListaClienti";
            this.labelListaClienti.TabIndex = 13;
            this.labelListaClienti.Text = "LISTA CLIENTI";
            //
            // btnAdauga
            //
            this.btnAdauga.Location = new System.Drawing.Point(390, 259);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(94, 31);
            this.btnAdauga.TabIndex = 14;
            this.btnAdauga.Text = "A&dauga";
            this.btnAdauga.UseVisualStyleBackColor = true;
            //
            // btnModifica
            //
            this.btnModifica.Location = new System.Drawing.Point(493, 259);
            this.btnModifica.Name = "btnModifica";
            this.btnModifica.Size = new System.Drawing.Size(94, 31);
            this.btnModifica.TabIndex = 15;
            this.btnModifica.Text = "&Modifica";
            this.btnModifica.UseVisualStyleBackColor = true;
            //
            // btnSterge
            //
            this.btnSterge.Location = new System.Drawing.Point(593, 259);
            this.btnSterge.Name = "btnSterge";
            this.btnSterge.Size = new System.Drawing.Size(94, 31);
            this.btnSterge.TabIndex = 16;
            this.btnSterge.Text = "Ste&rge";
            this.btnSterge.UseVisualStyleBackColor = true;
            //
            // dgvClienti
            //
            this.dgvClienti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClienti.Location = new System.Drawing.Point(49, 293);
            this.dgvClienti.Name = "dgvClienti";
            this.dgvClienti.Size = new System.Drawing.Size(638, 145);
            this.dgvClienti.TabIndex = 17;
            //
            // FormClienti
            //
            this.AcceptButton = this.btnSalveaza;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnAnuleaza;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvClienti);
            this.Controls.Add(this.btnSterge);
            this.Controls.Add(this.btnModifica);
            this.Controls.Add(this.btnAdauga);
            this.Controls.Add(this.labelListaClienti);
            this.Controls.Add(this.btnAnuleaza);
            this.Controls.Add(this.btnSalveaza);
            this.Controls.Add(this.tbAdresa);
            this.Controls.Add(this.labelAdresa);
            this.Controls.Add(this.tbTelefon);
            this.Controls.Add(this.labelTelefon);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.tbPrenume);
            this.Controls.Add(this.labelPrenume);
            this.Controls.Add(this.tbNume);
            this.Controls.Add(this.labelNume);
            this.Controls.Add(this.labelDateClient);
            this.Name = "FormClienti";
            this.Text = "FormClienti";
            ((System.ComponentModel.ISupportInitialize)(this.dgvClienti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label labelDateClient;
        private System.Windows.Forms.Label labelNume;
        private System.Windows.Forms.TextBox tbNume;
        private System.Windows.Forms.Label labelPrenume;
        private System.Windows.Forms.TextBox tbPrenume;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label labelTelefon;
        private System.Windows.Forms.TextBox tbTelefon;
        private System.Windows.Forms.Label labelAdresa;
        private System.Windows.Forms.TextBox tbAdresa;
        private System.Windows.Forms.Button btnSalveaza;
        private System.Windows.Forms.Button btnAnuleaza;
        private System.Windows.Forms.Label labelListaClienti;
        private System.Windows.Forms.Button btnAdauga;
        private System.Windows.Forms.Button btnModifica;
        private System.Windows.Forms.Button btnSterge;
        private System.Windows.Forms.DataGridView dgvClienti;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}

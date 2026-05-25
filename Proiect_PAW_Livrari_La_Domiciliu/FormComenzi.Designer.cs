namespace Proiect_PAW_Livrari_La_Domiciliu
{
    partial class FormComenzi
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
            this.labelClient = new System.Windows.Forms.Label();
            this.labelDataComanda = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.labelAdresaLivrare = new System.Windows.Forms.Label();
            this.cbClient = new System.Windows.Forms.ComboBox();
            this.dtpDataComanda = new System.Windows.Forms.DateTimePicker();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.tbAdresaLivrare = new System.Windows.Forms.TextBox();
            this.dgvComenzi = new System.Windows.Forms.DataGridView();
            this.labelDateComanda = new System.Windows.Forms.Label();
            this.labelListaComenzi = new System.Windows.Forms.Label();
            this.btnSalveaza = new System.Windows.Forms.Button();
            this.btnAnuleaza = new System.Windows.Forms.Button();
            this.btnAdauga = new System.Windows.Forms.Button();
            this.btnModifica = new System.Windows.Forms.Button();
            this.btnSterge = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComenzi)).BeginInit();
            this.SuspendLayout();
            //
            // labelDateComanda
            //
            this.labelDateComanda.AutoSize = true;
            this.labelDateComanda.Location = new System.Drawing.Point(46, 9);
            this.labelDateComanda.Name = "labelDateComanda";
            this.labelDateComanda.TabIndex = 10;
            this.labelDateComanda.Text = "DATE COMANDA";
            //
            // labelClient
            //
            this.labelClient.AutoSize = true;
            this.labelClient.Location = new System.Drawing.Point(46, 36);
            this.labelClient.Name = "labelClient";
            this.labelClient.TabIndex = 0;
            this.labelClient.Text = "&Client";
            //
            // labelDataComanda
            //
            this.labelDataComanda.AutoSize = true;
            this.labelDataComanda.Location = new System.Drawing.Point(422, 36);
            this.labelDataComanda.Name = "labelDataComanda";
            this.labelDataComanda.TabIndex = 1;
            this.labelDataComanda.Text = "&Data comanda";
            //
            // labelStatus
            //
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(46, 75);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.TabIndex = 2;
            this.labelStatus.Text = "&Status";
            //
            // labelAdresaLivrare
            //
            this.labelAdresaLivrare.AutoSize = true;
            this.labelAdresaLivrare.Location = new System.Drawing.Point(422, 75);
            this.labelAdresaLivrare.Name = "labelAdresaLivrare";
            this.labelAdresaLivrare.TabIndex = 3;
            this.labelAdresaLivrare.Text = "&Adresa livrare";
            //
            // cbClient
            //
            this.cbClient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbClient.FormattingEnabled = true;
            this.cbClient.Location = new System.Drawing.Point(49, 52);
            this.cbClient.Name = "cbClient";
            this.cbClient.Size = new System.Drawing.Size(262, 21);
            this.cbClient.TabIndex = 0;
            //
            // dtpDataComanda
            //
            this.dtpDataComanda.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDataComanda.CustomFormat = "dd/MM/yyyy";
            this.dtpDataComanda.Location = new System.Drawing.Point(425, 52);
            this.dtpDataComanda.Name = "dtpDataComanda";
            this.dtpDataComanda.Size = new System.Drawing.Size(262, 20);
            this.dtpDataComanda.TabIndex = 1;
            //
            // cbStatus
            //
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] { "In asteptare", "In livrare", "Livrat" });
            this.cbStatus.Location = new System.Drawing.Point(49, 91);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(262, 21);
            this.cbStatus.TabIndex = 2;
            //
            // tbAdresaLivrare
            //
            this.tbAdresaLivrare.Location = new System.Drawing.Point(425, 91);
            this.tbAdresaLivrare.Name = "tbAdresaLivrare";
            this.tbAdresaLivrare.Size = new System.Drawing.Size(262, 20);
            this.tbAdresaLivrare.TabIndex = 3;
            //
            // btnSalveaza
            //
            this.btnSalveaza.Location = new System.Drawing.Point(49, 122);
            this.btnSalveaza.Name = "btnSalveaza";
            this.btnSalveaza.Size = new System.Drawing.Size(94, 31);
            this.btnSalveaza.TabIndex = 4;
            this.btnSalveaza.Text = "Sal&veaza";
            this.btnSalveaza.UseVisualStyleBackColor = true;
            //
            // btnAnuleaza
            //
            this.btnAnuleaza.Location = new System.Drawing.Point(149, 122);
            this.btnAnuleaza.Name = "btnAnuleaza";
            this.btnAnuleaza.Size = new System.Drawing.Size(94, 31);
            this.btnAnuleaza.TabIndex = 5;
            this.btnAnuleaza.Text = "A&nuleaza";
            this.btnAnuleaza.UseVisualStyleBackColor = true;
            //
            // btnAdauga
            //
            this.btnAdauga.Location = new System.Drawing.Point(390, 224);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(94, 31);
            this.btnAdauga.TabIndex = 6;
            this.btnAdauga.Text = "Adau&ga";
            this.btnAdauga.UseVisualStyleBackColor = true;
            //
            // btnModifica
            //
            this.btnModifica.Location = new System.Drawing.Point(493, 224);
            this.btnModifica.Name = "btnModifica";
            this.btnModifica.Size = new System.Drawing.Size(94, 31);
            this.btnModifica.TabIndex = 7;
            this.btnModifica.Text = "&Modifica";
            this.btnModifica.UseVisualStyleBackColor = true;
            //
            // btnSterge
            //
            this.btnSterge.Location = new System.Drawing.Point(593, 224);
            this.btnSterge.Name = "btnSterge";
            this.btnSterge.Size = new System.Drawing.Size(94, 31);
            this.btnSterge.TabIndex = 8;
            this.btnSterge.Text = "St&erge";
            this.btnSterge.UseVisualStyleBackColor = true;
            //
            // labelListaComenzi
            //
            this.labelListaComenzi.AutoSize = true;
            this.labelListaComenzi.Location = new System.Drawing.Point(46, 233);
            this.labelListaComenzi.Name = "labelListaComenzi";
            this.labelListaComenzi.TabIndex = 11;
            this.labelListaComenzi.Text = "LISTA COMENZI";
            //
            // dgvComenzi
            //
            this.dgvComenzi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComenzi.Location = new System.Drawing.Point(49, 258);
            this.dgvComenzi.Name = "dgvComenzi";
            this.dgvComenzi.Size = new System.Drawing.Size(638, 180);
            this.dgvComenzi.TabIndex = 9;
            //
            // FormComenzi
            //
            this.AcceptButton = this.btnSalveaza;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnAnuleaza;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSterge);
            this.Controls.Add(this.btnModifica);
            this.Controls.Add(this.btnAdauga);
            this.Controls.Add(this.btnAnuleaza);
            this.Controls.Add(this.btnSalveaza);
            this.Controls.Add(this.labelListaComenzi);
            this.Controls.Add(this.labelDateComanda);
            this.Controls.Add(this.dgvComenzi);
            this.Controls.Add(this.tbAdresaLivrare);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.dtpDataComanda);
            this.Controls.Add(this.cbClient);
            this.Controls.Add(this.labelAdresaLivrare);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.labelDataComanda);
            this.Controls.Add(this.labelClient);
            this.Name = "FormComenzi";
            this.Text = "FormComenzi";
            ((System.ComponentModel.ISupportInitialize)(this.dgvComenzi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label labelDateComanda;
        private System.Windows.Forms.Label labelListaComenzi;
        private System.Windows.Forms.Label labelClient;
        private System.Windows.Forms.Label labelDataComanda;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label labelAdresaLivrare;
        private System.Windows.Forms.ComboBox cbClient;
        private System.Windows.Forms.DateTimePicker dtpDataComanda;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.TextBox tbAdresaLivrare;
        private System.Windows.Forms.DataGridView dgvComenzi;
        private System.Windows.Forms.Button btnSalveaza;
        private System.Windows.Forms.Button btnAnuleaza;
        private System.Windows.Forms.Button btnAdauga;
        private System.Windows.Forms.Button btnModifica;
        private System.Windows.Forms.Button btnSterge;
    }
}

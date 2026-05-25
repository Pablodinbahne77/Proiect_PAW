namespace Proiect_PAW_Livrari_La_Domiciliu
{
    partial class FormFacturi
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
            this.labelDateFactura = new System.Windows.Forms.Label();
            this.labelComanda = new System.Windows.Forms.Label();
            this.cbComanda = new System.Windows.Forms.ComboBox();
            this.labelDataEmitere = new System.Windows.Forms.Label();
            this.dtpDataEmitere = new System.Windows.Forms.DateTimePicker();
            this.labelPretTotal = new System.Windows.Forms.Label();
            this.tbPretTotal = new System.Windows.Forms.TextBox();
            this.btnSalveaza = new System.Windows.Forms.Button();
            this.btnAnuleaza = new System.Windows.Forms.Button();
            this.labelListaFacturi = new System.Windows.Forms.Label();
            this.btnAdauga = new System.Windows.Forms.Button();
            this.btnModifica = new System.Windows.Forms.Button();
            this.btnSterge = new System.Windows.Forms.Button();
            this.dgvFacturi = new System.Windows.Forms.DataGridView();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturi)).BeginInit();
            this.SuspendLayout();
            //
            // labelDateFactura
            //
            this.labelDateFactura.AutoSize = true;
            this.labelDateFactura.Location = new System.Drawing.Point(46, 9);
            this.labelDateFactura.Name = "labelDateFactura";
            this.labelDateFactura.TabIndex = 0;
            this.labelDateFactura.Text = "DATE FACTURA";
            //
            // labelComanda
            //
            this.labelComanda.AutoSize = true;
            this.labelComanda.Location = new System.Drawing.Point(46, 36);
            this.labelComanda.Name = "labelComanda";
            this.labelComanda.TabIndex = 1;
            this.labelComanda.Text = "&Comanda";
            //
            // cbComanda
            //
            this.cbComanda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbComanda.FormattingEnabled = true;
            this.cbComanda.Location = new System.Drawing.Point(49, 52);
            this.cbComanda.Name = "cbComanda";
            this.cbComanda.Size = new System.Drawing.Size(262, 21);
            this.cbComanda.TabIndex = 2;
            //
            // labelDataEmitere
            //
            this.labelDataEmitere.AutoSize = true;
            this.labelDataEmitere.Location = new System.Drawing.Point(422, 36);
            this.labelDataEmitere.Name = "labelDataEmitere";
            this.labelDataEmitere.TabIndex = 3;
            this.labelDataEmitere.Text = "&Data emitere";
            //
            // dtpDataEmitere
            //
            this.dtpDataEmitere.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDataEmitere.CustomFormat = "dd/MM/yyyy";
            this.dtpDataEmitere.Location = new System.Drawing.Point(425, 52);
            this.dtpDataEmitere.Name = "dtpDataEmitere";
            this.dtpDataEmitere.Size = new System.Drawing.Size(262, 20);
            this.dtpDataEmitere.TabIndex = 4;
            //
            // labelPretTotal
            //
            this.labelPretTotal.AutoSize = true;
            this.labelPretTotal.Location = new System.Drawing.Point(46, 80);
            this.labelPretTotal.Name = "labelPretTotal";
            this.labelPretTotal.TabIndex = 5;
            this.labelPretTotal.Text = "&Pret total (RON)";
            //
            // tbPretTotal
            //
            this.tbPretTotal.Location = new System.Drawing.Point(49, 96);
            this.tbPretTotal.Name = "tbPretTotal";
            this.tbPretTotal.ReadOnly = true;
            this.tbPretTotal.BackColor = System.Drawing.SystemColors.Control;
            this.tbPretTotal.Size = new System.Drawing.Size(262, 20);
            this.tbPretTotal.TabIndex = 6;
            //
            // btnSalveaza
            //
            this.btnSalveaza.Location = new System.Drawing.Point(49, 127);
            this.btnSalveaza.Name = "btnSalveaza";
            this.btnSalveaza.Size = new System.Drawing.Size(94, 31);
            this.btnSalveaza.TabIndex = 7;
            this.btnSalveaza.Text = "Sal&veaza";
            this.btnSalveaza.UseVisualStyleBackColor = true;
            //
            // btnAnuleaza
            //
            this.btnAnuleaza.Location = new System.Drawing.Point(149, 127);
            this.btnAnuleaza.Name = "btnAnuleaza";
            this.btnAnuleaza.Size = new System.Drawing.Size(94, 31);
            this.btnAnuleaza.TabIndex = 8;
            this.btnAnuleaza.Text = "A&nuleaza";
            this.btnAnuleaza.UseVisualStyleBackColor = true;
            //
            // labelListaFacturi
            //
            this.labelListaFacturi.AutoSize = true;
            this.labelListaFacturi.Location = new System.Drawing.Point(46, 174);
            this.labelListaFacturi.Name = "labelListaFacturi";
            this.labelListaFacturi.TabIndex = 9;
            this.labelListaFacturi.Text = "LISTA FACTURI";
            //
            // btnAdauga
            //
            this.btnAdauga.Location = new System.Drawing.Point(390, 169);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(94, 31);
            this.btnAdauga.TabIndex = 10;
            this.btnAdauga.Text = "Adau&ga";
            this.btnAdauga.UseVisualStyleBackColor = true;
            //
            // btnModifica
            //
            this.btnModifica.Location = new System.Drawing.Point(493, 169);
            this.btnModifica.Name = "btnModifica";
            this.btnModifica.Size = new System.Drawing.Size(94, 31);
            this.btnModifica.TabIndex = 11;
            this.btnModifica.Text = "&Modifica";
            this.btnModifica.UseVisualStyleBackColor = true;
            //
            // btnSterge
            //
            this.btnSterge.Location = new System.Drawing.Point(593, 169);
            this.btnSterge.Name = "btnSterge";
            this.btnSterge.Size = new System.Drawing.Size(94, 31);
            this.btnSterge.TabIndex = 12;
            this.btnSterge.Text = "St&erge";
            this.btnSterge.UseVisualStyleBackColor = true;
            //
            // dgvFacturi
            //
            this.dgvFacturi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFacturi.Location = new System.Drawing.Point(49, 207);
            this.dgvFacturi.Name = "dgvFacturi";
            this.dgvFacturi.Size = new System.Drawing.Size(638, 215);
            this.dgvFacturi.TabIndex = 13;
            //
            // FormFacturi
            //
            this.AcceptButton = this.btnSalveaza;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnAnuleaza;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvFacturi);
            this.Controls.Add(this.btnSterge);
            this.Controls.Add(this.btnModifica);
            this.Controls.Add(this.btnAdauga);
            this.Controls.Add(this.labelListaFacturi);
            this.Controls.Add(this.btnAnuleaza);
            this.Controls.Add(this.btnSalveaza);
            this.Controls.Add(this.tbPretTotal);
            this.Controls.Add(this.labelPretTotal);
            this.Controls.Add(this.dtpDataEmitere);
            this.Controls.Add(this.labelDataEmitere);
            this.Controls.Add(this.cbComanda);
            this.Controls.Add(this.labelComanda);
            this.Controls.Add(this.labelDateFactura);
            this.Name = "FormFacturi";
            this.Text = "FormFacturi";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label labelDateFactura;
        private System.Windows.Forms.Label labelComanda;
        private System.Windows.Forms.ComboBox cbComanda;
        private System.Windows.Forms.Label labelDataEmitere;
        private System.Windows.Forms.DateTimePicker dtpDataEmitere;
        private System.Windows.Forms.Label labelPretTotal;
        private System.Windows.Forms.TextBox tbPretTotal;
        private System.Windows.Forms.Button btnSalveaza;
        private System.Windows.Forms.Button btnAnuleaza;
        private System.Windows.Forms.Label labelListaFacturi;
        private System.Windows.Forms.Button btnAdauga;
        private System.Windows.Forms.Button btnModifica;
        private System.Windows.Forms.Button btnSterge;
        private System.Windows.Forms.DataGridView dgvFacturi;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}

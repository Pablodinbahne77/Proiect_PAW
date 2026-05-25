namespace Proiect_PAW_Livrari_La_Domiciliu
{
    partial class FormProduse
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
            this.labelDateProdus = new System.Windows.Forms.Label();
            this.labelDenumire = new System.Windows.Forms.Label();
            this.labelPretUnitar = new System.Windows.Forms.Label();
            this.tbDenumire = new System.Windows.Forms.TextBox();
            this.tbPretUnitar = new System.Windows.Forms.TextBox();
            this.btnSalveaza = new System.Windows.Forms.Button();
            this.btnAnuleaza = new System.Windows.Forms.Button();
            this.labelListaProduse = new System.Windows.Forms.Label();
            this.btnAdauga = new System.Windows.Forms.Button();
            this.btnModifica = new System.Windows.Forms.Button();
            this.btnSterge = new System.Windows.Forms.Button();
            this.dgvProduse = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduse)).BeginInit();
            this.SuspendLayout();
            //
            // labelDateProdus
            //
            this.labelDateProdus.AutoSize = true;
            this.labelDateProdus.Location = new System.Drawing.Point(46, 9);
            this.labelDateProdus.Name = "labelDateProdus";
            this.labelDateProdus.TabIndex = 10;
            this.labelDateProdus.Text = "DATE PRODUS";
            //
            // labelDenumire
            //
            this.labelDenumire.AutoSize = true;
            this.labelDenumire.Location = new System.Drawing.Point(46, 36);
            this.labelDenumire.Name = "labelDenumire";
            this.labelDenumire.TabIndex = 0;
            this.labelDenumire.Text = "&Denumire";
            //
            // labelPretUnitar
            //
            this.labelPretUnitar.AutoSize = true;
            this.labelPretUnitar.Location = new System.Drawing.Point(422, 36);
            this.labelPretUnitar.Name = "labelPretUnitar";
            this.labelPretUnitar.TabIndex = 1;
            this.labelPretUnitar.Text = "&Pret unitar";
            //
            // tbDenumire
            //
            this.tbDenumire.Location = new System.Drawing.Point(49, 52);
            this.tbDenumire.Name = "tbDenumire";
            this.tbDenumire.Size = new System.Drawing.Size(262, 20);
            this.tbDenumire.TabIndex = 0;
            //
            // tbPretUnitar
            //
            this.tbPretUnitar.Location = new System.Drawing.Point(425, 52);
            this.tbPretUnitar.Name = "tbPretUnitar";
            this.tbPretUnitar.Size = new System.Drawing.Size(262, 20);
            this.tbPretUnitar.TabIndex = 1;
            //
            // btnSalveaza
            //
            this.btnSalveaza.Location = new System.Drawing.Point(49, 88);
            this.btnSalveaza.Name = "btnSalveaza";
            this.btnSalveaza.Size = new System.Drawing.Size(94, 31);
            this.btnSalveaza.TabIndex = 2;
            this.btnSalveaza.Text = "Sal&veaza";
            this.btnSalveaza.UseVisualStyleBackColor = true;
            //
            // btnAnuleaza
            //
            this.btnAnuleaza.Location = new System.Drawing.Point(149, 88);
            this.btnAnuleaza.Name = "btnAnuleaza";
            this.btnAnuleaza.Size = new System.Drawing.Size(94, 31);
            this.btnAnuleaza.TabIndex = 3;
            this.btnAnuleaza.Text = "A&nuleaza";
            this.btnAnuleaza.UseVisualStyleBackColor = true;
            //
            // labelListaProduse
            //
            this.labelListaProduse.AutoSize = true;
            this.labelListaProduse.Location = new System.Drawing.Point(46, 135);
            this.labelListaProduse.Name = "labelListaProduse";
            this.labelListaProduse.TabIndex = 11;
            this.labelListaProduse.Text = "LISTA PRODUSE";
            //
            // btnAdauga
            //
            this.btnAdauga.Location = new System.Drawing.Point(390, 130);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(94, 31);
            this.btnAdauga.TabIndex = 4;
            this.btnAdauga.Text = "Adau&ga";
            this.btnAdauga.UseVisualStyleBackColor = true;
            //
            // btnModifica
            //
            this.btnModifica.Location = new System.Drawing.Point(493, 130);
            this.btnModifica.Name = "btnModifica";
            this.btnModifica.Size = new System.Drawing.Size(94, 31);
            this.btnModifica.TabIndex = 5;
            this.btnModifica.Text = "&Modifica";
            this.btnModifica.UseVisualStyleBackColor = true;
            //
            // btnSterge
            //
            this.btnSterge.Location = new System.Drawing.Point(593, 130);
            this.btnSterge.Name = "btnSterge";
            this.btnSterge.Size = new System.Drawing.Size(94, 31);
            this.btnSterge.TabIndex = 6;
            this.btnSterge.Text = "St&erge";
            this.btnSterge.UseVisualStyleBackColor = true;
            //
            // dgvProduse
            //
            this.dgvProduse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduse.Location = new System.Drawing.Point(49, 168);
            this.dgvProduse.Name = "dgvProduse";
            this.dgvProduse.Size = new System.Drawing.Size(638, 145);
            this.dgvProduse.TabIndex = 7;
            //
            // FormProduse
            //
            this.AcceptButton = this.btnSalveaza;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnAnuleaza;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvProduse);
            this.Controls.Add(this.btnSterge);
            this.Controls.Add(this.btnModifica);
            this.Controls.Add(this.btnAdauga);
            this.Controls.Add(this.labelListaProduse);
            this.Controls.Add(this.btnAnuleaza);
            this.Controls.Add(this.btnSalveaza);
            this.Controls.Add(this.tbPretUnitar);
            this.Controls.Add(this.tbDenumire);
            this.Controls.Add(this.labelPretUnitar);
            this.Controls.Add(this.labelDenumire);
            this.Controls.Add(this.labelDateProdus);
            this.Name = "FormProduse";
            this.Text = "FormProduse";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label labelDateProdus;
        private System.Windows.Forms.Label labelDenumire;
        private System.Windows.Forms.Label labelPretUnitar;
        private System.Windows.Forms.TextBox tbDenumire;
        private System.Windows.Forms.TextBox tbPretUnitar;
        private System.Windows.Forms.Button btnSalveaza;
        private System.Windows.Forms.Button btnAnuleaza;
        private System.Windows.Forms.Label labelListaProduse;
        private System.Windows.Forms.Button btnAdauga;
        private System.Windows.Forms.Button btnModifica;
        private System.Windows.Forms.Button btnSterge;
        private System.Windows.Forms.DataGridView dgvProduse;
    }
}

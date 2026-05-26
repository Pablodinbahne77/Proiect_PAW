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
            this.components = new System.ComponentModel.Container();
            this.labelDateComanda = new System.Windows.Forms.Label();
            this.labelClient = new System.Windows.Forms.Label();
            this.cbClient = new System.Windows.Forms.ComboBox();
            this.labelDataComanda = new System.Windows.Forms.Label();
            this.dtpDataComanda = new System.Windows.Forms.DateTimePicker();
            this.labelStatus = new System.Windows.Forms.Label();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.labelAdresaLivrare = new System.Windows.Forms.Label();
            this.tbAdresaLivrare = new System.Windows.Forms.TextBox();
            this.btnSalveaza = new System.Windows.Forms.Button();
            this.btnAnuleaza = new System.Windows.Forms.Button();
            this.labelListaComenzi = new System.Windows.Forms.Label();
            this.btnAdauga = new System.Windows.Forms.Button();
            this.btnModifica = new System.Windows.Forms.Button();
            this.btnSterge = new System.Windows.Forms.Button();
            this.dgvComenzi = new System.Windows.Forms.DataGridView();
            this.labelProduseComanda = new System.Windows.Forms.Label();
            this.labelProdus = new System.Windows.Forms.Label();
            this.cbProdus = new System.Windows.Forms.ComboBox();
            this.labelCantitate = new System.Windows.Forms.Label();
            this.tbCantitate = new System.Windows.Forms.TextBox();
            this.btnAdaugaProdus = new System.Windows.Forms.Button();
            this.btnStergeProdus = new System.Windows.Forms.Button();
            this.dgvLinii = new System.Windows.Forms.DataGridView();
            this.dgvProduseDrag = new System.Windows.Forms.DataGridView();
            this.labelDragProduse = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.labelClientSelectat = new System.Windows.Forms.Label();
            this.controlClientSelectat = new Proiect_PAW_Livrari_La_Domiciliu.ControlClient();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComenzi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLinii)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduseDrag)).BeginInit();
            this.controlClientSelectat.SuspendLayout();
            this.SuspendLayout();
            //
            // labelDateComanda
            //
            this.labelDateComanda.AutoSize = true;
            this.labelDateComanda.Location = new System.Drawing.Point(46, 9);
            this.labelDateComanda.Name = "labelDateComanda";
            this.labelDateComanda.TabIndex = 0;
            this.labelDateComanda.Text = "DATE COMANDA";
            //
            // labelClient
            //
            this.labelClient.AutoSize = true;
            this.labelClient.Location = new System.Drawing.Point(46, 36);
            this.labelClient.Name = "labelClient";
            this.labelClient.TabIndex = 1;
            this.labelClient.Text = "&Client";
            //
            // cbClient
            //
            this.cbClient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbClient.FormattingEnabled = true;
            this.cbClient.Location = new System.Drawing.Point(49, 52);
            this.cbClient.Name = "cbClient";
            this.cbClient.Size = new System.Drawing.Size(262, 21);
            this.cbClient.TabIndex = 2;
            //
            // labelDataComanda
            //
            this.labelDataComanda.AutoSize = true;
            this.labelDataComanda.Location = new System.Drawing.Point(422, 36);
            this.labelDataComanda.Name = "labelDataComanda";
            this.labelDataComanda.TabIndex = 3;
            this.labelDataComanda.Text = "&Data comanda";
            //
            // dtpDataComanda
            //
            this.dtpDataComanda.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDataComanda.CustomFormat = "dd/MM/yyyy";
            this.dtpDataComanda.Location = new System.Drawing.Point(425, 52);
            this.dtpDataComanda.Name = "dtpDataComanda";
            this.dtpDataComanda.Size = new System.Drawing.Size(262, 20);
            this.dtpDataComanda.TabIndex = 4;
            //
            // labelStatus
            //
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(46, 80);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.TabIndex = 5;
            this.labelStatus.Text = "&Status";
            //
            // cbStatus
            //
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] { "In asteptare", "In livrare", "Livrat" });
            this.cbStatus.Location = new System.Drawing.Point(49, 96);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(262, 21);
            this.cbStatus.TabIndex = 6;
            //
            // labelAdresaLivrare
            //
            this.labelAdresaLivrare.AutoSize = true;
            this.labelAdresaLivrare.Location = new System.Drawing.Point(422, 80);
            this.labelAdresaLivrare.Name = "labelAdresaLivrare";
            this.labelAdresaLivrare.TabIndex = 7;
            this.labelAdresaLivrare.Text = "&Adresa livrare";
            //
            // tbAdresaLivrare
            //
            this.tbAdresaLivrare.Location = new System.Drawing.Point(425, 96);
            this.tbAdresaLivrare.Name = "tbAdresaLivrare";
            this.tbAdresaLivrare.Size = new System.Drawing.Size(262, 20);
            this.tbAdresaLivrare.TabIndex = 8;
            //
            // btnSalveaza
            //
            this.btnSalveaza.Location = new System.Drawing.Point(49, 127);
            this.btnSalveaza.Name = "btnSalveaza";
            this.btnSalveaza.Size = new System.Drawing.Size(94, 31);
            this.btnSalveaza.TabIndex = 9;
            this.btnSalveaza.Text = "Sal&veaza";
            this.btnSalveaza.UseVisualStyleBackColor = true;
            //
            // btnAnuleaza
            //
            this.btnAnuleaza.Location = new System.Drawing.Point(149, 127);
            this.btnAnuleaza.Name = "btnAnuleaza";
            this.btnAnuleaza.Size = new System.Drawing.Size(94, 31);
            this.btnAnuleaza.TabIndex = 10;
            this.btnAnuleaza.Text = "A&nuleaza";
            this.btnAnuleaza.UseVisualStyleBackColor = true;
            //
            // labelListaComenzi
            //
            this.labelListaComenzi.AutoSize = true;
            this.labelListaComenzi.Location = new System.Drawing.Point(46, 174);
            this.labelListaComenzi.Name = "labelListaComenzi";
            this.labelListaComenzi.TabIndex = 11;
            this.labelListaComenzi.Text = "LISTA COMENZI";
            //
            // btnAdauga
            //
            this.btnAdauga.Location = new System.Drawing.Point(390, 169);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(94, 31);
            this.btnAdauga.TabIndex = 12;
            this.btnAdauga.Text = "Adau&ga";
            this.btnAdauga.UseVisualStyleBackColor = true;
            //
            // btnModifica
            //
            this.btnModifica.Location = new System.Drawing.Point(493, 169);
            this.btnModifica.Name = "btnModifica";
            this.btnModifica.Size = new System.Drawing.Size(94, 31);
            this.btnModifica.TabIndex = 13;
            this.btnModifica.Text = "&Modifica";
            this.btnModifica.UseVisualStyleBackColor = true;
            //
            // btnSterge
            //
            this.btnSterge.Location = new System.Drawing.Point(593, 169);
            this.btnSterge.Name = "btnSterge";
            this.btnSterge.Size = new System.Drawing.Size(94, 31);
            this.btnSterge.TabIndex = 14;
            this.btnSterge.Text = "St&erge";
            this.btnSterge.UseVisualStyleBackColor = true;
            //
            // dgvComenzi
            //
            this.dgvComenzi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComenzi.Location = new System.Drawing.Point(49, 207);
            this.dgvComenzi.Name = "dgvComenzi";
            this.dgvComenzi.Size = new System.Drawing.Size(638, 155);
            this.dgvComenzi.TabIndex = 15;
            //
            // labelProduseComanda
            //
            this.labelProduseComanda.AutoSize = true;
            this.labelProduseComanda.Location = new System.Drawing.Point(46, 375);
            this.labelProduseComanda.Name = "labelProduseComanda";
            this.labelProduseComanda.TabIndex = 16;
            this.labelProduseComanda.Text = "PRODUSE COMANDA SELECTATA";
            //
            // labelProdus
            //
            this.labelProdus.AutoSize = true;
            this.labelProdus.Location = new System.Drawing.Point(46, 398);
            this.labelProdus.Name = "labelProdus";
            this.labelProdus.TabIndex = 17;
            this.labelProdus.Text = "Produs";
            //
            // cbProdus
            //
            this.cbProdus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProdus.FormattingEnabled = true;
            this.cbProdus.Location = new System.Drawing.Point(49, 414);
            this.cbProdus.Name = "cbProdus";
            this.cbProdus.Size = new System.Drawing.Size(262, 21);
            this.cbProdus.TabIndex = 18;
            //
            // labelCantitate
            //
            this.labelCantitate.AutoSize = true;
            this.labelCantitate.Location = new System.Drawing.Point(330, 398);
            this.labelCantitate.Name = "labelCantitate";
            this.labelCantitate.TabIndex = 19;
            this.labelCantitate.Text = "Canti&tate";
            //
            // tbCantitate
            //
            this.tbCantitate.Location = new System.Drawing.Point(333, 414);
            this.tbCantitate.Name = "tbCantitate";
            this.tbCantitate.Size = new System.Drawing.Size(80, 20);
            this.tbCantitate.TabIndex = 20;
            //
            // btnAdaugaProdus
            //
            this.btnAdaugaProdus.Location = new System.Drawing.Point(430, 411);
            this.btnAdaugaProdus.Name = "btnAdaugaProdus";
            this.btnAdaugaProdus.Size = new System.Drawing.Size(130, 28);
            this.btnAdaugaProdus.TabIndex = 21;
            this.btnAdaugaProdus.Text = "Adauga &Produs";
            this.btnAdaugaProdus.UseVisualStyleBackColor = true;
            //
            // btnStergeProdus
            //
            this.btnStergeProdus.Location = new System.Drawing.Point(568, 411);
            this.btnStergeProdus.Name = "btnStergeProdus";
            this.btnStergeProdus.Size = new System.Drawing.Size(120, 28);
            this.btnStergeProdus.TabIndex = 22;
            this.btnStergeProdus.Text = "Ste&rge produs";
            this.btnStergeProdus.UseVisualStyleBackColor = true;
            //
            // dgvLinii
            //
            this.dgvLinii.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLinii.Location = new System.Drawing.Point(49, 448);
            this.dgvLinii.Name = "dgvLinii";
            this.dgvLinii.Size = new System.Drawing.Size(638, 145);
            this.dgvLinii.TabIndex = 23;
            //
            // labelDragProduse
            //
            this.labelDragProduse.AutoSize = true;
            this.labelDragProduse.Location = new System.Drawing.Point(710, 375);
            this.labelDragProduse.Name = "labelDragProduse";
            this.labelDragProduse.Text = "Trageti produse in lista:";
            //
            // dgvProduseDrag
            //
            this.dgvProduseDrag.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduseDrag.Location = new System.Drawing.Point(710, 393);
            this.dgvProduseDrag.Name = "dgvProduseDrag";
            this.dgvProduseDrag.Size = new System.Drawing.Size(220, 200);
            this.dgvProduseDrag.TabIndex = 24;
            this.dgvProduseDrag.ReadOnly = true;
            this.dgvProduseDrag.MultiSelect = false;
            this.dgvProduseDrag.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            //
            // labelClientSelectat
            //
            this.labelClientSelectat.AutoSize = true;
            this.labelClientSelectat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.labelClientSelectat.Location = new System.Drawing.Point(710, 9);
            this.labelClientSelectat.Name = "labelClientSelectat";
            this.labelClientSelectat.Text = "Client selectat:";
            //
            // controlClientSelectat
            //
            this.controlClientSelectat.Location = new System.Drawing.Point(710, 28);
            this.controlClientSelectat.Name = "controlClientSelectat";
            this.controlClientSelectat.Size = new System.Drawing.Size(220, 104);
            this.controlClientSelectat.TabIndex = 25;
            //
            // FormComenzi
            //
            this.AcceptButton = this.btnSalveaza;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnAnuleaza;
            this.ClientSize = new System.Drawing.Size(960, 620);
            this.Controls.Add(this.controlClientSelectat);
            this.Controls.Add(this.labelClientSelectat);
            this.Controls.Add(this.dgvProduseDrag);
            this.Controls.Add(this.labelDragProduse);
            this.Controls.Add(this.dgvLinii);
            this.Controls.Add(this.btnStergeProdus);
            this.Controls.Add(this.btnAdaugaProdus);
            this.Controls.Add(this.tbCantitate);
            this.Controls.Add(this.labelCantitate);
            this.Controls.Add(this.cbProdus);
            this.Controls.Add(this.labelProdus);
            this.Controls.Add(this.labelProduseComanda);
            this.Controls.Add(this.dgvComenzi);
            this.Controls.Add(this.btnSterge);
            this.Controls.Add(this.btnModifica);
            this.Controls.Add(this.btnAdauga);
            this.Controls.Add(this.labelListaComenzi);
            this.Controls.Add(this.btnAnuleaza);
            this.Controls.Add(this.btnSalveaza);
            this.Controls.Add(this.tbAdresaLivrare);
            this.Controls.Add(this.labelAdresaLivrare);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.dtpDataComanda);
            this.Controls.Add(this.labelDataComanda);
            this.Controls.Add(this.cbClient);
            this.Controls.Add(this.labelClient);
            this.Controls.Add(this.labelDateComanda);
            this.Name = "FormComenzi";
            this.Text = "FormComenzi";
            ((System.ComponentModel.ISupportInitialize)(this.dgvComenzi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLinii)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduseDrag)).EndInit();
            this.controlClientSelectat.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label labelDateComanda;
        private System.Windows.Forms.Label labelClient;
        private System.Windows.Forms.ComboBox cbClient;
        private System.Windows.Forms.Label labelDataComanda;
        private System.Windows.Forms.DateTimePicker dtpDataComanda;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Label labelAdresaLivrare;
        private System.Windows.Forms.TextBox tbAdresaLivrare;
        private System.Windows.Forms.Button btnSalveaza;
        private System.Windows.Forms.Button btnAnuleaza;
        private System.Windows.Forms.Label labelListaComenzi;
        private System.Windows.Forms.Button btnAdauga;
        private System.Windows.Forms.Button btnModifica;
        private System.Windows.Forms.Button btnSterge;
        private System.Windows.Forms.DataGridView dgvComenzi;
        private System.Windows.Forms.Label labelProduseComanda;
        private System.Windows.Forms.Label labelProdus;
        private System.Windows.Forms.ComboBox cbProdus;
        private System.Windows.Forms.Label labelCantitate;
        private System.Windows.Forms.TextBox tbCantitate;
        private System.Windows.Forms.Button btnAdaugaProdus;
        private System.Windows.Forms.Button btnStergeProdus;
        private System.Windows.Forms.DataGridView dgvLinii;
        private System.Windows.Forms.DataGridView dgvProduseDrag;
        private System.Windows.Forms.Label labelDragProduse;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Label labelClientSelectat;
        private ControlClient controlClientSelectat;
    }
}

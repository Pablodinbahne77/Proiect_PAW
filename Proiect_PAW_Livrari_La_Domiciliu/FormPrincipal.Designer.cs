namespace Proiect_PAW_Livrari_La_Domiciliu
{
    partial class FormPrincipal
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menuClienti = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemGestionareClienti = new System.Windows.Forms.ToolStripMenuItem();
            this.menuComenzi = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemGestionareComenzi = new System.Windows.Forms.ToolStripMenuItem();
            this.menuProduse = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemGestionareProduse = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFacturi = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemGestionareFacturi = new System.Windows.Forms.ToolStripMenuItem();
            this.menuGrafic = new System.Windows.Forms.ToolStripMenuItem();
            this.menuIesire = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctxGestionareClienti = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxGestionareComenzi = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxGestionareProduse = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxGestionareFacturi = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.ctxIesire = new System.Windows.Forms.ToolStripMenuItem();
            this.labelTitlu = new System.Windows.Forms.Label();
            this.labelClientiTitle = new System.Windows.Forms.Label();
            this.flowClienti = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip.SuspendLayout();
            this.contextMenu.SuspendLayout();
            this.flowClienti.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuClienti,
            this.menuComenzi,
            this.menuProduse,
            this.menuFacturi,
            this.menuGrafic,
            this.menuIesire});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(800, 24);
            this.menuStrip.TabIndex = 0;
            // 
            // menuClienti
            // 
            this.menuClienti.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemGestionareClienti});
            this.menuClienti.Name = "menuClienti";
            this.menuClienti.Size = new System.Drawing.Size(53, 20);
            this.menuClienti.Text = "&Clienti";
            // 
            // menuItemGestionareClienti
            // 
            this.menuItemGestionareClienti.Name = "menuItemGestionareClienti";
            this.menuItemGestionareClienti.Size = new System.Drawing.Size(167, 22);
            this.menuItemGestionareClienti.Text = "&Gestionare Clienti";
            this.menuItemGestionareClienti.Click += new System.EventHandler(this.menuItemGestionareClienti_Click);
            // 
            // menuComenzi
            // 
            this.menuComenzi.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemGestionareComenzi});
            this.menuComenzi.Name = "menuComenzi";
            this.menuComenzi.Size = new System.Drawing.Size(66, 20);
            this.menuComenzi.Text = "C&omenzi";
            // 
            // menuItemGestionareComenzi
            // 
            this.menuItemGestionareComenzi.Name = "menuItemGestionareComenzi";
            this.menuItemGestionareComenzi.Size = new System.Drawing.Size(180, 22);
            this.menuItemGestionareComenzi.Text = "G&estionare Comenzi";
            this.menuItemGestionareComenzi.Click += new System.EventHandler(this.menuItemGestionareComenzi_Click);
            // 
            // menuProduse
            // 
            this.menuProduse.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemGestionareProduse});
            this.menuProduse.Name = "menuProduse";
            this.menuProduse.Size = new System.Drawing.Size(62, 20);
            this.menuProduse.Text = "&Produse";
            // 
            // menuItemGestionareProduse
            // 
            this.menuItemGestionareProduse.Name = "menuItemGestionareProduse";
            this.menuItemGestionareProduse.Size = new System.Drawing.Size(176, 22);
            this.menuItemGestionareProduse.Text = "Gestionare &Produse";
            this.menuItemGestionareProduse.Click += new System.EventHandler(this.menuItemGestionareProduse_Click);
            // 
            // menuFacturi
            // 
            this.menuFacturi.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemGestionareFacturi});
            this.menuFacturi.Name = "menuFacturi";
            this.menuFacturi.Size = new System.Drawing.Size(55, 20);
            this.menuFacturi.Text = "&Facturi";
            // 
            // menuItemGestionareFacturi
            // 
            this.menuItemGestionareFacturi.Name = "menuItemGestionareFacturi";
            this.menuItemGestionareFacturi.Size = new System.Drawing.Size(169, 22);
            this.menuItemGestionareFacturi.Text = "Gestionare &Facturi";
            this.menuItemGestionareFacturi.Click += new System.EventHandler(this.menuItemGestionareFacturi_Click);
            //
            // menuGrafic
            //
            this.menuGrafic.Name = "menuGrafic";
            this.menuGrafic.Size = new System.Drawing.Size(49, 20);
            this.menuGrafic.Text = "&Grafic";
            this.menuGrafic.Click += new System.EventHandler(this.menuGrafic_Click);
            //
            // menuIesire
            //
            this.menuIesire.Name = "menuIesire";
            this.menuIesire.Size = new System.Drawing.Size(46, 20);
            this.menuIesire.Text = "&Iesire";
            this.menuIesire.Click += new System.EventHandler(this.menuIesire_Click);
            // 
            // contextMenu
            // 
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctxGestionareClienti,
            this.ctxGestionareComenzi,
            this.ctxGestionareProduse,
            this.ctxGestionareFacturi,
            this.ctxSeparator,
            this.ctxIesire});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(181, 120);
            // 
            // ctxGestionareClienti
            // 
            this.ctxGestionareClienti.Name = "ctxGestionareClienti";
            this.ctxGestionareClienti.Size = new System.Drawing.Size(180, 22);
            this.ctxGestionareClienti.Text = "Gestionare Clienti";
            this.ctxGestionareClienti.Click += new System.EventHandler(this.menuItemGestionareClienti_Click);
            // 
            // ctxGestionareComenzi
            // 
            this.ctxGestionareComenzi.Name = "ctxGestionareComenzi";
            this.ctxGestionareComenzi.Size = new System.Drawing.Size(180, 22);
            this.ctxGestionareComenzi.Text = "Gestionare Comenzi";
            this.ctxGestionareComenzi.Click += new System.EventHandler(this.menuItemGestionareComenzi_Click);
            // 
            // ctxGestionareProduse
            // 
            this.ctxGestionareProduse.Name = "ctxGestionareProduse";
            this.ctxGestionareProduse.Size = new System.Drawing.Size(180, 22);
            this.ctxGestionareProduse.Text = "Gestionare Produse";
            this.ctxGestionareProduse.Click += new System.EventHandler(this.menuItemGestionareProduse_Click);
            // 
            // ctxGestionareFacturi
            // 
            this.ctxGestionareFacturi.Name = "ctxGestionareFacturi";
            this.ctxGestionareFacturi.Size = new System.Drawing.Size(180, 22);
            this.ctxGestionareFacturi.Text = "Gestionare Facturi";
            this.ctxGestionareFacturi.Click += new System.EventHandler(this.menuItemGestionareFacturi_Click);
            // 
            // ctxSeparator
            // 
            this.ctxSeparator.Name = "ctxSeparator";
            this.ctxSeparator.Size = new System.Drawing.Size(177, 6);
            // 
            // ctxIesire
            // 
            this.ctxIesire.Name = "ctxIesire";
            this.ctxIesire.Size = new System.Drawing.Size(180, 22);
            this.ctxIesire.Text = "Iesire";
            this.ctxIesire.Click += new System.EventHandler(this.menuIesire_Click);
            // 
            // labelTitlu
            // 
            this.labelTitlu.AutoSize = true;
            this.labelTitlu.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.labelTitlu.Location = new System.Drawing.Point(260, 35);
            this.labelTitlu.Name = "labelTitlu";
            this.labelTitlu.Size = new System.Drawing.Size(236, 29);
            this.labelTitlu.TabIndex = 1;
            this.labelTitlu.Text = "Livrari La Domiciliu";
            //
            // labelClientiTitle
            //
            this.labelClientiTitle.AutoSize = true;
            this.labelClientiTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.labelClientiTitle.Location = new System.Drawing.Point(12, 78);
            this.labelClientiTitle.Name = "labelClientiTitle";
            this.labelClientiTitle.TabIndex = 2;
            this.labelClientiTitle.Text = "Clienti inregistrati:";
            //
            // flowClienti
            //
            this.flowClienti.AutoScroll = true;
            this.flowClienti.Location = new System.Drawing.Point(12, 98);
            this.flowClienti.Name = "flowClienti";
            this.flowClienti.Size = new System.Drawing.Size(776, 340);
            this.flowClienti.TabIndex = 3;
            this.flowClienti.WrapContents = true;
            //
            // FormPrincipal
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ContextMenuStrip = this.contextMenu;
            this.Controls.Add(this.flowClienti);
            this.Controls.Add(this.labelClientiTitle);
            this.Controls.Add(this.labelTitlu);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "FormPrincipal";
            this.Text = "Livrari La Domiciliu";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.contextMenu.ResumeLayout(false);
            this.flowClienti.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem menuClienti;
        private System.Windows.Forms.ToolStripMenuItem menuItemGestionareClienti;
        private System.Windows.Forms.ToolStripMenuItem menuComenzi;
        private System.Windows.Forms.ToolStripMenuItem menuItemGestionareComenzi;
        private System.Windows.Forms.ToolStripMenuItem menuProduse;
        private System.Windows.Forms.ToolStripMenuItem menuItemGestionareProduse;
        private System.Windows.Forms.ToolStripMenuItem menuFacturi;
        private System.Windows.Forms.ToolStripMenuItem menuItemGestionareFacturi;
        private System.Windows.Forms.ToolStripMenuItem menuGrafic;
        private System.Windows.Forms.ToolStripMenuItem menuIesire;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem ctxGestionareClienti;
        private System.Windows.Forms.ToolStripMenuItem ctxGestionareComenzi;
        private System.Windows.Forms.ToolStripMenuItem ctxGestionareProduse;
        private System.Windows.Forms.ToolStripMenuItem ctxGestionareFacturi;
        private System.Windows.Forms.ToolStripSeparator ctxSeparator;
        private System.Windows.Forms.ToolStripMenuItem ctxIesire;
        private System.Windows.Forms.Label labelTitlu;
        private System.Windows.Forms.Label labelClientiTitle;
        private System.Windows.Forms.FlowLayoutPanel flowClienti;
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Proiect_PAW_Livrari_La_Domiciliu
{
    public partial class FormComenzi : Form
    {
        private List<Comanda> listaComenzi = new List<Comanda>();
        private List<Client> listaClienti = new List<Client>();
        private List<Produs> listaProduse = new List<Produs>();
        private List<LinieComanda> listaLiniiComanda = new List<LinieComanda>();
        private int idUrm = 1;
        private int idUrmLinie = 1;
        private string caleXmlComenzi = "comenzi.xml";
        private string caleXmlClienti = "clienti.xml";
        private string caleXmlProduse = "produse.xml";
        private string caleXmlLinii = "linii_comanda.xml";
        private AccesBD bd = new AccesBD();
        private bool esteModificare = false;

        public FormComenzi()
        {
            InitializeComponent();
            this.Load += FormComenzi_Load;
            btnSalveaza.Click += btnSalveaza_Click;
            btnAnuleaza.Click += btnAnuleaza_Click;
            btnAdauga.Click += btnAdauga_Click;
            btnModifica.Click += btnModifica_Click;
            btnSterge.Click += btnSterge_Click;
            btnAdaugaProdus.Click += btnAdaugaProdus_Click;
            btnStergeProdus.Click += btnStergeProdus_Click;
            dgvComenzi.SelectionChanged += dgvComenzi_SelectionChanged;
            dgvProduseDrag.MouseDown += dgvProduseDrag_MouseDown;
            dgvLinii.DragEnter += dgvLinii_DragEnter;
            dgvLinii.DragDrop += dgvLinii_DragDrop;
        }

        private void FormComenzi_Load(object sender, EventArgs e)
        {
            dgvComenzi.ReadOnly = true;
            dgvComenzi.MultiSelect = false;
            dgvComenzi.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgvLinii.ReadOnly = true;
            dgvLinii.MultiSelect = false;
            dgvLinii.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLinii.AllowDrop = true;

            IncarcaClienti();
            IncarcaProduse();
            IncarcaComenzi();
            IncarcaLiniiComanda();
            RefreshGrid();
        }

        private void IncarcaClienti()
        {
            listaClienti.Clear();
            cbClient.Items.Clear();

            if (!File.Exists(caleXmlClienti)) return;

            XDocument doc = XDocument.Load(caleXmlClienti);

            foreach (XElement el in doc.Root.Elements("Client"))
            {
                int id = int.Parse(el.Element("Id").Value);
                string nume = el.Element("Nume").Value;
                string prenume = el.Element("Prenume").Value;
                string email = el.Element("Email").Value;
                string telefon = el.Element("Telefon").Value;
                string adresa = el.Element("Adresa").Value;

                listaClienti.Add(new Client(id, nume, prenume, email, telefon, adresa));
                cbClient.Items.Add(nume + " " + prenume);
            }
        }

        private void IncarcaProduse()
        {
            listaProduse.Clear();
            cbProdus.Items.Clear();

            if (!File.Exists(caleXmlProduse)) return;

            XDocument doc = XDocument.Load(caleXmlProduse);

            foreach (XElement el in doc.Root.Elements("Produs"))
            {
                int id = int.Parse(el.Element("Id").Value);
                string denumire = el.Element("Denumire").Value;
                decimal pret = decimal.Parse(el.Element("PretUnitar").Value);

                listaProduse.Add(new Produs(id, denumire, pret));
                cbProdus.Items.Add(denumire);
            }

            dgvProduseDrag.Rows.Clear();
            dgvProduseDrag.Columns.Clear();
            dgvProduseDrag.Columns.Add("IdP", "ID");
            dgvProduseDrag.Columns.Add("Denumire", "Denumire");
            dgvProduseDrag.Columns.Add("Pret", "Pret");
            dgvProduseDrag.Columns["IdP"].Width = 35;
            dgvProduseDrag.Columns["Pret"].Width = 55;

            foreach (Produs p in listaProduse)
            {
                dgvProduseDrag.Rows.Add(p.getId_produs(), p.getDenumire(), p.getPretUnitar().ToString("0.00"));
            }
        }

        private void IncarcaComenzi()
        {
            listaComenzi.Clear();

            if (!File.Exists(caleXmlComenzi)) return;

            XDocument doc = XDocument.Load(caleXmlComenzi);

            foreach (XElement el in doc.Root.Elements("Comanda"))
            {
                int id = int.Parse(el.Element("Id").Value);
                int idClient = int.Parse(el.Element("IdClient").Value);
                DateTime data = DateTime.Parse(el.Element("DataComanda").Value);
                string status = el.Element("Status").Value;
                string adresa = el.Element("AdresaLivrare").Value;

                listaComenzi.Add(new Comanda(id, idClient, data, status, adresa));

                if (id >= idUrm)
                    idUrm = id + 1;
            }
        }

        private void IncarcaLiniiComanda()
        {
            listaLiniiComanda.Clear();

            if (!File.Exists(caleXmlLinii)) return;

            XDocument doc = XDocument.Load(caleXmlLinii);

            foreach (XElement el in doc.Root.Elements("LinieComanda"))
            {
                int id = int.Parse(el.Element("Id").Value);
                int idComanda = int.Parse(el.Element("IdComanda").Value);
                int idProdus = int.Parse(el.Element("IdProdus").Value);
                int cantitate = int.Parse(el.Element("Cantitate").Value);
                decimal pretUnitar = decimal.Parse(el.Element("PretUnitar").Value);

                listaLiniiComanda.Add(new LinieComanda(id, idComanda, idProdus, cantitate, pretUnitar));

                if (id >= idUrmLinie)
                    idUrmLinie = id + 1;
            }
        }

        private void RefreshGrid()
        {
            dgvComenzi.Rows.Clear();
            dgvComenzi.Columns.Clear();

            dgvComenzi.Columns.Add("Id", "ID");
            dgvComenzi.Columns.Add("Client", "Client");
            dgvComenzi.Columns.Add("DataComanda", "Data comanda");
            dgvComenzi.Columns.Add("Status", "Status");
            dgvComenzi.Columns.Add("AdresaLivrare", "Adresa livrare");

            foreach (Comanda c in listaComenzi)
            {
                string numeClient = "Necunoscut";
                foreach (Client cl in listaClienti)
                {
                    if (cl.getIdClient() == c.getId_client())
                    {
                        numeClient = cl.getNume() + " " + cl.getPrenume();
                        break;
                    }
                }

                dgvComenzi.Rows.Add(
                    c.getId_comanda(),
                    numeClient,
                    c.getDataComanda().ToString("dd/MM/yyyy"),
                    c.getStatus(),
                    c.getAdresaLivrare()
                );
            }
        }

        private void RefreshLiniiGrid()
        {
            dgvLinii.Rows.Clear();
            dgvLinii.Columns.Clear();

            dgvLinii.Columns.Add("IdLinie", "ID Linie");
            dgvLinii.Columns.Add("Produs", "Produs");
            dgvLinii.Columns.Add("Cantitate", "Cantitate");
            dgvLinii.Columns.Add("PretUnitar", "Pret unitar (RON)");
            dgvLinii.Columns.Add("Subtotal", "Subtotal (RON)");

            if (dgvComenzi.SelectedRows.Count == 0) return;

            int idComanda = (int)dgvComenzi.SelectedRows[0].Cells["Id"].Value;

            foreach (LinieComanda lc in listaLiniiComanda)
            {
                if (lc.getId_comanda() == idComanda)
                {
                    string numeProdus = "Necunoscut";
                    foreach (Produs p in listaProduse)
                    {
                        if (p.getId_produs() == lc.getId_produs())
                        {
                            numeProdus = p.getDenumire();
                            break;
                        }
                    }

                    decimal subtotal = lc.getCantitate() * lc.getPretUnitar();

                    dgvLinii.Rows.Add(
                        lc.getId_linieComanda(),
                        numeProdus,
                        lc.getCantitate(),
                        lc.getPretUnitar().ToString("0.00"),
                        subtotal.ToString("0.00")
                    );
                }
            }
        }

        private void dgvComenzi_SelectionChanged(object sender, EventArgs e)
        {
            RefreshLiniiGrid();
            ActualizeazaCardClient();
        }

        private void ActualizeazaCardClient()
        {
            if (dgvComenzi.SelectedRows.Count == 0)
            {
                controlClientSelectat.Goleste();
                return;
            }

            int idClient = -1;
            int idComanda = (int)dgvComenzi.SelectedRows[0].Cells["Id"].Value;

            foreach (Comanda c in listaComenzi)
            {
                if (c.getId_comanda() == idComanda)
                {
                    idClient = c.getId_client();
                    break;
                }
            }

            foreach (Client cl in listaClienti)
            {
                if (cl.getIdClient() == idClient)
                {
                    controlClientSelectat.SeteazaClient(cl);
                    return;
                }
            }

            controlClientSelectat.Goleste();
        }

        private void GolesesteCampuri()
        {
            cbClient.SelectedIndex = -1;
            dtpDataComanda.Value = DateTime.Today;
            cbStatus.SelectedIndex = -1;
            tbAdresaLivrare.Text = "";
            dgvComenzi.ClearSelection();
            errorProvider.Clear();
        }

        private bool Valideaza()
        {
            errorProvider.Clear();
            bool ok = true;

            if (cbClient.SelectedIndex == -1)
            {
                errorProvider.SetError(cbClient, "Selectati un client.");
                ok = false;
            }

            if (cbStatus.SelectedIndex == -1)
            {
                errorProvider.SetError(cbStatus, "Selectati un status.");
                ok = false;
            }

            if (string.IsNullOrWhiteSpace(tbAdresaLivrare.Text))
            {
                errorProvider.SetError(tbAdresaLivrare, "Adresa de livrare este obligatorie.");
                ok = false;
            }

            return ok;
        }

        private void btnSalveaza_Click(object sender, EventArgs e)
        {
            if (!Valideaza()) return;

            int idClient = listaClienti[cbClient.SelectedIndex].getIdClient();
            DateTime data = dtpDataComanda.Value.Date;
            string status = cbStatus.SelectedItem.ToString();
            string adresa = tbAdresaLivrare.Text;

            if (!esteModificare)
            {
                Comanda comandaNoua = new Comanda(idUrm, idClient, data, status, adresa);
                listaComenzi.Add(comandaNoua);
                try { bd.AdaugaComanda(comandaNoua); } catch { }
                idUrm++;
            }
            else
            {
                int id = (int)dgvComenzi.SelectedRows[0].Cells["Id"].Value;
                Comanda comandaDeModificat = null;

                foreach (Comanda c in listaComenzi)
                {
                    if (c.getId_comanda() == id)
                    {
                        comandaDeModificat = c;
                        break;
                    }
                }

                if (comandaDeModificat != null)
                {
                    comandaDeModificat.setId_client(idClient);
                    comandaDeModificat.setDataComanda(data);
                    comandaDeModificat.setId_status(status);
                    comandaDeModificat.setAdresaLivrare(adresa);
                    try { bd.ModificaComanda(comandaDeModificat); } catch { }
                }
            }

            esteModificare = false;
            SalveazaComenziXml();
            RefreshGrid();
            GolesesteCampuri();
        }

        private void btnAnuleaza_Click(object sender, EventArgs e)
        {
            esteModificare = false;
            GolesesteCampuri();
        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            esteModificare = false;
            GolesesteCampuri();
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            if (dgvComenzi.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selectati o comanda din lista.", "Atentie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            esteModificare = true;

            int id = (int)dgvComenzi.SelectedRows[0].Cells["Id"].Value;

            foreach (Comanda c in listaComenzi)
            {
                if (c.getId_comanda() == id)
                {
                    for (int i = 0; i < listaClienti.Count; i++)
                    {
                        if (listaClienti[i].getIdClient() == c.getId_client())
                        {
                            cbClient.SelectedIndex = i;
                            break;
                        }
                    }

                    dtpDataComanda.Value = c.getDataComanda();
                    cbStatus.SelectedItem = c.getStatus();
                    tbAdresaLivrare.Text = c.getAdresaLivrare();
                    break;
                }
            }
        }

        private void btnSterge_Click(object sender, EventArgs e)
        {
            if (dgvComenzi.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selectati o comanda din lista.", "Atentie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = (int)dgvComenzi.SelectedRows[0].Cells["Id"].Value;
            Comanda comandaDeSters = null;

            foreach (Comanda c in listaComenzi)
            {
                if (c.getId_comanda() == id)
                {
                    comandaDeSters = c;
                    break;
                }
            }

            if (comandaDeSters != null)
            {
                listaLiniiComanda.RemoveAll(lc => lc.getId_comanda() == id);
                listaComenzi.Remove(comandaDeSters);
                try { bd.StergeLiniiByComanda(id); } catch { }
                try { bd.StergeComanda(id); } catch { }
                SalveazaComenziXml();
                SalveazaLiniiXml();
                RefreshGrid();
                GolesesteCampuri();
            }
        }

        private void btnAdaugaProdus_Click(object sender, EventArgs e)
        {
            if (dgvComenzi.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selectati mai intai o comanda din lista.", "Atentie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool eroare = false;

            if (cbProdus.SelectedIndex == -1)
            {
                errorProvider.SetError(cbProdus, "Selectati un produs.");
                eroare = true;
            }
            else
            {
                errorProvider.SetError(cbProdus, "");
            }

            int cantitate;
            if (string.IsNullOrWhiteSpace(tbCantitate.Text))
            {
                errorProvider.SetError(tbCantitate, "Cantitatea este obligatorie.");
                eroare = true;
            }
            else if (!int.TryParse(tbCantitate.Text, out cantitate) || cantitate <= 0)
            {
                errorProvider.SetError(tbCantitate, "Cantitatea trebuie sa fie un numar intreg pozitiv.");
                eroare = true;
            }
            else
            {
                errorProvider.SetError(tbCantitate, "");
            }

            if (eroare) return;

            int idComanda = (int)dgvComenzi.SelectedRows[0].Cells["Id"].Value;
            Produs produsSelectat = listaProduse[cbProdus.SelectedIndex];
            int cant = int.Parse(tbCantitate.Text);

            LinieComanda linieNoua = new LinieComanda(idUrmLinie, idComanda, produsSelectat.getId_produs(), cant, produsSelectat.getPretUnitar());
            listaLiniiComanda.Add(linieNoua);
            try { bd.AdaugaLinieComanda(linieNoua); } catch { }
            idUrmLinie++;

            SalveazaLiniiXml();
            RefreshLiniiGrid();

            cbProdus.SelectedIndex = -1;
            tbCantitate.Text = "";
            errorProvider.Clear();
        }

        private void btnStergeProdus_Click(object sender, EventArgs e)
        {
            if (dgvLinii.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selectati un produs din lista de produse.", "Atentie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idLinie = (int)dgvLinii.SelectedRows[0].Cells["IdLinie"].Value;
            LinieComanda linieDeSters = null;

            foreach (LinieComanda lc in listaLiniiComanda)
            {
                if (lc.getId_linieComanda() == idLinie)
                {
                    linieDeSters = lc;
                    break;
                }
            }

            if (linieDeSters != null)
            {
                listaLiniiComanda.Remove(linieDeSters);
                try { bd.StergeLinieComanda(idLinie); } catch { }
                SalveazaLiniiXml();
                RefreshLiniiGrid();
            }
        }

        private void dgvProduseDrag_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (dgvProduseDrag.SelectedRows.Count == 0) return;

            int idProdus = (int)dgvProduseDrag.SelectedRows[0].Cells["IdP"].Value;
            dgvProduseDrag.DoDragDrop(idProdus, DragDropEffects.Copy);
        }

        private void dgvLinii_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(int)))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void dgvLinii_DragDrop(object sender, DragEventArgs e)
        {
            if (dgvComenzi.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selectati mai intai o comanda din lista.", "Atentie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idProdus = (int)e.Data.GetData(typeof(int));
            Produs produsSelectat = null;

            foreach (Produs p in listaProduse)
            {
                if (p.getId_produs() == idProdus)
                {
                    produsSelectat = p;
                    break;
                }
            }

            if (produsSelectat == null) return;

            int cantitate = CereCantitate(produsSelectat.getDenumire());
            if (cantitate <= 0) return;

            int idComanda = (int)dgvComenzi.SelectedRows[0].Cells["Id"].Value;
            LinieComanda linieNoua = new LinieComanda(idUrmLinie, idComanda, produsSelectat.getId_produs(), cantitate, produsSelectat.getPretUnitar());
            listaLiniiComanda.Add(linieNoua);
            try { bd.AdaugaLinieComanda(linieNoua); } catch { }
            idUrmLinie++;

            SalveazaLiniiXml();
            RefreshLiniiGrid();
        }

        private int CereCantitate(string numeProdus)
        {
            Form dialog = new Form();
            dialog.Text = "Cantitate";
            dialog.Size = new System.Drawing.Size(260, 130);
            dialog.StartPosition = FormStartPosition.CenterParent;
            dialog.FormBorderStyle = FormBorderStyle.FixedDialog;
            dialog.MaximizeBox = false;
            dialog.MinimizeBox = false;

            Label lbl = new Label() { Text = "Cantitate pentru " + numeProdus + ":", Location = new System.Drawing.Point(10, 12), AutoSize = true };
            TextBox tb = new TextBox() { Location = new System.Drawing.Point(10, 35), Width = 80 };
            Button btn = new Button() { Text = "OK", Location = new System.Drawing.Point(10, 62), Width = 75, DialogResult = DialogResult.OK };
            dialog.AcceptButton = btn;
            dialog.Controls.AddRange(new System.Windows.Forms.Control[] { lbl, tb, btn });

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                int cant;
                if (int.TryParse(tb.Text, out cant) && cant > 0)
                    return cant;
                MessageBox.Show("Cantitatea trebuie sa fie un numar intreg pozitiv.", "Atentie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return -1;
        }

        private void SalveazaComenziXml()
        {
            XElement root = new XElement("Comenzi");

            foreach (Comanda c in listaComenzi)
            {
                XElement el = new XElement("Comanda",
                    new XElement("Id", c.getId_comanda()),
                    new XElement("IdClient", c.getId_client()),
                    new XElement("DataComanda", c.getDataComanda().ToString("yyyy-MM-dd")),
                    new XElement("Status", c.getStatus()),
                    new XElement("AdresaLivrare", c.getAdresaLivrare())
                );
                root.Add(el);
            }

            new XDocument(root).Save(caleXmlComenzi);
        }

        private void SalveazaLiniiXml()
        {
            XElement root = new XElement("LiniiComanda");

            foreach (LinieComanda lc in listaLiniiComanda)
            {
                XElement el = new XElement("LinieComanda",
                    new XElement("Id", lc.getId_linieComanda()),
                    new XElement("IdComanda", lc.getId_comanda()),
                    new XElement("IdProdus", lc.getId_produs()),
                    new XElement("Cantitate", lc.getCantitate()),
                    new XElement("PretUnitar", lc.getPretUnitar().ToString("0.00"))
                );
                root.Add(el);
            }

            new XDocument(root).Save(caleXmlLinii);
        }
    }
}

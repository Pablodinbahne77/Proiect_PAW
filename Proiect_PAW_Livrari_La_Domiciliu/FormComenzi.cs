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
        }

        private void FormComenzi_Load(object sender, EventArgs e)
        {
            dgvComenzi.ReadOnly = true;
            dgvComenzi.MultiSelect = false;
            dgvComenzi.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgvLinii.ReadOnly = true;
            dgvLinii.MultiSelect = false;
            dgvLinii.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

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

            if (dgvComenzi.SelectedRows.Count == 0)
            {
                Comanda comandaNoua = new Comanda(idUrm, idClient, data, status, adresa);
                listaComenzi.Add(comandaNoua);
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
                }
            }

            SalveazaComenziXml();
            RefreshGrid();
            GolesesteCampuri();
        }

        private void btnAnuleaza_Click(object sender, EventArgs e)
        {
            GolesesteCampuri();
        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            GolesesteCampuri();
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            if (dgvComenzi.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selectati o comanda din lista.", "Atentie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

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
                SalveazaLiniiXml();
                RefreshLiniiGrid();
            }
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

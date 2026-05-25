using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Proiect_PAW_Livrari_La_Domiciliu
{
    public partial class FormFacturi : Form
    {
        private List<Factura> listaFacturi = new List<Factura>();
        private List<Comanda> listaComenzi = new List<Comanda>();
        private List<Client> listaClienti = new List<Client>();
        private List<LinieComanda> listaLiniiComanda = new List<LinieComanda>();
        private int idUrm = 1;
        private string caleXmlFacturi = "facturi.xml";
        private string caleXmlComenzi = "comenzi.xml";
        private string caleXmlClienti = "clienti.xml";
        private string caleXmlLinii = "linii_comanda.xml";

        public FormFacturi()
        {
            InitializeComponent();
            this.Load += FormFacturi_Load;
            cbComanda.SelectedIndexChanged += cbComanda_SelectedIndexChanged;
            btnSalveaza.Click += btnSalveaza_Click;
            btnAnuleaza.Click += btnAnuleaza_Click;
            btnAdauga.Click += btnAdauga_Click;
            btnModifica.Click += btnModifica_Click;
            btnSterge.Click += btnSterge_Click;
        }

        private void FormFacturi_Load(object sender, EventArgs e)
        {
            dgvFacturi.ReadOnly = true;
            dgvFacturi.MultiSelect = false;
            dgvFacturi.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            IncarcaClienti();
            IncarcaComenzi();
            IncarcaLiniiComanda();
            IncarcaFacturi();
            RefreshGrid();
        }

        private void IncarcaClienti()
        {
            listaClienti.Clear();

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
            }
        }

        private void IncarcaComenzi()
        {
            listaComenzi.Clear();
            cbComanda.Items.Clear();

            if (!File.Exists(caleXmlComenzi)) return;

            XDocument doc = XDocument.Load(caleXmlComenzi);

            foreach (XElement el in doc.Root.Elements("Comanda"))
            {
                int id = int.Parse(el.Element("Id").Value);
                int idClient = int.Parse(el.Element("IdClient").Value);
                DateTime data = DateTime.Parse(el.Element("DataComanda").Value);
                string status = el.Element("Status").Value;
                string adresa = el.Element("AdresaLivrare").Value;

                Comanda c = new Comanda(id, idClient, data, status, adresa);
                listaComenzi.Add(c);

                string numeClient = "Necunoscut";
                foreach (Client cl in listaClienti)
                {
                    if (cl.getIdClient() == idClient)
                    {
                        numeClient = cl.getNume() + " " + cl.getPrenume();
                        break;
                    }
                }

                cbComanda.Items.Add("Comanda #" + id + " - " + numeClient);
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
            }
        }

        private void IncarcaFacturi()
        {
            listaFacturi.Clear();

            if (!File.Exists(caleXmlFacturi)) return;

            XDocument doc = XDocument.Load(caleXmlFacturi);

            foreach (XElement el in doc.Root.Elements("Factura"))
            {
                int id = int.Parse(el.Element("Id").Value);
                int idComanda = int.Parse(el.Element("IdComanda").Value);
                DateTime data = DateTime.Parse(el.Element("DataEmitere").Value);
                decimal pretTotal = decimal.Parse(el.Element("PretTotal").Value);

                listaFacturi.Add(new Factura(id, idComanda, data, pretTotal));

                if (id >= idUrm)
                    idUrm = id + 1;
            }
        }

        private void cbComanda_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbComanda.SelectedIndex == -1)
            {
                tbPretTotal.Text = "";
                return;
            }

            int idComanda = listaComenzi[cbComanda.SelectedIndex].getId_comanda();
            decimal pretTotal = 0;

            foreach (LinieComanda lc in listaLiniiComanda)
            {
                if (lc.getId_comanda() == idComanda)
                {
                    pretTotal += lc.getCantitate() * lc.getPretUnitar();
                }
            }

            tbPretTotal.Text = pretTotal.ToString("0.00");
        }

        private void RefreshGrid()
        {
            dgvFacturi.Rows.Clear();
            dgvFacturi.Columns.Clear();

            dgvFacturi.Columns.Add("Id", "ID");
            dgvFacturi.Columns.Add("Comanda", "Comanda");
            dgvFacturi.Columns.Add("DataEmitere", "Data emitere");
            dgvFacturi.Columns.Add("PretTotal", "Pret total (RON)");

            foreach (Factura f in listaFacturi)
            {
                string numeComanda = "Necunoscuta";
                foreach (Comanda c in listaComenzi)
                {
                    if (c.getId_comanda() == f.getId_comanda())
                    {
                        numeComanda = "Comanda #" + c.getId_comanda();
                        break;
                    }
                }

                dgvFacturi.Rows.Add(
                    f.getId_factura(),
                    numeComanda,
                    f.getDataEmitere().ToString("dd/MM/yyyy"),
                    f.getPretTotal().ToString("0.00")
                );
            }
        }

        private void GolesesteCampuri()
        {
            cbComanda.SelectedIndex = -1;
            dtpDataEmitere.Value = DateTime.Today;
            tbPretTotal.Text = "";
            dgvFacturi.ClearSelection();
            errorProvider.Clear();
        }

        private bool Valideaza()
        {
            errorProvider.Clear();
            bool ok = true;

            if (cbComanda.SelectedIndex == -1)
            {
                errorProvider.SetError(cbComanda, "Selectati o comanda.");
                ok = false;
            }

            return ok;
        }

        private void btnSalveaza_Click(object sender, EventArgs e)
        {
            if (!Valideaza()) return;

            int idComanda = listaComenzi[cbComanda.SelectedIndex].getId_comanda();
            DateTime dataEmitere = dtpDataEmitere.Value.Date;
            decimal pretTotal = decimal.Parse(tbPretTotal.Text == "" ? "0" : tbPretTotal.Text);

            if (dgvFacturi.SelectedRows.Count == 0)
            {
                Factura facturaNoua = new Factura(idUrm, idComanda, dataEmitere, pretTotal);
                listaFacturi.Add(facturaNoua);
                idUrm++;
            }
            else
            {
                int id = (int)dgvFacturi.SelectedRows[0].Cells["Id"].Value;
                Factura facturaDeModificat = null;

                foreach (Factura f in listaFacturi)
                {
                    if (f.getId_factura() == id)
                    {
                        facturaDeModificat = f;
                        break;
                    }
                }

                if (facturaDeModificat != null)
                {
                    facturaDeModificat.setId_comanda(idComanda);
                    facturaDeModificat.setDataEmitere(dataEmitere);
                    facturaDeModificat.setPretTotal(pretTotal);
                }
            }

            SalveazaXml();
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
            if (dgvFacturi.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selectati o factura din lista.", "Atentie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = (int)dgvFacturi.SelectedRows[0].Cells["Id"].Value;

            foreach (Factura f in listaFacturi)
            {
                if (f.getId_factura() == id)
                {
                    for (int i = 0; i < listaComenzi.Count; i++)
                    {
                        if (listaComenzi[i].getId_comanda() == f.getId_comanda())
                        {
                            cbComanda.SelectedIndex = i;
                            break;
                        }
                    }

                    dtpDataEmitere.Value = f.getDataEmitere();
                    break;
                }
            }
        }

        private void btnSterge_Click(object sender, EventArgs e)
        {
            if (dgvFacturi.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selectati o factura din lista.", "Atentie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = (int)dgvFacturi.SelectedRows[0].Cells["Id"].Value;
            Factura facturaDeSters = null;

            foreach (Factura f in listaFacturi)
            {
                if (f.getId_factura() == id)
                {
                    facturaDeSters = f;
                    break;
                }
            }

            if (facturaDeSters != null)
            {
                listaFacturi.Remove(facturaDeSters);
                SalveazaXml();
                RefreshGrid();
                GolesesteCampuri();
            }
        }

        private void SalveazaXml()
        {
            XElement root = new XElement("Facturi");

            foreach (Factura f in listaFacturi)
            {
                XElement el = new XElement("Factura",
                    new XElement("Id", f.getId_factura()),
                    new XElement("IdComanda", f.getId_comanda()),
                    new XElement("DataEmitere", f.getDataEmitere().ToString("yyyy-MM-dd")),
                    new XElement("PretTotal", f.getPretTotal().ToString("0.00"))
                );
                root.Add(el);
            }

            new XDocument(root).Save(caleXmlFacturi);
        }
    }
}

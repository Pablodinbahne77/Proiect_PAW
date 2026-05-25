using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Proiect_PAW_Livrari_La_Domiciliu
{
    public partial class FormClienti : Form
    {
        private List<Client> listaClienti = new List<Client>();
        private int idUrm = 1;
        private string caleXml = "clienti.xml";

        public FormClienti()
        {
            InitializeComponent();
            this.Load += FormClienti_Load;
            btnSalveaza.Click += btnSalveaza_Click;
            btnAnuleaza.Click += btnAnuleaza_Click;
            btnAdauga.Click += btnAdauga_Click;
            btnModifica.Click += btnModifica_Click;
            btnSterge.Click += btnSterge_Click;
        }

        private void FormClienti_Load(object sender, EventArgs e)
        {
            dgvClienti.ReadOnly = true;
            dgvClienti.MultiSelect = false;
            dgvClienti.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            IncarcaXml();
            RefreshGrid();
        }

        private void RefreshGrid()
        {
            dgvClienti.Rows.Clear();
            dgvClienti.Columns.Clear();

            dgvClienti.Columns.Add("Id", "ID");
            dgvClienti.Columns.Add("Nume", "Nume");
            dgvClienti.Columns.Add("Prenume", "Prenume");
            dgvClienti.Columns.Add("Email", "Email");
            dgvClienti.Columns.Add("Telefon", "Telefon");
            dgvClienti.Columns.Add("Adresa", "Adresa");

            foreach (Client c in listaClienti)
            {
                dgvClienti.Rows.Add(
                    c.getIdClient(),
                    c.getNume(),
                    c.getPrenume(),
                    c.getEmail(),
                    c.getTelefon(),
                    c.getAdresa()
                );
            }
        }

        private void GolesesteCampuri()
        {
            tbNume.Text = "";
            tbPrenume.Text = "";
            tbEmail.Text = "";
            tbTelefon.Text = "";
            tbAdresa.Text = "";
            dgvClienti.ClearSelection();
            errorProvider.Clear();
        }

        private bool Valideaza()
        {
            errorProvider.Clear();
            bool ok = true;

            if (string.IsNullOrWhiteSpace(tbNume.Text))
            {
                errorProvider.SetError(tbNume, "Numele este obligatoriu.");
                ok = false;
            }

            if (string.IsNullOrWhiteSpace(tbPrenume.Text))
            {
                errorProvider.SetError(tbPrenume, "Prenumele este obligatoriu.");
                ok = false;
            }

            if (string.IsNullOrWhiteSpace(tbEmail.Text))
            {
                errorProvider.SetError(tbEmail, "Email-ul este obligatoriu.");
                ok = false;
            }
            else if (!tbEmail.Text.Contains("@"))
            {
                errorProvider.SetError(tbEmail, "Adresa de email trebuie sa contina @.");
                ok = false;
            }

            if (string.IsNullOrWhiteSpace(tbTelefon.Text))
            {
                errorProvider.SetError(tbTelefon, "Telefonul este obligatoriu.");
                ok = false;
            }
            else if (tbTelefon.Text.Length != 10)
            {
                errorProvider.SetError(tbTelefon, "Numarul de telefon trebuie sa aiba exact 10 cifre.");
                ok = false;
            }
            else
            {
                foreach (char c in tbTelefon.Text)
                {
                    if (!char.IsDigit(c))
                    {
                        errorProvider.SetError(tbTelefon, "Numarul de telefon trebuie sa contina doar cifre.");
                        ok = false;
                        break;
                    }
                }
            }

            if (string.IsNullOrWhiteSpace(tbAdresa.Text))
            {
                errorProvider.SetError(tbAdresa, "Adresa este obligatorie.");
                ok = false;
            }

            return ok;
        }

        private void btnSalveaza_Click(object sender, EventArgs e)
        {
            if (!Valideaza()) return;

            if (dgvClienti.SelectedRows.Count == 0)
            {
                Client clientNou = new Client(idUrm, tbNume.Text, tbPrenume.Text, tbEmail.Text, tbTelefon.Text, tbAdresa.Text);
                listaClienti.Add(clientNou);
                idUrm++;
            }
            else
            {
                int id = (int)dgvClienti.SelectedRows[0].Cells["Id"].Value;
                Client clientDeModificat = null;

                foreach (Client c in listaClienti)
                {
                    if (c.getIdClient() == id)
                    {
                        clientDeModificat = c;
                        break;
                    }
                }

                if (clientDeModificat != null)
                {
                    clientDeModificat.setNume(tbNume.Text);
                    clientDeModificat.setPrenume(tbPrenume.Text);
                    clientDeModificat.setEmail(tbEmail.Text);
                    clientDeModificat.setTelefon(tbTelefon.Text);
                    clientDeModificat.setAdresa(tbAdresa.Text);
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
            if (dgvClienti.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selectati un client din lista.", "Atentie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = (int)dgvClienti.SelectedRows[0].Cells["Id"].Value;

            foreach (Client c in listaClienti)
            {
                if (c.getIdClient() == id)
                {
                    tbNume.Text = c.getNume();
                    tbPrenume.Text = c.getPrenume();
                    tbEmail.Text = c.getEmail();
                    tbTelefon.Text = c.getTelefon();
                    tbAdresa.Text = c.getAdresa();
                    break;
                }
            }
        }

        private void btnSterge_Click(object sender, EventArgs e)
        {
            if (dgvClienti.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selectati un client din lista.", "Atentie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = (int)dgvClienti.SelectedRows[0].Cells["Id"].Value;
            Client clientDeSters = null;

            foreach (Client c in listaClienti)
            {
                if (c.getIdClient() == id)
                {
                    clientDeSters = c;
                    break;
                }
            }

            if (clientDeSters != null)
            {
                listaClienti.Remove(clientDeSters);
                SalveazaXml();
                RefreshGrid();
                GolesesteCampuri();
            }
        }

        private void SalveazaXml()
        {
            XElement root = new XElement("Clienti");

            foreach (Client c in listaClienti)
            {
                XElement el = new XElement("Client",
                    new XElement("Id", c.getIdClient()),
                    new XElement("Nume", c.getNume()),
                    new XElement("Prenume", c.getPrenume()),
                    new XElement("Email", c.getEmail()),
                    new XElement("Telefon", c.getTelefon()),
                    new XElement("Adresa", c.getAdresa())
                );
                root.Add(el);
            }

            XDocument doc = new XDocument(root);
            doc.Save(caleXml);
        }

        private void IncarcaXml()
        {
            if (!File.Exists(caleXml)) return;

            XDocument doc = XDocument.Load(caleXml);

            foreach (XElement el in doc.Root.Elements("Client"))
            {
                int id = int.Parse(el.Element("Id").Value);
                string nume = el.Element("Nume").Value;
                string prenume = el.Element("Prenume").Value;
                string email = el.Element("Email").Value;
                string telefon = el.Element("Telefon").Value;
                string adresa = el.Element("Adresa").Value;

                listaClienti.Add(new Client(id, nume, prenume, email, telefon, adresa));

                if (id >= idUrm)
                    idUrm = id + 1;
            }
        }
    }
}

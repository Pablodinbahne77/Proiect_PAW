using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Proiect_PAW_Livrari_La_Domiciliu
{
    public partial class FormProduse : Form
    {
        private List<Produs> listaProduse = new List<Produs>();
        private int idUrm = 1;
        private string caleXml = "produse.xml";
        private AccesBD bd = new AccesBD();

        public FormProduse()
        {
            InitializeComponent();
            this.Load += FormProduse_Load;
            btnSalveaza.Click += btnSalveaza_Click;
            btnAnuleaza.Click += btnAnuleaza_Click;
            btnAdauga.Click += btnAdauga_Click;
            btnModifica.Click += btnModifica_Click;
            btnSterge.Click += btnSterge_Click;
        }

        private void FormProduse_Load(object sender, EventArgs e)
        {
            dgvProduse.ReadOnly = true;
            dgvProduse.MultiSelect = false;
            dgvProduse.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            IncarcaXml();
            RefreshGrid();
        }

        private void RefreshGrid()
        {
            dgvProduse.Rows.Clear();
            dgvProduse.Columns.Clear();

            dgvProduse.Columns.Add("Id", "ID");
            dgvProduse.Columns.Add("Denumire", "Denumire");
            dgvProduse.Columns.Add("PretUnitar", "Pret unitar (RON)");

            foreach (Produs p in listaProduse)
            {
                dgvProduse.Rows.Add(
                    p.getId_produs(),
                    p.getDenumire(),
                    p.getPretUnitar().ToString("0.00")
                );
            }
        }

        private void GolesesteCampuri()
        {
            tbDenumire.Text = "";
            tbPretUnitar.Text = "";
            dgvProduse.ClearSelection();
            errorProvider.Clear();
        }

        private bool Valideaza()
        {
            errorProvider.Clear();
            bool ok = true;

            if (string.IsNullOrWhiteSpace(tbDenumire.Text))
            {
                errorProvider.SetError(tbDenumire, "Denumirea este obligatorie.");
                ok = false;
            }

            if (string.IsNullOrWhiteSpace(tbPretUnitar.Text))
            {
                errorProvider.SetError(tbPretUnitar, "Pretul unitar este obligatoriu.");
                ok = false;
            }
            else
            {
                decimal pret;
                bool esteNumar = decimal.TryParse(tbPretUnitar.Text, out pret);

                if (!esteNumar)
                {
                    errorProvider.SetError(tbPretUnitar, "Pretul unitar trebuie sa fie un numar.");
                    ok = false;
                }
                else if (pret <= 0)
                {
                    errorProvider.SetError(tbPretUnitar, "Pretul unitar trebuie sa fie mai mare decat 0.");
                    ok = false;
                }
            }

            return ok;
        }

        private void btnSalveaza_Click(object sender, EventArgs e)
        {
            if (!Valideaza()) return;

            decimal pret = decimal.Parse(tbPretUnitar.Text);

            if (dgvProduse.SelectedRows.Count == 0)
            {
                Produs produsNou = new Produs(idUrm, tbDenumire.Text, pret);
                listaProduse.Add(produsNou);
                try { bd.AdaugaProdus(produsNou); } catch { }
                idUrm++;
            }
            else
            {
                int id = (int)dgvProduse.SelectedRows[0].Cells["Id"].Value;
                Produs produsDeModificat = null;

                foreach (Produs p in listaProduse)
                {
                    if (p.getId_produs() == id)
                    {
                        produsDeModificat = p;
                        break;
                    }
                }

                if (produsDeModificat != null)
                {
                    produsDeModificat.setDenumire(tbDenumire.Text);
                    produsDeModificat.setPretUnitar(pret);
                    try { bd.ModificaProdus(produsDeModificat); } catch { }
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
            if (dgvProduse.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selectati un produs din lista.", "Atentie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = (int)dgvProduse.SelectedRows[0].Cells["Id"].Value;

            foreach (Produs p in listaProduse)
            {
                if (p.getId_produs() == id)
                {
                    tbDenumire.Text = p.getDenumire();
                    tbPretUnitar.Text = p.getPretUnitar().ToString("0.00");
                    break;
                }
            }
        }

        private void btnSterge_Click(object sender, EventArgs e)
        {
            if (dgvProduse.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selectati un produs din lista.", "Atentie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = (int)dgvProduse.SelectedRows[0].Cells["Id"].Value;
            Produs produsDeSters = null;

            foreach (Produs p in listaProduse)
            {
                if (p.getId_produs() == id)
                {
                    produsDeSters = p;
                    break;
                }
            }

            if (produsDeSters != null)
            {
                listaProduse.Remove(produsDeSters);
                try { bd.StergeProdus(id); } catch { }
                SalveazaXml();
                RefreshGrid();
                GolesesteCampuri();
            }
        }

        private void SalveazaXml()
        {
            XElement root = new XElement("Produse");

            foreach (Produs p in listaProduse)
            {
                XElement el = new XElement("Produs",
                    new XElement("Id", p.getId_produs()),
                    new XElement("Denumire", p.getDenumire()),
                    new XElement("PretUnitar", p.getPretUnitar().ToString("0.00"))
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

            foreach (XElement el in doc.Root.Elements("Produs"))
            {
                int id = int.Parse(el.Element("Id").Value);
                string denumire = el.Element("Denumire").Value;
                decimal pret = decimal.Parse(el.Element("PretUnitar").Value);

                listaProduse.Add(new Produs(id, denumire, pret));

                if (id >= idUrm)
                    idUrm = id + 1;
            }
        }

        private void FormProduse_Load_1(object sender, EventArgs e)
        {

        }
    }
}

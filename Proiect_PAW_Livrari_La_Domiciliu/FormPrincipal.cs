using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Proiect_PAW_Livrari_La_Domiciliu
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void menuItemGestionareClienti_Click(object sender, EventArgs e)
        {
            new FormClienti().ShowDialog();
        }

        private void menuItemGestionareComenzi_Click(object sender, EventArgs e)
        {
            new FormComenzi().ShowDialog();
        }

        private void menuItemGestionareProduse_Click(object sender, EventArgs e)
        {
            new FormProduse().ShowDialog();
        }

        private void menuItemGestionareFacturi_Click(object sender, EventArgs e)
        {
            new FormFacturi().ShowDialog();
        }

        private void menuGrafic_Click(object sender, EventArgs e)
        {
            new FormGrafic().ShowDialog();
        }

        private void menuIesire_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            IncarcaCarduriClienti();
        }

        private void IncarcaCarduriClienti()
        {
            flowClienti.Controls.Clear();

            string caleXml = "clienti.xml";
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

                Client client = new Client(id, nume, prenume, email, telefon, adresa);
                ControlClient card = new ControlClient();
                card.SeteazaClient(client);
                card.Margin = new System.Windows.Forms.Padding(6);
                flowClienti.Controls.Add(card);
            }
        }
    }
}

using System;
using System.Windows.Forms;

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

        private void menuIesire_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}

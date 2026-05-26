using System.Windows.Forms;

namespace Proiect_PAW_Livrari_La_Domiciliu
{
    public partial class ControlClient : UserControl
    {
        public ControlClient()
        {
            InitializeComponent();
        }

        public void SeteazaClient(Client client)
        {
            lblNumePrenume.Text = client.getNume() + " " + client.getPrenume();
            lblEmail.Text = "Email: " + client.getEmail();
            lblTelefon.Text = "Telefon: " + client.getTelefon();
            lblAdresa.Text = "Adresa: " + client.getAdresa();
        }

        public void Goleste()
        {
            lblNumePrenume.Text = "";
            lblEmail.Text = "";
            lblTelefon.Text = "";
            lblAdresa.Text = "";
        }
    }
}

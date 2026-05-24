using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_PAW_Livrari_La_Domiciliu
{
    internal class Comanda : ICloneable
    {
        private int id_comanda;
        private int id_client;
        private DateTime dataComanda;
        private string status;
        private string adresaLivrare;

        public Comanda(int id_comanda, int id_client, DateTime dataComanda, string status, string adresaLivrare)
        {
            this.id_comanda = id_comanda;
            this.id_client = id_client;
            this.dataComanda = dataComanda;
            this.status = status;
            this.adresaLivrare = adresaLivrare;
        }

        public int getId_comanda() { return id_comanda; }
        public int getId_client() { return id_client; }
        public DateTime getDataComanda() { return dataComanda; }
        public string getStatus() { return status; }
        public string getAdresaLivrare() { return adresaLivrare; }

        public void setId_comanda(int id_comanda) { this.id_comanda=id_comanda; }
        public void setId_client(int id_client) {  this.id_client=id_client;}
        public void setId_status(string status) { this.status = status; }
        public void setDataComanda(DateTime dataComanda) { this.dataComanda=dataComanda; }
        public void setAdresaLivrare(string adresaLivrare) { this.adresaLivrare=adresaLivrare; }

        public object Clone()
        {
            return new Comanda(id_comanda, id_client, dataComanda, status, adresaLivrare);
        }

        public override string ToString()
        {
            return $"Comanda [ID: {id_comanda}, ID Client: {id_client}, Data: {dataComanda}, Status: {status}, Adresa livrare: {adresaLivrare}]";
        }


    }
}

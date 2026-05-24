using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_PAW_Livrari_La_Domiciliu
{
    internal class LinieComanda : ICloneable
    {
        private int id_linieComanda;
        private int id_comanda;
        private int id_produs;
        private int cantitate;
        private decimal pretUnitar;

        public LinieComanda(int id_linieComanda, int id_comanda, int id_produs, int cantitate, decimal pretUnitar)
        {
            this.id_linieComanda = id_linieComanda;
            this.id_comanda = id_comanda;
            this.id_produs = id_produs;
            this.cantitate = cantitate;
            this.pretUnitar = pretUnitar;
        }

        public int getId_linieComanda() { return id_linieComanda; }
        public int getId_comanda() { return id_comanda; }
        public int getId_produs() { return id_produs; }
        public int getCantitate() { return cantitate; }
        public decimal getPretUnitar() { return pretUnitar; }

        public void setId_linieComanda(int id_linieComanda) { this.id_linieComanda = id_linieComanda; }
        public void setId_comanda(int id_comanda) { this.id_comanda = id_comanda; }
        public void setId_produs(int id_produs) { this.id_produs = id_produs; }
        public void setCantitate(int cantitate) { this.cantitate = cantitate; }
        public void setPretUnitar(decimal pretUnitar) { this.pretUnitar = pretUnitar; }

        public object Clone()
        {
            return new LinieComanda(id_linieComanda, id_comanda, id_produs, cantitate, pretUnitar);
        }

        public override string ToString()
        {
            return $"LinieComanda [ID: {id_linieComanda}, ID Comanda: {id_comanda}, ID Produs: {id_produs}, Cantitate: {cantitate}, Pret unitar: {pretUnitar} RON]";
        }
    }
}

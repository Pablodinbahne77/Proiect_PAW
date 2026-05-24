using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_PAW_Livrari_La_Domiciliu
{
    internal class Factura : ICloneable
    {
        private int id_factura;
        private int id_comanda;
        private DateTime dataEmitere;
        private decimal pretTotal;

        public Factura(int id_factura, int id_comanda, DateTime dataEmitere, decimal pretTotal)
        {
            this.id_factura = id_factura;
            this.id_comanda = id_comanda;
            this.dataEmitere = dataEmitere;
            this.pretTotal = pretTotal;
        }

        public int getId_factura() { return id_factura; }
        public int getId_comanda() { return id_comanda; }
        public DateTime getDataEmitere() { return dataEmitere; }
        public decimal getPretTotal() { return pretTotal; }

        public void setId_factura(int id_factura) { this.id_factura = id_factura; }
        public void setId_comanda(int id_comanda) { this.id_comanda = id_comanda; }
        public void setDataEmitere(DateTime dataEmitere) { this.dataEmitere = dataEmitere; }
        public void setPretTotal(decimal pretTotal) { this.pretTotal = pretTotal; }

        public object Clone()
        {
            return new Factura(id_factura, id_comanda, dataEmitere, pretTotal);
        }

        public override string ToString()
        {
            return $"Factura [ID: {id_factura}, ID Comanda: {id_comanda}, Data emitere: {dataEmitere:dd/MM/yyyy}, Pret total: {pretTotal} RON]";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_PAW_Livrari_La_Domiciliu
{
    internal class Produs : ICloneable
    {
        private int id_produs;
        private string denumire;
        private decimal pretUnitar;

        public Produs(int id_produs, string denumire, decimal pretUnitar)
        {
            this.id_produs = id_produs;
            this.denumire = denumire;
            this.pretUnitar = pretUnitar;
        }

        public int getId_produs() { return id_produs; }
        public string getDenumire() { return denumire; }
        public decimal getPretUnitar() { return pretUnitar; }

        public void setId_produs(int id_produs) { this.id_produs = id_produs; }
        public void setDenumire(string denumire) {  this.denumire = denumire;}
        public void setPretUnitar(decimal pretUntar) { this.pretUnitar = pretUntar;}

        public object Clone()
        {
            return new Produs(id_produs, denumire, pretUnitar);
        }

        public override string ToString()
        {
            return $"Produs [ID: {id_produs}, Denumire: {denumire}, Pret unitar: {pretUnitar} RON]";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_PAW_Livrari_La_Domiciliu
{
    public class Client : ICloneable
    {
        private int id_client;
        private string nume;
        private string prenume;
        private string email;
        private string telefon;
        private string adresa;
    

    public Client(int id_client, string nume, string prenume, string email, string telefon, string adresa)
        {
            this.id_client = id_client;
            this.nume = nume;
            this.prenume = prenume;
            this.email = email;
            this.telefon = telefon;
            this.adresa = adresa;
        }

        public int getIdClient() { return id_client;}
        public string getNume() {return nume;}
        public string getPrenume() {return prenume;}
        public string getEmail() {return email;}
        public string getTelefon() {return telefon;}
        public string getAdresa() {return adresa;}

        public void setNume(string nume) {this.nume = nume;}
        public void setIdClient(int id_client) {this.id_client = id_client;}

        public void setPrenume(string prenume) { this.prenume = prenume;}
        public void setEmail(string email) { this.email = email;}
        public void setTelefon(string telefon) { this.telefon = telefon;}
        public void setAdresa(string adresa) { this.adresa = adresa;}

        public object Clone()
        {
            return new Client(id_client, nume, prenume, email, telefon, adresa);
        }

        public override string ToString()
        {
            return $"Client [ID: {id_client}, Nume: {nume} {prenume}, Email: {email}, Telefon: {telefon}, Adresa: {adresa}]";
        }

    }
}
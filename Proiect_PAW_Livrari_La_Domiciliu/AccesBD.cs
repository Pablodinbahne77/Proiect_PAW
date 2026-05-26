using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Proiect_PAW_Livrari_La_Domiciliu
{
    internal class AccesBD
    {
        private static string connectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=LivrariLaDomiciliu;Integrated Security=True";

        private SqlConnection GetConexiune()
        {
            return new SqlConnection(connectionString);
        }

        // ==================== CLIENTI ====================

        public List<Client> GetAllClienti()
        {
            List<Client> lista = new List<Client>();
            using (SqlConnection con = GetConexiune())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT id_client, nume, prenume, email, telefon, adresa FROM Clienti", con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    lista.Add(new Client(
                        reader.GetInt32(0),
                        reader.GetString(1),
                        reader.GetString(2),
                        reader.GetString(3),
                        reader.GetString(4),
                        reader.GetString(5)
                    ));
                }
            }
            return lista;
        }

        public void AdaugaClient(Client c)
        {
            using (SqlConnection con = GetConexiune())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(
                    "SET IDENTITY_INSERT Clienti ON; " +
                    "INSERT INTO Clienti (id_client, nume, prenume, email, telefon, adresa) VALUES (@id, @nume, @prenume, @email, @telefon, @adresa); " +
                    "SET IDENTITY_INSERT Clienti OFF",
                    con);
                cmd.Parameters.AddWithValue("@id", c.getIdClient());
                cmd.Parameters.AddWithValue("@nume", c.getNume());
                cmd.Parameters.AddWithValue("@prenume", c.getPrenume());
                cmd.Parameters.AddWithValue("@email", c.getEmail());
                cmd.Parameters.AddWithValue("@telefon", c.getTelefon());
                cmd.Parameters.AddWithValue("@adresa", c.getAdresa());
                cmd.ExecuteNonQuery();
            }
        }

        public void ModificaClient(Client c)
        {
            using (SqlConnection con = GetConexiune())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(
                    "UPDATE Clienti SET nume=@nume, prenume=@prenume, email=@email, telefon=@telefon, adresa=@adresa WHERE id_client=@id",
                    con);
                cmd.Parameters.AddWithValue("@id", c.getIdClient());
                cmd.Parameters.AddWithValue("@nume", c.getNume());
                cmd.Parameters.AddWithValue("@prenume", c.getPrenume());
                cmd.Parameters.AddWithValue("@email", c.getEmail());
                cmd.Parameters.AddWithValue("@telefon", c.getTelefon());
                cmd.Parameters.AddWithValue("@adresa", c.getAdresa());
                cmd.ExecuteNonQuery();
            }
        }

        public void StergeClient(int id_client)
        {
            using (SqlConnection con = GetConexiune())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Clienti WHERE id_client=@id", con);
                cmd.Parameters.AddWithValue("@id", id_client);
                cmd.ExecuteNonQuery();
            }
        }

        // ==================== PRODUSE ====================

        public List<Produs> GetAllProduse()
        {
            List<Produs> lista = new List<Produs>();
            using (SqlConnection con = GetConexiune())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT id_produs, denumire, pretUnitar FROM Produse", con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    lista.Add(new Produs(
                        reader.GetInt32(0),
                        reader.GetString(1),
                        reader.GetDecimal(2)
                    ));
                }
            }
            return lista;
        }

        public void AdaugaProdus(Produs p)
        {
            using (SqlConnection con = GetConexiune())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(
                    "SET IDENTITY_INSERT Produse ON; " +
                    "INSERT INTO Produse (id_produs, denumire, pretUnitar) VALUES (@id, @denumire, @pret); " +
                    "SET IDENTITY_INSERT Produse OFF",
                    con);
                cmd.Parameters.AddWithValue("@id", p.getId_produs());
                cmd.Parameters.AddWithValue("@denumire", p.getDenumire());
                cmd.Parameters.AddWithValue("@pret", p.getPretUnitar());
                cmd.ExecuteNonQuery();
            }
        }

        public void ModificaProdus(Produs p)
        {
            using (SqlConnection con = GetConexiune())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(
                    "UPDATE Produse SET denumire=@denumire, pretUnitar=@pret WHERE id_produs=@id",
                    con);
                cmd.Parameters.AddWithValue("@id", p.getId_produs());
                cmd.Parameters.AddWithValue("@denumire", p.getDenumire());
                cmd.Parameters.AddWithValue("@pret", p.getPretUnitar());
                cmd.ExecuteNonQuery();
            }
        }

        public void StergeProdus(int id_produs)
        {
            using (SqlConnection con = GetConexiune())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Produse WHERE id_produs=@id", con);
                cmd.Parameters.AddWithValue("@id", id_produs);
                cmd.ExecuteNonQuery();
            }
        }

        // ==================== COMENZI ====================

        public List<Comanda> GetAllComenzi()
        {
            List<Comanda> lista = new List<Comanda>();
            using (SqlConnection con = GetConexiune())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT id_comanda, id_client, dataComanda, status, adresaLivrare FROM Comenzi", con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    lista.Add(new Comanda(
                        reader.GetInt32(0),
                        reader.GetInt32(1),
                        reader.GetDateTime(2),
                        reader.GetString(3),
                        reader.GetString(4)
                    ));
                }
            }
            return lista;
        }

        public void AdaugaComanda(Comanda c)
        {
            using (SqlConnection con = GetConexiune())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(
                    "SET IDENTITY_INSERT Comenzi ON; " +
                    "INSERT INTO Comenzi (id_comanda, id_client, dataComanda, status, adresaLivrare) VALUES (@id, @id_client, @data, @status, @adresa); " +
                    "SET IDENTITY_INSERT Comenzi OFF",
                    con);
                cmd.Parameters.AddWithValue("@id", c.getId_comanda());
                cmd.Parameters.AddWithValue("@id_client", c.getId_client());
                cmd.Parameters.AddWithValue("@data", c.getDataComanda());
                cmd.Parameters.AddWithValue("@status", c.getStatus());
                cmd.Parameters.AddWithValue("@adresa", c.getAdresaLivrare());
                cmd.ExecuteNonQuery();
            }
        }

        public void ModificaComanda(Comanda c)
        {
            using (SqlConnection con = GetConexiune())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(
                    "UPDATE Comenzi SET id_client=@id_client, dataComanda=@data, status=@status, adresaLivrare=@adresa WHERE id_comanda=@id",
                    con);
                cmd.Parameters.AddWithValue("@id", c.getId_comanda());
                cmd.Parameters.AddWithValue("@id_client", c.getId_client());
                cmd.Parameters.AddWithValue("@data", c.getDataComanda());
                cmd.Parameters.AddWithValue("@status", c.getStatus());
                cmd.Parameters.AddWithValue("@adresa", c.getAdresaLivrare());
                cmd.ExecuteNonQuery();
            }
        }

        public void StergeComanda(int id_comanda)
        {
            using (SqlConnection con = GetConexiune())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Comenzi WHERE id_comanda=@id", con);
                cmd.Parameters.AddWithValue("@id", id_comanda);
                cmd.ExecuteNonQuery();
            }
        }

        // ==================== LINII COMANDA ====================

        public List<LinieComanda> GetLiniiByComanda(int id_comanda)
        {
            List<LinieComanda> lista = new List<LinieComanda>();
            using (SqlConnection con = GetConexiune())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(
                    "SELECT id_linieComanda, id_comanda, id_produs, cantitate, pretUnitar FROM LiniiComanda WHERE id_comanda=@id",
                    con);
                cmd.Parameters.AddWithValue("@id", id_comanda);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    lista.Add(new LinieComanda(
                        reader.GetInt32(0),
                        reader.GetInt32(1),
                        reader.GetInt32(2),
                        reader.GetInt32(3),
                        reader.GetDecimal(4)
                    ));
                }
            }
            return lista;
        }

        public List<LinieComanda> GetAllLiniiComanda()
        {
            List<LinieComanda> lista = new List<LinieComanda>();
            using (SqlConnection con = GetConexiune())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT id_linieComanda, id_comanda, id_produs, cantitate, pretUnitar FROM LiniiComanda", con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    lista.Add(new LinieComanda(
                        reader.GetInt32(0),
                        reader.GetInt32(1),
                        reader.GetInt32(2),
                        reader.GetInt32(3),
                        reader.GetDecimal(4)
                    ));
                }
            }
            return lista;
        }

        public void AdaugaLinieComanda(LinieComanda l)
        {
            using (SqlConnection con = GetConexiune())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(
                    "SET IDENTITY_INSERT LiniiComanda ON; " +
                    "INSERT INTO LiniiComanda (id_linieComanda, id_comanda, id_produs, cantitate, pretUnitar) VALUES (@id, @id_comanda, @id_produs, @cantitate, @pret); " +
                    "SET IDENTITY_INSERT LiniiComanda OFF",
                    con);
                cmd.Parameters.AddWithValue("@id", l.getId_linieComanda());
                cmd.Parameters.AddWithValue("@id_comanda", l.getId_comanda());
                cmd.Parameters.AddWithValue("@id_produs", l.getId_produs());
                cmd.Parameters.AddWithValue("@cantitate", l.getCantitate());
                cmd.Parameters.AddWithValue("@pret", l.getPretUnitar());
                cmd.ExecuteNonQuery();
            }
        }

        public void StergeLinieComanda(int id_linieComanda)
        {
            using (SqlConnection con = GetConexiune())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM LiniiComanda WHERE id_linieComanda=@id", con);
                cmd.Parameters.AddWithValue("@id", id_linieComanda);
                cmd.ExecuteNonQuery();
            }
        }

        public void StergeLiniiByComanda(int id_comanda)
        {
            using (SqlConnection con = GetConexiune())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM LiniiComanda WHERE id_comanda=@id", con);
                cmd.Parameters.AddWithValue("@id", id_comanda);
                cmd.ExecuteNonQuery();
            }
        }

        // ==================== GRAFIC ====================

        public Dictionary<string, int> GetTopProduseVandute()
        {
            Dictionary<string, int> rezultat = new Dictionary<string, int>();
            using (SqlConnection con = GetConexiune())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(
                    "SELECT p.denumire, SUM(lc.cantitate) AS totalVandut " +
                    "FROM LiniiComanda lc " +
                    "JOIN Produse p ON lc.id_produs = p.id_produs " +
                    "GROUP BY p.id_produs, p.denumire " +
                    "ORDER BY totalVandut DESC",
                    con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    rezultat[reader.GetString(0)] = reader.GetInt32(1);
                }
            }
            return rezultat;
        }

        // ==================== FACTURI ====================

        public List<Factura> GetAllFacturi()
        {
            List<Factura> lista = new List<Factura>();
            using (SqlConnection con = GetConexiune())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT id_factura, id_comanda, dataEmitere, pretTotal FROM Facturi", con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    lista.Add(new Factura(
                        reader.GetInt32(0),
                        reader.GetInt32(1),
                        reader.GetDateTime(2),
                        reader.GetDecimal(3)
                    ));
                }
            }
            return lista;
        }

        public void AdaugaFactura(Factura f)
        {
            using (SqlConnection con = GetConexiune())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(
                    "SET IDENTITY_INSERT Facturi ON; " +
                    "INSERT INTO Facturi (id_factura, id_comanda, dataEmitere, pretTotal) VALUES (@id, @id_comanda, @data, @pret); " +
                    "SET IDENTITY_INSERT Facturi OFF",
                    con);
                cmd.Parameters.AddWithValue("@id", f.getId_factura());
                cmd.Parameters.AddWithValue("@id_comanda", f.getId_comanda());
                cmd.Parameters.AddWithValue("@data", f.getDataEmitere());
                cmd.Parameters.AddWithValue("@pret", f.getPretTotal());
                cmd.ExecuteNonQuery();
            }
        }

        public void ModificaFactura(Factura f)
        {
            using (SqlConnection con = GetConexiune())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(
                    "UPDATE Facturi SET id_comanda=@id_comanda, dataEmitere=@data, pretTotal=@pret WHERE id_factura=@id",
                    con);
                cmd.Parameters.AddWithValue("@id", f.getId_factura());
                cmd.Parameters.AddWithValue("@id_comanda", f.getId_comanda());
                cmd.Parameters.AddWithValue("@data", f.getDataEmitere());
                cmd.Parameters.AddWithValue("@pret", f.getPretTotal());
                cmd.ExecuteNonQuery();
            }
        }

        public void StergeFactura(int id_factura)
        {
            using (SqlConnection con = GetConexiune())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Facturi WHERE id_factura=@id", con);
                cmd.Parameters.AddWithValue("@id", id_factura);
                cmd.ExecuteNonQuery();
            }
        }
    }
}

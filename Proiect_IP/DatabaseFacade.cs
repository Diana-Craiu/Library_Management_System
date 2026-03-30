/**************************************************************************
 *                                                                        *
 *  File:        Admin.cs                                                 *
 *  Copyright:   (c) 2023, Avdei Elena, Craiu Diana-Mihaela,              *
 *                         Ciubotaru Mara-Elena, Loghin Bianca            *
 *  E-mail:      elena.avdei@student.tuiasi.ro                            *
 *               diana-mihaela.craiu@student.tuiasi.ro                    *
 *               mara-elena.ciubotaru@student.tuiasi.ro                   *
 *               bianca.loghin@student.tuiasi.ro                          *
 *  Description: Aplicatie despre gestionarea unei biblioteci             *
 *                                                                        *
 *  This code and information is provided "as is" without warranty of     *
 *  any kind, either expressed or implied, including but not limited      *
 *  to the implied warranties of merchantability or fitness for a         *
 *  particular purpose. You are free to use this source code in your      *
 *  applications as long as the original copyright notice is included.    *
 *                                                                        *
 **************************************************************************/

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_IP
{
    /// <summary>
    /// Gestionarea interacțiunii cu baza de date în cadrul aplicației si furnizarea metodelor pentru adăugarea, ștergerea și actualizarea datelor referitoare la cărți și utilizatori în baza de date utilizand un design de tip Fatada si Singleton.
    /// </summary>
    public class DatabaseFacade
    {
        //Instanta de tip Singleton a clasei DatabaseFacade
        private static readonly DatabaseFacade instance = new DatabaseFacade();

        //Conexiunea cu baza de date
        private readonly SqlConnection _connection;

        /// <summary>
        /// Constructorul privat al clasei.
        /// </summary>
        private DatabaseFacade()
        {
            //Conexiune cu baza de date
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\FACULTATE\ANUL 3\SEMESTRUL 2\IP\PROIECT_IP\PROIECT_IP\DATABASE.MDF;Integrated Security=True";
            _connection = new SqlConnection(connectionString);
        }

        /// <summary>
        /// Proprietatea publica pentru a accesa instanta de tip Singleton
        /// </summary>
        public static DatabaseFacade GetInstance
        {
            get { return instance; }
        }

        /// <summary>
        /// Proprietatea publica pentru a accesa conexiunea la baza de date
        /// </summary>
        public SqlConnection Connection
        {
            get { return _connection; }
        }

        /// <summary>
        /// Metoda pentru adăugarea unei cărți în baza de date
        /// </summary>
        /// <param name="titlu"></param>
        /// <param name="autor"></param>
        /// <param name="isbn"></param>
        /// <param name="editura"></param>
        /// <param name="gen"></param>
        /// <param name="status"></param>
        /// <param name="nr_ex"></param>
        public void AddBook(string titlu, string autor, double isbn, string editura, string gen, string status, double nr_ex)
        {
            try
            {
                    //Deschiderea unei noi conexiuni si executarea interogarii
                    using (SqlCommand command = new SqlCommand("INSERT INTO Carti (ISBN, Titlu, Autor, Editura, Gen, Status, Nr_exemplare) " +
                    "VALUES (@ISBN, @Titlu, @Autor, @Editura, @Gen, @Status, @Nr_exemplare)", _connection))
                {
                    //Setarea valorilor parametrilor 
                    command.Parameters.AddWithValue("@ISBN", isbn);
                    command.Parameters.AddWithValue("@Titlu", titlu);
                    command.Parameters.AddWithValue("@Autor", autor);
                    command.Parameters.AddWithValue("@Editura", editura);
                    command.Parameters.AddWithValue("@Gen", gen);
                    command.Parameters.AddWithValue("@Status", status);
                    command.Parameters.AddWithValue("@Nr_exemplare", nr_ex);

                    //Deschiderea conexiunii cu baza de date, se executa comanda si se inchide conexiunea
                    _connection.Open();
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                // Handle the exception or throw it to be handled elsewhere
                throw new Exception("Error adding book to the database.", ex);
            }
            finally
            {
                _connection.Close();
            }
        }

        /// <summary>
        /// Metoda pentru ștergerea unei cărți din baza de date
        /// </summary>
        /// <param name="isbn"></param>
        public void DeleteBook(double isbn)
        {
            try { 
            //Deschiderea unei noi conexiuni si executarea interogarii
                using (SqlCommand command = new SqlCommand("DELETE FROM Carti WHERE ISBN = @ISBN", _connection))
                {
                    //Setarea valorilor parametrilor
                    command.Parameters.AddWithValue("@ISBN", isbn);

                    //Deschiderea conexiunii cu baza de date, se executa comanda si se inchide conexiunea
                    _connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected == 0)
                    {
                        throw new Exception("No book with the given ISBN exists in the database.");
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle the exception or throw it to be handled elsewhere
                throw new Exception("Error deleting book from the database.", ex);
            }
            finally
            {
                _connection.Close();
            }
        }

        /// <summary>
        /// Metoda pentru actualizarea statusului unei cărți în baza de date
        /// </summary>
        /// <param name="isbn"></param>
        /// <param name="status"></param>
        public void UpdateBookStatus(double isbn, string status)
        {
            try
            {
                if (isbn < 0)
                {
                    throw new Exception("Invalid ISBN provided.");
                }

                //Deschiderea unei noi conexiuni si executarea interogarii
                using (SqlCommand command = new SqlCommand("UPDATE Carti SET Status = @Status WHERE ISBN = @ISBN", _connection))
                {
                    //Setarea valorilor parametrilor
                    command.Parameters.AddWithValue("@Status", status);
                    command.Parameters.AddWithValue("@ISBN", isbn);

                    //Deschiderea conexiunii cu baza de date, se executa comanda si se inchide conexiunea
                    _connection.Open();
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error updating book status in the database.", ex);
            }
            finally
            {
                _connection.Close();
            }
        }

        /// <summary>
        /// Metoda pentru actualizarea numărului de exemplare al unei cărți în baza de date
        /// </summary>
        /// <param name="isbn"></param>
        /// <param name="nr_ex"></param>
        public void UpdateBookNrExemplare(double isbn, double nr_ex)
        {
            try {
                if (nr_ex < 0)
                {
                    throw new Exception("The quantity cannot be negative.");
                }
                //Deschiderea unei noi conexiuni si executarea interogarii
                using (SqlCommand command = new SqlCommand("UPDATE Carti SET Nr_exemplare = @Nr_exemplare WHERE ISBN = @ISBN", _connection))
                {
                    //Setarea valorilor parametrilor
                    command.Parameters.AddWithValue("@Nr_exemplare", nr_ex);
                    command.Parameters.AddWithValue("@ISBN", isbn);

                    //Deschiderea conexiunii cu baza de date, se executa comanda si se inchide conexiunea
                    _connection.Open();
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error updating book quantity in the database.", ex);
            }
            finally
            {
                _connection.Close();
            }
        }

        /// <summary>
        /// Metoda pentru adăugarea unui utilizator în baza de date
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nume"></param>
        /// <param name="prenume"></param>
        /// <param name="telefon"></param>
        /// <param name="nrCartiImprumutate"></param>
        /// <param name="penalizari"></param>
        /// <param name="blocat"></param>
        public void AddUser(double id, string nume, string prenume, double telefon, int nrCartiImprumutate, int penalizari, string blocat)
        {
            try
            {

            
                //Deschiderea unei noi conexiuni si executarea interogarii
                using (SqlCommand command = new SqlCommand("INSERT INTO Utilizatori (ID, Nume, Prenume, Telefon, Nr_Imprumutate, Penalizari, Blocat) " +
                    "VALUES (@ID, @Nume, @Prenume, @Telefon, @NrCartiImprumutate, @Penalizari, @Blocat)", _connection))
                {
                    //Setarea valorilor parametrilor
                    command.Parameters.AddWithValue("@ID", id);
                    command.Parameters.AddWithValue("@Nume", nume);
                    command.Parameters.AddWithValue("@Prenume", prenume);
                    command.Parameters.AddWithValue("@Telefon", telefon);
                    command.Parameters.AddWithValue("@NrCartiImprumutate", nrCartiImprumutate);
                    command.Parameters.AddWithValue("@Penalizari", penalizari);
                    command.Parameters.AddWithValue("@Blocat", blocat);

                    //Deschiderea conexiunii cu baza de date, se executa comanda si se inchide conexiunea
                    _connection.Open();
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error adding user to the database.", ex);
            }
            finally
            {
                _connection.Close();
            }
        }

        /// <summary>
        /// Metoda pentru ștergerea unui utilizator din baza de date
        /// </summary>
        /// <param name="id"></param>
        public void DeleteUser(double id)
        {
            try
            {
                //Deschiderea unei noi conexiuni si executarea interogarii
                using (SqlCommand command = new SqlCommand("DELETE FROM Utilizatori WHERE ID = @ID", _connection))
                {
                    //Setarea valorilor parametrilor
                    command.Parameters.AddWithValue("@ID", id);

                    //Deschiderea conexiunii cu baza de date, se executa comanda si se inchide conexiunea
                    _connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected == 0)
                    {
                        throw new Exception("No user with the given ID exists in the database.");
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error deleting user from the database.", ex);
            }
            finally
            {
                _connection.Close();
            }
        }

        /// <summary>
        /// Metoda pentru actualizarea statusului unui utilizator în baza de date
        /// </summary>
        /// <param name="id"></param>
        /// <param name="blocat"></param>
        public void UpdateUserStatus(double id, string blocat)
        {
            try 
            {
                if (id <= 0)
                {
                    throw new Exception("Invalid user ID provided.");
                }
                //Deschiderea unei noi conexiuni si executarea interogarii
                using (SqlCommand command = new SqlCommand("UPDATE Utilizatori SET Blocat = @Blocat WHERE ID = @ID", _connection))
                {
                    //Setarea valorilor parametrilor
                    command.Parameters.AddWithValue("@Blocat", blocat);
                    command.Parameters.AddWithValue("@ID", id);

                    //Deschiderea conexiunii cu baza de date, se executa comanda si se inchide conexiunea
                    _connection.Open();
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error updating user status in the database.", ex);
            }
            finally
            {
                _connection.Close();
            }
        }

        /// <summary>
        /// Metoda pentru actualizarea numărului de penalizări al unui utilizator în baza de date
        /// </summary>
        /// <param name="id"></param>
        /// <param name="penalizari"></param>
        public void UpdateUserPenalizari(double id, int penalizari)
        {
            try
            {
                if (id <= 0 || penalizari<=0)
                {
                    throw new Exception("Invalid user ID or number provided.");
                }
                //Deschiderea unei noi conexiuni si executarea interogarii
                using (SqlCommand command = new SqlCommand("UPDATE Utilizatori SET Penalizari = @Penalizari WHERE ID = @ID", _connection))
                {
                    //Setarea valorilor parametrilor
                    command.Parameters.AddWithValue("@Penalizari", penalizari);
                    command.Parameters.AddWithValue("@ID", id);

                    //Deschiderea conexiunii cu baza de date, se executa comanda si se inchide conexiunea
                    _connection.Open();
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error updating user penalties in the database.", ex);
            }
            finally
            {
                _connection.Close();
            }
        }

        /// <summary>
        /// Metoda pentru obținerea numărului de penalizări al unui utilizator din baza de date
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int GetUserPenalizari(double id)
        {
            try
            {
                int penalizari = 0;

                //Conexiune string cu baza de date
                string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\FACULTATE\ANUL 3\SEMESTRUL 2\IP\PROIECT_IP\PROIECT_IP\DATABASE.MDF;Integrated Security=True";

                //Interogare pentru a prelua penalizarea utilizatorului cu ID-ul dat
                string queryString = $"SELECT Penalizari FROM Utilizatori WHERE ID = {id}";

                //Deschiderea unei noi conexiuni si executarea interogarii
                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(queryString, connection))
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    //Se citeste rezultatul si analizarea valorii penalizarii
                    while (reader.Read())
                    {
                        int.TryParse(reader["Penalizari"].ToString(), out penalizari);
                    }
                    reader.Close();
                }
                return penalizari;
            }
            catch (Exception ex)
            {
                throw new Exception("Error retrieving user penalties from the database.", ex);
            }
            finally
            {
                _connection.Close();
            }
        }

        /// <summary>
        /// Metoda pentru obținerea statusului unui utilizator din baza de date
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public string GetUserStatus(double id)
        {
            try 
            { 
                string status = "";

                //Conexiune string cu baza de date
                string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\FACULTATE\ANUL 3\SEMESTRUL 2\IP\PROIECT_IP\PROIECT_IP\DATABASE.MDF;Integrated Security=True";

                //Interogare pentru a prelua status-ul utilizatorului cu ID-ul dat
                string queryString = $"SELECT Blocat FROM Utilizatori WHERE ID = {id}";

                //Deschiderea unei noi conexiuni si executarea interogarii
                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(queryString, connection))
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    //Se citeste rezultatul si analizarea valorii status-ului
                    while (reader.Read())
                    {
                        status = reader["Blocat"].ToString();
                    }
                    reader.Close();
                }
                return status;
            }
            catch (Exception ex)
            {
                throw new Exception("Error retrieving user status from the database.", ex);
            }
            finally
            {
                _connection.Close();
            }
        }

        /// <summary>
        /// Metoda pentru obținerea statusului unei cărți din baza de date
        /// </summary>
        /// <param name="isbn"></param>
        /// <returns></returns>
        public string GetBookStatus(double isbn)
        {
            try 
            { 
                string status = "";

                //Conexiune string cu baza de date
                string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\FACULTATE\ANUL 3\SEMESTRUL 2\IP\PROIECT_IP\PROIECT_IP\DATABASE.MDF;Integrated Security=True";

                //Interogare pentru a prelua status-ul cartii cu ISBN-ul dat
                string queryString = $"SELECT Status FROM Carti WHERE ISBN = {isbn}";

                //Deschiderea unei noi conexiuni si executarea interogarii
                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(queryString, connection))
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    //Se citeste rezultatul si analizarea valorii status-ului
                    while (reader.Read())
                    {
                        status = reader["Status"].ToString();
                    }
                    reader.Close();
                }
                return status;
            }
            catch (Exception ex)
            {
                throw new Exception("Error retrieving books from the database.", ex);
            }
            finally
            {
                _connection.Close();
            }
        }
        /// <summary>
        /// Metoda pentru obținerea numărului de cărți imprumutate de un utilizator din baza de date
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int GetUserNr_imprumutat(double id)
        {
            try 
            { 
                int imprumutate = 0;

                //Conexiune string cu baza de date
                string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\FACULTATE\ANUL 3\SEMESTRUL 2\IP\PROIECT_IP\PROIECT_IP\DATABASE.MDF;Integrated Security=True";
                //Interogare pentru a prelua numarul de carti imprumutate de un utilizator cu ID - ul dat
                string queryString = $"SELECT Nr_Imprumutate FROM Utilizatori WHERE ID = {id}";

                //Deschiderea unei noi conexiuni si executarea interogarii
                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(queryString, connection))
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    //Se citeste rezultatul si analizarea valorii numarului de carti imprumutate
                    while (reader.Read())
                    {
                        int.TryParse(reader["Nr_Imprumutate"].ToString(), out imprumutate);
                    }
                    reader.Close();
                }
                return imprumutate;
            }
            catch (Exception ex)
            {
                throw new Exception("Error retrieving users from the database.", ex);
            }
            finally
            {
                _connection.Close();
            }
        }

        /// <summary>
        /// Metoda pentru obținerea numărului de exemplare al unei cărți din baza de date
        /// </summary>
        /// <param name="isbn"></param>
        /// <returns></returns>
        public int GetBookNr_exemplare(double isbn)
        {
            try
            {

                int exemplare = 0;

                //Conexiune string cu baza de date
                string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\FACULTATE\ANUL 3\SEMESTRUL 2\IP\PROIECT_IP\PROIECT_IP\DATABASE.MDF;Integrated Security=True";

                //Interogare pentru a prelua numarul de exemplare a unei carti cu ISBN - ul dat
                string queryString = $"SELECT Nr_exemplare FROM Carti WHERE ISBN = {isbn}";

                //Deschiderea unei noi conexiuni si executarea interogarii
                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(queryString, connection))
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    //Se citeste rezultatul si analizarea valorii numarului de exemplare
                    while (reader.Read())
                    {
                        int.TryParse(reader["Nr_exemplare"].ToString(), out exemplare);
                    }
                    reader.Close();
                }
                return exemplare;
            }
            catch (Exception ex)
            {
                throw new Exception("Error retrieving nr_exemplare from the database.", ex);
            }
            finally
            {
                _connection.Close();
            }
        }

        /// <summary>
        /// Metoda pentru actualizarea numărului de cărți imprumutate ale unui utilizator în baza de date
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nr_impr"></param>
        public void UpdateUserNrImprumutat(double id, double nr_impr)
        {
            try
            {
                if (id <= 0 || nr_impr <= 0)
                {
                    throw new Exception("Invalid user ID or number provided.");
                }
                //Deschiderea unei noi conexiuni si executarea interogarii
                using (SqlCommand command = new SqlCommand("UPDATE Utilizatori SET Nr_Imprumutate = @Nr_Imprumutate WHERE ID = @ID", _connection))
                {
                    //Setarea valorilor parametrilor
                    command.Parameters.AddWithValue("@Nr_Imprumutate", nr_impr);
                    command.Parameters.AddWithValue("@ID", id);

                    //Deschiderea conexiunii cu baza de date, se executa comanda si se inchide conexiunea
                    _connection.Open();
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error retrieving updating users from the database.", ex);
            }
            finally
            {
                _connection.Close();
            }
        }

        /// <summary>
        /// Metoda pentru închiderea conexiunii cu baza de date
        /// </summary>
        public void CloseConnection()
        {
            if (_connection != null && _connection.State != System.Data.ConnectionState.Closed)
            {
                //Se inchide conexiunea
                _connection.Close();
            }
        }
    }
}

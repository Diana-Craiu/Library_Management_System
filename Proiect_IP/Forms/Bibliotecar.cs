using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_IP
{
    public partial class Biblio : Form
    {
        public Biblio()
        {
            InitializeComponent();
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            //Creeaza o noua instanta a form-ului Inregistrare
            Inregistrare inregistrare = new Inregistrare();

            //Ascunde form-ul curent(Biblio)
            this.Hide();

            //Afiseaza form-ul Inregistrare 
            inregistrare.ShowDialog();

            //Inchide form-ul curent
            this.Close();
        }
        private void ImprumutaButton_Click(object sender, EventArgs e)
        {
            try
            {
                //Preluarea id-ului si isbn-ului de pe form-ul asociat
                double id = Convert.ToDouble(IDpersBox.Text);
                double isbn = Convert.ToDouble(ISBNBox.Text);
                Bibliot bibliotecar = new Bibliot();

                //Preluarea statusul user-ului si a cartii din clasa Bibliot
                string userStatus = bibliotecar.GetUserStatus(id);
                string bookStatus = bibliotecar.GetBookStatus(isbn);

                //Preluarea numarului de carti imprumutate de utilizator si numarul de carti disponibile
                int imprumutate = bibliotecar.GetUserNr_imprumutat(id);
                int exemplare = bibliotecar.GetBookNr_exemplare(isbn);

                //Verificarea statusul utilizatorului si a cartii, si de asemenea numarul de carti imprumutate si copii disponibile
                if (imprumutate == 5)
                {
                    MessageBox.Show("S-a atins limita cartilor imprumutate!");
                    IDpersBox.Clear();
                    ISBNBox.Clear();
                    numeBox.Clear();
                    prenumeBox.Clear();
                    return;

                }
                else
                {
                    if (exemplare == 0)
                    {
                        MessageBox.Show("Nu mai sunt exemplare disponibile!");
                        IDpersBox.Clear();
                        ISBNBox.Clear();
                        numeBox.Clear();
                        prenumeBox.Clear();
                        return;

                    }
                    else
                    {
                        if (userStatus.Trim().Equals("DA", StringComparison.OrdinalIgnoreCase))
                        {
                            MessageBox.Show("Utilizatorul este blocat. Nu s-a putut realiza imprumutul!");
                            IDpersBox.Clear();
                            ISBNBox.Clear();
                            numeBox.Clear();
                            prenumeBox.Clear();
                            return;
                        }
                        else
                        {
                            if (bookStatus.Trim().Equals("Sala de lectura", StringComparison.OrdinalIgnoreCase))
                            {
                                MessageBox.Show("Exemplarul este disponibil doar pentru sala de lectura!");
                                IDpersBox.Clear();
                                ISBNBox.Clear();
                                numeBox.Clear();
                                prenumeBox.Clear();
                                return;
                            }
                        }
                    }
                }

                //Se actualizeaza numarul de carti imprumutate si numarul de copii disponibile
                if (imprumutate < 5 && userStatus.Trim().Equals("NU", StringComparison.OrdinalIgnoreCase))
                {
                    imprumutate++;
                    bibliotecar.UpdateUserNrImprumutat(id, imprumutate);
                    MessageBox.Show("Imprumutare realizata cu success!");
                }
                if (exemplare > 0 && bookStatus.Trim().Equals("Imprumutat", StringComparison.OrdinalIgnoreCase))
                {
                    exemplare--;
                    bibliotecar.UpdateBookNrExemplare(isbn, exemplare);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "A aparut o eroare la imprumutarea cartii!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //Eliberarea campurilor
            IDpersBox.Clear();
            ISBNBox.Clear();
            numeBox.Clear();
            prenumeBox.Clear();
        }
        private void RestituieButton_Click(object sender, EventArgs e)
        {
            try
            {
                //Preluarea id-ului si isbn-ului de pe form-ul asociat
                double id = Convert.ToDouble(IDpersBox.Text);
                double isbn = Convert.ToDouble(ISBNBox.Text);

                Bibliot bibliotecar = new Bibliot();

                //Preluarea numarului de carti imprumutate de utilizator si numarul de carti disponibile
                int imprumutate = bibliotecar.GetUserNr_imprumutat(id);
                int exemplare = bibliotecar.GetBookNr_exemplare(isbn);

                //Se actualizeaza numarul de carti imprumutate si numarul de copii disponibile
                if (imprumutate <= 5 && imprumutate > 0)
                {
                    imprumutate--;
                    bibliotecar.UpdateUserNrImprumutat(id, imprumutate);
                    exemplare++;
                    bibliotecar.UpdateBookNrExemplare(isbn, exemplare);
                    MessageBox.Show("Restituirea realizata cu success!");
                }
                if (imprumutate == 0)
                {
                    MessageBox.Show("Utilizatorul nu mai are carti de restituit!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "A aparut o eroare la restituirea cartii!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //Eliberarea campurilor
            IDpersBox.Clear();
            ISBNBox.Clear();
            numeBox.Clear();
            prenumeBox.Clear();

        }

        private void Biblio_Load(object sender, EventArgs e)
        {
            try
            {
                //Instantierea a DatabaseFacade
                DatabaseFacade database = DatabaseFacade.GetInstance;

                //Preia datele din tabela Carti si le afiseaza in form-uri
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Carti", database.Connection);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cartiGridView.DataSource = dt;

                //Preia datele din tabela Utilizatori si le afiseaza in form-uri
                SqlDataAdapter da2 = new SqlDataAdapter("SELECT * FROM Utilizatori", database.Connection);
                DataTable dt2 = new DataTable();
                da2.Fill(dt2);
                userGridView.DataSource = dt2;

                //Inchiderea conexiunii
                database.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}

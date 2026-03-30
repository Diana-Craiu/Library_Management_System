using Proiect_IP.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_IP
{
    public partial class Administrator : Form
    {
        public Administrator()
        {
            InitializeComponent();
        }

        private void deleteCarteLabel_Click(object sender, EventArgs e)
        {

        }

        private void statusButton_Click(object sender, EventArgs e)
        {
            //Se deschide form-ul Status
            Status status = new Status();
            status.ShowDialog();
        }

        private void listaAbonatiButton_Click(object sender, EventArgs e)
        {
            //Se deschide form-ul Abonati
            Abonati abonati = new Abonati();
            abonati.ShowDialog();
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            //Se deschide form-ul Inregistrare si se inchide form-ul curent
            Inregistrare inregistrare = new Inregistrare();
            this.Hide();
            inregistrare.ShowDialog();
            this.Close();
        }

        private void AddCarteButton_Click(object sender, EventArgs e)
        {
            //Se preiau detaliile cartii din form-ul asociat
            double isbn = Convert.ToDouble(addISBNBox.Text);
            string titlu = titluBox.Text;
            string autor = autorBox.Text;
            string editura = edituraBox.Text;
            string gen = genBox.Text;

            try
            {
                Admin admin = new Admin();

                //Adauga cartea in baza de date
                admin.AddBook(titlu, autor, isbn, editura, gen, "", 0);

                MessageBox.Show("Cartea s-a adaugat cu succes!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "A aparut o eroare la adaugarea cartii!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //Elibereaza campurile
            addISBNBox.Clear();
            titluBox.Clear();
            autorBox.Clear();
            edituraBox.Clear();
            genBox.Clear();
        }

        private void DeleteCarteButton_Click(object sender, EventArgs e)
        {
            //Preia isbn-ul din form-ul asociat
            double isbn = Convert.ToDouble(deleteCarteBox.Text);

            try
            {
                Admin admin = new Admin();

                //Sterge cartea din baza de date
                admin.DeleteBook(isbn);

                MessageBox.Show("Cartea s-a sters cu succes!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("A aparut o eroare la stergerea cartii!", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //Elibereaza campul
            deleteCarteBox.Clear();
        }

        private void DeletePersButton_Click(object sender, EventArgs e)
        {
            //Preia id-ul din form-ul asociat
            double id = Convert.ToDouble(deletePersBox.Text);

            try
            {
                Admin admin = new Admin();

                //Sterge utilizatorul din baza de date
                admin.DeleteUser(id);

                MessageBox.Show("Utilizatorul s-a sters cu succes!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("A aparut o eroare la stergerea utilizatorului!", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //Elibereaza campul
            deletePersBox.Clear();
        }

        private void ContPersAuxbutton_Click(object sender, EventArgs e)
        {
            //Deschide form-ul ContAngajati
            ContAngajati abonati = new ContAngajati();
            abonati.ShowDialog();
        }

        private void addPersbutton_Click(object sender, EventArgs e)
        {
            //Preia detaliile utilizatorului din form-ul asociat
            double id = Convert.ToDouble(idTextBox.Text);
            string nume = numeTextBox.Text;
            string prenume = prenumeTextBox.Text;
            double telefon = Convert.ToDouble(telefonTextBox.Text);

            try
            {
                Admin admin = new Admin();

                //Adauga utilizatorul in baza de date
                admin.AddUser(id, nume, prenume, telefon, 0, 0, "NU");

                MessageBox.Show("Utilizatorul s-a adaugat cu succes!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "A aparut o eroare la adaugarea utilizator!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //Elibereaza campurile
            idTextBox.Clear();
            numeTextBox.Clear();
            prenumeTextBox.Clear();
            telefonTextBox.Clear();
        }
    }
}

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
    public partial class Inregistrare : Form
    {
        private LoginManager _loginManager;
        public Inregistrare()
        {
            InitializeComponent();
            _loginManager = new LoginManager();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void logInButton_Click(object sender, EventArgs e)
        {
            try
            {
                string username = usernameBox.Text;
                string password = passwordBox.Text;

                //Incercarea de inregistrare cu numele si parloa date
                if (_loginManager.Login(username, password))
                {
                    //Testarea nivelului de acces a utilizatorului logat
                    switch (_loginManager.CurrentAccessLevel())
                    {
                        case 1:
                            //Daca utilizatorul este administrator, se va deschide form-ul Administrator
                            Administrator admin = new Administrator();
                            this.Hide();
                            admin.ShowDialog();
                            this.Close();
                            break;
                        case 0:
                            //Daca utilizatorul este bibliotecar, se va deschide form-ul Biblio
                            Biblio bibliotecar = new Biblio();
                            this.Hide();
                            bibliotecar.ShowDialog();
                            this.Close();
                            break;
                    }
                }
            }
            catch (ArgumentException ex)
            {
                //Afisarea unui mesaj de eroare daca intervine o exceptie in timpul logarii
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DespreButton_Click(object sender, EventArgs e)
        {
            //Afisarea de informatii despre aplicatie
            MessageBox.Show("Gestionare activitatii intr-o biblioteca \n\n " +
                "Administratorrul bibliotecii are drepturi complete asupra bazei de date. Acesta poate sterge, adauga sau modifica carti sau abonati. \n\n" +
                "Bibliotecarul are acces restrictionat. Acesta poate doar sa imprumute carti abonatilor.");
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            //Inchiderea aplicatiei
            Close();
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            //Inceperea unui nou proces de a deschide fisierul Help asociat
            System.Diagnostics.Process.Start("D:/Facultate/IP/Proiect_IP/Gestionare Biblioteca.chm");
        }
    }
}
